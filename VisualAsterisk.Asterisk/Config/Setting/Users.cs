using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("users.conf", "User configuration")]
    public class Users : ConfigFileBase
    {
        public Users()
        {
            users = new List<User>();
        }

        private List<User> users;

        [AstConfigProperty(AstConfigPropertyClass.CategoryCollection)]
        public List<User> UserList
        {
            get { return users; }
        }

        User defaultUser;

        [AstConfigProperty(AstConfigPropertyClass.Category)]
        public User DefaultUser
        {
            get { return defaultUser; }
            set { defaultUser = value; }
        }

        protected override void Clear()
        {
            base.Clear();
            defaultUser = null;
            users.Clear();
        }

        protected override void LoadCategory(AstCategory cat)
        {
            if (cat.Name == "general")
            {
                defaultUser = new User();
                defaultUser.Category = cat.Name;
                setProperties(defaultUser, cat);
            }
            else
            {
                User user = new User();
                if (defaultUser != null)
                {
                    user.SetDefault(defaultUser); // copy General settings 
                }
                user.Category = cat.Name;
                setProperties(user, cat);
                users.Add(user);
            }            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", defaultUser.ToString());
            foreach (User var in users)
            {
                sb.AppendFormat("{0}", var.ToString());
            }
            return sb.ToString();
        }

        protected override bool SetGeneralProperties
        {
            get { return false; }
        }
    }

    [UILabel("Users:")]
    [UIDisplayMemeberAttribute("Category")]
    [Description("")]
    public class User
    {
        private string category;

        //[Browsable(false)]
        //[ReadOnly(true)]
        [UIItem("Extension:", UIItemType.DETAIL, 0, "")]
        [Description("The numbered extension, i.e. 1234, that will be associated with this particular User / Phone.")]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string fullName;

        [UIItem("Name:", UIItemType.DETAIL, 0, "")]
        [Description("A character-based name for this user, i.e. \"Bob Jones\" ")]
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        private string secret;

        [UIItem("Password:", UIItemType.DETAIL, 0, "")]
        [Description("The password for the user's sip/iax account , Ex: \"12u3b6\" ")]
        public string Secret
        {
            get { return secret; }
            set { secret = value; }
        }

        private string vmsecret;

        [UIItem("VM Password:", UIItemType.DETAIL, 0, "")]
        [Description("Voicemail Password for this user, Ex: \"1234\".")]
        public string Vmsecret
        {
            get { return vmsecret; }
            set { vmsecret = value; }
        }
        private string email;

        [UIItem("E-mail:", UIItemType.DETAIL, 0, "")]
        [Description("The e-mail address for this user, i.e. \"bobjones@bobjones.null\"")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        string cid_number;

        [UIItem("Caller ID:", UIItemType.DETAIL, 0, "")]
        [Description("The Caller ID (CID) string used when this user calls another user or number, i.e. \"800-555-1234\"")]
        public string Cid_number
        {
            get { return cid_number; }
            set { cid_number = value; }
        }

        private int zapchan = -1;

        [UIItem("Analog Phone:", UIItemType.DETAIL, 0, "")]
        [Description("If this user is attached to an analog port on the system, please choose the port number here.")]
        public int Zapchan
        {
            get { return zapchan; }
            set { zapchan = value; }
        }

        private string context;

        [UIItem("Dial Plan:", UIItemType.DETAIL, 0, "")]
        [Description("Please choose the Calling Rule plan for this user as defined under the \"Calling Rules\" option to the left.")]
        public string Context
        {
            get { return context; }
            set { context = value; }
        }
        // TODO: Phone Serial:

        #region Extension Options:
        private bool hasVoicemail;

        [UIItem("Voicemail", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Check this box if the user should have a voicemail account.")]
        public bool HasVoicemail
        {
            get { return hasVoicemail; }
            set { hasVoicemail = value; }
        }

        private bool hasdirectory;

        [UIItem("In Directory", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Check this option if the user is to be listed in the telephone directory.")]
        public bool Hasdirectory
        {
            get { return hasdirectory; }
            set { hasdirectory = value; }
        }

        private bool hasSip;
        
        [UIItem("SIP", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Check this option if the User or Phone is using SIP or is a SIP device.")]
        public bool HasSip
        {
            get { return hasSip; }
            set { hasSip = value; }
        }
        private bool hasiax;

        
        [UIItem("IAX", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Check this option if the User or Phone is using IAX or is an IAX device.")]
        public bool Hasiax
        {
            get { return hasiax; }
            set { hasiax = value; }
        }

        private bool hasagent;

        [UIItem("Is Agent", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Check this option if this User or Phone is an Call Queue Member (Agent)")]
        public bool Hasagent
        {
            get { return hasagent; }
            set { hasagent = value; }
        }

        // TODO : don't know which item should map to CTI option in asterisk-gui, map it to HasH323 for now
        //[UIItem("CTI", UIItemType.DETAIL, 0, "Extension Options:")]
        //[Description("Check this option if the User is allowed to connect client applications to the Asterisk server.")]
        private bool callWaiting;

        [UIItem("Call Waiting", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Check this option if the User or Phone should have Call-Waiting capability.")]
        public bool CallWaiting
        {
            get { return callWaiting; }
            set { callWaiting = value; }
        }
        private bool threeWayCalling;

        [UIItem("3-Way Calling", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Check this option if the User or Phone should have 3-Way Calling capability.")]
        public bool ThreeWayCalling
        {
            get { return threeWayCalling; }
            set { threeWayCalling = value; }
        }

        private bool canreinvite;

        [UIItem("Can Reinvite", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("This option can be used to tell the Asterisk server whethere or not to issue a reinvite to the client.")]
        public bool Canreinvite
        {
            get { return canreinvite; }
            set { canreinvite = value; }
        }

        private string dtmfmode;

        [UIItem("DTMFMode", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description(@"Set default dtmfmode for sending DTMF. Default: rfc2833 
Other options:
info : SIP INFO messages
inband : Inband audio (requires 64 kbit codec -alaw, ulaw)
auto : Use rfc2833 if offered, inband otherwise
")]
        public string Dtmfmode
        {
            get { return dtmfmode; }
            set { dtmfmode = value; }
        }

        private string insecure;

        [UIItem("Insecure", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description(@"Matching of IP for a peer without matching port, do not require authentication of invites.

Options are:

    * Port
    * Invite
    * port,invite
")]
        public string Insecure
        {
            get { return insecure; }
            set { insecure = value; }
        }

        string disallow;

        [UIItem("Disallow", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Click to select the codecs that asterisk has to offer, for the particular user.")]
        public string Disallow
        {
            get { return disallow; }
            set { disallow = value; }
        }
        string allow;

        [UIItem("Allow", UIItemType.DETAIL, 0, "Extension Options:")]
        [Description("Click to select the codecs that asterisk has to offer, for the particular user.")]
        public string Allow
        {
            get { return allow; }
            set { allow = value; }
        }
        #endregion

        #region Non UI
        private bool hasH323;

        public bool HasH323
        {
            get { return hasH323; }
            set { hasH323 = value; }
        }
        private bool hasManager;

        public bool HasManager
        {
            get { return hasManager; }
            set { hasManager = value; }
        }
        private bool callWaitingCallerid;

        public bool CallWaitingCallerid
        {
            get { return callWaitingCallerid; }
            set { callWaitingCallerid = value; }
        }
        private bool transfer;

        public bool Transfer
        {
            get { return transfer; }
            set { transfer = value; }
        }
        private bool canPark;

        public bool CanPark
        {
            get { return canPark; }
            set { canPark = value; }
        }
        private bool canCallForward;

        public bool CanCallForward
        {
            get { return canCallForward; }
            set { canCallForward = value; }
        }
        private bool callReturn;

        public bool CallReturn
        {
            get { return callReturn; }
            set { callReturn = value; }
        }

        #endregion

        private int userBase;

        public int UserBase
        {
            get { return userBase; }
            set { userBase = value; }
        }


        private int callGroup;

        public int CallGroup
        {
            get { return callGroup; }
            set { callGroup = value; }
        }
        private int pickupGroup;

        public int PickupGroup
        {
            get { return pickupGroup; }
            set { pickupGroup = value; }
        }

        private UserHost host;

        public UserHost Host
        {
            get { return host; }
            set { host = value; }
        }
        private UserType type;

        public UserType Type
        {
            get { return type; }
            set { type = value; }
        }

        public void SetDefault(User defaultUser)
        {
            if (defaultUser != null)
            {
                this.callGroup = defaultUser.callGroup;
                this.callReturn = defaultUser.callReturn;
                this.callWaiting = defaultUser.callWaiting;
                this.callWaitingCallerid = defaultUser.callWaitingCallerid;
                this.canCallForward = defaultUser.canCallForward;
                this.canPark = defaultUser.canPark;
                this.category = defaultUser.category; // need ?
                this.context = defaultUser.context;
                this.email = defaultUser.email;
                this.fullName = defaultUser.fullName;
                this.hasH323 = defaultUser.hasH323;
                this.hasiax = defaultUser.hasiax;
                this.hasManager = defaultUser.hasManager;
                this.hasSip = defaultUser.hasSip;
                this.hasVoicemail = defaultUser.hasVoicemail;
                this.host = defaultUser.host;
                this.pickupGroup = defaultUser.pickupGroup;
                this.secret = defaultUser.secret;
                this.threeWayCalling = defaultUser.threeWayCalling;
                this.transfer = defaultUser.transfer;
                this.type = defaultUser.type;
                this.userBase = defaultUser.userBase; // need ?
                this.vmsecret = defaultUser.vmsecret;
                this.zapchan = defaultUser.zapchan; // need ?
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[{0}]\n", category);
            foreach (PropertyInfo var in this.GetType().GetProperties())
            {
                sb.AppendFormat("{0}", ConfigFileBase.PropertyToString(var, this));
            }
            return sb.ToString();
        }

    }

    public enum UserType
    {
        Friend = 0, Peer = 1, User = 2
    }
    public enum UserHost
    {
        Static = 0, Dynamic = 1
    }

}
