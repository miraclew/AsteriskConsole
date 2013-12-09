using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    internal class EnumHelper
    {
        public static ChannelState ParseChannelState(string state)
        {
            if (state.Equals(""))
            {
                return ChannelState.BUSY;
            }
            else if (state.Equals(""))
            {
                return ChannelState.DIALING;
            }
            else
                return ChannelState.HUNGUP;

            // TODO: UNCOMPLETED
        }

        public static HangupCause ParseHangupCauseByCode(int cause)
        {
            switch (cause)
            {
                case 1:
                    return HangupCause.AST_CAUSE_ACCESS_INFO_DISCARDED;
                default:
                    return HangupCause.AST_CAUSE_ACCESS_INFO_DISCARDED;
                    break;
                // TODO: UNCOMPLETED
            }
        }

        public static QueueMemberState ParseQueueMemberState(int state)
        {
            switch (state)
            {
                default:
                    return QueueMemberState.DEVICE_UNKNOWN;
            }
 
        }
    }
}
