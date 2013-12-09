using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    public class VoiceMail : VoiceMenuAction
    {
        private string extension;
        private string options;
        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        public VoiceMail(string[] application)
        {
            this.applicationString = new string[] { application[0], application[1], application[2] };
            extension = application[1];
            options = application[2];
        }
    }
}
