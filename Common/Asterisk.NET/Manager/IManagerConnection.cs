using System;
namespace Asterisk.NET.Manager
{
    public interface IManagerConnection
    {
        event AgentCallbackLoginEventHandler AgentCallbackLogin;
        event AgentCallbackLogoffEventHandler AgentCallbackLogoff;
        event AgentCalledEventHandler AgentCalled;
        event AgentCompleteEventHandler AgentComplete;
        event AgentConnectEventHandler AgentConnect;
        event AgentDumpEventHandler AgentDump;
        event AgentLoginEventHandler AgentLogin;
        event AgentLogoffEventHandler AgentLogoff;
        event AgentsEventHandler Agents;
        event AgentsCompleteEventHandler AgentsComplete;
        event AlarmEventHandler Alarm;
        event AlarmClearEventHandler AlarmClear;
        AsteriskVersion AsteriskVersion { get; }
        string BuildAction(Asterisk.NET.Manager.Action.ManagerAction action);
        string BuildAction(Asterisk.NET.Manager.Action.ManagerAction action, string internalActionId);
        event CdrEventHandler Cdr;
        event ConnectionStateEventHandler ConnectionState;
        event DBGetResponseEventHandler DBGetResponse;
        int DefaultEventTimeout { get; set; }
        int DefaultResponseTimeout { get; set; }
        event DialEventHandler Dial;
        event DNDStateEventHandler DNDState;
        event ExtensionStatusEventHandler ExtensionStatus;
        bool FireAllEvents { get; set; }
        string GetProtocolIdentifier();
        event HangupEventHandler Hangup;
        event HoldEventHandler Hold;
        event HoldedCallEventHandler HoldedCall;
        string Hostname { get; set; }
        bool IsConnected();
        event JoinEventHandler Join;
        bool KeepAlive { get; set; }
        bool KeepAliveAfterAuthenticationFailure { get; set; }
        event LeaveEventHandler Leave;
        event LinkEventHandler Link;
        event LogChannelEventHandler LogChannel;
        void Login(int timeout);
        void Login();
        void Logoff();
        event MeetMeJoinEventHandler MeetMeJoin;
        event MeetMeLeaveEventHandler MeetMeLeave;
        event MeetMeTalkingEventHandler MeetMeTalking;
        event MessageWaitingEventHandler MessageWaiting;
        event NewCallerIdEventHandler NewCallerId;
        event NewChannelEventHandler NewChannel;
        event NewExtenEventHandler NewExten;
        event NewStateEventHandler NewState;
        event OriginateResponseEventHandler OriginateResponse;
        event ParkedCallEventHandler ParkedCall;
        event ParkedCallGiveUpEventHandler ParkedCallGiveUp;
        event ParkedCallsCompleteEventHandler ParkedCallsComplete;
        event ParkedCallTimeOutEventHandler ParkedCallTimeOut;
        string Password { get; set; }
        event PeerEntryEventHandler PeerEntry;
        event PeerlistCompleteEventHandler PeerlistComplete;
        event PeerStatusEventHandler PeerStatus;
        int PingInterval { get; set; }
        int Port { get; set; }
        event QueueEntryEventHandler QueueEntry;
        event QueueMemberEventHandler QueueMember;
        event QueueMemberAddedEventHandler QueueMemberAdded;
        event QueueMemberPausedEventHandler QueueMemberPaused;
        event QueueMemberRemovedEventHandler QueueMemberRemoved;
        event QueueMemberStatusEventHandler QueueMemberStatus;
        event QueueParamsEventHandler QueueParams;
        event QueueStatusCompleteEventHandler QueueStatusComplete;
        void RegisterUserEventClass(Type userEventClass);
        event RegistryEventHandler Registry;
        event RenameEventHandler Rename;
        Asterisk.NET.Manager.Response.ManagerResponse SendAction(Asterisk.NET.Manager.Action.ManagerAction action, int timeout);
        int SendAction(Asterisk.NET.Manager.Action.ManagerAction action, ResponseHandler responseHandler);
        Asterisk.NET.Manager.Response.ManagerResponse SendAction(Asterisk.NET.Manager.Action.ManagerAction action);
        ResponseEvents SendEventGeneratingAction(Asterisk.NET.Manager.Action.ManagerActionEvent action);
        ResponseEvents SendEventGeneratingAction(Asterisk.NET.Manager.Action.ManagerActionEvent action, int timeout);
        int SleepTime { get; set; }
        System.Text.Encoding SocketEncoding { get; set; }
        event StatusEventHandler Status;
        event StatusCompleteEventHandler StatusComplete;
        event ManagerEventHandler UnhandledEvent;
        event UnholdEventHandler Unhold;
        event UnlinkEventHandler Unlink;
        event UnparkedCallEventHandler UnparkedCall;
        event UserEventHandler UserEvents;
        string Username { get; set; }
        string Version { get; }
        event ZapShowChannelsEventHandler ZapShowChannels;
        event ZapShowChannelsCompleteEventHandler ZapShowChannelsComplete;
    }
}
