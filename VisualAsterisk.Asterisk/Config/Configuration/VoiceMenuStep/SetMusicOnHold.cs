using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class SetMusicOnHold : VoiceMenuAction
    {
        public SetMusicOnHold(string musicClass)
        {
            this.applicationString = new string[] { "SetMusicOnHold", musicClass };
        }

        public override string DisplayText
        {
            get
            {
                return "Set Music-On-Hold class '" + applicationString[1] + "'";
            }
        }
    }
}
