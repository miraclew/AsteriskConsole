using System;
using System.Collections.Generic;
using System.Text;
using Sipek.Common;

namespace VisualAsterisk.Main.Controller
{
    class SipAccountConfig : IAccount
    {
        private string accoutName;
        private string displayName;
        private string domainName = "*";
        private string hostName;
        private string id;
        private int index = 0;
        private string password;
        private string proxyAddress = "";
        private int regState;
        private ETransportMode transportMode = ETransportMode.TM_UDP;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public ETransportMode TransportMode
        {
            get { return transportMode; }
            set { transportMode = value; }
        }

        public int RegState
        {
            get { return regState; }
            set { regState = value; }
        }

        public string ProxyAddress
        {
            get { return proxyAddress; }
            set { proxyAddress = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Id
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string HostName
        {
            get { return hostName; }
            set { hostName = value; }
        }
        public string AccountName
        {
            get
            {
                return accoutName;
            }
            set
            {
                accoutName = value;
            }
        }

        public string DisplayName
        {
            get
            {
                return displayName;
            }
            set
            {
                displayName = value;
            }
        }

        public string DomainName
        {
            get
            {
                return domainName;
                    
            }
            set
            {
                domainName = value;
            }
        }
    }
}
