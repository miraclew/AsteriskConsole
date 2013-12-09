using System;
using System.Collections.Generic;
using System.Text;
using Granados;
using System.Net.Sockets;
using System.Net;
using Granados.PKI;
using Granados.SSH2;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace VisualAsterisk.Core.SSH
{
    public class SSHCommand : ISSHCommand
    {
        private static SSHConnection _conn;
        private DefaultSSHEventReciever reader = new DefaultSSHEventReciever(); //simple event receiver
        private SSHChannel channel;
        private ScpCommand scp = new ScpCommand();

        public void Connect(string host, string user, string password)
        {
            SSHConnectionParameter f = new SSHConnectionParameter();
            f.EventTracer = new DefaultSSHEventTracer(); //to receive detailed events, set ISSHEventTracer
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            f.Protocol = SSHProtocol.SSH2; //this sample works on both SSH1 and SSH2
            f.UserName = user;               //<--!!! if you try this sample, edit these values for your environment!
            s.Connect(new IPEndPoint(IPAddress.Parse(host), 22)); //22 is the default SSH port

            //former algorithm is given priority in the algorithm negotiation
            f.PreferableHostKeyAlgorithms = new PublicKeyAlgorithm[] { PublicKeyAlgorithm.RSA, PublicKeyAlgorithm.DSA };
            f.PreferableCipherAlgorithms = new CipherAlgorithm[] { CipherAlgorithm.Blowfish, CipherAlgorithm.TripleDES };
            f.WindowSize = 0x1000; //this option is ignored with SSH1
            f.TerminalName = "";

            AuthenticationType at = AuthenticationType.Password;
            f.AuthenticationType = at;

            f.Password = password;
            f.KeyCheck = delegate(SSHConnectionInfo info)
            {
                byte[] h = info.HostKeyMD5FingerPrint();
                foreach (byte b in h) Debug.Write(String.Format("{0:x2} ", b));
                return true;
            };

            //Creating a new SSH connection over the underlying socket
            _conn = SSHConnection.Connect(f, reader, s);
            reader.Connection = _conn;

            //Opening a shell
            channel = _conn.OpenShell(reader);
            reader._pf = channel;
            //you can get the detailed connection information in this way:
            SSHConnectionInfo ci = _conn.ConnectionInfo;

            //byte[] data = (new ASCIIEncoding()).GetBytes(cmd + "ls\n");
            //foreach (byte item in data)
            //{
            //    byte b = new byte[1];
            //    b[0] = item;
            //    reader._pf.Transmit(b);                
            //}
            scp.Connect(host, user, password);
        }
        public void Close()
        {
            scp.Close();
            _conn.Disconnect("");
        }

        private static void SampleShell(DefaultSSHEventReciever reader)
        {
            byte[] b = new byte[1];
            while (true)
            {
                int input = System.Console.Read();

                b[0] = (byte)input;
                reader._pf.Transmit(b);
            }
        }


        #region ISSHCommand 成员


        public IList<string> Execute(string cmd)
        {
            return executeCore(cmd);
        }

        /// <summary>
        /// Execute a command 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        private IList<string> executeCore(string cmd)
        {
            reader.WaitPrompt();
            //Go to sample shell
            byte[] data = (new ASCIIEncoding()).GetBytes(cmd + "\n");

            reader._pf.Transmit(data);
            reader.WaitResult();
            if (reader.result.Count > 0 && reader.result[0].Contains("command not found"))
            {
                throw new CommandNotFoundException(cmd + ": command not found");
            }
            return reader.result;
        }

        private IList<string> readOutputFile(string file)
        {
            List<string> result = new List<string>(); 
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        result.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the User know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                throw;
            }
            return result;
        }

        public IList<string> ExecuteRedirect(string cmd)
        {
            string tmp = ".ssh_command_output." + DateTime.Now.Ticks.ToString();
            executeCore(cmd + " > " + tmp);
            scp.Copy(tmp, tmp, SCPCopyDirection.RemoteToLocal);
            executeCore("rm -f " + tmp);
            return readOutputFile(tmp);
        }

        public void Copy(string localFilePath, string remoteFileName, SCPCopyDirection direction)
        {
            scp.Copy(localFilePath, remoteFileName, direction);
        }

        #endregion
    }
}
