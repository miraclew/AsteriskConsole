using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("meetme.conf","Configuration file for MeetMe simple conference rooms for Asterisk of course.This configuration file is read every time you call app meetme()")]
    public class Meetme : ConfigFileBase
    {
        public Meetme()
        {
            categories.Add("General", new List<PropertyInfo>());
            categories.Add("Rooms", new List<PropertyInfo>());

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(AstConfigPropertyAttribute), false);
                object[] cats = pi.GetCustomAttributes(typeof(CategoryAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    AstConfigPropertyAttribute pro = pros[0] as AstConfigPropertyAttribute;
                    if (pro.Exclude)
                    {
                        continue;
                    }
                }

                if (cats != null && cats.Length > 0)
                {
                    CategoryAttribute c = cats[0] as CategoryAttribute;
                    categories[c.Category].Add(pi);
                }
            }

            confrooms = new List<ConfRoom>();
        }
        int audiobuffers;


        [Category("General"), Description("The number of 20ms audio buffers to be used when feeding audio frames from non-Zap channels into the conference; larger numbers will allow for the conference to 'de-jitter' audio that arrives at different timing than the conference's timing source, but can also allow for latency in hearing the audio from the speaker. Minimum value is 2, maximum value is 32.")]
        public int Audiobuffers
        {
            get { return audiobuffers; }
            set { audiobuffers = value; }
        }

        List<ConfRoom> confrooms;

        [Category("Rooms"), Browsable(false), Description("Usage is conf => confno[,pin][,adminpin] \r\nNote that once a participant has called the conference, a change to the pin number done in this file will not take effect until there are no more users in the conference and it goes away.  When it is created again, it will have the new pin number.")]
        [AstConfigProperty(AstConfigPropertyClass.Object, Name = "conf")]
        public List<ConfRoom> Conf
        {
            get { return confrooms; }
            set { confrooms = value; }
        }

        protected override void LoadCategory(AstCategory cat)
        {
            if (cat.Name.Equals("rooms"))
            {
                foreach (AstVariable var in cat.Variables)
                {
                    if (var.Name == "conf" && var.IsObject == 1)
                    {
                        ConfRoom room = new ConfRoom();
                        int index1 = var.Value.IndexOf(',');
                        int index2 = var.Value.IndexOf(',', index1 + 1);
                        if (index1 > 0)
                        {
                            room.Confno = var.Value.Substring(0, index1).Trim();
                            if (index2 > 0)
                            {
                                room.Pin = var.Value.Substring(index1 + 1, index2 - index1 - 1).Trim();
                                room.Adminpin = var.Value.Substring(index2 + 1).Trim();
                            }
                            else
                                room.Pin = var.Value.Substring(index1 + 1).Trim();

                        }
                        else
                            room.Confno = var.Value.Trim();

                        confrooms.Add(room);                        
                    }
                   
                }
            }

        }
    }

    [UILabel("Conference Bridges:")]
    [UIDisplayMemeberAttribute("Confno")]
    [Description("")]
    public class ConfRoom
    {
        public ConfRoom()
        {
            confno = "";
            pin = "";
            adminpin = "";
        }
        private string confno;

        [UIItem("Extension:", UIItemType.DETAIL, 0, "")]
        [Description("This is the number dialed to reach this Conference Bridge.")]
        public string Confno
        {
            get { return confno; }
            set { confno = value; }
        }
        private string pin;

        [UIItem("PIN Code:", UIItemType.DETAIL, 1, "Password Settings:")]
        [Description("Defining this option, i.e. \"1234\" sets a code that must be entered in order to access the Conference Bridge.")]
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        private string adminpin;

        [UIItem("Admin PIN Code:", UIItemType.DETAIL, 2, "Password Settings:")]
        [Description("Defining this option sets a PIN for Conference Administrators.")]
        public string Adminpin
        {
            get { return adminpin; }
            set { adminpin = value; }
        }

        // Conference Room Options:
        bool musicforfirstuser;

        [UIItem("Play hold music for first caller", UIItemType.DETAIL, 3, "Conference Room Options:")]
        [Description("If this option is set, then users joining the conference will not be able to speak to one-another until the marked user has joined the conference.")]
        public bool Musicforfirstuser
        {
            get { return musicforfirstuser; }
            set { musicforfirstuser = value; }
        }

        bool enablecallermenu;

        [UIItem("Enable caller menu", UIItemType.DETAIL, 4, "Conference Room Options:")]
        [Description("Checking this option causes Asterisk to play Hold Music to the first user in a conference, until another user has joined the same conference.")]
        //[DefaultValue()]
        public bool Enablecallermenu
        {
            get { return enablecallermenu; }
            set { enablecallermenu = value; }
        }

        bool announcecallers;

        [UIItem("Announce Callers", UIItemType.DETAIL, 5, "Conference Room Options:")]
        [Description("Checking this option announces, to all Bridge participants, the joining of any other participants.")]
        public bool Announcecallers
        {
          get { return announcecallers; }
          set { announcecallers = value; }
        }

        bool queuemode;

        [UIItem("Quiet Mode", UIItemType.DETAIL, 6, "Conference Room Options:")]
        [Description("Do not play enter/leave sounds")]
        public bool Queuemode
        {
            get { return queuemode; }
            set { queuemode = value; }
        }

        bool waitformarkeduser;

        [UIItem("Wait for marked user", UIItemType.DETAIL, 7, "Conference Room Options:")]
        [Description("If this option is set, then users joining the conference will not be able to speak to one-another until the marked user has joined the conference.")]
        public bool Waitformarkeduser
        {
            get { return waitformarkeduser; }
            set { waitformarkeduser = value; }
        }

        bool setmarkeduser;

        [UIItem("Set marked user", UIItemType.DETAIL, 8, "Conference Room Options:")]
        [Description("This option sets the person that enters the bridge using this extension as Marked. This option works in conjunction with the obove \"Wait for marked user\" option.")]
        public bool Setmarkeduser
        {
            get { return setmarkeduser; }
            set { setmarkeduser = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("conf => {0}", confno);
            if (pin.Length > 0)
            {
                sb.AppendFormat(",{0}", pin);
                if (adminpin.Length > 0)
                {
                    sb.AppendFormat(",{0}", adminpin);
                }
            }
            sb.Append("\n");
            return sb.ToString();
        }
    }
}
