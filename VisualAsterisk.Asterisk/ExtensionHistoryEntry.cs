using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk
{
    [Serializable]
    public class ExtensionHistoryEntry
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
        }
        private AstExten exten;

        public AstExten Exten
        {
            get { return exten; }
        }

        public ExtensionHistoryEntry(DateTime date, AstExten exten)
        {
            this.date = date;
            this.exten = exten;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append("ExtensionHistoryEntry[");
            sb.Append("date=").Append(date).Append(",");
            sb.Append("extension=").Append(exten).Append("]");
            return sb.ToString();
        }

    }
}
