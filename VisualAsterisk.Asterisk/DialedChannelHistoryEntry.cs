using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// An entry in the dialed channels history of an {@link AsteriskChannel}.
    /// </summary>
    public class DialedChannelHistoryEntry
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
        }
        private AsteriskChannel channel;

        public AsteriskChannel Channel
        {
            get { return channel; }
        }

        public DialedChannelHistoryEntry(DateTime date, AsteriskChannel channel)
        {
            this.date = date;
            this.channel = channel;
        }

        public override string ToString()
        {
            StringBuilder sb;
            sb = new StringBuilder("DialedChannelHistoryEntry[");
            sb.Append("date=").Append(date).Append(",");
            sb.Append("channel=").Append(channel).Append("]");
            return sb.ToString();
        }
    }
}
