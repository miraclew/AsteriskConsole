using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager;
using VisualAsterisk.Asterisk.Exception;
using Asterisk.NET.Manager.Event;
using Asterisk.NET.Manager.Response;
using Asterisk.NET.Manager.Action;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using VisualAsterisk.Core.Util;
using VisualAsterisk.Asterisk.Config;
using System.Reflection;
using System.Net;
using VisualAsterisk.Core.Management;
using System.Globalization;
using System.IO;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Default implementation of the AsteriskServer interface. 
    /// </summary>
    public class DefaultAsteriskServer : INotifyAsteriskServerChanged, IAsteriskServer
    {
        #region Fields
        private const string ACTION_ID_PREFIX_ORIGINATE = "VA_ORIGINATE_";
        private const string SHOW_VERSION_COMMAND = "show version";
        private const string SHOW_VERSION_1_6_COMMAND = "core show version";
        private const string SHOW_VERSION_FILES_COMMAND = "show version files";
        private const string SHOW_VERSION_FILES_1_6_COMMAND = "core show file version";
        private readonly Regex SHOW_VERSION_FILES_PATTERN = new Regex("^([\\S]+)\\s+Revision: ([0-9\\.]+)");
        private const string SHOW_VOICEMAIL_USERS_COMMAND = "show voicemail users";
        private readonly Regex SHOW_VOICEMAIL_USERS_PATTERN = new Regex("^(\\S+)\\s+(\\S+)\\s+(.{25})");

        private string asteriskConfigHttpURL;
        private string asteriskConfigRemotePath = "/var/lib/asterisk/static-http/config";
        private bool cdrLoaded;
        private LinuxSystem system;
        private int executeCommandTimeout = 60000;
        /// <summary>
        /// The exact Version string of the Asterisk server we are connected to.
        /// Contains <code>null</code> until lazily initialized.
        /// </summary>
        private string version;
        private IManagerConnection managerConnection;
        private ManagerConnectionInfo connectionInfo;
        private IAsteriskConfigManager configManager;
        private MeetMeManager meetMeManager;
        private readonly ChannelManager channelManager;
        private readonly QueueManager queueManager;
        private readonly PeerMananger peerManager;
        private readonly AgentManager agentManager;
        private readonly ParkedCallManager parkedCallManager;
        private object initializeLock = new object();
        private volatile ServerState state;
        private bool skipQueues;
        private long idCounter = 0;
        private int totalIntitializingPercent;
        /// <summary>
        /// Maps the traceId to the corresponding callback data.
        /// </summary>
        private readonly IDictionary<string, OriginateCallbackData> originateCallbacks;

        /// <summary>
        /// Set to <code>true</code> to not handle ManagerEvents in the reader
        /// thread but process them asynchronously. This is a good idea :)
        /// </summary>
        private bool asyncEventHandling = true;

        private object handleEventLock = new object();
        #endregion

        #region Constructors and common operation
        public DefaultAsteriskServer(string hostname, string username, string password)
            : this(new ManagerConnectionInfo(hostname, 5038, username, password))
        {
        }

        public DefaultAsteriskServer(string hostname, int port, string username, string password)
            : this(new ManagerConnectionInfo(hostname, port, username, password))
        {
        }

        public DefaultAsteriskServer(ManagerConnectionInfo connectionInfo)
        {
            this.connectionInfo = connectionInfo;
            originateCallbacks = new Dictionary<string, OriginateCallbackData>();
            configManager = new AsteriskConfigManager(this);
            channelManager = new ChannelManager(this);
            agentManager = new AgentManager(this);
            meetMeManager = new MeetMeManager(this, configManager, channelManager);
            peerManager = new PeerMananger(this, channelManager);
            parkedCallManager = new ParkedCallManager(this, channelManager);
            queueManager = new QueueManager(this, channelManager);
            this.State = ServerState.Created;
        }

        public void Initialize()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            initializeIfNeeded();
        }

        private void initializeIfNeeded()
        {
            lock (initializeLock)
            {
                if (this.State == ServerState.Initilized || this.State == ServerState.Initilizing)
                {
                    Trace.TraceInformation("DefaultAsteriskServer is initialing or initialized, just return");
                    return;
                }
                Trace.TraceInformation("Initilizing asterisk server");

                this.State = ServerState.Initilizing;
                managerConnection = createManagerConnection();
                managerConnection.KeepAlive = true;
                managerConnection.UnhandledEvent += handleManagerEvent;
                managerConnection.FireAllEvents = true;

                Trace.TraceInformation(string.Format("Connecting asterisk server {0}", managerConnection.Hostname));

                reportInitializingProgress(null, 0, "Connecting asterisk server");
                if (!managerConnection.IsConnected())
                {
                    try
                    {
                        managerConnection.Login();
                    }
                    catch (System.Exception e)
                    {
                        this.State = ServerState.Created; // restore State
                        Trace.TraceInformation(string.Format("Connect asterisk server {0} failed: {1}", managerConnection.Hostname, e.Message));
                        throw new ManagerCommunicationException("Unable to login: " + e.Message, e);
                    }
                }

                Trace.TraceInformation("Getting configurations from server");
                configManager.Initialize();

                Trace.TraceInformation("Initialize internal managers");
                reportInitializingProgress(null, 80, "Initialize internal managers");
                channelManager.Initialize();
                agentManager.Initialize();
                meetMeManager.Initialize();
                peerManager.Initialize();
                parkedCallManager.Initialize();
                if (!skipQueues)
                {
                    queueManager.Initialize();
                }
                reportInitializingProgress(null, 100, "Completed");

                Trace.TraceInformation("Initializing done");
                this.State = ServerState.Initilized;
            }
        }

        protected virtual IManagerConnection createManagerConnection()
        {
            IManagerConnection connection = new ManagerConnection(connectionInfo.Host, connectionInfo.Port,
                connectionInfo.User, connectionInfo.Password);
            return connection;
        }

        /// <summary>
        /// Each componect call this method to report it's initilizing progress
        /// </summary>
        internal void reportInitializingProgress(string component, int percent, string text)
        {
            const int configManagerProportion = 45;
            if (string.IsNullOrEmpty(component))
            {
                totalIntitializingPercent = percent;
            }
            else if (component == "ConfigManager")
            {
                totalIntitializingPercent += configManagerProportion / 100 * percent;
            }

            OnConnectingProgressChanged(new ConnectingProgressEventArg(totalIntitializingPercent, text));
        }

        public void Shutdown()
        {
            if (managerConnection != null && managerConnection.IsConnected())
            {
                Trace.TraceInformation(string.Format("Shutingdown asterisk server {0}", managerConnection.Hostname));
                managerConnection.Logoff();
            }
            managerConnection = null;

            clearup();
            this.State = ServerState.Destroyed;
        }
        #endregion

        #region Handle event for asterisk server
        void handleManagerEvent(object sender, ManagerEvent e)
        {

            lock (handleEventLock)
            {
                Trace.TraceInformation(string.Format("HandleManageEvent begin: {0}", e.ToString()));
                try
                {
                    doHandleEvent(sender, e);

                }
                catch (System.Exception ex)
                {
                    Trace.WriteLine("Error when handleEvent: " + e.ToString() + " Exception: " + ex.Message);
                    throw;
                }
                Trace.TraceInformation(string.Format("HandleManageEvent end.", e.ToString()));
            }
        }

        void doHandleEvent(object sender, ManagerEvent e)
        {
            #region Handle Channel related events
            if (e is ConnectEvent)
            {
                handleConnectEvent((ConnectEvent)e);
            }
            else if (e is DisconnectEvent)
            {
                handleDisconnectEvent((DisconnectEvent)e);
            }
            else if (e is NewChannelEvent)
            {
                channelManager.handleNewChannelEvent((NewChannelEvent)e);
            }
            else if (e is NewExtenEvent)
            {
                channelManager.handleNewExtenEvent((NewExtenEvent)e);
            }
            else if (e is NewStateEvent)
            {
                channelManager.handleNewStateEvent((NewStateEvent)e);
            }
            else if (e is NewCallerIdEvent)
            {
                channelManager.handleNewCallerIdEvent((NewCallerIdEvent)e);
            }
            else if (e is DialEvent)
            {
                channelManager.handleDialEvent((DialEvent)e);
            }
            else if (e is BridgeEvent)
            {
                channelManager.handleBridgeEvent((BridgeEvent)e);
            }
            else if (e is RenameEvent)
            {
                channelManager.handleRenameEvent((RenameEvent)e);
            }
            else if (e is HangupEvent)
            {
                channelManager.handleHangupEvent((HangupEvent)e);
            }
            else if (e is CdrEvent)
            {
                channelManager.handleCdrEvent((CdrEvent)e);
            }
            else if (e is VarSetEvent)
            {
                channelManager.handleVarSetEvent((VarSetEvent)e);
            }

            #endregion End of Channel related events
            #region Handle parking related event
            else if (e is ParkedCallEvent)
            {
                channelManager.handleParkedCallEvent((ParkedCallEvent)e);
                parkedCallManager.handleParkedCallEvent((ParkedCallEvent)e);
            }
            else if (e is ParkedCallGiveUpEvent)
            {
                channelManager.handleParkedCallGiveUpEvent((ParkedCallGiveUpEvent)e);
                parkedCallManager.handleParkedCallGiveUpEvent((ParkedCallGiveUpEvent)e);
            }
            else if (e is ParkedCallTimeOutEvent)
            {
                channelManager.handleParkedCallTimeOutEvent((ParkedCallTimeOutEvent)e);
                parkedCallManager.handleParkedCallTimeOutEvent((ParkedCallTimeOutEvent)e);
            }
            else if (e is UnparkedCallEvent)
            {
                channelManager.handleUnparkedCallEvent((UnparkedCallEvent)e);
                parkedCallManager.handleUnparkedCallEvent((UnparkedCallEvent)e);
            }
            #endregion  End of parking related events
            #region Handle queue related event
            else if (e is JoinEvent)
            {
                queueManager.handleJoinEvent((JoinEvent)e);
            }
            else if (e is LeaveEvent)
            {
                queueManager.handleLeaveEvent((LeaveEvent)e);
            }
            else if (e is QueueMemberStatusEvent)
            {
                queueManager.handleQueueMemberStatusEvent((QueueMemberStatusEvent)e);
            }
            else if (e is QueueMemberPenaltyEvent)
            {
                queueManager.handleQueueMemberPenaltyEvent((QueueMemberPenaltyEvent)e);
            }
            else if (e is QueueMemberAddedEvent)
            {
                queueManager.handleQueueMemberAddedEvent((QueueMemberAddedEvent)e);
            }
            else if (e is QueueMemberRemovedEvent)
            {
                queueManager.handleQueueMemberRemovedEvent((QueueMemberRemovedEvent)e);
            }
            else if (e is QueueMemberPausedEvent)
            {
                queueManager.handleQueueMemberPausedEvent((QueueMemberPausedEvent)e);
            }
            #endregion
            // >>>>>> AJ 94
            #region  Handle meetMeEvents
            else if (e is AbstractMeetmeEvent)
            {
                meetMeManager.handleMeetMeEvent((AbstractMeetmeEvent)e);
            }
            else if (e is OriginateResponseEvent)
            {
                handleOriginateEvent((OriginateResponseEvent)e);
            }
            #endregion
            #region  Handle agents-related events
            else if (e is AgentsEvent)
            {
                agentManager.handleAgentsEvent((AgentsEvent)e);
            }
            else if (e is AgentCalledEvent)
            {
                agentManager.handleAgentCalledEvent((AgentCalledEvent)e);
            }
            else if (e is AgentConnectEvent)
            {
                agentManager.handleAgentConnectEvent((AgentConnectEvent)e);
            }
            else if (e is AgentCompleteEvent)
            {
                agentManager.handleAgentCompleteEvent((AgentCompleteEvent)e);
            }
            else if (e is AgentCallbackLoginEvent)
            {
                agentManager.handleAgentCallbackLoginEvent((AgentCallbackLoginEvent)e);
            }
            else if (e is AgentCallbackLogoffEvent)
            {
                agentManager.handleAgentCallbackLogoffEvent((AgentCallbackLogoffEvent)e);
            }
            else if (e is AgentLoginEvent)
            {
                agentManager.handleAgentLoginEvent((AgentLoginEvent)e);
            }
            else if (e is AgentLogoffEvent)
            {
                agentManager.handleAgentLogoffEvent((AgentLogoffEvent)e);
            }
            #endregion End of agent-related events
            #region Handle peer-related events
            else if (e is PeerStatusEvent)
            {
                peerManager.handlePeerStatusEvent((PeerStatusEvent)e);
            }
            else if (e is PeerEntryEvent)
            {
                peerManager.handlePeerEntryEvent((PeerEntryEvent)e);
            }
            else if (e is PeerlistCompleteEvent)
            {
                peerManager.handlePeerlistCompleteEvent((PeerlistCompleteEvent)e);
            }
            #endregion
            #region handle Trunk-related events
            else if (e is RegistryEvent)
            {
                OnTrunkStateChanged(this, (RegistryEvent)e);
            }
            else
            {
                Trace.TraceWarning(string.Format("Event NOT handled : {0}", e.ToString()));
            }
            #endregion
        }

        private void handleOriginateEvent(OriginateResponseEvent originateEvent)
        {
            string traceId;
            OriginateCallbackData callbackData;
            IOriginateCallback cb;
            AsteriskChannel channel;
            AsteriskChannel otherChannel; // the other side if local Channel

            traceId = originateEvent.ActionId;
            if (traceId == null)
            {
                return;
            }

            lock (originateCallbacks)
            {
                if (!originateCallbacks.ContainsKey(traceId))
                {
                    return;
                }
                callbackData = originateCallbacks[traceId];
                originateCallbacks.Remove(traceId);
            }

            cb = callbackData.Callback;
            if (!AstUtil.isNull(originateEvent.UniqueId))
            {
                channel = channelManager.getChannelById(originateEvent.UniqueId);
            }
            else
            {
                channel = callbackData.Channel;
            }

            try
            {
                if (channel == null)
                {
                    AsteriskException cause = new NoSuchChannelException("Channel '"
                            + callbackData.OriginateAction.Channel
                            + "' is not available");
                    cb.fireFailure(this, cause);
                    return;
                }

                if (channel.wasInState(ChannelState.UP))
                {
                    cb.fireSuccess(this, channel);
                    return;
                }

                if (channel.wasBusy())
                {
                    cb.fireBusy(this, channel);
                    return;
                }

                otherChannel = channelManager.getOtherSideOfLocalChannel(channel);
                // special treatment of local channels:
                // the interesting things happen to the other side so we have a look
                // at that
                if (otherChannel != null)
                {
                    AsteriskChannel dialedChannel;

                    dialedChannel = otherChannel.DialedChannel;

                    // on busy the other Channel is in State busy when we receive
                    // the originate event
                    if (otherChannel.wasBusy())
                    {
                        cb.fireBusy(this, channel);
                        return;
                    }

                    // alternative:
                    // on busy the dialed Channel is hung up when we receive the
                    // originate event having a look at the hangup cause reveals the
                    // information we are interested in
                    // this alternative has the drawback that there might by
                    // multiple channels that have been dialed by the local Channel
                    // but we only look at the Last one.
                    if (dialedChannel != null && dialedChannel.wasBusy())
                    {
                        cb.fireBusy(this, channel);
                        return;
                    }
                }

                // if nothing else matched we asume no answer
                cb.fireNoAnswer(this, channel);
            }
            catch (System.Exception t)
            {
                Trace.TraceWarning("Exception dispatching originate progress" + t.Message);
            }
        }

        private void handleDisconnectEvent(DisconnectEvent disconnectEvent)
        {
            Trace.TraceWarning("handleDisconnectEvent");
            // same for channels, agents and Queues Rooms, they are reinitialized when reconnected
            clearup();
            this.State = ServerState.Destroyed;
        }

        private void clearup()
        {
            configManager.Disconnected();
            channelManager.Disconnected();
            agentManager.Disconnected();
            parkedCallManager.Disconnected();
            peerManager.Disconnected();
            meetMeManager.Disconnected();
            queueManager.Disconnected();
        }

        private void handleConnectEvent(ConnectEvent connectEvent)
        {
            try
            {
                Initialize();
            }
            catch (System.Exception e)
            {
                Trace.TraceError("Unable to reinitialize state after reconnection", e);
            }
        }
        #endregion

        #region Interact with server
        public string GetGlobalVariable(string variable)
        {
            ManagerResponse response;
            string value;

            initializeIfNeeded();
            response = SendAction(new GetVarAction(variable));
            if (response is ManagerError)
            {
                return null;
            }
            value = response.Attributes["Value"];
            if (value == null)
            {
                value = response.Attributes[variable]; // for Asterisk 1.0.x
            }
            return value;
        }

        public void SetGlobalVariable(string variable, string value)
        {
            ManagerResponse response;

            initializeIfNeeded();
            response = SendAction(new SetVarAction(variable, value));
            if (response is ManagerError)
            {
                Trace.TraceError("Unable to set global variable '" + variable
                        + "' to '" + value + "':" + response.Message);
            }
        }

        public IList<Voicemailbox> GetVoicemailboxes()
        {
            IList<Voicemailbox> voicemailboxes = new List<Voicemailbox>();
            ///
            return voicemailboxes;
        }

        public ManagerResponse SendAction(ManagerAction action)
        {
            try
            {
                return managerConnection.SendAction(action);
            }
            catch (System.Exception e)
            {
                throw ManagerCommunicationExceptionMapper.mapSendActionException(action.Action, e);
            }
        }

        public ManagerResponse SendAction(ManagerAction action, int timeout)
        {
            try
            {
                return managerConnection.SendAction(action, timeout);
            }
            catch (System.Exception e)
            {
                throw ManagerCommunicationExceptionMapper.mapSendActionException(action.Action, e);
            }
        }

        public List<string> ExecuteCliCommand(string command)
        {
            ManagerResponse response;

            initializeIfNeeded();
            response = SendAction(new CommandAction(command));
            if (!(response is CommandResponse))
            {
                throw new ManagerCommunicationException("Response to CommandAction(\"" + command
                        + "\") was not a CommandResponse but " + response, null);
            }

            return ((CommandResponse)response).Result;
        }

        public AsteriskChannel OriginateToExtension(string channel, string context,
                                            string exten, int priority, long timeout)
        {
            return OriginateToExtension(channel, context, exten, priority, timeout, null, null);
        }

        public AsteriskChannel OriginateToExtension(string channel, string context,
                                                    string exten, int priority, long timeout, CallerId callerId,
                                                    Dictionary<string, string> variables)
        {
            OriginateAction originateAction;

            originateAction = new OriginateAction();
            originateAction.Channel = channel;
            originateAction.Context = context;
            originateAction.Exten = exten;
            originateAction.Priority = priority;
            originateAction.Timeout = (int)timeout;
            if (callerId != null)
            {
                originateAction.CallerId = callerId.ToString();
            }
            originateAction.SetVariables(variables);

            return originate(originateAction);
        }

        public AsteriskChannel originateToApplication(string channel, string application, string data, long timeout)
        {
            return originateToApplication(channel, application, data, timeout, null, null);
        }

        public AsteriskChannel originateToApplication(string channel,
                                                      string application, string data, long timeout, CallerId callerId,
                                                      Dictionary<string, string> variables)
        {
            OriginateAction originateAction;

            originateAction = new OriginateAction();
            originateAction.Channel = channel;
            originateAction.Application = application;
            originateAction.Data = data;
            originateAction.Timeout = (int)timeout;
            if (callerId != null)
            {
                originateAction.CallerId = callerId.ToString();
            }
            originateAction.SetVariables(variables);

            return originate(originateAction);
        }


        public AsteriskChannel originate(OriginateAction originateAction)
        {
            ResponseEvents responseEvents;
            string uniqueId;
            AsteriskChannel channel = null;

            // must set async to true to receive OriginateEvents.
            originateAction.Async = true;
            initializeIfNeeded();

            // 2000 ms extra for the OriginateFailureEvent should be fine
            responseEvents = sendEventGeneratingAction(originateAction, originateAction.Timeout + 2000);

            // TODO: temporary disalbe throwing excepiton
            //foreach (ResponseEvent responseEvent in responseEvents.Events)
            //{
            //    if (responseEvent is OriginateResponseEvent)
            //    {
            //        uniqueId = ((OriginateResponseEvent)responseEvent).UniqueId;
            //        Trace.WriteLine(responseEvent.GetType().Name + " received with uniqueId " + uniqueId);
            //        channel = GetChannelById(uniqueId);
            //    }
            //}
            //if (channel == null)
            //{
            //    throw new NoSuchChannelException("Channel '" + originateAction.Channel + "' is not available");
            //}

            return channel;
        }

        public void originateAsync(OriginateAction originateAction,
                            IOriginateCallback cb)
        {
            Dictionary<string, string> variables;
            string traceId;

            traceId = ACTION_ID_PREFIX_ORIGINATE + Interlocked.Increment(ref idCounter);
            if (originateAction.GetVariables() == null)
            {
                variables = new Dictionary<string, string>();
            }
            else
            {
                variables = new Dictionary<string, string>(originateAction.GetVariables());
            }
            // prefix Variable Name by "__" to enable Variable inheritence across
            // channels
            variables.Add("__" + Constants.VARIABLE_TRACE_ID, traceId);
            originateAction.SetVariables(variables);

            // must set async to true to receive OriginateEvents.
            originateAction.Async = true;
            originateAction.ActionId = traceId;

            if (cb != null)
            {
                OriginateCallbackData callbackData;

                callbackData = new OriginateCallbackData(originateAction, DateTime.Now, cb);
                // Register callback
                lock (originateCallbacks)
                {
                    originateCallbacks.Add(traceId, callbackData);
                }
            }

            initializeIfNeeded();
            SendAction(originateAction);
        }

        internal ResponseEvents sendEventGeneratingAction(ManagerActionEvent action, int timeout)
        {
            try
            {
                Debug.Assert(managerConnection.IsConnected());
                return managerConnection.SendEventGeneratingAction(action, timeout);
            }
            catch (EventTimeoutException e)
            {
                if (!managerConnection.IsConnected())
                {
                    Trace.WriteLine("Connect lost, reconnect..");
                    Shutdown();
                    Initialize();
                    return managerConnection.SendEventGeneratingAction(action, timeout);
                }
                else
                {
                    throw ManagerCommunicationExceptionMapper.mapSendActionException(action.Action, e);
                }
            }
            catch (System.Exception e)
            {
                throw ManagerCommunicationExceptionMapper.mapSendActionException(action.Action, e);
            }
        }


        internal ResponseEvents sendEventGeneratingAction(ManagerActionEvent action)
        {
            try
            {
                return managerConnection.SendEventGeneratingAction(action);
            }
            catch (System.Exception e)
            {
                throw ManagerCommunicationExceptionMapper.mapSendActionException(action.Action, e);
            }
        }

        public List<PeerEntryEvent> GetPeerEntries()
        {
            ResponseEvents responseEvents = sendEventGeneratingAction(new SIPPeersAction(), 2000);
            List<PeerEntryEvent> peerEntries = new List<PeerEntryEvent>(30);
            foreach (ResponseEvent re in responseEvents.Events)
            {
                if (re is PeerEntryEvent)
                {
                    peerEntries.Add((PeerEntryEvent)re);
                }
            }
            return peerEntries;
        }

        public IList<AsteriskPeer> GetPeerEntriesEx()
        {
            return peerManager.getPeers();
        }

        public Dictionary<string, string> GetSipPeerDetailInfo(string peer)
        {
            ManagerResponse response;
            Dictionary<string, string> value;

            initializeIfNeeded();
            response = SendAction(new SIPShowPeerAction(peer));
            if (response is ManagerError)
            {
                return null;
            }
            value = response.Attributes;
            return value;
        }

        public IList<ParkedCall> GetParkedCalls()
        {
            return parkedCallManager.GetParkedCalls();
        }

        public DBGetResponseEvent DbGet(string family, string key)
        {
            ResponseEvents responseEvents = sendEventGeneratingAction(new DBGetAction(family, key), 2000);
            DBGetResponseEvent dbgre = null;
            foreach (ResponseEvent re in responseEvents.Events)
            {
                dbgre = (DBGetResponseEvent)re;
            }
            return dbgre;
        }

        public void DbDel(string family, string key)
        {
            // The following only works with BRIStuffed asrterisk: sendAction(new
            // DbDelAction(family,Key));
            // Use cli command instead ...
            SendAction(new CommandAction("database del " + family + " " + key));
        }

        public void DbPut(string family, string key, string value)
        {
            SendAction(new DBPutAction(family, key, value));
        }

        public AsteriskChannel GetChannelByNameAndActive(string name)
        {
            initializeIfNeeded();
            return channelManager.GetChannelByNameAndActive(name);
        }

        #endregion
        #region No implemented
        /* 
        public bool isModuleLoaded(string module)
        {
            return sendAction(new ModuleCheckAction(module)) is ModuleCheckResponse;
        }

        public void loadModule(string module)
        {
            sendModuleLoadAction(module, ModuleLoadAction.LOAD_TYPE_LOAD);
        }

        public void unloadModule(string module)
        {
            sendModuleLoadAction(module, ModuleLoadAction.LOAD_TYPE_UNLOAD);
        }

        public void reloadModule(string module)
        {
            sendModuleLoadAction(module, ModuleLoadAction.LOAD_TYPE_RELOAD);
        }

        public void reloadAllModules()
        {
            sendModuleLoadAction(null, ModuleLoadAction.LOAD_TYPE_RELOAD);
        }

        protected void sendModuleLoadAction(string module, string loadType)
        {
            ManagerResponse response;

            response = sendAction(new ModuleLoadAction(module, loadType));
            if (response is ManagerError)
            {
                ManagerError error = (ManagerError)response;
                throw new ManagerCommunicationException(error.getMessage(), null);
            }
        }
        */
        #endregion

        #region Raise Event
        /// <summary>
        /// Raise when connecting progress changed 
        /// </summary>
        public event EventHandler<ConnectingProgressEventArg> ConnectingProgressChanged;

        /// <summary>
        /// Raise when server State changed
        /// </summary>
        public event EventHandler<ServerStateEventArg> StateChanged;

        internal void OnServerStateChanged(ServerStateEventArg arg)
        {
            EventHandler<ServerStateEventArg> temp = StateChanged;
            if (temp != null)
            {
                temp(this, arg);
            }
        }

        internal void OnConnectingProgressChanged(ConnectingProgressEventArg arg)
        {
            EventHandler<ConnectingProgressEventArg> temp = ConnectingProgressChanged;
            if (temp != null)
            {
                temp(this, arg);
            }
        }

        internal void OnNewQueueEntry(AsteriskQueueEntry qe)
        {
            if (NewQueueEntry != null)
            {
                NewQueueEntry(this, qe);
            }
        }

        internal void OnRemoveQueueEntry(AsteriskQueueEntry qe)
        {
            if (QueueEntryRemoved != null)
            {
                QueueEntryRemoved(this, qe);
            }
        }

        internal void OnNewAgent(AsteriskAgent agent)
        {
            if (NewAgent != null)
            {
                NewAgent(this, agent);
            }
        }

        internal void OnRemoveAgent(AsteriskAgent agent)
        {
            if (AgentRemoved != null)
            {
                AgentRemoved(this, agent);
            }
        }

        internal void OnNewMeetMeUser(MeetMeUser user)
        {
            if (NewMeetMeUser != null)
            {
                NewMeetMeUser(this, user);
            }
        }

        internal void OnRemoveMeetMeUser(MeetMeUser user)
        {
            if (MeetMeUserRemoved != null)
            {
                MeetMeUserRemoved(this, user);
            }
        }

        internal void OnNewAsteriskChannel(AsteriskChannel channel)
        {
            if (NewAsteriskChannel != null)
            {
                NewAsteriskChannel(this, channel);
            }
        }


        internal void OnRemoveAsteriskChannel(AsteriskChannel channel)
        {
            if (AsteriskChannelRemoved != null)
            {
                AsteriskChannelRemoved(this, channel);
            }
        }

        internal void OnNewPeer(AsteriskPeer peer)
        {
            //throw new NotImplementedException();
        }

        internal void OnNewParkedCall(ParkedCall call)
        {
            if (NewParkedCall != null)
            {
                NewParkedCall(this, call);
            }
        }

        internal void OnRemoveParkedCall(ParkedCall call)
        {
            if (ParkedCallRemoved != null)
            {
                ParkedCallRemoved(this, call);
            }
        }

        private void OnTrunkStateChanged(DefaultAsteriskServer defaultAsteriskServer, RegistryEvent registryEvent)
        {
            if (TrunkStateChanged != null)
            {
                TrunkStateChanged(this, registryEvent);
            }
        }

        #endregion

        #region Properties

        public string AsteriskConfigHttpURL
        {
            get
            {
                if (string.IsNullOrEmpty(asteriskConfigHttpURL))
                {
                    asteriskConfigHttpURL = "http://" + ConnectionInfo.Host + ":8088/asterisk/static/config/";
                }
                return asteriskConfigHttpURL;
            }
            set { asteriskConfigHttpURL = value; }
        }

        public IManagerConnection ManagerConnection
        {
            get { return managerConnection; }
        }

        public ManagerConnectionInfo ConnectionInfo
        {
            get { return connectionInfo; }
            set { connectionInfo = value; }
        }

        public ServerState State
        {
            get { return state; }
            set
            {
                if (state == value) return;
                state = value;
                switch (state)
                {
                    case ServerState.Created:
                        totalIntitializingPercent = 0;
                        break;
                    case ServerState.Initilizing:
                        break;
                    case ServerState.Initilized:
                        totalIntitializingPercent = 100;
                        break;
                    case ServerState.ShutingDown:
                        break;
                    case ServerState.Destroyed:
                        break;
                    default:
                        break;
                }
                OnServerStateChanged(new ServerStateEventArg(value));
            }
        }

        public bool SkipQueues
        {
            get { return skipQueues; }
            set { skipQueues = value; }
        }
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public bool IsConnected()
        {
            if (managerConnection == null)
            {
                return false;
            }
            return managerConnection.IsConnected();
        }

        /// <summary>
        /// return a collection of all Active AsteriskChannels.
        /// </summary>        
        public IList<AsteriskChannel> Channels
        {
            get
            {
                return channelManager.Channels;
            }
        }

        /// <summary>
        /// Return the agents, registered at Asterisk server.
        /// </summary>
        public IList<AsteriskAgent> Agents
        {
            get
            {
                initializeIfNeeded();
                return agentManager.getAgents();
            }
        }

        public IAsteriskConfigManager ConfigManager
        {
            get { return configManager; }
            set
            {
                if (State != ServerState.Created)
                {
                    throw new InvalidOperationException("ConfigManager should be set before intialize");
                }
                configManager = value;
                // recreate meetMeManager
                meetMeManager = new MeetMeManager(this, configManager, channelManager);
            }
        }

        public IList<AsteriskQueue> Queues
        {
            get
            {
                initializeIfNeeded();
                return queueManager.getQueues();
            }
        }

        public IList<AsteriskMeetMeRoom> MeetmeRooms
        {
            get
            {
                return meetMeManager.getAsteriskMeetMeRooms();
            }
        }

        public AsteriskMeetMeRoom GetMeetmeRoom(string name)
        {
            return meetMeManager.getOrCreateRoom(name);
        }

        public AsteriskChannel GetChannelByName(string name)
        {
            initializeIfNeeded();
            return channelManager.getChannelByName(name);
        }

        public AsteriskChannel GetChannelById(string id)
        {
            initializeIfNeeded();
            return channelManager.getChannelById(id);
        }
        #endregion

        #region INotifyAsteriskServerChanged Members
        public event NewChannelEventHandler NewAsteriskChannel;
        public event NewMeetMeUserEventHandler NewMeetMeUser;
        public event NewAgentEventHandler NewAgent;
        public event NewQueueEntryEventHandler NewQueueEntry;
        public event ChannelRemovedEventHandler AsteriskChannelRemoved;
        public event MeetMeUserRemovedEventHandler MeetMeUserRemoved;
        public event AgentRemovedEventHandler AgentRemoved;
        public event QueueEntryRemovedEventHandler QueueEntryRemoved;
        public event NewParkedCallEventHandler NewParkedCall;
        public event ParkedCallRemovedEventHandler ParkedCallRemoved;
        public event TrunkEventHandler TrunkStateChanged;
        #endregion

        internal OriginateCallbackData getOriginateCallbackDataByTraceId(string traceId)
        {
            lock (originateCallbacks)
            {
                return originateCallbacks[traceId];
            }
        }

        #region Channel operation
        #endregion


        #region IAsteriskServer 成员
        public void ExecuteSystemCommand(string commandToExecute)
        {
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("command", commandToExecute);
            originateToApplication("Local/executecommand@asterisk_guitools", "noop", null, executeCommandTimeout, null, variables);
        }

        public void RecordVoicePrompt(string fileName, string extensionToRecord)
        {
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("var1", "/var/lib/asterisk/sounds/record/" + fileName);
            OriginateToExtension("Local/" + extensionToRecord, "asterisk_guitools", "record_vmenu", 1, executeCommandTimeout, null, variables);
        }

        public void PlayVoicePrompt(string fileName, string extensionToPlay)
        {
            fileName = fileName.Substring(0, fileName.IndexOf('.'));
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("var1", "/var/lib/asterisk/sounds/record/" + fileName);
            OriginateToExtension("Local/" + extensionToPlay, "asterisk_guitools", "play_file", 1, executeCommandTimeout, null, variables);
        }

        public void DeleteRecordedVoicePrompt(string fileName)
        {
            ExecuteSystemCommand("/bin/rm -f /var/lib/asterisk/sounds/record/" + fileName);
        }

        public IList<string> GetAllMusicFiles()
        {
            return listFiles("/var/lib/asterisk/sounds/");
        }

        public IList<string> GetAllAgiScripts()
        {
            throw new NotImplementedException();
        }

        public IList<string> GetAllRecordedVoicePrompt()
        {
            return listFiles("/var/lib/asterisk/sounds/record/");
        }

        private List<string> listFiles(string dir)
        {
            ExecuteSystemCommand("sh /var/lib/asterisk/scripts/listfiles " + dir);
            return GetSysInfoOutput("sysinfo_output.html", true);
        }

        public List<string> GetSysInfoOutput(string file, bool trimEmptyLine)
        {
            List<string> output = new List<string>();
            string sysinfoURL = AsteriskConfigHttpURL + file;
            WebClient client = new WebClient();
            string content=client.DownloadString(sysinfoURL);;
            foreach (string item in content.Split(new char[] { '\n' }))
            {
                if (trimEmptyLine && string.IsNullOrEmpty(item))
                {
                    continue;
                }
                output.Add(item);
            }
            return output;
        }

        public IList<string> GetAllCodecs()
        {
            List<string> codecs = new List<string>();
            foreach (string item in ExecuteCliCommand("module show like codec_"))
            {
                for (int i = 0; i < Codecs.Items.Length; i++)
                {
                    if (item.StartsWith("codec_" + Codecs.Items[i] + ".so"))
                    {
                        codecs.Add(Codecs.Items[i]);
                    }
                }
            }
            return codecs;
        }

        public LinuxSystem GetSystemInformation(bool refresh)
        {
            if (system == null || refresh)
            {
                ExecuteSystemCommand("sh /var/lib/asterisk/scripts/gui_sysinfo");
                List<string> output = GetSysInfoOutput("sysinfo_output.html", false);
                system = new LinuxSystem();
                system.Parse(output);
                system.IfConfig = string.Empty;
                foreach (string item in GetSysInfoOutput("ifconfig_output.html", false))
                {
                    system.IfConfig = system.IfConfig + item + "\r\n";
                }
                system.DiskUsage = string.Empty;
                foreach (string item in GetSysInfoOutput("diskusage_output.html", false))
                {
                    system.DiskUsage = system.DiskUsage + item + "\r\n";
                }
                system.MemoryUsage = string.Empty;
                foreach (string item in GetSysInfoOutput("memusage_output.html", false))
                {
                    system.MemoryUsage = system.MemoryUsage + item + "\r\n";
                }
            }
            return system;
        }

        public IList<string> GetAllBackupFiles()
        {
            return listFiles("/var/lib/asterisk/gui_configbackups/ time");
        }

        public void RemoveBackupFile(string file)
        {
            ExecuteSystemCommand("/bin/rm -f /var/lib/asterisk/gui_configbackups/" + file);
        }

        #endregion

        #region Backup


        public void CreateBackup(string name)
        {
            Backup backup = new Backup();
            backup.Name = name;
            backup.TakenTime = DateTime.Now;
            ExecuteSystemCommand("/bin/tar -cf /var/lib/asterisk/gui_configbackups/" + backup.FileName);
        }

        public void RestoreConfig(string fileName)
        {
            ExecuteSystemCommand("tar -xf /var/lib/asterisk/gui_configbackups/" + fileName + " -C");
            Reload();
        }

        public void Reload()
        {
            ExecuteCliCommand("reload");
        }

        public IEnumerable<Backup> Backups
        {
            get
            {
                List<Backup> backups = new List<Backup>();
                foreach (string item in GetAllBackupFiles())
                {
                    // aa__2008dec14.tar
                    int index = item.IndexOf("__");
                    string name = item.Substring(0, index);
                    string dateTimeString = item.Substring(index + 2, item.IndexOf('.') - index - 2);
                    Backup backup = new Backup();
                    backup.FileName = item;
                    backup.Name = name;
                    DateTime dateTime;
                    if (DateTime.TryParse(dateTimeString, out dateTime))
                    {
                        backup.TakenTime = dateTime;
                    }
                    backups.Add(backup);
                }
                return backups;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region CDR

        public void LoadCDR(string directory, bool reload)
        {
            if (cdrLoaded && !reload)
            {
                return;
            }
            ExecuteSystemCommand("/bin/cp /var/log/asterisk/cdr-csv/Master.csv " + asteriskConfigRemotePath);

            WebClient client = new WebClient();
            Directory.CreateDirectory(directory);
            File.Delete(directory + "\\Master.csv");
            client.DownloadFile(AsteriskConfigHttpURL + "Master.csv", directory + "\\Master.csv");
            cdrLoaded = true;
        }

        #endregion

        #region IAsteriskServer 成员


        public int ExecuteCommandTimeout
        {
            get
            {
                return executeCommandTimeout;
            }
            set
            {
                executeCommandTimeout = value;
            }
        }

        #endregion

        #region IAsteriskServer 成员


        public string GetConfigFile(string file)
        {
            ExecuteSystemCommand("cp /etc/asterisk/" + file + " " + asteriskConfigRemotePath);

            string sysinfoURL = AsteriskConfigHttpURL + file;
            WebClient client = new WebClient();
            client.DownloadFile(sysinfoURL, file);
            return file;
        }

        public void UpdateConfigFile(string file)
        {

            string sysinfoURL = AsteriskConfigHttpURL + file;
            WebClient client = new WebClient();
            client.UploadFile(sysinfoURL, file);
            ExecuteSystemCommand("cp " + asteriskConfigRemotePath + "/" + file + " /etc/asterisk" + file);
        }

        #endregion

    }

    public enum ServerState
    {
        Created,
        Initilizing,
        Initilized,
        ShutingDown,
        Destroyed
    }

    public class ConnectingProgressEventArg : EventArgs
    {
        public readonly int Percent;
        public readonly string ProgressText;

        public ConnectingProgressEventArg(int percent, string progressText)
        {
            this.Percent = percent;
            this.ProgressText = progressText;
        }
    }

    public class ServerStateEventArg : EventArgs
    {
        ServerState state;

        public ServerState State
        {
            get { return state; }
        }
        public ServerStateEventArg(ServerState state)
        {
            this.state = state;

        }
    }
}
