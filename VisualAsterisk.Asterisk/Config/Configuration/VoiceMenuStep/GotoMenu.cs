using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    class GotoMenu : VoiceMenuAction
    {
        public GotoMenu()
        {
            this.applicationString = new string[] { "GotoMenu" };
        }

        VoiceMenu voiceMenu;

        public VoiceMenu VoiceMenu
        {
            get { return voiceMenu; }
            set { voiceMenu = value; }
        }

        public override string ToString()
        {
            return string.Format("Goto({0}|s|1)", voiceMenu.Context);
        }


    }
}
