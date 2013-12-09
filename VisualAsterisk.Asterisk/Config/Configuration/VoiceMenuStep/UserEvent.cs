using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class UserEvent : VoiceMenuAction
    {
        public UserEvent(string eventname, string body)
        {
            this.applicationString = new string[] { "UserEvent", eventname, body };
        }

        public override string HelpText
        {
            get
            {
                return "Send an arbitrary event to the manager interface";
            }
        }
    }
}
