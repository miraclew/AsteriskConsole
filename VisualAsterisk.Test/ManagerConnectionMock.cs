using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager;
using System.Diagnostics;
using System.Reflection;
using Asterisk.NET.Manager.Response;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Event;

namespace VisualAsterisk.Test
{
    class ManagerConnectionMock : IManagerConnection
    {

        #region IManagerConnection 成员

        public event AgentCallbackLoginEventHandler AgentCallbackLogin;

        public event AgentCallbackLogoffEventHandler AgentCallbackLogoff;

        public event AgentCalledEventHandler AgentCalled;

        public event AgentCompleteEventHandler AgentComplete;

        public event AgentConnectEventHandler AgentConnect;

        public event AgentDumpEventHandler AgentDump;

        public event AgentLoginEventHandler AgentLogin;

        public event AgentLogoffEventHandler AgentLogoff;

        public event AgentsEventHandler Agents;

        public event AgentsCompleteEventHandler AgentsComplete;

        public event AlarmEventHandler Alarm;

        public event AlarmClearEventHandler AlarmClear;

        public AsteriskVersion AsteriskVersion
        {
            get { throw new NotImplementedException(); }
        }

        public string BuildAction(global::Asterisk.NET.Manager.Action.ManagerAction action)
        {
            throw new NotImplementedException();
        }

        public string BuildAction(global::Asterisk.NET.Manager.Action.ManagerAction action, string internalActionId)
        {
            throw new NotImplementedException();
        }

        public event CdrEventHandler Cdr;

        public event ConnectionStateEventHandler ConnectionState;

        public event DBGetResponseEventHandler DBGetResponse;

        public int DefaultEventTimeout
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int DefaultResponseTimeout
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event DialEventHandler Dial;

        public event DNDStateEventHandler DNDState;

        public event ExtensionStatusEventHandler ExtensionStatus;

        private bool fireAllEvents;
        public bool FireAllEvents
        {
            get
            {
                return fireAllEvents;
            }
            set
            {
                fireAllEvents = value;
            }
        }

        public string GetProtocolIdentifier()
        {
            throw new NotImplementedException();
        }

        public event HangupEventHandler Hangup;

        public event HoldEventHandler Hold;

        public event HoldedCallEventHandler HoldedCall;

        public string Hostname
        {
            get
            {
                return "Mock Server";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsConnected()
        {
            return true;
        }

        public event JoinEventHandler Join;

        public bool KeepAlive
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool KeepAliveAfterAuthenticationFailure
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event LeaveEventHandler Leave;

        public event LinkEventHandler Link;

        public event LogChannelEventHandler LogChannel;

        public void Login(int timeout)
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public void Logoff()
        {
            throw new NotImplementedException();
        }

        public event MeetMeJoinEventHandler MeetMeJoin;

        public event MeetMeLeaveEventHandler MeetMeLeave;

        public event MeetMeTalkingEventHandler MeetMeTalking;

        public event MessageWaitingEventHandler MessageWaiting;

        public event NewCallerIdEventHandler NewCallerId;

        public event NewChannelEventHandler NewChannel;

        public event NewExtenEventHandler NewExten;

        public event NewStateEventHandler NewState;

        public event OriginateResponseEventHandler OriginateResponse;

        public event ParkedCallEventHandler ParkedCall;

        public event ParkedCallGiveUpEventHandler ParkedCallGiveUp;

        public event ParkedCallsCompleteEventHandler ParkedCallsComplete;

        public event ParkedCallTimeOutEventHandler ParkedCallTimeOut;

        public string Password
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event PeerEntryEventHandler PeerEntry;

        public event PeerlistCompleteEventHandler PeerlistComplete;

        public event PeerStatusEventHandler PeerStatus;

        public int PingInterval
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Port
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event QueueEntryEventHandler QueueEntry;

        public event QueueMemberEventHandler QueueMember;

        public event QueueMemberAddedEventHandler QueueMemberAdded;

        public event QueueMemberPausedEventHandler QueueMemberPaused;

        public event QueueMemberRemovedEventHandler QueueMemberRemoved;

        public event QueueMemberStatusEventHandler QueueMemberStatus;

        public event QueueParamsEventHandler QueueParams;

        public event QueueStatusCompleteEventHandler QueueStatusComplete;

        public void RegisterUserEventClass(Type userEventClass)
        {
            throw new NotImplementedException();
        }

        public event RegistryEventHandler Registry;

        public event RenameEventHandler Rename;

        public global::Asterisk.NET.Manager.Response.ManagerResponse SendAction(global::Asterisk.NET.Manager.Action.ManagerAction action, int timeout)
        {
            throw new NotImplementedException();
        }

        public int SendAction(global::Asterisk.NET.Manager.Action.ManagerAction action, ResponseHandler responseHandler)
        {
            throw new NotImplementedException();
        }

        public global::Asterisk.NET.Manager.Response.ManagerResponse SendAction(global::Asterisk.NET.Manager.Action.ManagerAction action)
        {
            throw new NotImplementedException();
        }

        public ResponseEvents SendEventGeneratingAction(global::Asterisk.NET.Manager.Action.ManagerActionEvent action)
        {
            return SendEventGeneratingAction(action, 5000);
        }

        public ResponseEvents SendEventGeneratingAction(ManagerActionEvent action, int timeout)
        {
            if (action is OriginateAction)
            {
                return createOrignateResponse(action as OriginateAction, timeout);
            }
            else
            {
                return createCommonResponse(action, timeout);
            }
        }

        private ResponseEvents createCommonResponse(ManagerActionEvent action, int timeout)
        {
            ResponseEvents response = new ResponseEvents();
            response.Complete = true;
            response.Response = new ManagerResponse();
            Trace.WriteLine(string.Format("{0}({1})", MethodBase.GetCurrentMethod().Name, action.ToString()));
            return response;
        }

        private ResponseEvents createOrignateResponse(OriginateAction action, int timeout)
        {
            // create that Channel
            NewChannelEvent channel = new NewChannelEvent(null);
            channel.UniqueId = "123456789";
            channel.State = "Ring";
            channel.Channel = action.Channel;
            if (UnhandledEvent != null)
            {
                this.UnhandledEvent(this, channel);
            }
            // send response
            OriginateResponseEvent originateResponse = new OriginateResponseEvent(null);
            originateResponse.UniqueId = channel.UniqueId;

            ResponseEvents response = new ResponseEvents();
            response.Complete = true;
            response.Events.Add(originateResponse);
            Trace.WriteLine(string.Format("{0}({1})", MethodBase.GetCurrentMethod().Name, action.ToString()));
            return response;

        }

        public int SleepTime
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Encoding SocketEncoding
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event StatusEventHandler Status;

        public event StatusCompleteEventHandler StatusComplete;

        public event ManagerEventHandler UnhandledEvent;

        public event UnholdEventHandler Unhold;

        public event UnlinkEventHandler Unlink;

        public event UnparkedCallEventHandler UnparkedCall;

        public event UserEventHandler UserEvents;

        public string Username
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Version
        {
            get { throw new NotImplementedException(); }
        }

        public event ZapShowChannelsEventHandler ZapShowChannels;

        public event ZapShowChannelsCompleteEventHandler ZapShowChannelsComplete;

        #endregion
    }
}
