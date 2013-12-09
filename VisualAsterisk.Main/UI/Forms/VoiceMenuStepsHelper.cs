using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;

namespace VisualAsterisk.Main.UI.Forms
{
    /// <summary>
    /// 
    /// </summary>
    class VoiceMenuStepsHelper
    {
        public VoiceMenuStepsHelper()
        {

            stepChoices = new List<VoiceMenuAction>();
            stepChoices.AddRange(new VoiceMenuAction[] { 
                new Answer(), new Authenticate(""), new Background(""), new Busy(1),new Congestion(1),
                new DigitsTimeout(1), new DISA("",""), new ResponseTimeout(1), new Macro(""), new Playback(""),
                new Ringing(), new SetMusicOnHold(""), new SayAlpha(""), new SayDigits(""), 
                new SayNumber(""),new Wait(1), new WaitExten(1),
                new Goto("","",1), new SetLanguage(""), new Directory(), // TODO: dial via trunk not support
                new Agi(""), new UserEvent("",""), new Hangup()
            });

        }
        private IAsteriskConfigManager configManger;
        private List<VoiceMenuAction> stepChoices;

        public List<VoiceMenuAction> StepChoices
        {
            get { return stepChoices; }
            set { stepChoices = value; }
        }
        
        /// <summary>
        /// Step name/Step description
        /// </summary>
        private Dictionary<string, string> steps = new Dictionary<string, string>();

        public Dictionary<string, string> Steps
        {
            get { return steps; }
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
            VOICEMENU_STEP_MACRO, // 1 string
            VOICEMENU_STEP_PLAYBACK, // 1 string (music file)
            VOICEMENU_STEP_RINGING, //
            VOICEMENU_STEP_WAIT, // 1 int
            VOICEMENU_STEP_WAITEXTEN, // 1 int
            //VOICEMENU_STEP_GOTOMENU, // 1 string (menu)
            VOICEMENU_STEP_GOTODIRECTORY, // 0 args
            //VOICEMENU_STEP_GOTOEXTENSION, // 1 string (Extension)
            //VOICEMENU_STEP_GOTOTIMEBASEDRULE, // 0 args
            //VOICEMENU_STEP_DIALRINGGROUP, // 1 string (ringgoup)
            //VOICEMENU_STEP_CHECKOWERVOICEMAIL, // 0 args
            //VOICEMENU_STEP_HANGUP // 0 args                         
        };

        private const string VOICEMENU_STEP_ANSWER = "Answer";
        private const string VOICEMENU_STEP_AUTHENTICATE = "Authenticate";
        private const string VOICEMENU_STEP_BACKGROUND = "Background";
        private const string VOICEMENU_STEP_BUSYTONE = "Busy Tone";
        private const string VOICEMENU_STEP_CONGESTION = "Congestion";
        private const string VOICEMENU_STEP_DIGITTIMEOUT = "DigitTimeout";
        private const string VOICEMENU_STEP_DISA = "DISA";
        private const string VOICEMENU_STEP_RESPONSETIMEOUT = "ResponseTimeout";
        private const string VOICEMENU_STEP_MACRO = "Macro";
        private const string VOICEMENU_STEP_PLAYBACK = "Playback";
        private const string VOICEMENU_STEP_RINGING = "Ringing";
        private const string VOICEMENU_STEP_SetMusicOnHold = "Set MusicOhHold Class";
        private const string VOICEMENU_STEP_SayAlpha = "SayAlpha";
        private const string VOICEMENU_STEP_SayDigits = "SayDigits";
        private const string VOICEMENU_STEP_SayNumber = "SayNumber";
        private const string VOICEMENU_STEP_WAIT = "Wait";
        private const string VOICEMENU_STEP_WAITEXTEN = "WaitExten";
        private const string VOICEMENU_STEP_GoToDestination = "Goto Destination";
        private const string VOICEMENU_STEP_SetLanguage = "Set Language";
        private const string VOICEMENU_STEP_GOTODIRECTORY = "Goto Directory";
        private const string VOICEMENU_STEP_DialViaTrunk = "Dial a Number via Trunk";
        //private const string VOICEMENU_STEP_GOTOTIMEBASEDRULE = "Goto TimebasedRule";
        private const string VOICEMENU_STEP_UserEvent = "User Event";
        //private const string VOICEMENU_STEP_DIALRINGGROUP = "Dial RingGroup";
        //private const string VOICEMENU_STEP_CHECKOWERVOICEMAIL = "Check Ower VoiceMail";
        private const string VOICEMENU_STEP_HANGUP = "Hangup";
    }
}
