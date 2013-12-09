using System;
using System.Text;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Response;
using System.Collections.Generic;
using Asterisk.NET.Manager.Event;
using VisualAsterisk.Asterisk.Exception;
using System.Diagnostics;
using System.Text.RegularExpressions;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Configuration;

namespace VisualAsterisk.Asterisk
{
    public class MeetMeManager : IAsteriskServerComponent
    {
        private const string MEETME_LIST_COMMAND = "meetme list";
        private readonly Regex MEETME_LIST_PATTERN = new Regex("^User #: ([0-9]+).*Channel: (\\S+).*$");

        //private Log logger = LogFactory.getLog(getClass());
        private DefaultAsteriskServer server;
        private ChannelManager channelManager;
        private IAsteriskConfigManager configManager; 

        /**
         * Maps room Number to MeetMe room.
         */
        

        private IDictionary<string, AsteriskMeetMeRoom> rooms;

        public MeetMeManager(DefaultAsteriskServer server, IAsteriskConfigManager configManager, ChannelManager channelManager)
        {
            this.server = server;
            this.channelManager = channelManager;
            this.configManager = configManager;
            this.rooms = new Dictionary<string, AsteriskMeetMeRoom>();
        }

        public void Initialize()
        {
            lock (rooms)
            {
                rooms.Clear();
                foreach (ConferenceRoom item in configManager.ConferenceRooms)
                {
                    rooms.Add(item.RoomNumber, new AsteriskMeetMeRoom(server, item.RoomNumber));
                }

                foreach (AsteriskMeetMeRoom room in rooms.Values)
                {
                    populateRoom(room);
                }
            }
        }

        public void Disconnected()
        {
            lock (rooms)
            {
                rooms.Clear();
            }
        }

