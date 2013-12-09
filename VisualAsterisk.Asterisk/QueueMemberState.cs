using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Represents the status of a Queue memeber.
    /// Valid status codes are:
    /// AST_DEVICE_UNKNOWN (0)
    /// AST_DEVICE_NOT_INUSE (1)
    /// AST_DEVICE_INUSE (2)
    /// AST_DEVICE_BUSY (3)
    /// AST_DEVICE_INVALID (4)
    /// AST_DEVICE_UNAVAILABLE (5)
    /// </summary>
    public enum QueueMemberState
    {
        DEVICE_UNKNOWN,
        /// <summary>
        /// Queue member is available, eg. Agent is logged in but idle.
        /// </summary>
        DEVICE_NOT_INUSE,
        DEVICE_INUSE,
        /// <summary>
        /// Busy means, phone is in Action, eg. is ringing, in call.
        /// </summary>
        DEVICE_BUSY,
        DEVICE_INVALID,
        /// <summary>
        /// Device is not availible for call, eg. Agent is logged off.
        /// </summary>
        DEVICE_UNAVAILABLE
    }
}
