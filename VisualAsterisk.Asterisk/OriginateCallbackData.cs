using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Wrapper class for OriginateCallbacks.
    /// </summary>
    class OriginateCallbackData
    {
        private OriginateAction originateAction;

        public OriginateAction OriginateAction
        {
            get { return originateAction; }
        }
        private DateTime dateSent;

        public DateTime DateSent
        {
            get { return dateSent; }
        }
        private IOriginateCallback callback;

        public IOriginateCallback Callback
        {
            get { return callback; }
        }
        private AsteriskChannel channel;

        public AsteriskChannel Channel
        {
            get { return channel; }
            set { channel = value; }
        }

        public OriginateCallbackData(OriginateAction originateAction, DateTime dateSent, IOriginateCallback callback)
        {
            this.originateAction = originateAction;
            this.dateSent = dateSent;
            this.callback = callback;
        }
    }
}
