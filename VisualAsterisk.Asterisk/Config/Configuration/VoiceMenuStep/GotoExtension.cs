using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    class GotoExtension : VoiceMenuAction
    {
        public GotoExtension(string exten)
        {
            this.extension = exten;
            this.applicationString = new string[] { "Goto", string.Format("default|{0}|1",extension) };
        }

        string extension;

        public string Extension
        {
            get { return extension; }
        }
    }
}
