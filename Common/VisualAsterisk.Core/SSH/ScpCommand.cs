using System;
using System.Collections.Generic;
using System.Text;
using Granados;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace VisualAsterisk.Core.SSH
{
    public class ScpCommand
    {
        private SSHConnection conn;
        private string host,user,password;

        public void Connect(string host, string user, string password)
        {
            this.host = host;
            this.user = user;
            this.password = password;

            SSHConnectionParameter f = new SSHConnectionParameter();
            f.EventTracer = new DefaultSSHEventTracer(); //to receive detailed events, set ISSHEventTracer
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            f.Protocol = SSHProtocol.SSH2;
            f.UserName = user;          //<--!!! if you try this sample, edit these values for your environment!
            f.Password = password;              //<--!!! 
            f.AuthenticationType = AuthenticationType.Password;
            s.Connect(new IPEndPoint(IPAddress.Parse(host), 22)); //22 is the default SSH port

            conn = SSHConnection.Connect(f, new DefaultSSHEventReciever(), s);
            conn.AutoDisconnect = false; //auto close is disabled for multiple scp operations
        }

        public void Close()
        {
            conn.Disconnect("");
        }

        public void Copy(string localFilePath, string remoteFileName, SCPCopyDirection direction)
        {
            ScpParameter scp_param = new ScpParameter();
            scp_param.Direction = direction; //  SCPCopyDirection.LocalToRemote;
            scp_param.RemoteFilename = remoteFileName;
            //scp_param.Directory = true;
            scp_param.LocalSource = new ScpLocalSource(localFilePath);

            try
            {
                conn.ExecuteSCP(scp_param);
            }
            catch (SSHException sshEx)
            {
                if (sshEx.Message.Contains("No such file or directory"))
                {
                    throw new NoSuchRemoteFileOrDirectoryException("No such file or directory " + remoteFileName, sshEx);
                }
                else
                    throw;                
            }
            catch (SocketException ex)
            {
                reconnect();
                conn.ExecuteSCP(scp_param);
            }
        }

        private void reconnect()
        {
            Connect(host, user, password);
        }

        //public static void Copy(string src, string dest, SCPCopyDirection direction)
        //{
        //    ScpParameter scp_param = new ScpParameter();
        //    scp_param.Direction = direction; //  SCPCopyDirection.LocalToRemote;
        //    scp_param.RemoteFilename = @"/root/MyListener.log";
        //    //scp_param.Directory = true;
        //    scp_param.LocalSource = new ScpLocalSource("C:\\MyListener.log");
            
        //    string host_ip= "192.168.88.129";
        //    string username = "root";
        //    string Password = "Ideal12";

        //    SSHConnectionParameter f = new SSHConnectionParameter();
        //    f.EventTracer = new DefaultSSHEventTracer(); //to receive detailed events, set ISSHEventTracer
        //    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //    f.Protocol = SSHProtocol.SSH2;
        //    f.UserName = username;          //<--!!! if you try this sample, edit these values for your environment!
        //    f.Password = Password;              //<--!!! 
        //    f.AuthenticationType = AuthenticationType.Password;
        //    s.Connect(new IPEndPoint(IPAddress.Parse(host_ip), 22)); //22 is the default SSH port

        //    SSHConnection conn = SSHConnection.Connect(f, new DefaultSSHEventReciever(), s);
        //    conn.AutoDisconnect = false; //auto close is disabled for multiple scp operations
        //    conn.ExecuteSCP(scp_param);

        //    conn.Disconnect("");
        //}
    }

}
