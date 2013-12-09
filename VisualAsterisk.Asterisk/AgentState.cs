using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public enum AgentState
    {
        /**
         * Agent isn't logged in.
         */
        AGENT_LOGGEDOFF,

        /**
         * Agent is logged in and waiting for call.
         */
        AGENT_IDLE,

        /**
         * Agent is logged in and on a call.
         */
        AGENT_ONCALL,

        /**
         * Don't know anything about agent. Shouldn't ever get this.
         */
        AGENT_UNKNOWN,

        /**
         * Agent is logged in and a call is waiting for connect.
         */
        AGENT_RINGING
    }
}
