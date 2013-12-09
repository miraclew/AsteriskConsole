using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Core.SSH;

namespace VisualAsterisk.Main
{
    [Serializable]
    public class AsteriskController
    {
        private ManagerConnectionInfo managerConnectionInfo;
        private SSHConnectionInfo2 sshConnectionInfo;
        private IAsteriskServer server;
        private bool connected;
        private bool toolInstalled;
        private string rootDataDirectory;

        public SSHConnectionInfo2 SshConnectionInfo
        {
            get { return sshConnectionInfo; }
            set { sshConnectionInfo = value; }
        }

        public bool ToolInstalled
        {
            get { return toolInstalled; }
            set { toolInstalled = value; }
        }

        [XmlIgnore]
        public string RootDataDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(rootDataDirectory) && managerConnectionInfo != null)
                {
                    rootDataDirectory = "data\\" + managerConnectionInfo.Name;
                }
                return rootDataDirectory;
            }
            set { rootDataDirectory = value; }
        }

        [XmlIgnore]
        public string CDRCsvDirectory
        {
            get { return RootDataDirectory + "\\cdr-csv"; }
        }

        public ManagerConnectionInfo ManagerConnectionInfo
        {
            get { return managerConnectionInfo; }
            set
            {
                managerConnectionInfo = value;
            }
        }

        [XmlIgnore]
        public IAsteriskServer Server
        {
            get { return server; }
            set { server = value; }
        }

        [XmlIgnore]
        public bool Connected
        {
            get { return connected; }
            set { connected = value; }
        }

        public void Disconnect()
        {
            if (connected && server != null)
            {
                server.Shutdown();
                connected = false;
            }
        }

        public void Connect(EventHandler<ConnectingProgressEventArg> eventHandler)
        {
            server = new DefaultAsteriskServer(managerConnectionInfo);
#if DEBUG
            server.ExecuteCommandTimeout = 10000;
#endif
            server.ConnectingProgressChanged += eventHandler;
            server.Initialize();
            connected = server.IsConnected();
        }

        public void Reload()
        {
            if (connected && server != null)
            {
                server.Reload();
            }
        }
    }
}
