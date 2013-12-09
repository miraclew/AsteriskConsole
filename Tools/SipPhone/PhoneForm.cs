using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common;
using Sipek.Common.CallControl;
using WaveLib.AudioMixer;

namespace SipPhone
{
    public partial class PhoneForm : Form
    {
        #region Properties
        private const string ReadyForCall = "Ready for Call";

        private Timer tmr = new Timer();  // Refresh Call List
        private EUserStatus _lastUserStatus = EUserStatus.AVAILABLE;
        private string HEADER_TEXT;

        private SipekResources _resources = null;
        private SipekResources SipekResources
        {
            get { return _resources; }
        }

        public bool IsInitialized
        {
            get { return SipekResources.StackProxy.IsInitialized; }
        }

        #endregion

        public PhoneForm(List<IAccount> accounts)
            :this()
        {
            this.sipUsersBindingSource.DataSource = accounts;
        }

        public PhoneForm()
        {
            InitializeComponent();

            numberPad1.NumberKeyPressed += new EventHandler<IC.Controls.NumberPadEventArgs>(numberPad1_NumberKeyPressed);
            // Create resource object containing SipekSdk and other Sipek related data
            _resources = new SipekResources(this);
        }

        void numberPad1_NumberKeyPressed(object sender, IC.Controls.NumberPadEventArgs e)
        {
            if (_call != null && _call.StateId == EStateId.ACTIVE)
            {
                SipekResources.CallManager.onUserDialDigit(_call.Session, e.NumberKey ,SipekResources.Configurator.DtmfMode);
            }
            numberLabel.Text += e.NumberKey;
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            LoadAudioValues();

            SipekResources.CallManager.CallStateRefresh += CallManager_CallStateRefresh;
            SipekResources.CallManager.IncomingCallNotification += new DIncomingCallNotification(CallManager_IncomingCallNotification);
            SipekResources.Registrar.AccountStateChanged += new DAccountStateChanged(Registrar_AccountStateChanged);
            // Initialize and set factory for CallManager

            int status = SipekResources.CallManager.Initialize();
            SipekResources.CallManager.CallLogger = SipekResources.CallLogger;

            if (status != 0)
            {
                MessageBox.Show("Initialize Error", "Init SIP stack problem! \r\nPlease, check configuration and start again! \r\nStatus code " + status);
                return;
            }

            // set codecs priority...
            // initialize/reset codecs - enable PCMU and PCMA only
            int noOfCodecs = SipekResources.StackProxy.getNoOfCodecs();
            for (int i = 0; i < noOfCodecs; i++)
            {
                string codecname = SipekResources.StackProxy.getCodec(i);
                if (SipekResources.Configurator.CodecList.Contains(codecname))
                {
                    // leave default
                    SipekResources.StackProxy.setCodecPriority(codecname, 128);
                }
                else
                {
                    // disable
                    SipekResources.StackProxy.setCodecPriority(codecname, 0);
                }
            }

            if (this.sipUsersBindingSource.Count > 0)
            {
                this.sipUsersComboBox.SelectedIndex = 0;
                setCurrentSipAccout();
            }

        }

        void Registrar_AccountStateChanged(int accountId, int accState)
        {

            if (InvokeRequired)
                this.BeginInvoke(new DAccountStateChanged(OnRegistrationUpdate), new object[] { accountId, accState });
            else
                OnRegistrationUpdate(accountId, accState);
        }

        delegate void DIncomingCall(int sessionId, string number, string info);

        void CallManager_IncomingCallNotification(int sessionId, string number, string info)
        {
            if (InvokeRequired)
                this.BeginInvoke(new DIncomingCall(this.OnIncomingCall), new object[] { sessionId, number, info });
            else
                OnIncomingCall(sessionId, number, info);
        }

        void CallManager_CallStateRefresh(int sessionId)
        {
            if (InvokeRequired)
                this.BeginInvoke(new DCallStateRefresh(OnStateUpdate), new object[] { sessionId });
            else
                OnStateUpdate(sessionId);
        }

