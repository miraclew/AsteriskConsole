using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class SayAlpha : VoiceMenuAction
    {
        public SayAlpha(string toSay)
        {
            this.applicationString = new string[] { "SayAlpha", toSay };
        }

        public override string HelpText
        {
            get
            {
                return "Say each character in the string including letters, numbers and other characters, one by one";
            }
        }
    }
}
