using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Background : VoiceMenuAction
    {
        string fileName;

        public string FileName
        {
            get { return fileName; }
        }

        public Background(string fileName)
        {
            this.fileName = fileName;
            this.applicationString = new string[] { "Background", fileName };
        }

        public override string HelpText
        {
            get
            {
                return "Play an audio file while waiting for digits of an extension to go to.";
            }
        }

        public override string DisplayText
        {
            get
            {
                return "Play " + fileName + " & Listen for KeyPress events";
            }
        }
    }
}