        #region Synhronized callbacks
        private void OnRegistrationUpdate(int accountId, int accState)
        {
            if (accState == 200)
            {
                callStatusLabel.Text = ReadyForCall;
            }
        }

        private void OnStateUpdate(int sessionId)
        {
            if (SipekResources.CallManager.getCall(sessionId).StateId == EStateId.NULL)
            {
                callStatusLabel.Text = ReadyForCall;
            }
            else
                callStatusLabel.Text = SipekResources.CallManager.getCall(sessionId).StateId.ToString();
        }

        private void OnIncomingCall(int sessionId, string number, string info)
        {
            this.BringToFront();
            IncommingCallForm form = new IncommingCallForm(number, 15000);
            DialogResult result = form.ShowDialog();
            //DialogResult result = MessageBox.Show("Incoming call from " + number + "!" + "\n\nAnswer the call?", "Sip Phone", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _call = SipekResources.CallManager.getCall(sessionId);
                numberLabel.Text = number;
                SipekResources.CallManager.onUserAnswer(sessionId);
            }
            else
            {
                SipekResources.CallManager.onUserRelease(sessionId);
            }
        }

        #endregion

        private IStateMachine _call = null;

        private void callButton_Click(object sender, EventArgs e)
        {
            _call = SipekResources.CallManager.createOutboundCall(numberLabel.Text);
        }

        private void hangupButton_Click(object sender, EventArgs e)
        {
            numberLabel.Text = string.Empty;
            if (_call == null)
            {
                return;
            }
            SipekResources.CallManager.onUserRelease(_call.Session);
        }

