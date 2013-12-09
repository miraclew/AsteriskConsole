using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class UserExtension : ConfigurationItemBase, IExtension, IConfiguration
    {
        #region internal class members
        public UserExtension()
            : this(null)
        {
        }

        public UserExtension(UserExtension defaultUser)
        {
            if (defaultUser != null)
            {
                copy(defaultUser); 
            }
        }

        public override ConfigurationItemBase Copy()
        {
            return new UserExtension(this);
        }

        protected override void copy(ConfigurationItemBase obj)
        {
            UserExtension user = obj as UserExtension;
            // set property to notify property change
            this.FullName = user.fullName;
            this.Password = user.secret;
            this.Vmsecret = user.vmsecret;
            this.Context = user.context;
            this.Email = user.email;

            this.HasVoicemail = user.hasvoicemail;
            this.Hasdirectory = user.hasdirectory;
            this.Hasagent = user.hasagent;
            this.Hasiax = user.hasiax;
            this.HasSip = user.hassip;
            this.HasSip = user.hasCTI;
            this.CallWaiting = user.callwaiting;
            this.ThreeWayCalling = user.threewaycalling;
            this.Canreinvite = user.canreinvite;
            this.Nat = user.nat;
            this.Dtmfmode = user.dtmfmode;
            this.Disallow = user.disallow;
            this.Allow = user.allow;
        }

        #endregion
        
        #region [general]
        private string userbase;
        private int localextenlength;
        private string operatorExtension;
        private bool allow_aliasextns;
        private bool allow_an_extns;
        private string login_exten;
        private string login_callback_exten;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "login_exten")]
        public string LoginExten
        {
            get { return login_exten; }
            set { login_exten = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "login_callback_exten")]
        public string LoginCallbackExten
        {
            get { return login_callback_exten; }
            set { login_callback_exten = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "userbase")]
        public string Userbase
        {
            get { return userbase; }
            set
            {
                firePropertyChange("userbase", userbase, value);
                userbase = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "localextenlength")]
        public int LocalExtenLength
        {
            get { return localextenlength; }
            set
            {
                firePropertyChange("localextenlength", localextenlength, value);
                localextenlength = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "operatorExtension")]
        public string OperatorExtension
        {
            get { return operatorExtension; }
            set
            {
                firePropertyChange("operatorExtension", operatorExtension, value);
                operatorExtension = value;
            }
        }

        /// <summary>
        /// Allow analog phones to be assigned to multiple extensions
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "allow_aliasextns")]
        [Description("Allow analog phones to be assigned to multiple extensions")]
        public bool AllowAliasExtns
        {
            get { return allow_aliasextns; }
            set
            {
                firePropertyChange("allow_aliasextns", allow_aliasextns, value);
                allow_aliasextns = value;
            }
        }

        /// <summary>
        /// Allow extensions to be AlphaNumeric (SIP/IAX users)
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "allow_an_extns")]
        [Description("Allow extensions to be AlphaNumeric (SIP/IAX users)")]
        public bool AllowAlphaNumericExtns
        {
            get { return allow_an_extns; }
            set
            {
                firePropertyChange("allow_an_extns", allow_an_extns, value);
                allow_an_extns = value;
            }
        }
        #endregion
        
        #region User Extension define

        private string category;
        private string fullName;
        private string secret;
        private string vmsecret;
        private string email;
        string cid_number;
        private int? zapchan;
        private string context;

        [Description("The numbered extension, i.e. 1234, that will be associated with this particular User / Phone.")]
        public string Category
        {
            get { return category; }
            set {
                firePropertyChange("Category", category, value);
                category = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "fullname")]
        [Description("A character-based name for this user, i.e. \"Bob Jones\" ")]
        public string FullName
        {
            get { return fullName; }
            set
            {
                firePropertyChange("FullName", fullName, value);
                fullName = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "secret")]
        [Description("The password for the user's sip/iax account , Ex: \"12u3b6\" ")]
        public string Password
        {
            get { return secret; }
            set
            {
                firePropertyChange("Password", secret, value);
                secret = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "vmsecret")]
        [Description("Voicemail Password for this user, Ex: \"1234\".")]
        public string Vmsecret
        {
            get { return vmsecret; }
            set
            {
                firePropertyChange("Vmsecret", vmsecret, value);
                vmsecret = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "email")]
        [Description("The e-mail address for this user, i.e. \"bobjones@bobjones.null\"")]
        public string Email
        {
            get { return email; }
            set
            {
                firePropertyChange("Email", email, value);
                email = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "cid_number")]
        [Description("The Caller ID (CID) string used when this user calls another user or number, i.e. \"800-555-1234\"")]
        public string CidNumber
        {
            get { return cid_number; }
            set
            {
                firePropertyChange("CidNumber", cid_number, value);
                cid_number = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "zapchan")]
        [Description("If this user is attached to an analog port on the system, please choose the port number here.")]
        public int? Zapchan
        {
            get { return zapchan; }
            set
            {
                firePropertyChange("Zapchan", zapchan, value);
                zapchan = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "context")]
        [Description("Please choose the Calling Rule plan for this user as defined under the \"Calling Rules\" option to the left.")]
        public string Context
        {
            get { return context; }
            set
            {
                firePropertyChange("Context", context, value);
                context = value;
            }
        }
        // TODO: Phone Serial:
        #endregion

        #region Extension Options:
        private bool hasvoicemail;
        private bool hasdirectory;
        private bool hassip;
        private bool hasiax;
        private bool hasagent;
        private bool hasCTI;
        private bool callwaiting;
        private bool threewaycalling;
        private bool canreinvite;
        private bool nat;
        private string dtmfmode;
        private string insecure;

        private string disallow;
        private string allow;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "hasvoicemail")]
        [Description("Check this box if the user should have a voicemail account.")]
        public bool HasVoicemail
        {
            get { return hasvoicemail; }
            set
            {
                firePropertyChange("HasVoicemail", hasvoicemail, value);
                hasvoicemail = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "hasdirectory")]
        [Description("Check this option if the user is to be listed in the telephone directory.")]
        public bool Hasdirectory
        {
            get { return hasdirectory; }
            set
            {
                firePropertyChange("Hasdirectory", hasdirectory, value);
                hasdirectory = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "hassip")]
        [Description("Check this option if the User or Phone is using SIP or is a SIP device.")]
        public bool HasSip
        {
            get { return hassip; }
            set
            {
                firePropertyChange("HasSip", hassip, value);
                hassip = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "hasiax")]
        [Description("Check this option if the User or Phone is using IAX or is an IAX device.")]
        public bool Hasiax
        {
            get { return hasiax; }
            set
            {
                firePropertyChange("Hasiax", hasiax, value);
                hasiax = value;
            }
        }

        // TODO: [ConfigurationProperty(ConfigurationPropertyType.Var, "")]
        [Description("Computer Telephony Integration: Check this option if the user is allowed to connect client applications to the Asterisk server.")]
        public bool HasCTI
        {
            get { return hasCTI; }
            set
            {
                //firePropertyChange("HasCTI", a, Value);
                hasCTI = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "hasagent")]
        [Description("Check this option if this User or Phone is an Call Queue Member (Agent)")]
        public bool Hasagent
        {
            get { return hasagent; }
            set
            {
                firePropertyChange("Hasagent", hasagent, value);
                hasagent = value;
            }
        }

        // TODO : don't know which item should map to CTI option in asterisk-gui, map it to HasH323 for now
        //[UIItem("CTI", UIItemType.DETAIL, 0, "Extension Options:")]
        //[Description("Check this option if the User is allowed to connect client applications to the Asterisk server.")]

        [ConfigurationProperty(ConfigurationPropertyType.Var, "callwaiting")]
        [Description("Check this option if the User or Phone should have Call-Waiting capability.")]
        public bool CallWaiting
        {
            get { return callwaiting; }
            set
            {
                firePropertyChange("CallWaiting", callwaiting, value);
                callwaiting = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "threewaycalling")]
        [Description("Check this option if the User or Phone should have 3-Way Calling capability.")]
        public bool ThreeWayCalling
        {
            get { return threewaycalling; }
            set
            {
                firePropertyChange("ThreeWayCalling", threewaycalling, value);
                threewaycalling = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "canreinvite")]
        [Description("This option can be used to tell the Asterisk server whethere or not to issue a reinvite to the client.")]
        public bool Canreinvite
        {
            get { return canreinvite; }
            set
            {
                firePropertyChange("Canreinvite", canreinvite, value);
                canreinvite = value;
            }
        }


        [ConfigurationProperty(ConfigurationPropertyType.Var, "nat")]
        [Description("NAT: Try this setting when Asterisk is on a public IP, communicating with devices hidden behind a NAT device (broadband router). If you have one-way audio problems, you usually have problems with your NAT configuration or your firewall's support of SIP+RTP ports.")]
        public bool Nat
        {
            get { return nat; }
            set
            {
                firePropertyChange("Nat", nat, value);
                nat = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "dtmfmode")]
        [Description(@"Set default dtmfmode for sending DTMF. Default: rfc2833 
Other options:
info : SIP INFO messages
inband : Inband audio (requires 64 kbit codec -alaw, ulaw)
auto : Use rfc2833 if offered, inband otherwise
")]
        public string Dtmfmode
        {
            get { return dtmfmode; }
            set
            {
                firePropertyChange("Dtmfmode", dtmfmode, value);
                dtmfmode = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "insecure")]
        [Description(@"Matching of IP for a peer without matching port, do not require authentication of invites.

Options are:

    * Port
    * Invite
    * port,invite
")]
        public string Insecure
        {
            get { return insecure; }
            set
            {
                firePropertyChange("Insecure", insecure, value);
                insecure = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "disallow")]
        [Description("Click to select the codecs that asterisk has to offer, for the particular user.")]
        public string Disallow
        {
            get { return disallow; }
            set
            {
                firePropertyChange("Disallow", disallow, value);
                disallow = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "allow")]
        [Description("Click to select the codecs that asterisk has to offer, for the particular user.")]
        public string Allow
        {
            get { return allow; }
            set {
                firePropertyChange("Allow", allow, value);
                allow = value;
            }
        }
        #endregion

        #region IExtension 成员

        public string Extension
        {
            get { return this.Category; }
            set { this.Category = value; }
        }

        public string Descripton
        {
            get
            {
                return fullName;
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
    }
}
