using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Authenticate : VoiceMenuAction
    {
        public Authenticate(string password)
        {
            this.password = password;
            this.applicationString = new string[] { "Authenticate", password };
        }

        string password;

        public string Password
        {
            get { return password; }
        }

        public override string HelpText
        {
            get
            {
                return "This application asks the caller to enter a given password in order to continue dialplan execution.";
            }
        }

        public override string DisplayText
        {
            get
            {
                return "Authenticate for password " + password;
            }
        }
    }
}
