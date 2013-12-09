using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class ResponseTimeout : Wait
    {
        public ResponseTimeout(int timeout)
            : base(timeout)
        {
            this.applicationString = new string[] { "Set", string.Format("TIMEOUT(response)={0}", timeout) };
        }

        public override string Name
        {
            get
            {
                return "Response Timeout";
            }
        }

        public override string DisplayText
        {
            get
            {
                return this.ToString();
            }
        }
    }
}
