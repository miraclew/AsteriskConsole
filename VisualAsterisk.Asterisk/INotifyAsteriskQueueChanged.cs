using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Entry event handler delegate for NewEntry,EntryLeave and EntryServiceLevelExceeded
    /// </summary>
    /// <param Name="sender">source of the event</param>
    /// <param Name="entry">the entry</param>
    public delegate void EntryEventHandler(object sender, AsteriskQueueEntry entry);
    /// <summary>
    /// Member event handler delgete for MemberStateChange,MemberAdded and MemberRemoved
    /// </summary>
    /// <param Name="sender">source of the event</param>
    /// <param Name="member">the member</param>
    public delegate void MemberEventHandler(object sender, AsteriskQueueMember member);

    public interface INotifyAsteriskQueueChanged
    {
        /// <summary>
        /// Called whenever an entry appears in the queue.
        /// </summary>
        event EntryEventHandler NewEntry;
        /// <summary>
        /// Called whenever an entry leaves the queue.
        /// </summary>
        event EntryEventHandler EntryLeave;
        event EntryEventHandler EntryServiceLevelExceeded;
        /// <summary>
        /// Called whenever a member Changes his State.
        /// </summary>
        event MemberEventHandler MemberStateChange;
        /// <summary>
        /// Called whenever a new member is added to the queue.
        /// </summary>
        event MemberEventHandler MemberAdded;
        /// <summary>
        /// Called whenever a member is removed From this queue.
        /// </summary>
        event MemberEventHandler MemberRemoved;
    }
}
