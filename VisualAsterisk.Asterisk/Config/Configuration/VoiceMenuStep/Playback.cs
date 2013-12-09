using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Playback : Background
    {
        public Playback(string filename)
            : base(filename)
        {
            this.applicationString = new string[] { "Playback", filename };
        }

        public override string DisplayText
        {
            get
            {
                return "Play " + FileName + " & Donot Listen for KeyPress events";
            }
        }

        public override string HelpText
        {
            get
            {
                return "Plays back given file";
            }
        }
    }
}
