using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using VisualAsterisk.Core.SSH;
using System.Reflection;

namespace VisualAsterisk.Test.UI.Main.Gui.Forms
{
    class InitialConfigInstaller : VisualAsterisk.Main.Gui.Forms.IConfigInstaller
    {
        private ISSHCommand sshCommand;
        private IScpCommand scpCommand;

        public ISSHCommand SshCommand
        {
            get { return sshCommand; }
            set { sshCommand = value; }
        }

        public IScpCommand ScpCommand
        {
            get { return scpCommand; }
            set { scpCommand = value; }
        }

        public void CheckInstalledConfigFiles()
        {
            Trace.WriteLine(MethodBase.GetCurrentMethod().Name);
            Thread.Sleep(3000);
        }

        public void TransmitInitialConfigFiles()
        {
            Trace.WriteLine(MethodBase.GetCurrentMethod().Name);
            Thread.Sleep(3000);
        }

        public void InstallConfigFiles()
        {
            Trace.WriteLine(MethodBase.GetCurrentMethod().Name);
            Thread.Sleep(3000);
        }

        #region IInitialConfigInstaller 成员

        public void CheckConnection(string host, string user, string password)
        {
            Trace.WriteLine(string.Format("{0}({1},{2},{3})", MethodBase.GetCurrentMethod().Name, host, user, password));
            if (password == "pass")
            {
                Thread.Sleep(3000);
            }
            else
            {
                throw new ArgumentException("Hello, this is a dummy failed message");
            }
        }

        #endregion

        #region IConfigInstaller 成员


        public void RestartAsterisk()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
