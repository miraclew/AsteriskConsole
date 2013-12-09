using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace VisualAsterisk.Asterisk
{
    public class AsteriskQueue : AsteriskObject, INotifyAsteriskQueueChanged
    {
        //private Log logger = LogFactory.getLog(this.getClass());
        private string name;

        public string Name
        {
            get { return name; }
        }
        private int max;

        public int Max
        {
            get { return max; }
            set { max = value; }
        }
        private string strategy;

        public string Strategy
        {
            get { return strategy; }
        }
        private int serviceLevel;

        public int ServiceLevel
        {
            get { return serviceLevel; }
            set { serviceLevel = value; }
        }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private IList<AsteriskQueueEntry> entries;

        public IList<AsteriskQueueEntry> Entries
        {
            get { return entries; }
        }
        private Timer timer;
        private IDictionary<string, AsteriskQueueMember> members;

        public IDictionary<string, AsteriskQueueMember> Members
        {
            get { return members; }
            set { members = value; }
        }
        //private List<AsteriskQueueListener> listeners;
        //private IDictionary<AsteriskQueueEntry, ServiceLevelTimerTask> serviceLevelTimerTasks;

        public AsteriskQueue(DefaultAsteriskServer server, string name, int max,
                  string strategy, int serviceLevel, int weight)
            : base(server)
        {
            this.name = name;
            this.max = max;
            this.strategy = strategy;
            this.serviceLevel = serviceLevel;
            this.weight = weight;
            entries = new List<AsteriskQueueEntry>(25);
            //listeners = new List<AsteriskQueueListener>();
            members = new Dictionary<string, AsteriskQueueMember>();
            //timer = new Timer("ServiceLevelTimer-" + Name, true);
            //serviceLevelTimerTasks = new HashMap<AsteriskQueueEntry, ServiceLevelTimerTask>();
        }

        #region queue member related method
        /**
     * Add a new member to this queue.
     *
     * @param member to add
     */
        public void addMember(AsteriskQueueMember member)
        {
            lock (members)
            {
                // Check if member already exists
                if (members.Values.Contains(member))
                {
                    return;
                }
                // If not, add the new member.
                Trace.TraceInformation("Adding new member to the queue " + name + ": " + member.ToString());
                members.Add(member.Location, member);
            }

            fireMemberAdded(member);
        }

        /**
         * Retrieves a member by its Location.
         *
         * @param Location of the member
         * @return the requested member.
         */
        internal AsteriskQueueMember getMemberByLocation(string location)
        {
            AsteriskQueueMember member = null;
            lock (members)
            {
                if (members.ContainsKey(location))
                {
                    member = members[location];                    
                }
            }
            if (member == null)
            {
                Trace.TraceError("Requested member at location " + location + " not found!");
            }
            return member;
        }

        /**
         * Removes a member From this queue.
         *
         * @param member the member to remove.
         */
        public void removeMember(AsteriskQueueMember member)
        {
            lock (members)
            {
                // Check if member exists
                if (!members.ContainsKey(member.Location))
                {
                    return;
                }
                // If so, remove the member.
                Trace.TraceInformation("Remove member from the queue " + name + ": "
                        + member.ToString());
                members.Remove(member.Location);
            }

            fireMemberRemoved(member);
        }

        #endregion

        #region entry related code
        /**
         * Gets an entry of the queue by its Channel Name.
         *
         * @param channelName The entry's Channel Name.
         * @return the queue entry if found, null otherwise.
         */

        public AsteriskQueueEntry getEntry(string channelName)
        {
            lock (entries)
            {
                foreach (AsteriskQueueEntry entry in entries)
                {
                    if (entry.Channel.Name.Equals(channelName))
                    {
                        return entry;
                    }
                }
            }
            return null;
        }

        /**
         * Gets an entry by its (estimated) Position in the queue.
         *
         * @param Position the Position, starting at 1.
         * @return the queue entry if exiting at this Position, null otherwise.
         */
        public AsteriskQueueEntry getEntry(int position)
        {
            // positions in asterisk start at 1, but list starts at 0
            position--;
            AsteriskQueueEntry foundEntry = null;
            lock (entries)
            {
                try
                {
                    foundEntry = entries[position];
                }
                catch (IndexOutOfRangeException e)
                {
                    // For consistency with the above method,
                    // swallow. We might indeed request the 1st one From time to time
                } // NOPMD
            }
            return foundEntry;
        }
        /**
         * Removes the given queue entry From the queue.<p>
         * Fires if needed:
         * <ul>
         * <li>PCE on Channel</li>
         * <li>EntryLeave on this queue</li>
         * <li>PCE on other queue entries if shifted</li>
         * </ul>
         *
         * @param entry        an existing entry object.
         * @param dateReceived the remove event was received.
         */
        public void removeEntry(AsteriskQueueEntry entry, DateTime dateReceived)
        {
            //lock (serviceLevelTimerTasks)
            //{
            //    if (serviceLevelTimerTasks.containsKey(entry))
            //    {
            //        ServiceLevelTimerTask timerTask = serviceLevelTimerTasks.get(entry);
            //        timerTask.cancel();
            //        serviceLevelTimerTasks.remove(entry);
            //    }
            //}

            bool changed;
            lock (entries)
            {
                changed = entries.Remove(entry);

                if (changed)
                {
                    // Keep the lock !
                    shift();
                }
            }

            // Fire outside lock
            if (changed)
            {
                //entry.Channel.setQueueEntry(null);
                entry.left(dateReceived);
                fireEntryLeave(entry);
            }
        }

        /**
        * Shifts the Position of the queue entries if needed
        * (and fire PCE on queue entries if appropriate).
        */
        private void shift()
        {
            int currentPos = 1; // Asterisk starts at 1

            lock (entries)
            {
                foreach (AsteriskQueueEntry qe in entries)
                {
                    // Only set (and fire PCE on qe) if necessary
                    if (qe.Position != currentPos)
                    {
                        qe.Position = currentPos;
                    }
                    currentPos++;
                }
            }
        }


        #endregion

        #region fire event
        private void fireMemberAdded(AsteriskQueueMember member)
        {
            if (MemberAdded == null) return;
            lock (MemberAdded)
            {
                MemberAdded(this, member);
            }
        }

        private void fireMemberRemoved(AsteriskQueueMember member)
        {
            if (MemberRemoved == null) return;
            lock (MemberRemoved)
            {
                MemberRemoved(this, member);
            }
        }

        void fireServiceLevelExceeded(AsteriskQueueEntry entry)
        {
            if (EntryServiceLevelExceeded == null) return;
            lock (EntryServiceLevelExceeded)
            {
                EntryServiceLevelExceeded(this, entry);
            }
        }

        private void fireNewEntry(AsteriskQueueEntry qe)
        {
            if (NewEntry == null) return;
            lock (NewEntry)
            {
                NewEntry(this, qe);
            }
        }

        private void fireEntryLeave(AsteriskQueueEntry entry)
        {
            if (EntryLeave == null) return;
            lock (EntryLeave)
            {
                EntryLeave(this, entry);
            }
        }

        internal void fireMemberStateChanged(AsteriskQueueMember member)
        {
            if (MemberStateChange == null) return;
            lock (MemberStateChange)
            {
                MemberStateChange(this, member);
            }
        }

        #endregion

        internal void cancelServiceLevelTimer()
        {
            //timer.cancel();
        }

        /// <summary>
        /// Creates a new AsteriskQueueEntry, adds it to this queue.
        /// Fires:
        /// * PCE on Channel
        /// * NewEntry on this queue
        /// * PCE on other queue entries if shifted (never happens)
        /// * NewQueueEntry on server
        /// </summary>
        /// <param Name="Channel">the Channel that joined the queue</param>
        /// <param Name="reportedPosition">the Position as given by Asterisk (currently not used)</param>
        /// <param Name="p">the date the Channel joined the queue</param>
        internal void createNewEntry(AsteriskChannel channel, int reportedPosition, DateTime dateReceived)
        {
            AsteriskQueueEntry qe = new AsteriskQueueEntry(server, this, channel, reportedPosition, dateReceived);

            //long delay = serviceLevel * 1000L;
            //if (delay > 0)
            //{
            //    ServiceLevelTimerTask timerTask = new ServiceLevelTimerTask(qe);
            //    timer.schedule(timerTask, delay);
            //    lock (serviceLevelTimerTasks)
            //    {
            //        serviceLevelTimerTasks.put(qe, timerTask);
            //    }
            //}

            lock (entries)
            {
                entries.Add(qe); // at the end of the list

                // Keep the lock !
                // This will fire PCE on the newly created queue entry
                // but hopefully this one has no listeners yet
                shift();
            }

            // Set the Channel property ony here as queue entries and channels
            // maintain a reciprocal reference.
            // That way property change on Channel and new entry event on queue will be
            // lanched when BOTH Channel and queue are correctly set.
            channel.QueueEntry = qe;
            fireNewEntry(qe);
            server.OnNewQueueEntry(qe);
        }

        #region INotifyAsteriskQueueChanged Members

        public event EntryEventHandler NewEntry;

        public event EntryEventHandler EntryLeave;

        public event EntryEventHandler EntryServiceLevelExceeded;

        public event MemberEventHandler MemberStateChange;

        public event MemberEventHandler MemberAdded;

        public event MemberEventHandler MemberRemoved;

        #endregion
    }
}
