using System;
using System.Collections.Generic;
using System.Text;
using Sipek.Common;

namespace SipPhone
{
    class AccountConfig : IAccount
    {
        #region IAccount Members

        public string AccountName
        {
            get
            {
                return "6001";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string DisplayName
        {
            get
            {
                return "SipCommunicator";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string DomainName
        {
            get
            {
                return "*";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string HostName
        {
            get
            {
                //return "sipserver.net";
                return "192.168.203.129";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string Id
        {
            get
            {
                return "6001";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public int Index
        {
            get
            {
                return 0;
            }
            set
            {
                ;
            }
        }

        public string Password
        {
            get
            {
                //return "mypass";
                return "6001";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string ProxyAddress
        {
            get
            {
                return "";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public int RegState
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                //throw new Exception("The method or operation is not implemented.");
            }
        }

        public ETransportMode TransportMode
        {
            get
            {
                return ETransportMode.TM_UDP;
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public string UserName
        {
            get
            {
                //return "myuser";
                return "6001";
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion
    }
}
