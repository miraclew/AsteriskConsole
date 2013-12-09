using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Directory : VoiceMenuAction
    {
        public Directory()
        {
            this.applicationString = new string[] { "Directory", "default" };
        }

        public override int ParameterCount
        {
            get
            {
                return 0;
            }
        }

        public override string Name
        {
            get
            {
                return "Goto Directory";
            }
        }

        public override string DisplayText
        {
            get
            {
                return "Directory for context " + applicationString[1];
            }
        }
    }
}
