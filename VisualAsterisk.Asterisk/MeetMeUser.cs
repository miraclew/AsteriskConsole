using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk
{
    public class MeetMeUser : AsteriskObject
    {
        private const string COMMAND_PREFIX = "meetme";
        private const string MUTE_COMMAND = "mute";
        private const string UNMUTE_COMMAND = "unmute";
        private const string KICK_COMMAND = "kick";

        string PROPERTY_TALKING = "talking";
        string PROPERTY_MUTED = "muted";
        string PROPERTY_STATE = "state";

        private readonly AsteriskMeetMeRoom room;

        public AsteriskMeetMeRoom Room
        {
            get { return room; }
        }

        private readonly int userNumber;

        public int UserNumber
        {
            get { return userNumber; }
        }

        private readonly AsteriskChannel channel;

        public AsteriskChannel Channel
        {
            get { return channel; }
        }

        private readonly DateTime dateJoined;

        public DateTime DateJoined
        {
            get { return dateJoined; }
        }


        private DateTime dateLeft;

        public DateTime DateLeft
        {
            get { return dateLeft; }
            set { dateLeft = value; }
        }
        private MeetMeUserState state;
        private bool talking;

        public bool IsTalking
        {
            get { return talking; }
            set {
                bool oldTalking = talking;
                talking = value;
                firePropertyChange(PROPERTY_TALKING, oldTalking, talking);
            }
        }
        private bool muted;

        public bool IsMuted
        {
            get { return muted; }
            set {
                bool oldMuted = this.muted;
                muted = value;
                firePropertyChange(PROPERTY_MUTED, oldMuted, muted);                 
            }
        }

        public MeetMeUser(DefaultAsteriskServer server, AsteriskMeetMeRoom room, int userNumber,
            AsteriskChannel channel, DateTime dateJoined)
            : base(server)
        {
            this.room = room;
            this.userNumber = userNumber;
            this.channel = channel;
            this.dateJoined = dateJoined;
            this.state = MeetMeUserState.JOINED;
        }

        // Action methods

        public void kick()
        {
            sendMeetMeUserCommand(KICK_COMMAND);
        }

        public void mute()
        {
            sendMeetMeUserCommand(MUTE_COMMAND);
        }

        public void unmute()
        {
            sendMeetMeUserCommand(UNMUTE_COMMAND);
        }

        private void sendMeetMeUserCommand(string command)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(COMMAND_PREFIX);
            sb.Append(" ");
            sb.Append(command);
            sb.Append(" ");
            sb.Append(room.RoomNumber);
            sb.Append(" ");
            sb.Append(userNumber);

            server.SendAction(new CommandAction(sb.ToString()));
        }

        /**
         * Sets the status to {@link MeetMeUserState#LEFT} and dateLeft to the given date.
         * 
         * @param dateLeft the date this User left the room.
         */
        public void left(DateTime dateLeft)
        {
            MeetMeUserState oldState;
            lock (asteriskObjectLock)
            {
                oldState = this.state;
                this.dateLeft = dateLeft;
                this.state = MeetMeUserState.LEFT;
            }
            firePropertyChange(PROPERTY_STATE, oldState, state);
        }

        public override string ToString()
        {
            StringBuilder sb;
            int systemHashcode;

            sb = new StringBuilder("MeetMeUser[");

            lock (asteriskObjectLock)
            {
                sb.Append("dateJoined='").Append(this.DateJoined).Append("',");
                sb.Append("dateLeft='").Append(DateLeft).Append("',");
                sb.Append("talking=").Append(this.IsTalking).Append(",");
                sb.Append("muted=").Append(this.IsMuted).Append(",");
                sb.Append("room=").Append(room).Append(",");
                systemHashcode = this.GetHashCode();
            }
            sb.Append("channel=AsteriskChannel[");
            lock (channel)
            {
                sb.Append("id='").Append(channel.Id).Append("',");
                sb.Append("name='").Append(channel.Name).Append("'],");
            }
            sb.Append("systemHashcode=").Append(systemHashcode);
            sb.Append("]");

            return sb.ToString();
        }
    }
}
