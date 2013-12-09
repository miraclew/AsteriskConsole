using System;
using System.Collections.Generic;
using Granados;
namespace VisualAsterisk.Core.SSH
{
    public interface ISSHCommand
    {
        void Close();
        void Connect(string host, string user, string password);
        IList<string> Execute(string cmd);
        /// <summary>
        /// Execut a command and redirect output to file
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        IList<string> ExecuteRedirect(string cmd);
        void Copy(string localFilePath, string remoteFileName, SCPCopyDirection direction);
    }
}
