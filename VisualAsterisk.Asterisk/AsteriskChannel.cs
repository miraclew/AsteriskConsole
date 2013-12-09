using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Internal;
using Asterisk.NET.Manager.Response;
using Asterisk.NET.Manager.Action;
using VisualAsterisk.Asterisk.Exception;
using System.Diagnostics;

namespace VisualAsterisk.Asterisk
{
    public class AsteriskChannel : AsteriskObject
    {
        string PROPERTY_NAME = "name";
        string PROPERTY_CALLER_ID = "callerId";
        string PROPERTY_STATE = "state";
        string PROPERTY_ACCOUNT = "account";
        string PROPERTY_CURRENT_EXTENSION = "CurrentExtension";
        string PROPERTY_CALL_DETAIL_RECORD = "callDetailRecord";
        string PROPERTY_DIALED_CHANNEL = "dialedChannel";
        string PROPERTY_DIALING_CHANNEL = "dialingChannel";
        string PROPERTY_LINKED_CHANNEL = "linkedChannel";
        string PROPERTY_MEET_ME_USER = "meetMeUser";
        string PROPERTY_Peer = "Peer";
        string PROPERTY_QUEUE_ENTRY = "queueEntry";
        string PROPERTY_PARKED_AT = "parkedAt";

        string VARIABLE_MONITOR_EXEC = "MONITOR_EXEC";
        string VARIABLE_MONITOR_EXEC_ARGS = "MONITOR_EXEC_ARGS";

        const string CAUSE_VARIABLE_NAME = "PRI_CAUSE";

        public AsteriskChannel(DefaultAsteriskServer server, string name, string id, DateTime dateOfCreation)
            : base(server)
        {
            if (server == null || name == null || id == null || dateOfCreation == null)
            {
                throw new ArgumentNullException("Parameters passed to AsteriskChannel() must not be null.");
            }
            this.name = name;
            this.id = id;
            this.dateOfCreation = dateOfCreation;
            this.extensionHistory = new List<ExtensionHistoryEntry>();
            this.stateHistory = new List<ChannelStateHistoryEntry>();
            this.linkedChannelHistory = new List<LinkedChannelHistoryEntry>();
            this.dialedChannelHistory = new List<DialedChannelHistoryEntry>();
            this.variables = new Dictionary<string, string>();
        }
        /// <summary>
        /// Unique Id of this Channel.
        /// </summary>
        private readonly string id;

        public string Id
        {
            get { return id; }
        }

        /// <summary>
        /// The traceId is used to trace originated channels.
        /// </summary>

        private string traceId;

        public string TraceId
        {
            get { return traceId; }
            set { traceId = value; }
        }

        /// <summary>
        /// Date this Channel has been created.
        /// </summary>
        private readonly DateTime dateOfCreation;

        public DateTime DateOfCreation
        {
            get { return dateOfCreation; }
        }

        /// <summary>
        /// Date this Channel has left the Asterisk server.
        /// This value is set when hangup called
        /// </summary>
        private DateTime dateOfRemoval;

        public DateTime DateOfRemoval
        {
            get { return dateOfRemoval; }
        }

        /// <summary>
        /// Name of this Channel.
        /// </summary>
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Caller*ID of this Channel.
        /// </summary>
        private CallerId callerId;

        internal CallerId CallerId
        {
            get { return callerId; }
            set { callerId = value; }
        }

        /// <summary>
        /// State of this Channel.
        /// </summary>
        private ChannelState state;

        public ChannelState State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Account code used to bill this Channel.
        /// </summary>
        private string account;

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        private List<ExtensionHistoryEntry> extensionHistory;
        private List<ChannelStateHistoryEntry> stateHistory;
        private List<LinkedChannelHistoryEntry> linkedChannelHistory;
        private List<DialedChannelHistoryEntry> dialedChannelHistory;

        private AsteriskChannel dialedChannel;

        public AsteriskChannel DialedChannel
        {
            get { return dialedChannel; }
            set { dialedChannel = value; }
        }

        private AsteriskChannel dialingChannel;

