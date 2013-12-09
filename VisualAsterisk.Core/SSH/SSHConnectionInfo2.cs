using System;
using System.Collections.Generic;
using System.Text;
using Granados;

namespace VisualAsterisk.Core.SSH
{
    [Serializable]
    public class SSHConnectionInfo2
    {
        private string host;
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Host
        {
            get { return host; }
            set { host = value; }
        }
    }
}
