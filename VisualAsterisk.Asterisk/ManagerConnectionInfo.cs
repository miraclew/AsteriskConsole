using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    [Serializable]
    public class ManagerConnectionInfo
    {
        public ManagerConnectionInfo()
        {
        }

        public ManagerConnectionInfo(string host, string user, string password)
            : this(host, 5038, user, password)
        {
        }

        public ManagerConnectionInfo(string host, int port, string user, string password)
            : this(null,host,port,user,password)
        {
        }

        public ManagerConnectionInfo(string name, string host, int port, string user, string password)
        {
            this.name = name;
            this.host = host;
            this.port = port;
            this.user = user;
            this.password = password;
        }

        string host;
        int port;
        string user;
        string password;
        string name; // The Name of this connction info

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return host;
                }
                else
                    return name;
            }
            set { name = value; }
        }

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name={0},Host={1},Port={2},User={3},Password={4}", name, host, port, user, password);

            return sb.ToString();
        }
    }
}
