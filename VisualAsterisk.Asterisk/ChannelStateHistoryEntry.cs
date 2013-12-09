using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// An entry in the Channel State history of an AsteriskChannel
    /// </summary>
    [Serializable]
    class ChannelStateHistoryEntry
    {
        private readonly DateTime date;

        public DateTime Date
        {
            get { return date; }
        }

        private readonly ChannelState state;

        public ChannelState State
        {
            get { return state; }
        } 

        public ChannelStateHistoryEntry(DateTime date, ChannelState state)
        {
            this.date = date;
            this.state = state;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("ChannelStateHistoryEntry[");
            sb.Append("date=").Append(date).Append(",");
            sb.Append("state=").Append(state).Append("]");
            return sb.ToString();
        }
    }
}
