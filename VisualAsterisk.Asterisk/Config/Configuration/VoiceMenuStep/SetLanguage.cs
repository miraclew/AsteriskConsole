using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class SetLanguage : VoiceMenuAction
    {
        public SetLanguage(string language)
        {
            this.language = language;
            this.applicationString = new string[] { "Set", "CHANNEL(language)=" + language };
        }

        public override string Name
        {
            get
            {
                return "Set Language";
            }
        }
        private string language;
        public override string DisplayText
        {
            get
            {
                return "Set Language to " + language;
            }
        }
    }
}
