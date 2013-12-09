using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Agi : VoiceMenuAction
    {
        public Agi(string script)
        {
            this.applicationString = new string[] { "AGI", script };
        }

        public override string DisplayText
        {
            get
            {
                return "Execute AGI script " + applicationString[1];
            }
        }

        public override string HelpText
        {
            get
            {
                return "Executes an AGI compliant application";
            }
        }
    }
}
