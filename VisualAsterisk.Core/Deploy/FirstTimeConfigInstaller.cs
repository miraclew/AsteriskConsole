using System;
using System.Collections.Generic;
using System.Text;
using Granados;
using System.IO;
using VisualAsterisk.Core.SSH;

namespace VisualAsterisk.Core.Deploy
{
    public class FirstTimeConfigInstaller : IConfigInstaller
    {
        private string osVersion;
        private string asteriskVersion;
        private string astConfigDir;
        private string astLibDir;
        private ISSHCommand sshCommandExecutor;
        private string[] scripts = new string[] { "editmisdn.sh", "editzap.sh", "graphs.sh", 
            "gui_sysinfo", "listfiles", "mastercsvexists","networking.sh"
        };
        private string localScriptDir = "scripts";
        private string host;
        private string toolsPath;

        public string ToolsPath
        {
            get { return toolsPath; }
            set { toolsPath = value; }
        }
        //private IAsteriskServer server;

        public FirstTimeConfigInstaller(string toolsFullFileName)
        {
            this.toolsPath = toolsFullFileName;
        }

        #region IConfigInstaller 成员

        public void Connect(string host, string user, string password)
        {
            this.host = host;
            if (sshCommandExecutor == null)
            {
                // create default executor
                sshCommandExecutor = new SSHCommand();
            }
            sshCommandExecutor.Connect(host, user, password);
        }

        public void Disconnect()
        {
            sshCommandExecutor.Close();
        }

        public void CheckPreInstallCondition()
        {
            Directory.CreateDirectory("tmp");
            osVersion = sshCommandExecutor.Execute("uname -a")[0];
            checkAsterisk();
        }

        private void checkAsterisk()
        {
            try
            {
                asteriskVersion = sshCommandExecutor.Execute("asterisk -V")[0];
            }
            catch (CommandNotFoundException ex)
            {
                throw new PreInstallConditionNotSatisfiedException("Asterisk not found in system", ex);
            }
        }

        public string GetOperatingSystemVersion()
        {
            return osVersion;
        }

        public string GetAsteriskVerison()
        {
            return asteriskVersion;
        }

        public void RestartAsterisk()
        {
            IList<string> result = sshCommandExecutor.Execute("asterisk");
            if (result.Count > 0 && result[0].Contains("Asterisk already running"))
            {
                sshCommandExecutor.Execute("asterisk -rx \"restart now\"");                
            }
        }

        //public void ConnectAsterisk(string managerUser, string secret)
        //{
        //    ManagerConnectionInfo info = new ManagerConnectionInfo(Host, managerUser, secret);
        //    server = new DefaultAsteriskServer(info);
        //    server.Initialize();
        //}

        public void Install()
        {
            //sshCommandExecutor.Execute("cd /usr/src");
            sshCommandExecutor.Copy(ToolsPath, "visualasterisk-tools.tar.gz", SCPCopyDirection.LocalToRemote);
            sshCommandExecutor.Execute("tar -zxvf visualasterisk-tools.tar.gz");
            sshCommandExecutor.Execute("cd visualasterisk-tools");
            sshCommandExecutor.Execute("./configure");
            sshCommandExecutor.Execute("make install");
        }

        //public void UpdateExtensionsDotConf()
        //{
        //    string context = "visualasterisk_tools";
        //    UpdateConfigAction remove = new UpdateConfigAction("extensions.conf", "extensionss.conf");
        //    remove.AddCommand(UpdateConfigAction.ACTION_DELCAT, context);
        //    ManagerResponse response = server.SendAction(remove);
        //    if (!response.IsSuccess())
        //    {
        //        throw new ManagerOperationException(string.Format("Remove  visualasterisk_tools failed, {0}", response.Message));
        //    }

        //    UpdateConfigAction add = new UpdateConfigAction("extensions.conf", "extensionss.conf");
        //    add.Reload = "yes";
        //    add.AddCommand(UpdateConfigAction.ACTION_NEWCAT, context);
        //    add.AddCommand(UpdateConfigAction.ACTION_APPEND, context, "exten", "executecommand,1,System(${command})");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "executecommand,n,Hangup()");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "record_vmenu,1,Answer");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "record_vmenu,n,Playback(vm-intro)");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "record_vmenu,n,Record(${var1})");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "record_vmenu,n,Playback(vm-saved)");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "record_vmenu,n,Playback(vm-goodbye)");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "record_vmenu,n,Hangup");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "play_file,1,Answer");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "play_file,n,Playback(${var1})");
        //    add.AddCommand(UpdateConfigAction.ACTION_DELCAT, context, "exten", "exten = play_file,n,Hangup");

        //    response = server.SendAction(add);
        //    if (!response.IsSuccess())
        //    {
        //        throw new ManagerOperationException(string.Format("Add visualasterisk_tools failed, {0}", response.Message));
        //    }
        //}

        public VisualAsterisk.Core.SSH.ISSHCommand SshCommand
        {
            get
            {
                return sshCommandExecutor;
            }
            set
            {
                sshCommandExecutor = value;
            }
        }

        public void PreInstall()
        {
            throw new NotImplementedException();
        }

        public void PostInstall()
        {
            throw new NotImplementedException();
        }

        public void ConnectAsterisk(string managerUser, string secret)
        {
            throw new NotImplementedException();
        }

        public void UpdateExtensionsDotConf()
        {
            throw new NotImplementedException();
        }

        public void Connect(SSHConnectionInfo2 connectionInfo)
        {
            this.Connect(connectionInfo.Host, connectionInfo.User, connectionInfo.Password);
        }

        #endregion
    }
}
