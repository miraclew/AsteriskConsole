using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using System.IO;
using System.Diagnostics;

namespace VisualAsterisk.Test
{
    public class AsteriskServerMock : IAsteriskServer
    {
        private string configFileDir;
        private IAsteriskConfigManager configManager;
        #region IAsteriskServer 成员

        public AsteriskServerMock()
        {
            configFileDir = Path.Combine(Environment.CurrentDirectory, @"..\..\..\TestData\configfiles\centos1");
            configManager = new AsteriskConfigManager(configFileDir);
            configManager.Initialize();
        }

        public event AgentRemovedEventHandler AgentRemoved;

        public IList<AsteriskAgent> Agents
        {
            get { throw new NotImplementedException(); }
        }

        public event ChannelRemovedEventHandler AsteriskChannelRemoved;

        public IList<AsteriskChannel> Channels
        {
            get
            {
                return new List<AsteriskChannel>();
            }
        }

        public IAsteriskConfigManager ConfigManager
        {
            get { return configManager; }
            set { configManager = value; }
        }

        public event EventHandler<ConnectingProgressEventArg> ConnectingProgressChanged;

        public ManagerConnectionInfo ConnectionInfo
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

        public void DbDel(string family, string key)
        {
            throw new NotImplementedException();
        }

        public global::Asterisk.NET.Manager.Event.DBGetResponseEvent DbGet(string family, string key)
        {
            throw new NotImplementedException();
        }

        public void DbPut(string family, string key, string value)
        {
            throw new NotImplementedException();
        }

        public List<string> ExecuteCliCommand(string command)
        {
            throw new NotImplementedException();
        }

        public AsteriskChannel GetChannelById(string id)
        {
            throw new NotImplementedException();
        }

        public AsteriskChannel GetChannelByName(string name)
        {
            throw new NotImplementedException();
        }

        public AsteriskChannel GetChannelByNameAndActive(string name)
        {
            throw new NotImplementedException();
        }

        public string GetGlobalVariable(string variable)
        {
            throw new NotImplementedException();
        }

        public AsteriskMeetMeRoom GetMeetmeRoom(string name)
        {
            throw new NotImplementedException();
        }

        public IList<ParkedCall> GetParkedCalls()
        {
            throw new NotImplementedException();
        }

        public List<global::Asterisk.NET.Manager.Event.PeerEntryEvent> GetPeerEntries()
        {
            throw new NotImplementedException();
        }

        public IList<AsteriskPeer> GetPeerEntriesEx()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetSipPeerDetailInfo(string peer)
        {
            throw new NotImplementedException();
        }

        public IList<Voicemailbox> GetVoicemailboxes()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            configManager.Initialize();
        }

        public bool IsConnected()
        {
            return true;
        }

        public IList<AsteriskMeetMeRoom> MeetmeRooms
        {
            get { throw new NotImplementedException(); }
        }

        public event MeetMeUserRemovedEventHandler MeetMeUserRemoved;

        public event NewAgentEventHandler NewAgent;

        public event NewChannelEventHandler NewAsteriskChannel;

        public event NewMeetMeUserEventHandler NewMeetMeUser;

        public event NewParkedCallEventHandler NewParkedCall;

        public event NewQueueEntryEventHandler NewQueueEntry;

        public AsteriskChannel originate(global::Asterisk.NET.Manager.Action.OriginateAction originateAction)
        {
            throw new NotImplementedException();
        }

        public void originateAsync(global::Asterisk.NET.Manager.Action.OriginateAction originateAction, IOriginateCallback cb)
        {
            throw new NotImplementedException();
        }

        public AsteriskChannel originateToApplication(string channel, string application, string data, long timeout)
        {
            throw new NotImplementedException();
        }

        public AsteriskChannel originateToApplication(string channel, string application, string data, long timeout, CallerId callerId, Dictionary<string, string> variables)
        {
            throw new NotImplementedException();
        }

        public AsteriskChannel OriginateToExtension(string channel, string context, string exten, int priority, long timeout)
        {
            throw new NotImplementedException();
        }

        public AsteriskChannel OriginateToExtension(string channel, string context, string exten, int priority, long timeout, CallerId callerId, Dictionary<string, string> variables)
        {
            throw new NotImplementedException();
        }

        public event ParkedCallRemovedEventHandler ParkedCallRemoved;

        public event QueueEntryRemovedEventHandler QueueEntryRemoved;

        public IList<AsteriskQueue> Queues
        {
            get { throw new NotImplementedException(); }
        }

