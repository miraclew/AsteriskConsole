using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Busy : VoiceMenuAction
    {
        public Busy(int time)
        {
            this.time = time;
            this.applicationString = new string[] { "Busy", time.ToString() };
        }

        private int time;

        public override string Name
        {
            get
            {
                return "Busy Tone";
            }
        }

        public override string DisplayText
        {
            get
            {
                return "Play BusyTone for '" + time.ToString() + "' seconds and Hangup";
            }
        }

        public override string HelpText
        {
            get
            {
                return "Indicate the Busy condition";
            }
        }
    }
}
