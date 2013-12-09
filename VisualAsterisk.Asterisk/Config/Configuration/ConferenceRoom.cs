using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class ConferenceRoom : ConfigurationItemBase, IExtension, IConfiguration
    {
        public ConferenceRoom()
        {
              
        }

        public ConferenceRoom(ConferenceRoom room)
        {
            copy(room);
        }

        #region extensions.conf
        private string optionString;
        
        /// <summary>
        /// For example in config line : exten => 8000,1,MeetMe(${EXTEN}|MI)
        /// OptionString return MI
        /// </summary>
        public string OptionString
        {
            get {
                if (musicforfirstuser && optionString.IndexOf('M') == -1)
                {
                    optionString = optionString + "M";
                }
                else if (!musicforfirstuser && optionString.IndexOf('M') != -1)
                {
                    optionString = optionString.Remove(optionString.IndexOf('M'));
                }

                if (enablecallermenu && optionString.IndexOf('s') == -1)
                {
                    optionString = optionString + "s";
                }
                else if (!enablecallermenu && optionString.IndexOf('s') != -1)
                {
                    optionString = optionString.Remove(optionString.IndexOf('s'));
                }

                if (announcecallers && optionString.IndexOf('I') == -1)
                {
                    optionString = optionString + "I";
                }
                else if (!announcecallers && optionString.IndexOf('I') != -1)
                {
                    optionString = optionString.Remove(optionString.IndexOf('I'));
                }

                if (quietmode && optionString.IndexOf('q') == -1)
                {
                    optionString = optionString + "q";
                }
                else if (!quietmode && optionString.IndexOf('q') != -1)
                {
                    optionString = optionString.Remove(optionString.IndexOf('q'));
                }

                if (waitformarkeduser && optionString.IndexOf('w') == -1)
                {
                    optionString = optionString + "w";
                }
                else if (!waitformarkeduser && optionString.IndexOf('w') != -1)
                {
                    optionString = optionString.Remove(optionString.IndexOf('w'));
                }

                if (setmarkeduser && optionString.IndexOf('A') == -1)
                {
                    optionString = optionString + "A";
                }
                else if (!setmarkeduser && optionString.IndexOf('A') != -1)
                {
                    optionString = optionString.Remove(optionString.IndexOf('A'));
                }

                return optionString; 
            }
            set {
                optionString = value;
                musicforfirstuser = optionString.IndexOf('M') != -1 ? true:false;
                enablecallermenu = optionString.IndexOf('s') != -1 ? true : false;
                announcecallers = optionString.IndexOf('I') != -1 ? true : false;
                quietmode = optionString.IndexOf('q') != -1 ? true : false;
                waitformarkeduser = optionString.IndexOf('w') != -1 ? true : false;
                setmarkeduser = optionString.IndexOf('A') != -1 ? true : false;
            }
        }
        
        /// <summary>
        /// For example in config line : exten => 8000,1,MeetMe(${EXTEN}|MI)
        /// MeetMeApplicationString return MeetMe(${EXTEN}|MI)
        /// </summary>
        public string MeetMeApplicationString
        {
            get
            {
                return string.Format("MeetMe(${{EXTEN}}|{0})", OptionString); // two {{ to escape
            }
        }

        /// <summary>
        /// get: Return a exten config line in [default] in extensions.conf
        /// 
        /// For example in config line : exten => 8000,1,MeetMe(${EXTEN}|MI)
        /// ExtenConfigString return 8000,1,MeetMe(${EXTEN}|MI)
        /// </summary>
        public string ExtenConfigString
        {
            get
            {
                return string.Format("{0},1,{1}", roomNumber, MeetMeApplicationString);
            }
        }
        #endregion

        #region meetme.conf

        private string roomsConfigString;
        /// <summary>
        /// get: Return a conf config line of [rooms] in meetme.conf
        /// set: Load a conf config line of [rooms] in meetme.conf
        /// </summary>
        public string ConfConfigString
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}", roomNumber);
                if (pin.Length > 0)
                {
                    sb.AppendFormat(",{0}", pin);
                    if (adminPin.Length > 0)
                    {
                        sb.AppendFormat(",{0}", adminPin);
                    }
                }
                roomsConfigString = sb.ToString();
                return roomsConfigString; 
            }
            set 
            {
                
                roomsConfigString = value;

                int index1 = roomsConfigString.IndexOf(',');
                int index2 = roomsConfigString.IndexOf(',', index1 + 1);
                if (index1 > 0)
                {
                    this.roomNumber = roomsConfigString.Substring(0, index1).Trim();
                    if (index2 > 0)
                    {
                        this.pin = roomsConfigString.Substring(index1 + 1, index2 - index1 - 1).Trim();
                        this.adminPin = roomsConfigString.Substring(index2 + 1).Trim();
                    }
                    else
                        this.pin = roomsConfigString.Substring(index1 + 1).Trim();

                }
                else
                    this.roomNumber = roomsConfigString.Trim();

            }
        }
        #endregion 

        #region Conference Room define
        private string roomNumber;
        private string pin;
        private string adminPin;

        [Description("This is the number dialed to reach this Conference Bridge.")]
        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        [Description("Defining this option, i.e. \"1234\" sets a code that must be entered in order to access the Conference Bridge.")]
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        [Description("Defining this option sets a PIN for Conference Administrators.")]
        public string AdminPin
        {
            get { return adminPin; }
            set { adminPin = value; }
        }
        #endregion

        #region Conference Room Options

        bool musicforfirstuser;
        bool enablecallermenu;
        bool announcecallers;
        bool quietmode;
        bool waitformarkeduser;
        bool setmarkeduser;

        [Description("Play Hold Music for First Caller: Checking this option causes Asterisk to play Hold Music to the first user in a conference, until another user has joined the same conference.")]
        public bool Musicforfirstuser
        {
            get { return musicforfirstuser; }
            set { musicforfirstuser = value; }
        }

        [Description("Enable Caller Menu: Checking this option allows a user to access the Conference Bridge menu by pressing the * key on their dialpad.")]
        public bool Enablecallermenu
        {
            get { return enablecallermenu; }
            set
            {
                enablecallermenu = value; 
                changeExtenString();
            }
        }

        [Description("Checking this option announces, to all Bridge participants, the joining of any other participants.")]
        public bool Announcecallers
        {
            get { return announcecallers; }
            set
            {
                announcecallers = value;
                changeExtenString();
            }
        }

        [Description("Do not play enter/leave sounds")]
        public bool Quietmode
        {
            get { return quietmode; }
            set
            {
                quietmode = value;
                changeExtenString();
            }
        }

        [Description("If this option is set, then users joining the conference will not be able to speak to one-another until the marked user has joined the conference.")]
        public bool Waitformarkeduser
        {
            get { return waitformarkeduser; }
            set
            {
                waitformarkeduser = value;
                changeExtenString();
            }
        }

        [Description("This option sets the person that enters the bridge using this extension as Marked. This option works in conjunction with the obove \"Wait for marked user\" option.")]
        public bool Setmarkeduser
        {
            get { return setmarkeduser; }
            set
            {
                setmarkeduser = value;
                changeExtenString();
            }
        }

        #endregion


        #region IExtension 成员

        public string Extension
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }
        public string Descripton
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
        #region IConfiguration 成员

        public void LoadUsersConfig(ConfigFile file, string cat)
        {
            throw new NotImplementedException();
        }

        public void LoadExtensionsConfig(VisualAsterisk.Asterisk.Config.Dialplan.ExtensionsConfigFile file, Category cat)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEditableObject members
        public override ConfigurationItemBase Copy()
        {
            return new ConferenceRoom(this);
        }

        protected override void copy(ConfigurationItemBase obj)
        {
            ConferenceRoom conferenceRoom = obj as ConferenceRoom;
            this.AdminPin = conferenceRoom.adminPin;
            this.Announcecallers = conferenceRoom.announcecallers;
            this.Enablecallermenu = conferenceRoom.enablecallermenu;
            this.Musicforfirstuser = conferenceRoom.musicforfirstuser;
            this.Pin = conferenceRoom.pin;
            this.Quietmode = conferenceRoom.quietmode;
            this.RoomNumber = conferenceRoom.roomNumber;
            this.Setmarkeduser = conferenceRoom.setmarkeduser;
            this.Waitformarkeduser = conferenceRoom.waitformarkeduser;
        }

        private void changeExtenString()
        {

            if (!editing) return;
            ConfigurationChange change = new ConfigurationChange();
            change.Filename = "extensions.conf";
            change.Action = UpdateConfigAction.ACTION_UPDATE;
            change.Category = "default";
            change.Variable = "exten";
            change.Value = this.ExtenConfigString;
            change.Match = this.RoomNumber; // duplicate change should be removed 
            addChange(change);
        }

        #endregion
    }
}
