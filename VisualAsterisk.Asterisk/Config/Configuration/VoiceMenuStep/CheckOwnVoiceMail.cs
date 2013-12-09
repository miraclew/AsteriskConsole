using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    class CheckOwnVoiceMail : VoiceMenuAction
    {
        public CheckOwnVoiceMail()
        {
            this.applicationString = new string[] { "VoiceMailMain", "${CALLERID(num)}@default" };
        }

        public override string Name
        {
            get
            {
                return "CheckOwnVoiceMail";
            }
        }
    }
}
