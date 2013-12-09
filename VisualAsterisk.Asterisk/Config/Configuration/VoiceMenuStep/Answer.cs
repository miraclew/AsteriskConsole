using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Answer : VoiceMenuAction
    {
        public Answer()
        {
            this.applicationString = new string[] { "Answer" };
            
        }

        public override string DisplayText
        {
            get
            {
                return "Answer the call";
            }
        }

        public override string HelpText
        {
            get
            {
                return "Answer a channel if ringing";
            }
        }
    }
}
