using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public class AsteriskQueueEntry : AsteriskObject
    {
        string PROPERTY_STATE = "state";
        string PROPERTY_POSITION = "position";
        string PROPERTY_REPORTED_POSITION = "reportedPosition";
        int POSITION_UNDETERMINED = -1;

        private AsteriskQueue queue;

        public AsteriskQueue Queue
        {
            get { return queue; }
        }
        private AsteriskChannel channel;

        public AsteriskChannel Channel
        {
            get { return channel; }
        }
        private DateTime dateJoined;

        public DateTime DateJoined
        {
            get { return dateJoined; }
        }
        private DateTime dateLeft;

        public DateTime DateLeft
        {
            get { return dateLeft; }
        }

        private QueueEntryState state;

        public QueueEntryState State
        {
            get { return state; }
        }

        // the Position as given by asterisk in the queue entry or join event.
        // we cannot work reliably with it because asterisk doesn't tell us when it shifts the entries.
        private int reportedPosition;

        public int ReportedPosition
        {
            get { return reportedPosition; }
            set { reportedPosition = value; }
        }

        // The Position of this entry in our representation of the queue. Will be set
        // and maintained by the respective queue when the entry is added/removed/shifted
        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public AsteriskQueueEntry(DefaultAsteriskServer server, AsteriskQueue queue,
                               AsteriskChannel channel, int reportedPosition, DateTime dateJoined)
            : base(server)
        {
            this.queue = queue;
            this.channel = channel;
            this.dateJoined = dateJoined;
            this.state = QueueEntryState.JOINED;
            this.reportedPosition = reportedPosition;

            position = POSITION_UNDETERMINED;
        }

        /**
         * Sets the status to {@link QueueEntryState#LEFT} and dateLeft to the given date.
         *
         * @param dateLeft the date this member left the queue.
         */
        
        internal void left(DateTime dateLeft)
        {
            QueueEntryState oldState;
            lock (asteriskObjectLock)
            {
                oldState = this.state;
                this.dateLeft = dateLeft;
                this.state = QueueEntryState.LEFT;
            }
            firePropertyChange(PROPERTY_STATE, oldState, state);
        }
    }
}
