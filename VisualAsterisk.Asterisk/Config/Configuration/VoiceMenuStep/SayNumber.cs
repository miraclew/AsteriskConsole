using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class SayNumber : VoiceMenuAction
    {
        public SayNumber(string toSay)
        {
            this.applicationString = new string[] { "SayNumber", toSay };
        }

        public override string HelpText
        {
            get
            {
                return "Say a number (e.g. 'six thousand, five hundred and seventy two')";
            }
        }
    }
}