        public AsteriskChannel DialingChannel
        {
            get { return dialingChannel; }
            set { dialingChannel = value; }
        }

        /// <summary>
        /// If this Channel is bridged to another Channel, the linkedChannel contains
        /// the Channel this Channel is bridged with.
        /// </summary>
        private AsteriskChannel linkedChannel;

        public AsteriskChannel LinkedChannel
        {
            get { return linkedChannel; }
            set { linkedChannel = value; }
        }

        /// <summary>
        /// Indicates if this Channel was linked to another Channel at least once.
        /// </summary>
        private bool wasLinked;

        public bool WasLinked
        {
            get { return wasLinked; }
            set { wasLinked = value; }
        }

        private HangupCause hangupCause;

        internal HangupCause HangupCause
        {
            get { return hangupCause; }
            set { hangupCause = value; }
        }

        private string hangupCauseText;

        public string HangupCauseText
        {
            get { return hangupCauseText; }
            set { hangupCauseText = value; }
        }

        private CallDetailRecord callDetailRecord;

        private AsteriskPeer peer;
        /// <summary>
        /// Peer associated with this Channel if any, <code>null</code>
        /// otherwise.
        /// </summary>
        public AsteriskPeer Peer
        {
            get { return peer; }
            set { peer = value; }
        }
        /**
         * MeetMe room User associated with this Channel if any, <code>null</code>
         * otherwise.
         */
        private MeetMeUser meetMeUser;

        public MeetMeUser MeetMeUser
        {
            get { return meetMeUser; }
            set { meetMeUser = value; }
        }

        /**
         * Queue entry associated with this Channel if any, <code>null</code>
         * otherwise.
         */
        private AsteriskQueueEntry queueEntry;

        public AsteriskQueueEntry QueueEntry
        {
            get { return queueEntry; }
            set { queueEntry = value; }
        }

        /**
         * Extension where the call is parked if it is parked, <code>null</code>
         * otherwise.
         */
        private AstExten parkedAt;

        public AstExten ParkedAt
        {
            get { return parkedAt; }
            set { parkedAt = value; }
        }

        private readonly IDictionary<string, string> variables;

        public IDictionary<string, string> Variables
        {
            get { return variables; }
        }



        /**
         * Adds a visted dialplan entry to the history.
         *
         * @param date      the date the Extension1 has been visited.
         * @param Extension1 the visted dialplan entry to add.
         */
        internal void extensionVisited(DateTime date, AstExten extension)
        {
            AstExten oldCurrentExtension = this.CurrentExtension;
            ExtensionHistoryEntry historyEntry;

            historyEntry = new ExtensionHistoryEntry(date, extension);

            lock (extensionHistory)
            {
                extensionHistory.Add(historyEntry);
            }

            firePropertyChange(PROPERTY_CURRENT_EXTENSION, oldCurrentExtension, extension);
        }

        public AstExten CurrentExtension
        {
            get
            {
                AstExten extension;

                lock (extensionHistory)
                {
                    if (extensionHistory.Count <= 0)
                    {
                        extension = null;
                    }
                    else
                    {
                        extension = extensionHistory[extensionHistory.Count - 1].Exten;
                    }
                }

                return extension;
            }
        }

        public AstExten getFirstExtension()
        {
            AstExten extension;

            lock (extensionHistory)
            {
                if (extensionHistory.Count <= 0)
                {
                    extension = null;
                }
                else
                {
                    extension = extensionHistory[0].Exten;
                }
            }

            return extension;
        }

        /// <summary>
        /// Changes the State of this Channel.
        /// </summary>
        /// <param Name="date">when the State change occurred.</param>
        /// <param Name="State">the new State of this Channel</param>
        internal void stateChanged(DateTime date, ChannelState state)
        {
            ChannelStateHistoryEntry historyEntry;
            ChannelState oldState = this.state;

            if (oldState == state)
            {
                return;
            }

            Trace.TraceInformation(string.Format("{0} state change: {1} => {2} ({3})", id, oldState.ToString(), 
                state.ToString(), Name));
            historyEntry = new ChannelStateHistoryEntry(date, state);
            lock (stateHistory)
            {
                stateHistory.Add(historyEntry);
            }

            this.state = state;
            firePropertyChange(PROPERTY_STATE, oldState, state);
        }

