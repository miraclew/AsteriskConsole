using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public class ZapChannel //: AsteriskChannel
    {
        public ZapChannel()
        {

        }

        private int channelNum;

        public int ChannelNum
        {
            get { return channelNum; }
            set { channelNum = value; }
        }

        private string signalling;

        public string Signalling
        {
            get { return signalling; }
            set { signalling = value; }
        }
        private string context;

        public string Context
        {
            get { return context; }
            set { context = value; }
        }
        private string alarm;

        public string Alarm
        {
            get { return alarm; }
            set { alarm = value; }
        }

        private bool dnd;

        public bool Dnd
        {
            get { return dnd; }
            set { dnd = value; }
        }

    }
}
