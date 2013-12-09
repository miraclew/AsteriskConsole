using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// An Asterisk voicemailbox with status.
    /// </summary>
    [Serializable]
    public class Voicemailbox
    {
        private string mailbox;

        public string Mailbox
        {
            get { return mailbox; }
            set { mailbox = value; }
        }
        private string context;

        public string Context
        {
            get { return context; }
            set { context = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private int newMessages;

        public int NewMessages
        {
            get { return newMessages; }
            set { newMessages = value; }
        }
        private int oldMessages;

        public int OldMessages
        {
            get { return oldMessages; }
            set { oldMessages = value; }
        }

        /**
         * Creates a new instance.
         * 
         * @param mailbox the Name of this mailbox as defined in <code>voicemail.conf</code>.
         * @param Context the Context of this mailbox as defined in <code>voicemail.conf</code>.
         * @param User the User of this mailbox as defined in <code>voicemail.conf</code>.
         */
        public Voicemailbox(string mailbox, string context, string user)
        {
            this.mailbox = mailbox;
            this.context = context;
            this.user = user;
        }

        public override string ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder(100);
            sb.Append("Voicemailbox[");
            sb.Append("mailbox='").Append(this.Mailbox).Append("',");
            sb.Append("context='").Append(this.Context).Append("',");
            sb.Append("user='").Append(this.User).Append("',");
            sb.Append("newMessages=").Append(this.NewMessages).Append(",");
            sb.Append("oldMessages=").Append(this.OldMessages).Append("]");

            return sb.ToString();
        }

    }
}