        public global::Asterisk.NET.Manager.Response.ManagerResponse SendAction(global::Asterisk.NET.Manager.Action.ManagerAction action)
        {
            throw new NotImplementedException();
        }

        public global::Asterisk.NET.Manager.Response.ManagerResponse SendAction(global::Asterisk.NET.Manager.Action.ManagerAction action, int timeout)
        {
            throw new NotImplementedException();
        }

        public void SetGlobalVariable(string variable, string value)
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            Trace.WriteLine("MockServer shutdown");
        }

        public bool SkipQueues
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

        public ServerState State
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

        public event EventHandler<ServerStateEventArg> StateChanged;

        public event TrunkEventHandler TrunkStateChanged;

        public string Version
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

        #endregion

        #region IAsteriskServer 成员

        public void RecordVoicePrompt(string fileName, string extensionToRecord)
        {
            Trace.WriteLine(string.Format("OK..., I will record {0} using {1}", fileName, extensionToRecord));
        }

        public void PlayVoicePrompt(string fileName, string extensionToRecord)
        {
            Trace.WriteLine(string.Format("OK..., I will play {0} using {1}", fileName, extensionToRecord));
        }

        public void DeleteRecordedVoicePrompt(string fileName)
        {
            Trace.WriteLine(string.Format("OK..., I will delete {0}", fileName));
        }

        public IEnumerable<string> GetAllRecordedVoicePrompt()
        {
            string[] recorded = new string[] { "mockFile1", "MockFile2", "MockFile3" };
            return recorded;
        }
        #endregion

        #region IAsteriskServer 成员


        public IEnumerable<string> GetAllMusicFiles()
        {
            return new string[] { "dangerous.mp3", "地球之歌", "who is it.mp3" };
        }

        #endregion

        #region IAsteriskServer 成员


        public IEnumerable<string> GetAllCodecs()
        {
            return Codecs.Items;
        }

        #endregion

        #region IAsteriskServer 成员


        public VisualAsterisk.Core.Management.LinuxSystem GetSystemInformation()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAsteriskServer 成员


        public void ExecuteSystemCommand(string commandToExecute)
        {
            throw new NotImplementedException();
        }

        public List<string> GetSysInfoOutput(string file, bool trimEmptyLine)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAsteriskServer 成员


        public IList<string> GetAllBackupFiles()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAsteriskServer 成员


        public void RemoveBackupFile(string p)
        {
            throw new NotImplementedException();
        }

        public void CreateBackup()
        {
            throw new NotImplementedException();
        }

        public void RestoreConfig(string fileName)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAsteriskServer 成员


        public IEnumerable<Backup> Backups
        {
            get
            {
                List<Backup> backups = new List<Backup>();
                for (int i = 0; i < 10; i++)
                {
                    backups.Add(Backup.CreateNew("Dummy backup "+i.ToString()));
                }
                return backups;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IAsteriskServer 成员


        public void CreateBackup(string name)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAsteriskServer 成员


        public void Reload()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAsteriskServer 成员


        public void LoadCDR(string directory, bool reload)
        {
        }

        #endregion

        #region IAsteriskServer 成员


        public VisualAsterisk.Core.Management.LinuxSystem GetSystemInformation(bool refresh)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAsteriskServer 成员


        public int ExecuteCommandTimeout
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

        #endregion

        #region IAsteriskServer 成员


        public string GetConfigFile(string file)
        {
            Trace.WriteLine("GetConfigFile " + file);
            return configFileDir + "\\" + file;
        }

        public void UpdateConfigFile(string file)
        {
            Trace.WriteLine("updateconfigfile " + file);
        }

        #endregion

        #region IAsteriskServer 成员


        IList<string> IAsteriskServer.GetAllRecordedVoicePrompt()
        {
            List<string> files = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                files.Add("record_voice-" + (i + 1).ToString());
            }
            return files;
        }

        IList<string> IAsteriskServer.GetAllMusicFiles()
        {
            List<string> files = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                files.Add("music-" + (i + 1).ToString());
            }
            return files;
        }

        IList<string> IAsteriskServer.GetAllCodecs()
        {
            List<string> files = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                files.Add("codec-" + (i + 1).ToString());
            }
            return files;
        }

        public IList<string> GetAllAgiScripts()
        {
            List<string> files = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                files.Add("agi_script-" + (i + 1).ToString());
            }
            return files;
        }

        #endregion
    }
}
