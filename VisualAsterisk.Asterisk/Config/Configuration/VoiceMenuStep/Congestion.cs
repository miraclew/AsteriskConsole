using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Congestion : VoiceMenuAction
    {
        public Congestion()
        {
            this.applicationString = new string[] { "Congestion" };
            time = -1;
        }

        public Congestion(int time)
        {
            this.time = time;
            this.applicationString = new string[] { "Congestion", time.ToString() };
        }

        private int time;

        public override string DisplayText
        {
            get
            {
                if (time != -1)
                {
                    return "Indicate Congestion for '" + time.ToString() + "' seconds and Hangup";
                }
                else
                    return "Indicate Congestion and Hangup";
            }
        }

        public override string HelpText
        {
            get
            {
                return "Indicate the congestion condition to the calling channel.";
            }
        }
    }
}
