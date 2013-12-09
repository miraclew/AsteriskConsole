using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    class DialRingGroup : VoiceMenuAction
    {
        public DialRingGroup(RingGroup ringGroup)
        {
            this.applicationString = new string[] { "Goto", ringGroup.Context, "s", "1" };
        }

        private RingGroup ringGroup;

        public RingGroup RingGroup
        {
            get { return ringGroup; }
        }
    }
}
