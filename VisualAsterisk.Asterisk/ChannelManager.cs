using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager;
using Asterisk.NET.Manager.Event;
using System.Diagnostics;
using System.Threading;
using Asterisk.NET.Manager.Action;
using System.Globalization;
using VisualAsterisk.Asterisk.Config.Internal;
using VisualAsterisk.Core.Util;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Manages Channel events on behalf of an AsteriskServer.
    /// </summary>
    public class ChannelManager : IAsteriskServerComponent
    {
        /// <summary>
        /// How long we wait before we remove hung up channels From memory (in milliseconds).
        /// </summary>
        private const long REMOVAL_THRESHOLD = 15 * 60 * 1000L; // 15 minutes
        private const int SLEEP_TIME_BEFORE_GET_VAR = 50;

        private readonly DefaultAsteriskServer server;

        /**
         * A map of all Active Channel by their unique Id.
         */
        private IDictionary<string, AsteriskChannel> channels;
        object channelsLock = new object();
        object addNewChannelLock = new object();


        public ChannelManager(DefaultAsteriskServer server)
        {
            this.server = server;
            this.channels = new Dictionary<string, AsteriskChannel>();
        }
        public void Initialize()
        {
            ResponseEvents re;

            Disconnected();
            re = server.sendEventGeneratingAction(new StatusAction());
            foreach (ManagerEvent e in re.Events)
            {
                if (e is StatusEvent)
                {
                    handleStatusEvent((StatusEvent)e);
                }
            }
            re = server.sendEventGeneratingAction(new ZapShowChannelsAction());
            foreach (ManagerEvent e in re.Events)
            {
                if (e is ZapShowChannelsEvent)
                {
                    handleZapShowChannelsEvent((ZapShowChannelsEvent)e);                    
                }
            }
        }

        private void handleZapShowChannelsEvent(ZapShowChannelsEvent zapShowChannelsEvent)
        {
            ZapChannel channel = new ZapChannel(); ;
            channel.ChannelNum = int.Parse(zapShowChannelsEvent.Channel);
            channel.Context = zapShowChannelsEvent.Context;
            channel.Alarm = zapShowChannelsEvent.Alarm;
            channel.Signalling = zapShowChannelsEvent.Signalling;
            // TODO: CODE UNCOMPLETED
        }

        public void Disconnected()
        {
            lock (channels)
            {
                channels.Clear();
            }
        }

        private void addChannel(AsteriskChannel channel)
        {
            lock (channelsLock)
            {
                if (channels.ContainsKey(channel.Id))
                {
                    channels.Remove(channel.Id);
                }
                channels.Add(channel.Id, channel);
            }
        }

        private void removeOldChannels()
        {
            lock (channelsLock)
            {
                foreach (string id in new List<string>(channels.Keys))
                {
                    AsteriskChannel c = channels[id];
                    DateTime dateOfRemoval = c.DateOfRemoval;
                    if (c.State == ChannelState.HUNGUP && dateOfRemoval != null)
                    {
                        long diff = DateTime.Now.Ticks - dateOfRemoval.Ticks;
                        if (diff > REMOVAL_THRESHOLD)
                        {
                            server.OnRemoveAsteriskChannel(c);
                            channels.Remove(id);
                        }
                    }
                }
            }
        }

        private AsteriskChannel addNewChannel(string uniqueId, string name,
                                              DateTime dateOfCreation, string callerIdNumber, string callerIdName,
                                              ChannelState state, string account)
        {
            string traceId;
            AsteriskChannel channel = new AsteriskChannel(server, name, uniqueId, dateOfCreation);
            channel.CallerId = new CallerId(callerIdName, callerIdNumber);
            channel.Account = account;
            channel.stateChanged(dateOfCreation, state);
            Trace.TraceInformation("Adding channel " + channel.Name + "(" + channel.Id + ")");
            if (SLEEP_TIME_BEFORE_GET_VAR > 0)
            {
                Thread.Sleep(SLEEP_TIME_BEFORE_GET_VAR);
            }

            traceId = getTraceId(channel);
            channel.TraceId = traceId;

            addChannel(channel);

            // TODO: culture info ignored!
            if (traceId != null && (!name.ToLower().StartsWith("local/") || name.EndsWith(",1")))
            {
                OriginateCallbackData callbackData;
                callbackData = server.getOriginateCallbackDataByTraceId(traceId);
                if (callbackData != null && callbackData.Channel == null)
                {
                    callbackData.Channel = channel;
                    try
                    {
                        callbackData.Callback.fireDialing(this, channel);
                    }
                    catch (System.Exception t)
                    {
                        Trace.TraceWarning("Exception dispatching originate progress. " + t.Message);
                    }
                }
            }
            server.OnNewAsteriskChannel(channel);
            return channel;
        }

        private string getTraceId(AsteriskChannel channel)
        {
            if (channel.Variables.ContainsKey(Constants.VARIABLE_TRACE_ID))
            {
                return channel.Variables[Constants.VARIABLE_TRACE_ID];
            }
            else
                return null;
            //Trace.TraceInformation("TraceId for Channel " + Channel.Name + " is " + traceId);
        }
        /// <summary>
        /// return a collection of all Active AsteriskChannels.
        /// </summary>        
        internal IList<AsteriskChannel> Channels
        {
            get
            {
                IList<AsteriskChannel> copy = new List<AsteriskChannel>();

                lock (channelsLock)
                {
                    foreach (AsteriskChannel c in channels.Values)
                    {
                        if (c.State != ChannelState.HUNGUP)
                        {
                            copy.Add(c);
                        }
                    }
                } return copy;
            }
        }

        internal void handleStatusEvent(StatusEvent statusEvent)
        {
            AsteriskChannel channel;
            AstExten extension;
            bool isNew = false;

            channel = getChannelById(statusEvent.UniqueId);
            if (channel == null)
            {
                DateTime dateOfCreation;

                if (statusEvent.Seconds != null)
                {
                    dateOfCreation = new DateTime(DateTime.Now.Ticks - (statusEvent.Seconds * 1000L));
                }
                else
                {
                    dateOfCreation = DateTime.Now;
                }
                channel = new AsteriskChannel(server, statusEvent.Channel, statusEvent.UniqueId, dateOfCreation);
                isNew = true;
            }

            if (statusEvent.Context == null && statusEvent.Extension == null
                    && statusEvent.Priority == null)
            {
                extension = null;
            }
            else
            {
                extension = new AstExten(statusEvent.Context, statusEvent.Extension, statusEvent.Priority);
            }

            lock (channel)
            {
                channel.CallerId = new CallerId(statusEvent.CallerIdName, statusEvent.CallerIdNum);
                channel.Account = statusEvent.Account;
                if (statusEvent.State != null)
                {
                    if (!string.IsNullOrEmpty(statusEvent.State))
                    {                        
                        channel.stateChanged(statusEvent.DateReceived, ChannelStateHelper.FromString(statusEvent.State));
                    }
                }
                channel.extensionVisited(statusEvent.DateReceived, extension);

                if (statusEvent.Link != null)
                {
                    AsteriskChannel linkedChannel = getChannelByName(statusEvent.Link);
                    if (linkedChannel != null)
                    {
                        // the date used here is not correct!
                        channel.channelLinked(statusEvent.DateReceived, linkedChannel);
                        lock (linkedChannel)
                        {
                            linkedChannel.channelLinked(statusEvent.DateReceived, channel);
                        }
                    }
                }
            }

            if (isNew)
            {
                Trace.TraceInformation("Adding new channel " + channel.Name);
                addChannel(channel);
                server.OnNewAsteriskChannel(channel);
            }
        }

        /// <summary>
        /// Returns a Channel From the ChannelManager's cache with the given Name
        /// If multiple channels are found, returns the most recently CREATED one.
        /// If two channels with the very same date exist, avoid HUNGUP ones.
        /// </summary>
        /// <param Name="Name">Name the Name of the requested Channel.</param>
        /// <returns>the (most recent) Channel if found, in any State, or null if none found.</returns>
        internal AsteriskChannel getChannelByName(string name)
        {
            DateTime dateOfCreation = DateTime.Now;
            AsteriskChannel channel = null;

            if (name == null)
            {
                return null;
            }

            lock (channelsLock)
            {
                foreach (AsteriskChannel tmp in channels.Values)
                {
                    if (tmp.Name != null && tmp.Name.Equals(name))
                    {
                        // return the most recent Channel or when dates are similar, the Active one
                        if (channel == null || tmp.DateOfCreation.CompareTo(dateOfCreation) > 0 ||
                                (tmp.DateOfCreation.Equals(dateOfCreation) && tmp.State != ChannelState.HUNGUP))
                        {
                            channel = tmp;
                            dateOfCreation = channel.DateOfCreation;
                        }
                    }
                }
            }
            return channel;
        }

        internal AsteriskChannel getChannelById(string id)
        {
            AsteriskChannel channel = null;

            if (id == null)
            {
                return null;
            }

            lock (channels)
            {
                if (channels.ContainsKey(id))
                {
                    channel = channels[id];
                }
            }
            return channel;
        }

        /// <summary>
        /// Returns a NON-HUNGUP Channel From the ChannelManager's cache with the given Name.
        /// </summary>
        /// <param Name="Name">the Name of the requested Channel.</param>
        /// <returns>the NON-HUNGUP Channel if found, or null if none is found.</returns>
        internal AsteriskChannel getChannelByNameAndActive(string name)
        {
            // In non bristuffed AST 1.2, we don't have uniqueid header to Match the Channel
            // So we must use the Channel Name
            // Channel Name is unique at any give moment in the  * server
            // But asterisk-java keeps Hungup channels for a while.
            // We don't want to retrieve hungup channels.

            AsteriskChannel channel = null;

            if (name == null)
            {
                return null;
            }

            lock (channelsLock)
            {
                foreach (AsteriskChannel tmp in channels.Values)
                {
                    if (tmp.Name != null && tmp.Name.Equals(name) && tmp.State != ChannelState.HUNGUP)
                    {
                        channel = tmp;
                    }
                }
            }
            return channel;
        }

        /// <summary>
        /// Returns a NON-HUNGUP Channel From the ChannelManager's cache with the given Name.
        /// </summary>
        /// <param Name="Name">the Name of the requested Channel.</param>
        /// <returns>the NON-HUNGUP Channel if found, or null if none is found.</returns>
        internal AsteriskChannel GetChannelByNameAndActive(string name)
        {

            // In non bristuffed AST 1.2, we don't have uniqueid header to Match the Channel
            // So we must use the Channel Name
            // Channel Name is unique at any give moment in the  * server
            // But asterisk-java keeps Hungup channels for a while.
            // We don't want to retrieve hungup channels.

            AsteriskChannel channel = null;
            if (name == null)
            {
                return null;
            }

            lock (channelsLock)
            {
                foreach (AsteriskChannel tmp in channels.Values)
                {
                    if (tmp.Name != null && tmp.Name.Equals(name) && tmp.State != ChannelState.HUNGUP)
                    {
                        channel = tmp;
                    }
                }
            }
            return channel;
        }

        /**
         * Returns the other side of a local Channel.
         * <p/>
         * Local channels consist of two sides, like
         * "Local/1234@From-local-60b5,1" and "Local/1234@From-local-60b5,2"
         * this method returns the other side.
         *
         * @param localChannel one side
         * @return the other side, or <code>null</code> if not available or if the given Channel
         *         is not a local Channel.
         */
        internal AsteriskChannel getOtherSideOfLocalChannel(AsteriskChannel localChannel)
        {
            string name;
            char num;

            if (localChannel == null)
            {
                return null;
            }

            name = localChannel.Name;
            if (name == null || !name.StartsWith("Local/") || name[name.Length - 2] != ',')
            {
                return null;
            }

            num = name[name.Length - 1];

            if (num == '1')
            {
                return getChannelByName(name.Substring(0, name.Length - 1) + "2");
            }
            else if (num == '2')
            {
                return getChannelByName(name.Substring(0, name.Length - 1) + "1");
            }
            else
            {
                return null;
            }
        }

        internal void handleNewChannelEvent(NewChannelEvent e)
        {
            lock (addNewChannelLock)
            {
                AsteriskChannel channel = getChannelById(e.UniqueId);
                ChannelState state = (ChannelState)Enum.Parse(typeof(ChannelState), e.State, true);

                if (channel == null)
                {

                    addNewChannel(
                            e.UniqueId, e.Channel, e.DateReceived,
                            e.CallerIdNum, e.CallerIdName,
                            state, e.AccountCode);
                }
                else
                {
                    // Channel had already been created probably by a NewCallerIdEvent
                    lock (channel)
                    {
                        channel.nameChanged(e.DateReceived, e.Channel);
                        channel.CallerId = new CallerId(e.CallerIdName, e.CallerIdNum);
                        channel.stateChanged(e.DateReceived, state);
                    }
                }

            }
        }

        internal void handleNewExtenEvent(NewExtenEvent e)
        {
            AsteriskChannel channel;
            AstExten extension;

            channel = getChannelById(e.UniqueId);
            if (channel == null)
            {
                Trace.TraceError("Ignored NewExtenEvent for unknown channel " + e.Channel);
                return;
            }

            extension = new AstExten(
                    e.Context, e.Extension, e.Priority,
                    e.Application, e.AppData);

            lock (channel)
            {
                channel.extensionVisited(e.DateReceived, extension);
            }
        }

        internal void handleNewStateEvent(NewStateEvent e)
        {
            lock (addNewChannelLock)
            {
                AsteriskChannel channel = getChannelById(e.UniqueId);

                if (channel == null)
                {
                    // NewStateEvent can occur instead of a NewChannelEvent
                    ChannelState state = (ChannelState)Enum.Parse(typeof(ChannelState), e.State, true);
                    channel = addNewChannel(
                            e.UniqueId, e.Channel, e.DateReceived,
                            e.CallerIdNum, e.CallerIdName,
                            state, null /* account code not available */);
                }
                else
                {
                    // NewStateEvent can provide a new CallerIdNum or CallerIdName not previously received through a
                    // NewCallerIdEvent. This happens at least on outgoing legs From the queue Application to agents.

                    if (e.CallerIdNum != null || e.CallerIdName != null)
                    {
                        string cidnum = "";
                        string cidname = "";
                        CallerId currentCallerId = channel.CallerId;

                        if (currentCallerId != null)
                        {
                            cidnum = currentCallerId.Number;
                            cidname = currentCallerId.Name;
                        }

                        if (e.CallerIdNum != null)
                        {
                            cidnum = e.CallerIdNum;
                        }

                        if (e.CallerIdName != null)
                        {
                            cidname = e.CallerIdName;
                        }

                        CallerId newCallerId = new CallerId(cidname, cidnum);
                        Trace.WriteLine("Updating CallerId (following NewStateEvent) to: " + newCallerId.ToString());
                        channel.CallerId = newCallerId;
                    }

                    // Also, NewStateEvent can return a new Channel Name for the same Channel uniqueid, indicating the Channel has been
                    // renamed but no related RenameEvent has been received.
                    // This happens with mISDN channels (see AJ-153)
                    if (e.Channel != null && !e.Channel.Equals(channel.Name))
                    {
                        Trace.TraceInformation("Renaming channel (following NewStateEvent) '" + channel.Name + "' to '"
                                + e.Channel + "'");
                        lock (channel)
                        {
                            channel.nameChanged(e.DateReceived, e.Channel);
                        }
                    }
                }

                //if (e.ChannelState != null)
                if (e.State != null)
                {
                    ChannelState state = (ChannelState)Enum.Parse(typeof(ChannelState), e.State, true);
                    lock (channel)
                    {
                        channel.stateChanged(e.DateReceived, state);
                    }
                }

            }
        }

        internal void handleNewCallerIdEvent(NewCallerIdEvent e)
        {
            AsteriskChannel channel = getChannelById(e.UniqueId);

            if (channel == null)
            {
                // NewCallerIdEvent can occur before NewChannelEvent
                addNewChannel(
                        e.UniqueId, e.Channel, e.DateReceived,
                        e.CallerIdNum, e.CallerIdName,
                        ChannelState.DOWN, null /* account code not available */);
            }
            else
            {
                lock (channel)
                {
                    channel.CallerId = new CallerId(e.CallerIdName, e.CallerIdNum);
                }
            }
        }

        internal void handleHangupEvent(HangupEvent e)
        {
            HangupCause cause;
            AsteriskChannel channel = getChannelById(e.UniqueId);

            if (channel == null)
            {
                Trace.TraceError("Ignored HangupEvent for unknown channel " + e.Channel);
                return;
            }

            cause = EnumHelper.ParseHangupCauseByCode(e.Cause);

            lock (channel)
            {
                channel.hungup(e.DateReceived, cause, e.CauseTxt);
            }

            Trace.TraceInformation("Removing channel " + channel.Name + " due to hangup (" + cause + ")");
            // TODO: I don't know why we should wait REMOVAL_THRESHOLD, so we replace removeOldChannels() as following
            server.OnRemoveAsteriskChannel(channel);
            channels.Remove(e.UniqueId);

            //removeOldChannels();
        }

        internal void handleDialEvent(DialEvent e)
        {
            AsteriskChannel sourceChannel = getChannelById(e.UniqueId);
            AsteriskChannel destinationChannel = getChannelById(e.DestUniqueId);

            if (sourceChannel == null)
            {
                Trace.TraceError("Ignored LinkEvent for unknown source channel " + e.Channel);
                return;
            }
            if (destinationChannel == null)
            {
                Trace.TraceError("Ignored DialEvent for unknown destination channel " + e.Destination);
                return;
            }

            Trace.TraceInformation(sourceChannel.Name + " dialed " + destinationChannel.Name);
            getTraceId(sourceChannel);
            getTraceId(destinationChannel);
            lock (sourceChannel)
            {
                sourceChannel.channelDialed(e.DateReceived, destinationChannel);
            }
            lock (destinationChannel)
            {
                destinationChannel.channelDialing(e.DateReceived, sourceChannel);
            }
        }

        internal void handleBridgeEvent(BridgeEvent e)
        {
            AsteriskChannel channel1 = getChannelById(e.UniqueId1);
            AsteriskChannel channel2 = getChannelById(e.UniqueId2);

            if (channel1 == null)
            {
                Trace.TraceError("Ignored BridgeEvent for unknown channel " + e.Channel1);
                return;
            }
            if (channel2 == null)
            {
                Trace.TraceError("Ignored BridgeEvent for unknown channel " + e.Channel2);
                return;
            }

            if (e.BridgeState == BridgeEvent.BridgeStates.BRIDGE_STATE_LINK)
            {
                Trace.TraceInformation("Linking channels " + channel1.Name + " and " + channel2.Name);
                lock (channel1)
                {
                    channel1.channelLinked(e.DateReceived, channel2);
                }

                lock (channel2)
                {
                    channel2.channelLinked(e.DateReceived, channel1);
                }
            }

            if (e.BridgeState == BridgeEvent.BridgeStates.BRIDGE_STATE_UNLINK)
            {
                Trace.TraceInformation("Unlinking channels " + channel1.Name + " and " + channel2.Name);
                lock (channel1)
                {
                    channel1.channelUnlinked(e.DateReceived);
                }

                lock (channel2)
                {
                    channel2.channelUnlinked(e.DateReceived);
                }
            }
        }

        internal void handleRenameEvent(RenameEvent e)
        {
            AsteriskChannel channel = getChannelById(e.UniqueId);

            if (channel == null)
            {
                Trace.TraceError("Ignored RenameEvent for unknown channel with uniqueId "
                        + e.UniqueId);
                return;
            }

            Trace.TraceInformation("Renaming channel '" + channel.Name + "' to '"
                    + e.NewName + "'");
            lock (channel)
            {
                channel.nameChanged(e.DateReceived, e.NewName);
            }
        }

        internal void handleCdrEvent(CdrEvent e)
        {
            AsteriskChannel channel = getChannelById(e.UniqueId);
            AsteriskChannel destinationChannel = getChannelByName(e.DestinationChannel);
            CallDetailRecord cdr;

            if (channel == null)
            {
                Trace.TraceInformation("Ignored CdrEvent for unknown channel with uniqueId " + e.UniqueId);
                return;
            }

            cdr = new CallDetailRecord(channel, destinationChannel, e);

            lock (channel)
            {
                channel.callDetailRecordReceived(e.DateReceived, cdr);
            }
        }

        internal void handleParkedCallEvent(ParkedCallEvent e)
        {
            // Only bristuffed versions: AsteriskChannel Channel = getChannelById(e.UniqueId);
            AsteriskChannel channel = getChannelByNameAndActive(e.Channel);

            if (channel == null)
            {
                Trace.TraceInformation("Ignored ParkedCallEvent for unknown channel "
                        + e.Channel);
                return;
            }

            lock (channel)
            {
                // todo The Context should be "parkedcalls" or whatever has been configured in Features.conf
                // unfortunately we don't get the Context in the ParkedCallEvent so for now we'll set it to null.
                AstExten ext = new AstExten(null, e.Exten, 1);
                channel.ParkedAt = ext;
                Trace.TraceInformation("Channel " + channel.Name + " is parked at " + channel.ParkedAt.Exten);
            }
        }

        internal void handleParkedCallGiveUpEvent(ParkedCallGiveUpEvent e)
        {
            // Only bristuffed versions: AsteriskChannel Channel = getChannelById(e.UniqueId);
            AsteriskChannel channel = getChannelByNameAndActive(e.Channel);

            if (channel == null)
            {
                Trace.TraceInformation("Ignored ParkedCallGiveUpEvent for unknown channel "
                        + e.Channel);
                return;
            }

            AstExten wasParkedAt = channel.ParkedAt;

            if (wasParkedAt == null)
            {
                Trace.TraceInformation("Ignored ParkedCallGiveUpEvent as the channel was not parked");
                return;
            }

            lock (channel)
            {
                channel.ParkedAt = null;
            }
            Trace.TraceInformation("Channel " + channel.Name + " is unparked (GiveUp) from " + wasParkedAt.Exten);
        }

        internal void handleParkedCallTimeOutEvent(ParkedCallTimeOutEvent e)
        {
            // Only bristuffed versions: AsteriskChannel Channel = getChannelById(e.UniqueId);
            AsteriskChannel channel = getChannelByNameAndActive(e.Channel);

            if (channel == null)
            {
                Trace.TraceInformation("Ignored ParkedCallTimeOutEvent for unknown channel " + e.Channel);
                return;
            }

            AstExten wasParkedAt = channel.ParkedAt;

            if (wasParkedAt == null)
            {
                Trace.TraceInformation("Ignored ParkedCallTimeOutEvent as the channel was not parked");
                return;
            }

            lock (channel)
            {
                channel.ParkedAt = null;
            }
            Trace.TraceInformation("Channel " + channel.Name + " is unparked (Timeout) from " + wasParkedAt.Exten);
        }

        internal void handleUnparkedCallEvent(UnparkedCallEvent e)
        {
            // Only bristuffed versions: AsteriskChannel Channel = getChannelById(e.UniqueId);
            AsteriskChannel channel = getChannelByNameAndActive(e.Channel);

            if (channel == null)
            {
                Trace.TraceInformation("Ignored UnparkedCallEvent for unknown channel " + e.Channel);
                return;
            }

            AstExten wasParkedAt = channel.ParkedAt;

            if (wasParkedAt == null)
            {
                Trace.TraceInformation("Ignored UnparkedCallEvent as the channel was not parked");
                return;
            }

            lock (channel)
            {
                channel.ParkedAt = null;
            }
            Trace.TraceInformation("Channel " + channel.Name + " is unparked (moved away) from " + wasParkedAt.Exten);
        }

        internal void handleVarSetEvent(VarSetEvent e)
        {
            if (e.UniqueId == null)
            {
                return;
            }

            AsteriskChannel channel = getChannelById(e.UniqueId);
            if (channel == null)
            {
                Trace.TraceInformation("Ignored VarSetEvent for unknown channel with uniqueId " + e.UniqueId);
                return;
            }

            lock (channel)
            {
                channel.updateVariable(e.Variable, e.Value);
            }
        }

    }
}
