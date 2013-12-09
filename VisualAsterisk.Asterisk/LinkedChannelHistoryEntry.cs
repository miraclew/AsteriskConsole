using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// An entry in the linked channels history of an  AsteriskChannel.
    /// </summary>
    public class LinkedChannelHistoryEntry
    {
        private DateTime dateLinked;

        public DateTime DateLinked
        {
            get { return dateLinked; }
        }
        private DateTime dateUnlinked;

        public DateTime DateUnlinked
        {
            get { return dateUnlinked; }
            set { dateUnlinked = value; }
        }
        private AsteriskChannel channel;

        public AsteriskChannel Channel
        {
            get { return channel; }
            set { channel = value; }
        }

        /**
         * Creates a new instance.
         *
         * @param dateLinked the date the Channel was linked.
         * @param Channel    the Channel that has been linked.
         */
        public LinkedChannelHistoryEntry(DateTime dateLinked, AsteriskChannel channel)
        {
            this.dateLinked = dateLinked;
            this.channel = channel;
        }


        public override string ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder(100);
            sb.Append("LinkedChannelHistoryEntry[");
            sb.Append("dateLinked=").Append(dateLinked).Append(",");
            sb.Append("dateUnlinked=").Append(dateUnlinked).Append(",");
            sb.Append("channel=").Append(channel).Append("]");
            return sb.ToString();
        }

    }
}
