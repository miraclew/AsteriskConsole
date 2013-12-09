using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Represents an Asterisk Peer, sip or iax
    /// </summary>
    public class AsteriskPeer : AsteriskObject
    {
        public const string PROPERTY_STATUS = "Status";
        public const string PROPERTY_CHANNEL = "Channel";
        // basic propety PeerEntry
        private string channelType;
        private string objectName;
        private string chanObjectType;
        private string ipAddress;
        private int ipPort;
        private bool dynamic;
        private bool natSupport;
        private bool videoSupport;
        private bool textSupport;
        private bool acl;
        private string status;
        private bool realtimedevice;

        // advanced 
        private bool SecretExist;
        private bool MD5SecretExist;
        private string Context;
        private string Language;
        private string AMAflags;
        private string CID_CallingPres;
        private string Callgroup;
        private string Pickupgroup;
        private string VoiceMailbox;
        private string TransferMode;
        private string LastMsgsSent;
        private string Call_limit;
        private string MaxCallBR;
        private string Callerid;
        private string RegExpire;
        private string SIP_AuthInsecure;
        private string SIP_NatSupport;
        private string SIP_CanReinvite;
        private string SIP_PromiscRedir;
        private string SIP_VideoSupport;
        private string SIP_DTMFmode;
        private string SIPLastMsg;
        private string SIP_ToHost;
        //private string Address_IP;
        //private string Address_Port;
        private string Default_addr_IP;
        private string Default_addr_port;
        private string Default_Username;
        private string Codecs;
        private string SIP_CodecOrder;
        //private string Status;
        private string SIP_Useragent;
        private string Reg_Contact;


        #region property
        /// <summary>
        /// For SIP peers this is "SIP".
        /// </summary>
        public string ChannelType
        {
            get { return this.channelType; }
            set { this.channelType = value; }
        }

        public string ObjectName
        {
            get { return this.objectName; }
            set { this.objectName = value; }
        }
        /// <summary>
        /// For SIP peers this is either "Peer" or "User".
        /// </summary>
        public string ChanObjectType
        {
            get { return this.chanObjectType; }
            set { this.chanObjectType = value; }
        }
        /// <summary>
        /// Get/Set the IP address of the Peer.
        /// </summary>
        public string IpAddress
        {
            get { return this.ipAddress; }
            set { this.ipAddress = value; }
        }
        public int IpPort
        {
            get { return this.ipPort; }
            set { this.ipPort = value; }
        }
        public bool Dynamic
        {
            get { return this.dynamic; }
            set { this.dynamic = value; }
        }
        public bool NatSupport
        {
            get { return this.natSupport; }
            set { this.natSupport = value; }
        }
        public bool VideoSupport
        {
            get { return this.videoSupport; }
            set { this.videoSupport = value; }
        }
        public bool TextSupport
        {
            get { return this.textSupport; }
            set { this.textSupport = value; }
        }
        public bool Acl
        {
            get { return this.acl; }
            set { this.acl = value; }
        }
        /// <summary>
        /// Get/Set the status of this Peer.<br/>
        /// For SIP peers this is one of:
        /// <dl>
        /// <dt>"UNREACHABLE"</dt>
        /// <dd></dd>
        /// <dt>"LAGGED (%d ms)"</dt>
        /// <dd></dd>
        /// <dt>"OK (%d ms)"</dt>
        /// <dd></dd>
        /// <dt>"UNKNOWN"</dt>
        /// <dd></dd>
        /// <dt>"Unmonitored"</dt>
        /// <dd></dd>
        /// </dl>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public bool RealtimeDevice
        {
            get { return this.realtimedevice; }
            set { this.realtimedevice = value; }
        }


        #endregion

        AsteriskChannel channel;

        public AsteriskChannel Channel
        {
            get { return channel; }
            set {
                object oldChannel = channel;
                channel = value;
                firePropertyChange(PROPERTY_CHANNEL, oldChannel, channel); 
            }
        }

        string name;

        public string Name
        {
            get {
                name = string.Format("{0}/{1}", channelType, objectName);
                return name; 
            }
            set { name = value; }
        }

        public AsteriskPeer(DefaultAsteriskServer server)
            :base(server)
        {

        }

        internal void updateState(string newState)
        {
            lock (asteriskObjectLock)
            {
                string oldState = this.status;
                this.status = newState;
                firePropertyChange(PROPERTY_STATUS, oldState, this.status);
            }
        }
    }
}
