using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Exception;
using Asterisk.NET.Manager.Response;

namespace VisualAsterisk.Asterisk
{
    public class AsteriskQueueMember : AsteriskObject
    {
        string PROPERTY_STATE = "state";
        string PROPERTY_PENALTY = "penalty";
        string PROPERTY_PAUSED = "paused";
        #region basic property
        private AsteriskQueue queue;

        public AsteriskQueue Queue
        {
            get { return queue; }
        }
        private QueueMemberState state;
        /// <summary>
        /// Get/Set the status of this queue member.<br/>
        /// Available since Asterisk 1.2<br/>
        /// Valid status codes are:
        /// <dl>
        /// <dt>AST_DEVICE_UNKNOWN (0)</dt>
        /// <dd>Queue member is available</dd>
        /// <dt>AST_DEVICE_NOT_INUSE (1)</dt>
        /// <dd>?</dd>
        /// <dt>AST_DEVICE_INUSE (2)</dt>
        /// <dd>?</dd>
        /// <dt>AST_DEVICE_BUSY (3)</dt>
        /// <dd>?</dd>
        /// <dt>AST_DEVICE_INVALID (4)</dt>
        /// <dd>?</dd>
        /// <dt>AST_DEVICE_UNAVAILABLE (5)</dt>
        /// <dd>?</dd>
        /// </dl>
        /// </summary>
        public QueueMemberState State
        {
            get { return state; }
            set { state = value; }
        }


        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private int penalty;
        /// <summary>
        /// Get/Set the penalty for the added member. When calls are distributed Members with higher penalties are considered Last.
        /// </summary>
        public int Penalty
        {
            get { return penalty; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Penalty must not be negative");
                }
                //ManagerResponse response = server.SendAction(
                //new QueuePenaltyAction(Location, penalty, queue));
                //if (response is ManagerError)
                //{
                //    throw new InvalidPenaltyException("Unable to set penalty for '" + Location + "' on '" +
                //            queue.Name + "': " + response.Message);
                //}
                penalty = value;
            }
        }
        private bool paused;

        public bool Paused
        {
            get { return paused; }
            set { paused = value; }
        }
        private string membership;

        public string Membership
        {
            get { return membership; }
        }
        #endregion

        #region detailed property
        private string memberName;

        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }
        private int callsTaken;
        /// <summary>
        /// Get/Set the Number of calls answered by the member.
        /// </summary>
        public int CallsTaken
        {
            get { return callsTaken; }
            set { callsTaken = value; }
        }
        private DateTime lastCall;
        /// <summary>
        /// Get/Set the time (in seconds since 01/01/1970) the Last successful call answered by the added member was hungup.
        /// </summary>
        public DateTime LastCall
        {
            get { return lastCall; }
            set { lastCall = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        /**
         * Creates a new queue member.
         *
         * @param server     server this Channel belongs to.
         * @param queue      queue this member is registered to.
         * @param Location   Location of member.
         * @param State      State of this member.
         * @param paused     <code>true</code> if this member is currently paused, <code>false</code> otherwise.
         * @param penalty    penalty of this member.
         * @param membership "dynamic" if the added member is a dynamic queue member, "static"
         *                   if the added member is a static queue member.
         */
        public AsteriskQueueMember(DefaultAsteriskServer server,
                                AsteriskQueue queue, string location,
                                QueueMemberState state, bool paused,
                                int penalty, string membership)
            : base(server)
        {
            this.queue = queue;
            this.location = location;
            this.state = state;
            this.penalty = penalty;
            this.paused = paused;
            this.membership = membership;
        }

        public bool isStatic()
        {
            return membership != null && "static".Equals(membership);
        }

        public bool isDynamic()
        {
            return membership != null && "dynamic".Equals(membership);
        }

        internal void pausedChanged(bool paused)
        {
            lock (asteriskObjectLock)
            {
                bool oldPaused = this.paused;
                this.paused = paused;
                firePropertyChange(PROPERTY_PAUSED, oldPaused, paused);
            }
        }

        internal void stateChanged(QueueMemberState state)
        {
            lock (asteriskObjectLock)
            {
                QueueMemberState oldState = this.state;
                this.state = state;
                firePropertyChange(PROPERTY_STATE, oldState, state);
            }
        }

        internal void penaltyChanged(int penalty)
        {
            lock (asteriskObjectLock)
            {
                int oldPenalty = this.penalty;
                this.penalty = penalty;
                firePropertyChange(PROPERTY_PENALTY, oldPenalty, penalty);
            }
        }

    }
}
