using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class WaitExten : Wait
    {
        public WaitExten(int timeout)
            : base(timeout)
        {
            this.applicationString = new string[] { "WaitExten", timeout.ToString() };
        }

        public override string DisplayText
        {
            get
            {
                return "Wait '" + timeout.ToString() + "' sec for the user to enter an extension";
            }
        }
        public override string HelpText
        {
            get
            {
                return "Wait for the user to enter a new extension for a specified number of seconds.";
            }
        }
    }
}
