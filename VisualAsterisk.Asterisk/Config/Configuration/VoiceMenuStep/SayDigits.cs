using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class SayDigits : VoiceMenuAction
    {
        private string digits;

        public string Digits
        {
            get { return digits; }
        }

        public SayDigits(string digits)
        {
            this.digits = digits;
            this.applicationString = new string[] {"SayDigits", digits };
        }

        public override string HelpText
        {
            get
            {
                return "Say the digits, one by one";
            }
        }
    }
}
