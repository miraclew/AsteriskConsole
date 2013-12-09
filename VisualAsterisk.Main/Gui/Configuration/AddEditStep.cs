using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;

namespace VisualAsterisk.Main.Gui.Configuration
{
    public partial class AddEditStep : DialogBase
    {
        public AddEditStep()
        {
            InitializeComponent();
            this.comboBoxStep.Items.Add("-- Select --");
            foreach (string s in avaliableSteps)
            {
                this.comboBoxStep.Items.Add(s);
            }
            this.comboBoxArg.Visible = false;
            this.textBoxArg.Visible = false;
        }

        private VoiceMenuAction step;

        private IEnumerable<string> musicfiles;
        private List<string> voicemenus;
        private List<string> extensions;
        private List<string> ringgroups;

        public IEnumerable<string> Musicfiles
        {
            get { return musicfiles; }
            set { musicfiles = value; }
        }

        public List<string> Voicemenus
        {
            get { return voicemenus; }
            set { voicemenus = value; }
        }

        public List<string> Extensions
        {
            get { return extensions; }
            set { extensions = value; }
        }

        public List<string> Ringgroups
        {
            get { return ringgroups; }
            set { ringgroups = value; }
        }

        public VoiceMenuAction Step
        {
            get {
                string arg = this.comboBoxArg.Visible ? this.comboBoxArg.SelectedItem.ToString() : this.textBoxArg.Text;
                return VoiceMenuAction.Parse(new string[] { comboBoxStep.SelectedItem.ToString(), arg });
            }
        }

        private void displayArg()
        {
            if (this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_ANSWER ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_BUSYTONE ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_CONGESTION ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_GOTODIRECTORY ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_GOTOTIMEBASEDRULE ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_CHECKOWERVOICEMAIL ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_HANGUP
                )
            {
                this.comboBoxArg.Visible = false;
                this.textBoxArg.Visible = false;
            }
            else if (this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_BACKGROUND ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_PLAYBACK
                )
            {
                this.comboBoxArg.Items.Clear();
                foreach (string item in musicfiles)
                {
                    this.comboBoxArg.Items.Add(item);
                }
                this.textBoxArg.Visible = false;
                this.comboBoxArg.Visible = true;
            }
            else if (this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_GOTOMENU)
            {
                this.comboBoxArg.Items.Clear();
                foreach (string item in voicemenus)
                {
                    this.comboBoxArg.Items.Add(item);
                }
                this.textBoxArg.Visible = false;
                this.comboBoxArg.Visible = true;
            }
            else if (this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_GOTOEXTENSION)
            {
                this.comboBoxArg.Items.Clear();
                foreach (string item in extensions)
                {
                    this.comboBoxArg.Items.Add(item);
                }
                this.textBoxArg.Visible = false;
                this.comboBoxArg.Visible = true;
            }
            else if (this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_DIALRINGGROUP)
            {
                this.comboBoxArg.Items.Clear();
                foreach (string item in ringgroups)
                {
                    this.comboBoxArg.Items.Add(item);
                }
                this.textBoxArg.Visible = false;
                this.comboBoxArg.Visible = true;
            }
            else if (this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_AUTHENTICATE ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_DISA 
                )
            {
                // string
                this.textBoxArg.Text = "";
                this.textBoxArg.Visible = true;
                this.comboBoxArg.Visible = false;                
            }
            else if (this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_DIGITTIMEOUT ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_WAITEXTEN ||
                this.comboBoxStep.SelectedItem.ToString() == VOICEMENU_STEP_WAIT
                )
            {
                // int
                this.textBoxArg.Text = "";
                this.textBoxArg.Visible = true;
                this.comboBoxArg.Visible = false;
            }
        }

        private static string[] avaliableSteps = new string[] { 
            VOICEMENU_STEP_ANSWER, // 0 args
            VOICEMENU_STEP_AUTHENTICATE, // 1 string
            VOICEMENU_STEP_BACKGROUND, // 1 string (music file)
            VOICEMENU_STEP_BUSYTONE, // 0 args
            VOICEMENU_STEP_CONGESTION, // 0 args
            VOICEMENU_STEP_DIGITTIMEOUT, // 1 int
            VOICEMENU_STEP_DISA, // 1 string
            VOICEMENU_STEP_RESPONSETIMEOUT, // 1 int
            VOICEMENU_STEP_PLAYBACK, // 1 string (music file)
            VOICEMENU_STEP_WAIT, // 1 int
            VOICEMENU_STEP_WAITEXTEN, // 1 int
            VOICEMENU_STEP_GOTOMENU, // 1 string (menu)
            VOICEMENU_STEP_GOTODIRECTORY, // 0 args
            VOICEMENU_STEP_GOTOEXTENSION, // 1 string (Extension)
            VOICEMENU_STEP_GOTOTIMEBASEDRULE, // 0 args
            VOICEMENU_STEP_DIALRINGGROUP, // 1 string (ringgoup)
            VOICEMENU_STEP_CHECKOWERVOICEMAIL, // 0 args
            VOICEMENU_STEP_HANGUP // 0 args                         
        };

        private const string VOICEMENU_STEP_ANSWER = "Answer";
        private const string VOICEMENU_STEP_AUTHENTICATE = "Authenticate";
        private const string VOICEMENU_STEP_BACKGROUND = "Background";
        private const string VOICEMENU_STEP_BUSYTONE = "Busy Tone";
        private const string VOICEMENU_STEP_CONGESTION = "Congestion";
        private const string VOICEMENU_STEP_DIGITTIMEOUT = "DigitTimeout";
        private const string VOICEMENU_STEP_DISA = "DISA";
        private const string VOICEMENU_STEP_RESPONSETIMEOUT = "ResponseTimeout";
        private const string VOICEMENU_STEP_PLAYBACK = "Playback";
        private const string VOICEMENU_STEP_WAIT = "Wait";
        private const string VOICEMENU_STEP_WAITEXTEN = "WaitExten";
        private const string VOICEMENU_STEP_GOTOMENU = "Goto Menu";
        private const string VOICEMENU_STEP_GOTODIRECTORY = "Goto Directory";
        private const string VOICEMENU_STEP_GOTOEXTENSION = "Goto Extension";
        private const string VOICEMENU_STEP_GOTOTIMEBASEDRULE = "Goto TimebasedRule";
        private const string VOICEMENU_STEP_DIALRINGGROUP = "Dial RingGroup";
        private const string VOICEMENU_STEP_CHECKOWERVOICEMAIL = "Check Ower VoiceMail";
        private const string VOICEMENU_STEP_HANGUP = "Hangup";

        private void comboBoxStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayArg();
        }
    }
}
