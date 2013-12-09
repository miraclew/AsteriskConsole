using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public enum QueueEntryState
    {
        /// <summary>
        /// The User joined the queue.
        /// </summary>
        JOINED,
        /// <summary>
        /// The User left the queue.
        /// </summary>
        LEFT
    }
}