        private void PhoneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutdownVoIP();
        }

        private void ShutdownVoIP()
        {
            if (IsInitialized)
            {
                SipekResources.CallLogger.save();
            }
            SipekResources.Configurator.Save();

            // shutdown stack
            SipekResources.CallManager.Shutdown();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (SipekResources.Configurator.Accounts.Count <= 0)
            {
                return;
            }

            if (registerButton.Text == "Unregister")
            {
                int status = SipekResources.Registrar.unregisterAccounts();
                if (status == 0)
                {
                    registerButton.Text = "Register";
                    callStatusLabel.Text = string.Empty;
                }
            }
            else
            {
                int status = SipekResources.Registrar.registerAccounts();
                if (status == 1)
                {
                    registerButton.Text = "Unregister";
                }
            }
        }

        private void numberPad1_Load(object sender, EventArgs e)
        {

        }

        private void sipUsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setCurrentSipAccout();
        }

        private void setCurrentSipAccout()
        {
            IAccount account = sipUsersBindingSource.Current as IAccount;
            if (account == null)
            {
                return;
            }
            List<IAccount> accList = new List<IAccount>();
            accList.Add(account);
            SipekResources.Configurator.Accounts = accList;

            // update UI
            if (account.RegState == 200)
            {
                registerButton.Text = "Unregister";
                callStatusLabel.Text = ReadyForCall;
            }
            else
            {
                registerButton.Text = "Register";
                callStatusLabel.Text = string.Empty;
            }
            accountLabel.Text = account.DisplayName + " " + account.UserName;
        }

        private void sipUsersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            setCurrentSipAccout();
        }


        #region Audio control
        
        private Mixers mMixers;
        private bool mAvoidEvents = false;

        private void LoadAudioValues()
        {
            try
            {
                mMixers = new Mixers();
            }
            catch (Exception e)
            {
                ///report error
                MessageBox.Show("Initialize Error " + e.Message, "Audio Mixer cannot initialize! \r\nCheck audio configuration and start again!");
                return;
            }
            // set callback
            mMixers.Playback.MixerLineChanged += new WaveLib.AudioMixer.Mixer.MixerLineChangeHandler(mMixer_MixerLineChanged);
            mMixers.Recording.MixerLineChanged += new WaveLib.AudioMixer.Mixer.MixerLineChangeHandler(mMixer_MixerLineChanged);

            MixerLine pbline = mMixers.Playback.UserLines.GetMixerFirstLineByComponentType(MIXERLINE_COMPONENTTYPE.SRC_WAVEOUT);

            this.volumeTrackBar.Tag = pbline;
            this.muteButton.Tag = pbline;
            MixerLine recline = mMixers.Recording.UserLines.GetMixerFirstLineByComponentType(MIXERLINE_COMPONENTTYPE.SRC_MICROPHONE); ;
            micMuteButton.Tag = recline;

            //If it is 2 channels then ask both and set the volume to the bigger but keep relation between them (Balance)
            int volume = 0;
            float balance = 0;
            if (pbline.Channels != 2)
                volume = pbline.Volume;
            else
            {
                pbline.Channel = Channel.Left;
                int left = pbline.Volume;
                pbline.Channel = Channel.Right;
                int right = pbline.Volume;
                if (left > right)
                {
                    volume = left;
                    balance = (volume > 0) ? -(1 - (right / (float)left)) : 0;
                }
                else
                {
                    volume = right;
                    balance = (volume > 0) ? (1 - (left / (float)right)) : 0;
                }
            }

            if (volume >= 0)
                this.volumeTrackBar.Value = volume;
            else
                this.volumeTrackBar.Enabled = false;

            // toolstrip checkboxes
            this.muteButton.Checked = pbline.Mute;
            this.micMuteButton.Checked = recline.Volume == 0 ? true : false;
            _lastMicVol = recline.Volume;
        }

        /// <summary>
        /// Callback from Windows Volume Control
        /// </summary>
        /// <param name="mixer"></param>
        /// <param name="line"></param>
        private void mMixer_MixerLineChanged(Mixer mixer, MixerLine line)
        {
            mAvoidEvents = true;

            try
            {
                float balance = -1;
                MixerLine frontEndLine = (MixerLine)volumeTrackBar.Tag;
                if (frontEndLine == line)
                {
                    int volume = 0;
                    if (line.Channels != 2)
                        volume = line.Volume;
                    else
                    {
                        line.Channel = Channel.Left;
                        int left = line.Volume;
                        line.Channel = Channel.Right;
                        int right = line.Volume;
                        if (left > right)
                        {
                            volume = left;
                            // TIP: Do not reset the balance if both left and right channel have 0 value
                            if (left != 0 && right != 0)
                                balance = (volume > 0) ? -(1 - (right / (float)left)) : 0;
                        }
                        else
                        {
                            volume = right;
                            // TIP: Do not reset the balance if both left and right channel have 0 value
                            if (left != 0 && right != 0)
                                balance = (volume > 0) ? 1 - (left / (float)right) : 0;
                        }
                    }

                    if (volume >= 0)
                        volumeTrackBar.Value = volume;

                }

                // adjust toolstrip checkboxes
                if ((MixerLine)micMuteButton.Tag == line)
                {
                    micMuteButton.Checked = line.Volume == 0 ? true : false;
                }
                else if ((MixerLine)muteButton.Tag == line)
                {
                    muteButton.Checked = line.Mute;
                }
            }
            finally
            {
                mAvoidEvents = false;
            }
        }

        private void volumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (mAvoidEvents)
                return;

            TrackBar tBar = (TrackBar)sender;
            MixerLine line = (MixerLine)tBar.Tag;
            if (line.Channels != 2)
            {
                // One channel or more than two let set the volume uniform
                line.Channel = Channel.Uniform;
                line.Volume = tBar.Value;
            }
            else
            {
                //Set independent volume
                line.Channel = Channel.Uniform;
                line.Volume = volumeTrackBar.Value;
            }
        }

        private int _lastMicVol = 0;

        private void muteButton_Click(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            MixerLine line = (MixerLine)chkBox.Tag;
            if (line.Direction == MixerType.Recording)
            {
                //line.Selected = chkBox.Checked;
                if (chkBox.Checked == true)
                {
                    _lastMicVol = line.Volume;
                    line.Volume = 0;
                }
                else
                {
                    line.Volume = _lastMicVol;
                }
            }
            else
            {
                line.Mute = chkBox.Checked;
            }
        }
        #endregion

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void hide()
        {
            this.Visible = false;
            notifyIcon1.ShowBalloonTip(500);
        }

        private void PhoneForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

    }
}
