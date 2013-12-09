using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    // TODO:
    // Goto([[Context,]Extension,]priority)
    // Goto(named_priority) is not considered

    /// <summary>
    /// 
    /// </summary>
    [StepAttribute]
    public class Goto : VoiceMenuAction
    {
        public Goto(string context, string extension, int priority)
        {
            this.applicationString = new string[] { "Goto", context, extension, priority.ToString() };
            this.context = context;
            this.extension = extension;
            this.gotoPriority = priority;
        }

        public override string Name
        {
            get
            {
                return "Goto Destination";
            }
        }

        private string context;

        public string Context
        {
            get { return context; }
            set { context = value; }
        }
        private string extension;

        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        private int gotoPriority;

        public int GotoPriority
        {
            get { return gotoPriority; }
            set { gotoPriority = value; }
        }
        private string options;

        public static Goto Parse(string[] application)
        {
            if (application.Length > 1 && application[0] == "Goto")
            {
                if (application.Length == 4)
                {
                    return new Goto(application[1], application[2], int.Parse(application[3]));
                }
                else
                {
                    Trace.WriteLine("Error: Goto application argument count is not 4: " + application.ToString());
                    Goto gt = new Goto();
                    string args = application[1];
                    return gt;
                }
            }
            else
                return null;
        }
        private Goto()
        {
        }
    }
}
