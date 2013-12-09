using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public enum ParkedCallState
    {
        WAITING,
        GIVEUP,
        TIMEOUT
    }

    public class ParkedCall : AsteriskObject
    {
        private const string PROPERTY_PREFIX = "ParkedCall";
        public const string PROPERTY_STATE = PROPERTY_PREFIX + "State";

        private AsteriskChannel channel;

        public AsteriskChannel Channel
        {
            get { return channel; }
            set { channel = value; }
        }
        private AsteriskChannel from;

        public AsteriskChannel From
        {
            get { return from; }
            set { from = value; }
        }
        private string exten;

        public string Exten
        {
            get { return exten; }
            set { exten = value; }
        }
        private CallerId callerId;

        public CallerId CallerId
        {
            get { return callerId; }
            set { callerId = value; }
        }
        private long timeout;

        public long Timeout
        {
            get { return timeout; }
            set { timeout = value; }
        }
        private ParkedCallState state;

        public ParkedCallState State
        {
            get { return state; }
            set { state = value; }
        }

        public ParkedCall(DefaultAsteriskServer server)
            : base(server)
        {
            state = ParkedCallState.WAITING;
        }

        public void CallGiveup()
        {
            ParkedCallState oldState = state;
            state = ParkedCallState.GIVEUP;
            firePropertyChange(PROPERTY_STATE, oldState, state);
        }

        public void CallTimeout()
        {
            ParkedCallState oldState = state;
            state = ParkedCallState.TIMEOUT;
            firePropertyChange(PROPERTY_STATE, oldState, state);
        }
    }
}
