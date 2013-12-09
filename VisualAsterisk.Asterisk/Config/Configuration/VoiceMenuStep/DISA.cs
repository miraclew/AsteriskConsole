using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class DISA : VoiceMenuAction
    {
        public DISA(string password, string dialplan)
        {
            this.password = password;
            this.dialplan = dialplan;
            this.applicationString = new string[] { "DISA", password, dialplan };
        }

        private string password;
        private string dialplan;

        public override string DisplayText
        {
            get
            {
                return "DISA using password " + password + " against context " + dialplan;
            }
        }

        public override string HelpText
        {
            get
            {
                return "Allow someone from outside the telephone switch (PBX) to obtain an internal system dialtone and to place calls from it as if they were placing a call from within the switch.";
            }
        }
    }
}
