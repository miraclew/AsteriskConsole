using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Hangup : VoiceMenuAction
    {
        public Hangup()
        {
            this.applicationString = new string[] { "Hangup" };
        }

        public override string DisplayText
        {
            get
            {
                return "Hangup call";
            }
        }

        public override string HelpText
        {
            get
            {
                return "Hang up the calling channel";
            }
        }
    }
}
