using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// The lifecycle status of a MeetMeUser.
    /// </summary>
    public enum MeetMeUserState
    {
        /// <summary>
        /// The User joined the MeetMe room.
        /// </summary>
        JOINED,
        /// <summary>
        /// The User left the MeetMe room.
        /// </summary>
        LEFT
    }
}
