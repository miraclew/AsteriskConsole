using System;
using System.Collections.Generic;
using System.Text;
using Sipek.Common;
using Sipek.Sip;
using Sipek.Common.CallControl;
using System.Timers;
using System.Media;

namespace SipPhone
{
    /// <summary>
    /// ConcreteFactory 
    /// Implementation of AbstractFactory. 
    /// </summary>
    public class SipekResources : AbstractFactory
    {
        PhoneForm _form; // reference to PhoneForm to provide timer context
        IMediaProxyInterface _mediaProxy = new CMediaPlayerProxy();
        ICallLogInterface _callLogger = new CallLog();
        pjsipStackProxy _stackProxy = pjsipStackProxy.Instance;
        SipekConfigurator _config = new SipekConfigurator();

        #region Constructor
        public SipekResources(PhoneForm mf)
        {
            _form = mf;

            // initialize sip struct at startup
            SipConfigStruct.Instance.stunServer = this.Configurator.StunServerAddress;
            SipConfigStruct.Instance.publishEnabled = this.Configurator.PublishEnabled;
            SipConfigStruct.Instance.expires = this.Configurator.Expires;
            SipConfigStruct.Instance.VADEnabled = this.Configurator.VADEnabled;
            SipConfigStruct.Instance.ECTail = this.Configurator.ECTail;
            SipConfigStruct.Instance.nameServer = this.Configurator.NameServer;

            // initialize modules
            _callManager.StackProxy = _stackProxy;
            _callManager.Config = _config;
            _callManager.Factory = this;
            _callManager.MediaProxy = _mediaProxy;
            _stackProxy.Config = _config;
            _registrar.Config = _config;
            _messenger.Config = _config;

            //// do not save account state
            //for (int i = 0; i < 5; i++)
            //{
            //    Properties.Settings.Default.SipAccountState[i] = "0";
            //    Properties.Settings.Default.SipAccountIndex[i] = "0";
            //}
        }
        #endregion Constructor

        #region AbstractFactory methods
        public ITimer createTimer()
        {
            return new GUITimer(_form);
        }

        public IStateMachine createStateMachine()
        {
            // TODO: check max number of calls
            return new CStateMachine();
        }

        #endregion

        #region Other Resources
        public pjsipStackProxy StackProxy
        {
            get { return _stackProxy; }
            set { _stackProxy = value; }
        }

        public SipekConfigurator Configurator
        {
            get { return _config; }
            set { }
        }

        // getters
        public IMediaProxyInterface MediaProxy
        {
            get { return _mediaProxy; }
            set { }
        }

        public ICallLogInterface CallLogger
        {
            get { return _callLogger; }
            set { }
        }

        private IRegistrar _registrar = pjsipRegistrar.Instance;
        public IRegistrar Registrar
        {
            get { return _registrar; }
        }

        private IPresenceAndMessaging _messenger = pjsipPresenceAndMessaging.Instance;
        public IPresenceAndMessaging Messenger
        {
            get { return _messenger; }
        }

        private CCallManager _callManager = CCallManager.Instance;
        public CCallManager CallManager
        {
            get { return CCallManager.Instance; }
        }
        #endregion
    }

    #region Concrete implementations

    public class GUITimer : ITimer
    {
        Timer _guiTimer;
        PhoneForm _form;


        public GUITimer(PhoneForm mf)
        {
            _form = mf;
            _guiTimer = new Timer();
            if (this.Interval > 0) _guiTimer.Interval = this.Interval;
            _guiTimer.Interval = 100;
            _guiTimer.Enabled = true;
            _guiTimer.Elapsed += new ElapsedEventHandler(_guiTimer_Tick);
        }

        void _guiTimer_Tick(object sender, EventArgs e)
        {
            _guiTimer.Stop();
            //_elapsed(sender, e);
            // Synchronize thread with GUI because SIP stack works with GUI thread only
            if ((_form.IsDisposed) || (_form.Disposing) || (!_form.IsInitialized))
            {
                return;
            }
            _form.Invoke(_elapsed, new object[] { sender, e });
        }

        public bool Start()
        {
            _guiTimer.Start();
            return true;
        }

        public bool Stop()
        {
            _guiTimer.Stop();
            return true;
        }

        private int _interval;
        public int Interval
        {
            get { return _interval; }
            set { _interval = value; _guiTimer.Interval = value; }
        }

        private TimerExpiredCallback _elapsed;
        public TimerExpiredCallback Elapsed
        {
            set
            {
                _elapsed = value;
            }
        }
    }


