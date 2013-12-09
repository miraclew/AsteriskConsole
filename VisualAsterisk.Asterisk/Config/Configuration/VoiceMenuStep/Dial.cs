using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    public class Dial : VoiceMenuAction
    {
        private string[] dialedMembers;
        private int ringTimeout;
        private string flags;
        private string url;

        public string[] DialedMembers
        {
            get { return dialedMembers; }
            set { dialedMembers = value; }
        }

        public int RingTimeout
        {
            get { return ringTimeout; }
            set { ringTimeout = value; }
        }

        public string Flags
        {
            get { return flags; }
            set { flags = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public Dial()
        {
            this.applicationString = new string[] { "Dial" };
        }

        public Dial(string[] dialedMembers)
            : this(dialedMembers, -1)
        {
        }
        public Dial(string[] dialedMembers, int ringTimeout)
            : this(dialedMembers, ringTimeout, null)
        {
        }

        public Dial(string[] dialedMembers, int ringTimeout, string flags)
            : this(dialedMembers, ringTimeout, flags, null)
        {
        }

        public Dial(string[] dialedMembers, int ringTimeout, string flags, string url)
        {
            this.dialedMembers = dialedMembers;
            this.ringTimeout = ringTimeout;
            this.flags = flags;
            this.url = url;
        }

        public static Dial Parse(string[] args)
        {
            string[] members = null;
            int ringTimeout = -1;
            string flags = null;
            string url = null;
            if (args.Length > 1)
            {
                members = args[1].Split(new char[] {'&'});
                if (args.Length > 2)
                {
                    ringTimeout = int.Parse(args[2]);
                    if (args.Length > 3)
                    {
                        flags = args[3];
                        if (args.Length > 4)
                        {
                            url = args[4];
                        }
                    }
                }
            }

            return new Dial(members, ringTimeout, flags, url);
        }
    }
}
