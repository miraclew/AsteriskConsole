using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Ringing : VoiceMenuAction
    {
        public Ringing()
        {
            applicationString = new string[] { "Ringing"};
        }

        public override string HelpText
        {
            get
            {
                return "Indicate ringing tone";
            }
        }
    }
}
