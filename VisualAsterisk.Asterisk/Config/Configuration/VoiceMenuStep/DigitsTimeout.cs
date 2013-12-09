using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class DigitsTimeout : Wait
    {
        public DigitsTimeout(int timeout)
            : base(timeout)
        {
            this.applicationString = new string[] { "Set", string.Format("TIMEOUT(digit)={0}", timeout) };
        }

        public override string Name
        {
            get
            {
                return "Digits Timeout";
            }
        }

        public override string HelpText
        {
            get
            {
                return "";
            }
        }

        public override string DisplayText
        {
            get
            {
                return this.ToString();
            }
        }


    }
}