        /// <summary>
        /// Sets the Channel this Channel is bridged with.
        /// </summary>
        /// <param Name="dateTime">the date this Channel was linked.</param>
        /// <param Name="linkedChannel">the Channel this Channel is bridged with.</param>
        internal void channelLinked(DateTime date, AsteriskChannel linkedChannel)
        {
            AsteriskChannel oldLinkedChannel = this.linkedChannel;
            LinkedChannelHistoryEntry historyEntry;

            historyEntry = new LinkedChannelHistoryEntry(date, linkedChannel);
            lock (linkedChannelHistory)
            {
                linkedChannelHistory.Add(historyEntry);
            }
            this.linkedChannel = linkedChannel;
            this.wasLinked = true;
            firePropertyChange(PROPERTY_LINKED_CHANNEL, oldLinkedChannel, linkedChannel);
        }

        /// <summary>
        /// Changes the Name of this Channel.
        /// </summary>
        /// <param Name="dateTime">date of the Name change.</param>
        /// <param Name="Name">the new Name of this Channel.</param>
        internal void nameChanged(DateTime dateTime, string name)
        {
            string oldName = this.name;

            if (oldName != null && oldName.Equals(name))
            {
                return;
            }

            this.name = name;
            firePropertyChange(PROPERTY_NAME, oldName, name);
        }

        /// <summary>
        /// Sets dateOfRemoval, hangupCause and hangupCauseText and Changes State to ChannelState#HUNGUP}. Fires a PropertyChangeEvent for State.
        /// </summary>
        /// <param Name="dateOfRemoval">date the Channel was hung up</param>
        /// <param Name="hangupCause">cause for hangup</param>
        /// <param Name="hangupCauseText">textual representation of hangup cause</param>
        internal void hungup(DateTime dateOfRemoval, HangupCause hangupCause, string hangupCauseText)
        {
            lock (asteriskObjectLock)
            {
                this.dateOfRemoval = dateOfRemoval;
                this.hangupCause = hangupCause;
                this.hangupCauseText = hangupCauseText;
                // update State and fire PropertyChangeEvent
                stateChanged(dateOfRemoval, ChannelState.HUNGUP);
            }
        }

        internal void channelDialed(DateTime date, AsteriskChannel dialedChannel)
        {
            lock (asteriskObjectLock)
            {
                AsteriskChannel oldDialedChannel = this.dialedChannel;
                DialedChannelHistoryEntry historyEntry;

                historyEntry = new DialedChannelHistoryEntry(date, dialedChannel);
                lock (dialedChannelHistory)
                {
                    dialedChannelHistory.Add(historyEntry);
                }
                this.dialedChannel = dialedChannel;
                firePropertyChange(PROPERTY_DIALED_CHANNEL, oldDialedChannel, dialedChannel);

            }
        }

        internal void channelDialing(DateTime date, AsteriskChannel dialingChannel)
        {
            lock (asteriskObjectLock)
            {
                AsteriskChannel oldDialingChannel = this.dialingChannel;

                this.dialingChannel = dialingChannel;
                firePropertyChange(PROPERTY_DIALING_CHANNEL, oldDialingChannel, dialingChannel);
            }
        }

        internal void channelUnlinked(DateTime date)
        {
            lock (asteriskObjectLock)
            {
                AsteriskChannel oldLinkedChannel = this.linkedChannel;
                LinkedChannelHistoryEntry historyEntry;

                lock (linkedChannelHistory)
                {
                    if (linkedChannelHistory.Count <= 0)
                    {
                        historyEntry = null;
                    }
                    else
                    {
                        historyEntry = linkedChannelHistory[linkedChannelHistory.Count - 1];
                    }
                }

                if (historyEntry != null)
                {
                    historyEntry.DateUnlinked = date;
                }
                this.linkedChannel = null;
                firePropertyChange(PROPERTY_LINKED_CHANNEL, oldLinkedChannel, null);

            }
        }

