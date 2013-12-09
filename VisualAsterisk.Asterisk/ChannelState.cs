using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Core.Util;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// The lifecycle status of an AsteriskChannel
    /// From include/asterisk/channel.h
    /// </summary>
    public enum ChannelState
    {
        /// <summary>
        /// Channel is down and available.
        /// This is the initial State of the Channel when it is not yet in use.
        /// </summary>
        DOWN = AstState.AST_STATE_DOWN,
        /// <summary>
        /// Channel is down, but reserved.
        /// </summary>
        RSRVD = AstState.AST_STATE_RSRVD,
        /// <summary>
        /// Channel is off hook.
        /// </summary>
        OFFHOOK = AstState.AST_STATE_OFFHOOK,
        /// <summary>
        /// Digits (or equivalent) have been dialed.
        /// </summary>
        DIALING = AstState.AST_STATE_DIALING,
        /// <summary>
        /// Line is ringing.
        /// </summary>
        RING = AstState.AST_STATE_RING,
        /// <summary>
        /// Remote end is ringing.
        /// </summary>
        RINGING = AstState.AST_STATE_RINGING,
        /// <summary>
        /// Line is up.
        /// </summary>
        UP = AstState.AST_STATE_UP,
        /// <summary>
        /// Line is busy.
        /// </summary>
        BUSY = AstState.AST_STATE_BUSY,
        /// <summary>
        /// Digits (or equivalent) have been dialed while offhook.
        /// </summary>
        DIALING_OFFHOOK = AstState.AST_STATE_DIALING_OFFHOOK,
        /// <summary>
        /// Channel has detected an incoming call and is waiting for ring.
        /// </summary>
        PRERING = AstState.AST_STATE_PRERING,
        /// <summary>
        /// The Channel has been hung up and is not longer available on the Asterisk server.
        /// </summary>
        HUNGUP = -1
    }

    public class ChannelStateHelper
    {
        public static ChannelState FromInteger(int status)
        {
            bool foud = false;
            foreach (int item in Enum.GetValues(typeof(ChannelState)))
            {
                if (item == status)
                {
                    foud = true;
                    break;
                }
            }

            if (foud)
            {
                return (ChannelState)Enum.ToObject(typeof(ChannelState), status);
            }
            else
            {
                throw new ArgumentException("status value is illegal", "status");
            }
        }

        public static ChannelState FromString(string state)
        {
            return FromInteger(AstState.Str2state(state));
        }
    }
}
