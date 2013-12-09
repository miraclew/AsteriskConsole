using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager;
using VisualAsterisk.Test.Simulator;
using Asterisk.NET.Manager.Event;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Response;

namespace VisualAsterisk.Test.Simulator
{
    
    public class AsteriskSim : SimulatorBase, IManagerConnection
    {
        #region IManagerConnection Members

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
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public string BuildAction(ManagerAction action)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public string BuildAction(ManagerAction action, string internalActionId)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public event CdrEventHandler Cdr;

        public event ConnectionStateEventHandler ConnectionState;

        public event DBGetResponseEventHandler DBGetResponse;

        public int DefaultEventTimeout
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public int DefaultResponseTimeout
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public event DialEventHandler Dial;

        public event DNDStateEventHandler DNDState;

        public event ExtensionStatusEventHandler ExtensionStatus;

        public bool FireAllEvents
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string GetProtocolIdentifier()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public event HangupEventHandler Hangup;

        public event HoldEventHandler Hold;

        public event HoldedCallEventHandler HoldedCall;

        public string Hostname
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public bool IsConnected()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public event JoinEventHandler Join;

        public bool KeepAlive
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public bool KeepAliveAfterAuthenticationFailure
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public event LeaveEventHandler Leave;

        public event LinkEventHandler Link;

        public event LogChannelEventHandler LogChannel;

        public void Login(int timeout)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Login()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Logoff()
        {
            throw new Exception("The method or operation is not implemented.");
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
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public event PeerEntryEventHandler PeerEntry;

        public event PeerlistCompleteEventHandler PeerlistComplete;

        public event PeerStatusEventHandler PeerStatus;

        public int PingInterval
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public int Port
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
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
            throw new Exception("The method or operation is not implemented.");
        }

        public event RegistryEventHandler Registry;

        public event RenameEventHandler Rename;

        public ManagerResponse SendAction(ManagerAction action, int timeout)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int SendAction(ManagerAction action, ResponseHandler responseHandler)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ManagerResponse SendAction(ManagerAction action)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ResponseEvents SendEventGeneratingAction(ManagerActionEvent action)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ResponseEvents SendEventGeneratingAction(ManagerActionEvent action, int timeout)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int SleepTime
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public Encoding SocketEncoding
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
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
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string Version
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public event ZapShowChannelsEventHandler ZapShowChannels;

        public event ZapShowChannelsCompleteEventHandler ZapShowChannelsComplete;

        #endregion

        public override void Start()
        {
            m_Timer.Start();
        }

        public override void Stop()
        {
            m_Timer.Stop();
        }

        protected override void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //NewStateEvent newstate = new NewStateEvent(this);
            //newstate.Attributes.Add("", "");
            //this.NewState(this, newstate);
        }        
    }
}
