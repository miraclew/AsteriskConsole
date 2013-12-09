using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Wait : VoiceMenuAction
    {
        public Wait(int timeout)
        {
            this.timeout = timeout;
            this.applicationString = new string[] { "Wait", timeout.ToString() };
        }

        protected int timeout;

        public int Timeout
        {
            get { return timeout; }
        }

        public override string DisplayText
        {
            get
            {
                return "Pause dialplan execution for '" + timeout.ToString() + "' seconds";
            }
        }

        public override string HelpText
        {
            get
            {
                return "Pause dialplan execution for a specified number of seconds";
            }
        }
    }
}
