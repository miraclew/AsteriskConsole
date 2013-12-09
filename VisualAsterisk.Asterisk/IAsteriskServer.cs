using System;
using Asterisk.NET.Manager.Event;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Response;
using System.Collections.Generic;
using VisualAsterisk.Asterisk.Config;

namespace VisualAsterisk.Asterisk
{
    public interface IAsteriskServer
    {
        event AgentRemovedEventHandler AgentRemoved;
        System.Collections.Generic.IList<AsteriskAgent> Agents { get; }
        event ChannelRemovedEventHandler AsteriskChannelRemoved;
        System.Collections.Generic.IList<AsteriskChannel> Channels { get; }
        IAsteriskConfigManager ConfigManager { get; set; }
        event EventHandler<ConnectingProgressEventArg> ConnectingProgressChanged;
        ManagerConnectionInfo ConnectionInfo { get; set; }
        void DbDel(string family, string key);
        DBGetResponseEvent DbGet(string family, string key);
        void DbPut(string family, string key, string value);
        System.Collections.Generic.List<string> ExecuteCliCommand(string command);
        AsteriskChannel GetChannelById(string id);
        AsteriskChannel GetChannelByName(string name);
        AsteriskChannel GetChannelByNameAndActive(string name);
        string GetGlobalVariable(string variable);
        AsteriskMeetMeRoom GetMeetmeRoom(string name);
        System.Collections.Generic.IList<ParkedCall> GetParkedCalls();
        System.Collections.Generic.List<PeerEntryEvent> GetPeerEntries();
        System.Collections.Generic.IList<AsteriskPeer> GetPeerEntriesEx();
        System.Collections.Generic.Dictionary<string, string> GetSipPeerDetailInfo(string peer);
        System.Collections.Generic.IList<Voicemailbox> GetVoicemailboxes();
        void Initialize();
        bool IsConnected();
        System.Collections.Generic.IList<AsteriskMeetMeRoom> MeetmeRooms { get; }
        event MeetMeUserRemovedEventHandler MeetMeUserRemoved;
        event NewAgentEventHandler NewAgent;
        event NewChannelEventHandler NewAsteriskChannel;
        event NewMeetMeUserEventHandler NewMeetMeUser;
        event NewParkedCallEventHandler NewParkedCall;
        event NewQueueEntryEventHandler NewQueueEntry;
        AsteriskChannel originate(OriginateAction originateAction);
        void originateAsync(OriginateAction originateAction, IOriginateCallback cb);
        AsteriskChannel originateToApplication(string channel, string application, string data, long timeout);
        AsteriskChannel originateToApplication(string channel, string application, string data, long timeout, CallerId callerId, System.Collections.Generic.Dictionary<string, string> variables);
        AsteriskChannel OriginateToExtension(string channel, string context, string exten, int priority, long timeout);
        AsteriskChannel OriginateToExtension(string channel, string context, string exten, int priority, long timeout, CallerId callerId, System.Collections.Generic.Dictionary<string, string> variables);
        event ParkedCallRemovedEventHandler ParkedCallRemoved;
        event QueueEntryRemovedEventHandler QueueEntryRemoved;
        System.Collections.Generic.IList<AsteriskQueue> Queues { get; }
        ManagerResponse SendAction(ManagerAction action);
        ManagerResponse SendAction(ManagerAction action, int timeout);
        void SetGlobalVariable(string variable, string value);
        void Shutdown();
        bool SkipQueues { get; set; }
        int ExecuteCommandTimeout { get; set; }
        ServerState State { get; set; }
        event EventHandler<ServerStateEventArg> StateChanged;
        event TrunkEventHandler TrunkStateChanged;
        string Version { get; set; }

        void RecordVoicePrompt(string fileName, string extensionToRecord);
        void PlayVoicePrompt(string fileName, string extensionToRecord);
        void DeleteRecordedVoicePrompt(string fileName);

        IList<string> GetAllRecordedVoicePrompt();
        IList<string> GetAllMusicFiles();
        IList<string> GetAllCodecs();
        IList<string> GetAllAgiScripts();

        // System
        void ExecuteSystemCommand(string commandToExecute);
        List<string> GetSysInfoOutput(string file, bool trimEmptyLine);
        VisualAsterisk.Core.Management.LinuxSystem GetSystemInformation(bool refresh);

        // Backup
        IList<string> GetAllBackupFiles();
        void RemoveBackupFile(string file);
        void CreateBackup(string name);
        void RestoreConfig(string fileName);
        IEnumerable<Backup> Backups { get; set; }

        // Asterisk server
        void Reload();

        // CDR
        //int CallsThisMonth { get; }
        //int CallsThisWeek { get; }
        //int CallsToday { get; }
        //IEnumerable<CdrEvent> CallDetailRecords { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory">where to store the cdr file</param>
        void LoadCDR(string directory, bool reload);

        string GetConfigFile(string file);

        void UpdateConfigFile(string file);
    }
}
