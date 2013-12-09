using System;
using System.Collections.Generic;
using System.Text;
using Granados;
using System.Diagnostics;
using System.Threading;

namespace VisualAsterisk.Core.SSH
{
    public class DefaultSSHEventReciever : ISSHConnectionEventReceiver, ISSHChannelEventReceiver
    {
        private SSHConnection _conn;

        public SSHConnection Connection
        {
            get { return _conn; }
            set { _conn = value; }
        }
        private bool _ready;

        private AutoResetEvent promptReceivedEvent = new AutoResetEvent(false);
        private AutoResetEvent resultReceivedEvent = new AutoResetEvent(false);

        public void WaitPrompt()
        {
            promptReceivedEvent.WaitOne();
        }

        public void WaitResult()
        {
            resultReceivedEvent.WaitOne();
        }

        public List<string> result;

        private bool promptReceived;

        enum DataRecvState { Initial, WaitingPrompt, PromptReceived, WaitingResult, ResultReceived }
        private DataRecvState state = DataRecvState.Initial;

        private DataRecvState State
        {
            get { return state; }
            set
            {
                state = value;
                switch (state)
                {
                    case DataRecvState.Initial:
                        break;
                    case DataRecvState.WaitingPrompt:
                        break;
                    case DataRecvState.PromptReceived:
                        promptReceivedEvent.Set();
                        break;
                    case DataRecvState.WaitingResult:
                        break;
                    case DataRecvState.ResultReceived:
                        resultReceivedEvent.Set();
                        break;
                    default:
                        break;
                }
            }
        }

        public void OnData(byte[] data, int offset, int length)
        {
            System.Console.Write(Encoding.ASCII.GetString(data, offset, length));            
            string recvString = Encoding.ASCII.GetString(data, offset, length);

            if (State == DataRecvState.Initial)
            {
                if (recvString.EndsWith("\r\n"))
                {
                    State = DataRecvState.WaitingPrompt;
                }
            }
            else if (State == DataRecvState.WaitingPrompt)
            {
                if (isPrompt(recvString))
                {
                    State = DataRecvState.PromptReceived;
                }
            }
            else if (State == DataRecvState.PromptReceived)
            {
                if (recvString.EndsWith("\r\n"))
                {
                    State = DataRecvState.WaitingResult;
                    result = new List<string>();
                }
            }
            else if (State == DataRecvState.WaitingResult)
            {
                if (isPrompt(recvString))
                {
                    State = DataRecvState.ResultReceived;
                    State = DataRecvState.WaitingPrompt;
                    State = DataRecvState.PromptReceived;
                }
                else
                {
                    foreach (string item in recvString.Split('\n'))
                    {
                        if (item.Length == 0)
                        {
                            continue;
                        }
                        result.Add(item.Trim('\r'));
                    }
                    //if (recvString.EndsWith("\r\n"))
                    //{
                    //    State = DataRecvState.ResultReceived;
                    //    State = DataRecvState.WaitingPrompt;
                    //}
                }
            }

            //if (recvString.EndsWith('#') || recvString.EndsWith('$'))
            //{
            //    promptReceived = true;
            //    promptReceivedEvent.Set();
            //}
            //else
            //    return;


            //foreach (string item in temp)
            //{
            //    if (item.StartsWith("[") || item == string.Empty)
            //    {
            //        continue;
            //    }
            //    result.Add(item);
            //}

            //ResetEvent.Set();
        }

        private bool isPrompt(string value)
        {
            if (value.EndsWith("# ") || value.EndsWith("$ "))
            {
                return true;
            }
            else
                return false;
        }

        public void OnDebugMessage(bool always_display, byte[] data)
        {
            Debug.WriteLine("DEBUG: " + Encoding.ASCII.GetString(data));
        }
        public void OnIgnoreMessage(byte[] data)
        {
            Debug.WriteLine("Ignore: " + Encoding.ASCII.GetString(data));
        }
        public void OnAuthenticationPrompt(string[] msg)
        {
            Debug.WriteLine("Auth Prompt " + (msg.Length > 0 ? msg[0] : "(empty)"));
        }

        public void OnError(Exception error)
        {
            Debug.WriteLine("ERROR: " + error.Message);
            Debug.WriteLine(error.StackTrace);
        }
        public void OnChannelClosed()
        {
            Debug.WriteLine("Channel closed");
            //Connection.AsyncReceive(this);
        }
        public void OnChannelEOF()
        {
            _pf.Close();
            Debug.WriteLine("Channel EOF");
        }
        public void OnExtendedData(int type, byte[] data)
        {
            Debug.WriteLine("EXTENDED DATA");
        }
        public void OnConnectionClosed()
        {
            Debug.WriteLine("Connection closed");
        }
        public void OnUnknownMessage(byte type, byte[] data)
        {
            Debug.WriteLine("Unknown Message " + type);
        }
        public void OnChannelReady()
        {
            Debug.WriteLine("Channel Ready ");
            _ready = true;
        }
        public void OnChannelError(Exception error)
        {
            Debug.WriteLine("Channel ERROR: " + error.Message);
        }
        public void OnMiscPacket(byte type, byte[] data, int offset, int length)
        {
        }

        public PortForwardingCheckResult CheckPortForwardingRequest(string host, int port, string originator_host, int originator_port)
        {
            PortForwardingCheckResult r = new PortForwardingCheckResult();
            r.allowed = true;
            r.channel = this;
            return r;
        }
        public void EstablishPortforwarding(ISSHChannelEventReceiver rec, SSHChannel channel)
        {
            _pf = channel;
        }

        public SSHChannel _pf;
    }
}
