using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk
{
    public class AsteriskMeetMeRoom : AsteriskObject
    {
        private const string COMMAND_PREFIX = "meetme";
        private const string LOCK_COMMAND = "lock";
        private const string UNLOCK_COMMAND = "unlock";

        private string roomNumber;

        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        /**
         * Maps userNumber to User.
         */
        private IDictionary<int, MeetMeUser> users;

        public AsteriskMeetMeRoom(DefaultAsteriskServer server, string roomNumber)
            : base(server)
        {
            this.roomNumber = roomNumber;
            this.users = new Dictionary<int, MeetMeUser>(20);
        }

        public IList<MeetMeUser> GetUsers()
        {
            lock (users)
            {
                return new List<MeetMeUser>(users.Values);
            }
        }

        public bool IsEmpty()
        {
            lock (users)
            {
                return users.Count <= 0;
            }
        }

        public void addUser(MeetMeUser user)
        {
            lock (users)
            {
                users.Add(user.UserNumber, user);
            }
        }

        public MeetMeUser GetUser(int userNumber)
        {
            lock (users)
            {
                if (users.ContainsKey(userNumber))
                {
                    return users[userNumber];
                }
                else
                    return null;
            }
        }

        public void removeUser(MeetMeUser user)
        {
            lock (users)
            {
                users.Remove(user.UserNumber);
            }
        }

        // Action methods

        public void Lock()
        {
            sendMeetMeCommand(LOCK_COMMAND);
        }

        public void Unlock()
        {
            sendMeetMeCommand(UNLOCK_COMMAND);
        }

        private void sendMeetMeCommand(string command)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(COMMAND_PREFIX);
            sb.Append(" ");
            sb.Append(command);
            sb.Append(" ");
            sb.Append(roomNumber);

            server.SendAction(new CommandAction(sb.ToString()));
        }

        public override string ToString()
        {
            StringBuilder sb;
            int systemHashcode;

            sb = new StringBuilder("MeetMeRoom[");

            lock (asteriskObjectLock)
            {
                sb.Append("roomNumber='").Append(RoomNumber).Append("',");
                systemHashcode = this.GetHashCode();
            }
            sb.Append("systemHashcode=").Append(systemHashcode);
            sb.Append("]");

            return sb.ToString();
        }

    }
}