        internal void callDetailRecordReceived(DateTime date, CallDetailRecord cdr)
        {
            CallDetailRecord oldCallDetailRecord = this.callDetailRecord;

            this.callDetailRecord = cdr;
            firePropertyChange(PROPERTY_CALL_DETAIL_RECORD, oldCallDetailRecord, callDetailRecord);
        }

        internal void updateVariable(string name, string value)
        {
            lock (variables)
            {
                // string oldValue = variables.get(Name);
                if (variables.ContainsKey(name))
                {
                    variables.Remove(name);
                }
                variables[name] = value;
                // TODO add notification for updated Channel variables
            }
        }

        public bool wasInState(ChannelState channelState)
        {
            lock (stateHistory)
            {
                foreach (ChannelStateHistoryEntry historyEntry in stateHistory)
                {
                    if (historyEntry.State == state)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        internal bool wasBusy()
        {
            return wasInState(ChannelState.BUSY)
                    || hangupCause == HangupCause.AST_CAUSE_BUSY
                    || hangupCause == HangupCause.AST_CAUSE_USER_BUSY;
        }

        public override string ToString()
        {
            StringBuilder sb;
            AsteriskChannel dialedChannel;
            AsteriskChannel dialingChannel;
            AsteriskChannel linkedChannel;

            sb = new StringBuilder("AsteriskChannel[");

            lock (this)
            {
                sb.Append("id='").Append(id).Append("',");
                sb.Append("name='").Append(name).Append("',");
                sb.Append("callerId='").Append(callerId).Append("',");
                sb.Append("state='").Append(state).Append("',");
                sb.Append("account='").Append(account).Append("',");
                sb.Append("dateOfCreation=").Append(dateOfCreation).Append(",");
                dialedChannel = this.dialedChannel;
                dialingChannel = this.dialingChannel;
                linkedChannel = this.linkedChannel;
            }
            if (dialedChannel == null)
            {
                sb.Append("dialedChannel=null,");
            }
            else
            {
                sb.Append("dialedChannel=AsteriskChannel[");
                lock (dialedChannel)
                {
                    sb.Append("id='").Append(dialedChannel.Id).Append("',");
                    sb.Append("name='").Append(dialedChannel.Name).Append("'],");
                }
            }
            if (dialingChannel == null)
            {
                sb.Append("dialingChannel=null,");
            }
            else
            {
                sb.Append("dialingChannel=AsteriskChannel[");
                lock (dialingChannel)
                {
                    sb.Append("id='").Append(dialingChannel.Id).Append("',");
                    sb.Append("name='").Append(dialingChannel.Name).Append("'],");
                }
            }
            if (linkedChannel == null)
            {
                sb.Append("linkedChannel=null");
            }
            else
            {
                sb.Append("linkedChannel=AsteriskChannel[");
                lock (linkedChannel)
                {
                    sb.Append("id='").Append(linkedChannel.Id).Append("',");
                    sb.Append("name='").Append(linkedChannel.Name).Append("']");
                }
            }
            sb.Append("]");

            return sb.ToString();
        }

        #region Action methods
        /// <summary>
        /// 
        /// </summary>
        public void Hangup()
        {
            ManagerResponse response;

            response = server.SendAction(new HangupAction(name));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }
        /// <summary>
        ///  throws ManagerCommunicationException, NoSuchChannelException
        /// </summary>
        /// <param Name="cause"></param>
        public void Hangup(HangupCause cause)
        {
            if (cause != null)
            {
                SetVariable(CAUSE_VARIABLE_NAME, cause.ToString());
            }
            Hangup();
        }
        /// <summary>
        ///  throws ManagerCommunicationException, NoSuchChannelException
        /// </summary>
        /// <param Name="seconds"></param>
        public void SetAbsoluteTimeout(int seconds)
        {
            ManagerResponse response;

            response = server.SendAction(new AbsoluteTimeoutAction(name, seconds));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }
        /// <summary>
        ///  throws ManagerCommunicationException, NoSuchChannelException
        /// </summary>
        /// <param Name="Context"></param>
        /// <param Name="Exten"></param>
        /// <param Name="Priority"></param>
        public void Redirect(string context, string exten, int priority)
        {
            ManagerResponse response;

            response = server.SendAction(new RedirectAction(name, context, exten, priority));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }


        public void RedirectBothLegs(string context, string exten, int priority)
        {
            ManagerResponse response;

            if (linkedChannel == null)
            {
                response = server.SendAction(new RedirectAction(name, context, exten, priority));
            }
            else
            {
                //response = server.SendAction(new RedirectAction(Name, linkedChannel.Name, Context, Exten, Priority,
                //        Context, Exten, Priority));
                // TODO: Unsupported
                throw new AsteriskException("Unsupported redirectBothLegs");
            }

            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }

        public string GetVariable(string variable)
        {
            ManagerResponse response;
            string value;

            response = server.SendAction(new GetVarAction(name, variable));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
            value = response.GetAttribute("Value");
            if (value == null)
            {
                value = response.GetAttribute(variable); // for Asterisk 1.0.x
            }
            return value;
        }

        public void SetVariable(string variable, string value)
        {
            ManagerResponse response;

            response = server.SendAction(new SetVarAction(name, variable, value));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }

        /// <summary>
        /// throws ManagerCommunicationException, NoSuchChannelException, ArgumentException
        /// </summary>
        /// <param Name="digit"></param>
        //public void playDtmf(string digit)
        //{
        //    ManagerResponse response;

        //    if (digit == null)
        //    {
        //        throw new ArgumentNullException("DTMF digit to send must not be null");
        //    }

        //    response = server.SendAction(new PlayDtmfAction(Name, digit));
        //    if (response is ManagerError)
        //    {
        //        throw new NoSuchChannelException("Channel '" + Name + "' is not available: " + response.Message);
        //    }
        //}

        public void StartMonitoring(string filename)
        {
            StartMonitoring(filename, null, false);
        }

        public void StartMonitoring(string filename, string format)
        {
            StartMonitoring(filename, format, false);
        }

        /// <summary>
        /// throws ManagerCommunicationException, NoSuchChannelException
        /// </summary>
        /// <param Name="Filename"></param>
        /// <param Name="format"></param>
        /// <param Name="mix"></param>
        public void StartMonitoring(string filename, string format, bool mix)
        {
            ManagerResponse response;

            response = server.SendAction(new MonitorAction(name, filename, format, mix));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }
        /// <summary>
        /// throws ManagerCommunicationException, NoSuchChannelException, ArgumentException
        /// </summary>
        /// <param Name="Filename"></param>
        public void ChangeMonitoring(string filename)
        {
            ManagerResponse response;

            if (filename == null)
            {
                throw new ArgumentNullException("New filename must not be null");
            }

            response = server.SendAction(new ChangeMonitorAction(name, filename));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }

        public void StopMonitoring()
        {
            ManagerResponse response;

            response = server.SendAction(new StopMonitorAction(name));
            if (response is ManagerError)
            {
                throw new NoSuchChannelException("Channel '" + name + "' is not available: " + response.Message);
            }
        }

        // Asterisk.net not support this Action
        //public void pauseMonitoring()
        //{
        //    ManagerResponse response;

        //    response = server.SendAction(new PauseMonitorAction(Name));
        //    if (response is ManagerError)
        //    {
        //        throw new NoSuchChannelException("Channel '" + Name + "' is not available: " + response.Message);
        //    }
        //}

        // Asterisk.net not support this Action
        //public void unpauseMonitoring()
        //{
        //    ManagerResponse response;

        //    response = server.SendAction(new UnpauseMonitorAction(Name));
        //    if (response is ManagerError)
        //    {
        //        throw new NoSuchChannelException("Channel '" + Name + "' is not available: " + response.Message);
        //    }
        //}

        #endregion

    }
}