    // Accounts
    public class SipekAccount : IAccount
    {
        private int _index = -1;
        private int _accountIdentification = -1;

        /// <summary>
        /// Temp storage!
        /// The account index assigned by voip stack
        /// </summary>
        public int Index
        {
            get
            {
                int value;
                if (Int32.TryParse(Properties.Settings.Default.SipAccountIndex[_index], out value))
                {
                    return value;
                }
                return -1;
            }
            set { Properties.Settings.Default.SipAccountIndex[_index] = value.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">the account identification used by configuration (values 0..4)</param>
        public SipekAccount(int index)
        {
            _index = index;
        }

        #region Properties

        public string AccountName
        {
            get
            {
                return Properties.Settings.Default.SipAccountNames[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountNames[_index] = value;
            }
        }

        public string HostName
        {
            get
            {
                return Properties.Settings.Default.SipAccountAddresses[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountAddresses[_index] = value;
            }
        }

        public string Id
        {
            get
            {
                return Properties.Settings.Default.SipAccountIds[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountIds[_index] = value;
            }
        }

        public string UserName
        {
            get
            {
                return Properties.Settings.Default.SipAccountUsername[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountUsername[_index] = value;
            }
        }

        public string Password
        {
            get
            {
                return Properties.Settings.Default.SipAccountPassword[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountPassword[_index] = value;
            }
        }

        public string DisplayName
        {
            get
            {
                return Properties.Settings.Default.SipAccountDisplayName[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountDisplayName[_index] = value;
            }
        }

        public string DomainName
        {
            get
            {
                return Properties.Settings.Default.SipAccountDomains[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountDomains[_index] = value;
            }
        }

        public int RegState
        {
            get
            {
                int value;
                if (Int32.TryParse(Properties.Settings.Default.SipAccountState[_index], out value))
                {
                    return value;
                }
                return 0;
            }
            set
            {
                Properties.Settings.Default.SipAccountState[_index] = value.ToString();
            }
        }

        public string ProxyAddress
        {
            get
            {
                return Properties.Settings.Default.SipAccountProxyAddresses[_index];
            }
            set
            {
                Properties.Settings.Default.SipAccountProxyAddresses[_index] = value;
            }
        }

        public ETransportMode TransportMode
        {
            get
            {
                int value;
                if (Int32.TryParse(Properties.Settings.Default.SipAccountTransport[_index], out value))
                {
                    return (ETransportMode)value;
                }
                return (ETransportMode.TM_UDP); // default
            }
            set
            {
                Properties.Settings.Default.SipAccountTransport[_index] = ((int)value).ToString();
            }
        }
        #endregion

    }

    /// <summary>
    /// 
    /// </summary>
    public class SipekConfigurator : IConfiguratorInterface
    {
        List<IAccount> accList;

        public bool IsNull { get { return false; } }

        public bool CFUFlag
        {
            get { return Properties.Settings.Default.CFUFlag; }
            set { Properties.Settings.Default.CFUFlag = value; }
        }
        public string CFUNumber
        {
            get { return Properties.Settings.Default.CFUNumber; }
            set { Properties.Settings.Default.CFUNumber = value; }
        }
        public bool CFNRFlag
        {
            get { return Properties.Settings.Default.CFNRFlag; }
            set { Properties.Settings.Default.CFNRFlag = value; }
        }
        public string CFNRNumber
        {
            get { return Properties.Settings.Default.CFNRNumber; }
            set { Properties.Settings.Default.CFNRNumber = value; }
        }
        public bool DNDFlag
        {
            get { return Properties.Settings.Default.DNDFlag; }
            set { Properties.Settings.Default.DNDFlag = value; }
        }
        public bool AAFlag
        {
            get { return Properties.Settings.Default.AAFlag; }
            set { Properties.Settings.Default.AAFlag = value; }
        }

        public bool CFBFlag
        {
            get { return Properties.Settings.Default.CFBFlag; }
            set { Properties.Settings.Default.CFBFlag = value; }
        }

        public string CFBNumber
        {
            get { return Properties.Settings.Default.CFBNumber; }
            set { Properties.Settings.Default.CFBNumber = value; }
        }

        public int SIPPort
        {
            get { return Properties.Settings.Default.SipPort; }
            set { Properties.Settings.Default.SipPort = value; }
        }

        public bool PublishEnabled
        {
            get
            {
                SipConfigStruct.Instance.publishEnabled = Properties.Settings.Default.SipPublishEnabled;
                return Properties.Settings.Default.SipPublishEnabled;
            }
            set
            {
                SipConfigStruct.Instance.publishEnabled = value;
                Properties.Settings.Default.SipPublishEnabled = value;
            }
        }

        public string StunServerAddress
        {
            get
            {
                SipConfigStruct.Instance.stunServer = Properties.Settings.Default.StunServerAddress;
                return Properties.Settings.Default.StunServerAddress;
            }
            set
            {
                Properties.Settings.Default.StunServerAddress = value;
                SipConfigStruct.Instance.stunServer = value;
            }
        }

        public EDtmfMode DtmfMode
        {
            get
            {
                return (EDtmfMode)Properties.Settings.Default.DtmfMode;
            }
            set
            {
                Properties.Settings.Default.DtmfMode = (int)value;
            }
        }

        public int Expires
        {
            get
            {
                SipConfigStruct.Instance.expires = Properties.Settings.Default.RegistrationTimeout;
                return Properties.Settings.Default.RegistrationTimeout;
            }
            set
            {
                Properties.Settings.Default.RegistrationTimeout = value;
                SipConfigStruct.Instance.expires = value;
            }
        }

        public int ECTail
        {
            get
            {
                SipConfigStruct.Instance.ECTail = Properties.Settings.Default.ECTail;
                return Properties.Settings.Default.ECTail;
            }
            set
            {
                Properties.Settings.Default.ECTail = value;
                SipConfigStruct.Instance.ECTail = value;
            }
        }

        public bool VADEnabled
        {
            get
            {
                SipConfigStruct.Instance.VADEnabled = Properties.Settings.Default.VAD;
                return Properties.Settings.Default.VAD;
            }
            set
            {
                Properties.Settings.Default.VAD = value;
                SipConfigStruct.Instance.VADEnabled = value;
            }
        }


        public string NameServer
        {
            get
            {
                SipConfigStruct.Instance.nameServer = Properties.Settings.Default.NameServer;
                return Properties.Settings.Default.NameServer;
            }
            set
            {
                Properties.Settings.Default.NameServer = value;
                SipConfigStruct.Instance.nameServer = value;
            }
        }

        /// <summary>
        /// The position of default account in account list. Does NOT mean same as DefaultAccountIndex
        /// </summary>
        public int DefaultAccountIndex
        {
            get
            {
                return Properties.Settings.Default.SipAccountDefault;
            }
            set
            {
                Properties.Settings.Default.SipAccountDefault = value;
            }
        }

        public List<IAccount> Accounts
        {
            get
            {
                //List<IAccount> accList = new List<IAccount>();

                //accList.Add(new AccountConfig());

                //for (int i = 0; i < 5; i++)
                //{
                //    IAccount item = new SipekAccount(i);
                //    accList.Add(item);
                //}
                return accList;

            }
            set
            {
                accList = value;
            }
        }

        public void Save()
        {
            // save properties
            Properties.Settings.Default.Save();
        }

        public List<string> CodecList
        {
            get
            {
                List<string> codecList = new List<string>();
                foreach (string item in Properties.Settings.Default.CodecList)
                {
                    codecList.Add(item);
                }
                return codecList;
            }
            set
            {
                Properties.Settings.Default.CodecList.Clear();
                List<string> cl = value;
                foreach (string item in cl)
                {
                    Properties.Settings.Default.CodecList.Add(item);
                }
            }
        }
    }


    //////////////////////////////////////////////////////
    // Media proxy
    // internal class
    public class CMediaPlayerProxy : IMediaProxyInterface
    {
        SoundPlayer player = new SoundPlayer();

        #region Methods

        public int playTone(ETones toneId)
        {
            string fname;

            switch (toneId)
            {
                case ETones.EToneDial:
                    fname = "Sounds/dial.wav";
                    player.Stream = Properties.Resources.dial;
                    break;
                case ETones.EToneCongestion:
                    fname = "Sounds/congestion.wav";
                    player.Stream = Properties.Resources.congestion;
                    break;
                case ETones.EToneRingback:
                    fname = "Sounds/ringback.wav";
                    player.Stream = Properties.Resources.ringback;
                    break;
                case ETones.EToneRing:
                    fname = "Sounds/ring.wav";
                    player.Stream = Properties.Resources.ring;
                    break;
                default:
                    fname = "";
                    break;
            }
            //player.SoundLocation = fname;
            player.Load();
            player.PlayLooping();

            return 1;
        }

        public int stopTone()
        {
            player.Stop();
            return 1;
        }

        #endregion

    }

    #endregion Concrete Implementations
}
