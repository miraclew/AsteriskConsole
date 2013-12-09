using System;
using VisualAsterisk.Core.SSH;
namespace VisualAsterisk.Core.Deploy
{
    public interface IConfigInstaller
    {
        // SSH connection
        void Connect(string host, string user, string password);
        void Connect(SSHConnectionInfo2 connectionInfo);
        void Disconnect();

        /// <summary>
        /// Initial instller
        /// </summary>
        void CheckPreInstallCondition();
        void PreInstall();
        void Install();
        void PostInstall();

        void RestartAsterisk();
        string ToolsPath
        {
            get;
            set;
        }
        ISSHCommand SshCommand { get; set; }
    }
}
