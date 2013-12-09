using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Event;
using System.Diagnostics;

namespace VisualAsterisk.Asterisk
{
    class ParkedCallManager : IAsteriskServerComponent
    {
        private DefaultAsteriskServer server;
        private ChannelManager channelManager;
        /**
         * A Map of parkedcalls by thier uniqId.
         */
        private IDictionary<string, ParkedCall> parkedCalls;

        public ParkedCallManager(DefaultAsteriskServer asteriskServer, ChannelManager channelManager)
        {
            this.server = asteriskServer;
            this.channelManager = channelManager;
            parkedCalls = new Dictionary<string, ParkedCall>();
        }

        /**
         * Retrieves all parkedCalls Asterisk server by sending an
         * ParkedCallsAction.
         *
         * @throws ManagerCommunicationException if communication with Asterisk
         *                                       server fails.
         */
        public void Initialize()
        {
            ResponseEvents re;
            Disconnected();
            re = server.sendEventGeneratingAction(new ParkedCallsAction());
            foreach (ManagerEvent e in re.Events)
            {
                if (e is ParkedCallEvent)
                {
                    //System.cons.println(e);
                    handleParkedCallEvent((ParkedCallEvent)e);
                }
            }

            // HACK: is this good design?
            //server.NewAsteriskChannel += new NewChannelEventHandler(server_NewAsteriskChannel);
        }

        private void addParkedCall(ParkedCall call)
        {
            lock (parkedCalls)
            {
                if (!parkedCalls.ContainsKey(call.Exten))
                {
                    parkedCalls.Add(call.Exten, call);
                    server.OnNewParkedCall(call);
                }
            }
        }

        private void removeParkedCall(ParkedCall call)
        {
            lock (parkedCalls)
            {
                if (parkedCalls.ContainsKey(call.Exten))
                {
                    parkedCalls.Remove(call.Exten);
                    server.OnRemoveParkedCall(call);
                }
            }
        }

        public void Disconnected()
        {
            lock (parkedCalls)
            {
                parkedCalls.Clear();
            }
        }

        internal void handleParkedCallEvent(ParkedCallEvent parkedCallEvent)
        {
            lock (this)
            {
                ParkedCall call = new ParkedCall(server);
                call.From = server.GetChannelByName(parkedCallEvent.From);
                call.Channel = server.GetChannelByName(parkedCallEvent.Channel);
                call.CallerId = new CallerId(parkedCallEvent.CallerIdName, parkedCallEvent.CallerIdNum);
                call.Exten = parkedCallEvent.Exten;
                call.Timeout = parkedCallEvent.Timeout;
                Trace.TraceInformation(string.Format("Adding parkedcall {0}", call.ToString()));

                addParkedCall(call);
                
            }
        }

        internal void handleUnparkedCallEvent(UnparkedCallEvent unparkedCallEvent)
        {
            if (parkedCalls.ContainsKey(unparkedCallEvent.Exten))
            {
                ParkedCall call = parkedCalls[unparkedCallEvent.Exten];
                removeParkedCall(call);
            }
        }

        internal void handleParkedCallTimeOutEvent(ParkedCallTimeOutEvent parkedCallTimeOutEvent)
        {
            ParkedCall call = parkedCalls[parkedCallTimeOutEvent.Exten];
            call.CallTimeout();
        }

        internal void handleParkedCallGiveUpEvent(ParkedCallGiveUpEvent parkedCallGiveUpEvent)
        {
            ParkedCall call = parkedCalls[parkedCallGiveUpEvent.Exten];
            call.CallGiveup();
        }

        internal IList<ParkedCall> GetParkedCalls()
        {
            IList<ParkedCall> copy;

            lock (parkedCalls)
            {
                copy = new List<ParkedCall>(parkedCalls.Values);
            }
            return copy;
        }
    }
}
