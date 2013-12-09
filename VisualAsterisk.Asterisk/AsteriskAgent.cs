using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Represents an Asterisk agent
    /// </summary>
    public class AsteriskAgent : AsteriskObject
    {
        string PROPERTY_STATE = "state";
        string name;

        public string Name
        {
            get { return name; }
        }
        string agentId;

        public string AgentId
        {
            get { return agentId; }
        }
        AgentState state;

        public AgentState State
        {
            get { return state; }
            set
            {
                lock (asteriskObjectLock)
                {
                    state = value;
                }
            }
        }

        public AsteriskAgent(DefaultAsteriskServer server, string name, string agentId, AgentState state)
            : base(server)
        {
            if (server == null || name == null || agentId == null)
            {
                throw new ArgumentNullException("Parameters passed to AsteriskAgent() must not be null.");
            }
            this.name = name;
            this.agentId = agentId;
            this.state = state;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("AsteriskAgent[");
            sb.Append("agentId='").Append(agentId).Append("',");
            sb.Append("name='").Append(name).Append("',");
            sb.Append("state=").Append(state).Append(",");
            sb.Append("systemHashcode=").Append(this.GetHashCode());
            sb.Append("]");

            return sb.ToString();

        }

        internal void updateState(AgentState agentState)
        {
            lock (asteriskObjectLock)
            {
                AgentState oldState = this.state;
                this.state = agentState;
                firePropertyChange(PROPERTY_STATE, oldState, this.state);
            }
        }
    }
}