        /// <summary>
        /// Return meetme rooms which has users
        /// </summary>
        /// <returns></returns>
        public IList<AsteriskMeetMeRoom> getActiveMeetMeRooms()
        {
            IList<AsteriskMeetMeRoom> result;

            result = new List<AsteriskMeetMeRoom>();
            lock (rooms)
            {
                foreach (AsteriskMeetMeRoom room in rooms.Values)
                {
                    if (!room.IsEmpty())
                    {
                        result.Add(room);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Return all meetme rooms
        /// </summary>
        /// <returns></returns>
        public IList<AsteriskMeetMeRoom> getAsteriskMeetMeRooms()
        {
            IList<AsteriskMeetMeRoom> result;

            result = new List<AsteriskMeetMeRoom>();
            lock (rooms)
            {
                foreach (AsteriskMeetMeRoom room in rooms.Values)
                {
                    result.Add(room);
                }
            }
            return result;
        }

        internal void handleMeetMeEvent(AbstractMeetmeEvent e)
        {
            string roomNumber;
            int userNumber;
            AsteriskChannel channel;
            AsteriskMeetMeRoom room;
            MeetMeUser user;

            roomNumber = e.Meetme;
            if (roomNumber == null)
            {
                Trace.TraceWarning("RoomNumber (meetMe property) is null. Ignoring " + e.GetType().Name);
                return;
            }

            userNumber = e.Usernum;
            if (userNumber == null)
            {
                Trace.TraceWarning("UserNumber (userNum property) is null. Ignoring " + e.GetType().Name);
                return;
            }

            user = getOrCreateUser(e);
            if (user == null)
            {
                return;
            }

            channel = user.Channel;
            room = user.Room;

            if (e is MeetmeLeaveEvent)
            {
                Trace.TraceInformation("Removing channel " + channel.Name + " from room " + roomNumber);
                if (room != user.Room)
                {
                    if (user.Room != null)
                    {
                        Trace.TraceError("Channel " + channel.Name + " should be removed from room " + roomNumber
                                + " but is user of room " + user.Room.RoomNumber);
                        user.Room.removeUser(user);
                    }
                    else
                    {
                        Trace.TraceError("Channel " + channel.Name + " should be removed from room " + roomNumber
                                + " but is user of no room");
                    }
                }
                // Mmmm should remove From the room before firing PropertyChangeEvents ?
                user.left(e.DateReceived);
                room.removeUser(user);
                channel.MeetMeUser = null;
            }
            else if (e is MeetmeTalkingEvent)
            {
                bool status;

                status = ((MeetmeTalkingEvent)e).Status;
                user.IsTalking = status;
            }
            else if (e is MeetmeMuteEvent)
            {
                bool status;

                status = ((MeetmeMuteEvent)e).Status;
                user.IsMuted = status;
            }
        }

        private void populateRoom(AsteriskMeetMeRoom room)
        {
            CommandAction meetMeListAction;
            ManagerResponse response;
            List<string> lines;
            IList<int> userNumbers = new List<int>(); // list of User numbers in the room

            meetMeListAction = new CommandAction(MEETME_LIST_COMMAND + " " + room.RoomNumber);
            try
            {
                response = server.SendAction(meetMeListAction);
            }
            catch (ManagerCommunicationException e)
            {
                Trace.TraceError("Unable to send \"" + MEETME_LIST_COMMAND + "\" command", e);
                return;
            }
            if (response is ManagerError)
            {
                Trace.TraceError("Unable to send \"" + MEETME_LIST_COMMAND + "\" command: " + response.Message);
                return;
            }
            if (!(response is CommandResponse))
            {
                Trace.TraceError("Response to \"" + MEETME_LIST_COMMAND + "\" command is not a CommandResponse but "
                        + response.GetType());
                return;
            }

            lines = ((CommandResponse)response).Result;
            foreach (string line in lines)
            {
                MatchCollection matches;
                int userNumber;
                AsteriskChannel channel;
                bool muted = false;
                bool talking = false;
                MeetMeUser channelUser;
                MeetMeUser roomUser;

                matches = MEETME_LIST_PATTERN.Matches(line);
                if (matches.Count <= 0)
                {
                    continue;
                }

                userNumber = int.Parse(matches[0].Groups[1].Value);
                channel = channelManager.getChannelByName(matches[0].Groups[2].Value);

                userNumbers.Add(userNumber);

                if (line.Contains("(Admin Muted)") || line.Contains("(Muted)"))
                {
                    muted = true;
                }

                if (line.Contains("(talking)"))
                {
                    talking = true;
                }

                channelUser = channel.MeetMeUser;
                if (channelUser != null && channelUser.Room != room)
                {
                    channelUser.left(DateTime.Now);
                    channelUser = null;
                }

                roomUser = room.GetUser(userNumber);
                if (roomUser != null && roomUser.Channel != channel)
                {
                    room.removeUser(roomUser);
                    roomUser = null;
                }

                if (channelUser == null && roomUser == null)
                {
                    MeetMeUser user;
                    // using the current date as dateJoined is not correct but we
                    // don't have anything that is better
                    user = new MeetMeUser(server, room, userNumber, channel, DateTime.Now);
                    user.IsMuted = muted;
                    user.IsTalking = talking;
                    room.addUser(user);
                    channel.MeetMeUser = user;
                    server.OnNewMeetMeUser(user);
                }
                else if (channelUser != null && roomUser == null)
                {
                    channelUser.IsMuted = muted;
                    room.addUser(channelUser);
                }
                else if (channelUser == null)
                {
                    roomUser.IsMuted = muted;
                    channel.MeetMeUser = roomUser;
                }
                else
                {
                    if (channelUser != roomUser)
                    {
                        Trace.TraceError("Inconsistent state: channelUser != roomUser, channelUser=" + channelUser + ", roomUser="
                                + roomUser);
                    }
                }
            }

            IList<MeetMeUser> users = room.GetUsers();
            IList<MeetMeUser> usersToRemove = new List<MeetMeUser>();
            foreach (MeetMeUser user in users)
            {
                if (!userNumbers.Contains(user.UserNumber))
                {
                    // remove User as he is no longer in the room
                    usersToRemove.Add(user);
                }
            }
            foreach (MeetMeUser user in usersToRemove)
            {
                user.left(DateTime.Now);
                room.removeUser(user);
                user.Channel.MeetMeUser = null;
            }
        }

        private MeetMeUser getOrCreateUser(AbstractMeetmeEvent e)
        {
            string roomNumber;
            AsteriskMeetMeRoom room;
            string uniqueId;
            AsteriskChannel channel;
            MeetMeUser user;

            roomNumber = e.Meetme;
            room = getOrCreateRoom(roomNumber);
            user = room.GetUser(e.Usernum);
            if (user != null)
            {
                return user;
            }

            // ok create a new one
            uniqueId = e.UniqueId;
            if (uniqueId == null)
            {
                //Trace.TraceWarning("UniqueId is null. Ignoring MeetMeEvent");
                return null;
            }

            channel = channelManager.getChannelById(uniqueId);
            if (channel == null)
            {
                //Trace.TraceWarning("No Channel with unique Id " + uniqueId + ". Ignoring MeetMeEvent");
                return null;
            }

            user = channel.MeetMeUser;
            if (user != null)
            {
                Trace.TraceError("Got MeetMeEvent for channel " + channel.Name + " that is already user of a room");
                user.left(e.DateReceived);
                if (user.Room != null)
                {
                    user.Room.removeUser(user);
                }
                channel.MeetMeUser = null;
            }

            Trace.TraceInformation("Adding channel " + channel.Name + " as user " + e.Usernum + " to room " + roomNumber);
            user = new MeetMeUser(server, room, e.Usernum, channel, e.DateReceived);
            room.addUser(user);
            channel.MeetMeUser = user;
            server.OnNewMeetMeUser(user);

            return user;
        }

        /**
         * Returns the room with the given Number or creates a new one if none is
         * there yet.
         *
         * @param RoomNumber Number of the room to get or create.
         * @return the room with the given Number.
         */
        internal AsteriskMeetMeRoom getOrCreateRoom(string roomNumber)
        {
            AsteriskMeetMeRoom room;
            bool created = false;

            lock (rooms)
            {
                if (rooms.ContainsKey(roomNumber))
                {
                    room = rooms[roomNumber];
                }
                else
                {
                    room = new AsteriskMeetMeRoom(server, roomNumber);
                    populateRoom(room);
                    rooms.Add(roomNumber, room);
                    created = true;
                }
            }

            if (created)
            {
                Trace.WriteLine("Created AsteriskMeetMeRoom " + roomNumber);
            }

            return room;
        }
    }
}
