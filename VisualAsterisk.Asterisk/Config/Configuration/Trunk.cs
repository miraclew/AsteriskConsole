using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class Trunk : ConfigurationItemBase
    {
        #region internal class members
        public Trunk(Trunk trunk)
        {
            copy(trunk);
        }

        protected override void copy(ConfigurationItemBase obj)
        {
            Trunk trunk = obj as Trunk;
            this.Allow = trunk.allow;
            this.Canreinvite = trunk.canreinvite;
            this.Cid = trunk.cid;
            this.Comment = trunk.comment;
            this.Contact = trunk.contact;
            this.Disallow = trunk.disallow;
            this.Fromdomain = trunk.fromdomain;
            this.Fromuser = trunk.fromuser;
            this.Host = trunk.host;
            this.Insecure = trunk.insecure;
            this.Number = trunk.number;
            this.Password = trunk.password;
            this.Port = trunk.port;
            this.Register = trunk.register;
            this.server = trunk.server;
            this.Trunkname = trunk.trunkname;
            this.TrunkTech = trunk.trunkTech;
            this.Username = trunk.username;
        }

        public Trunk(int number)
        {
            this.number = number;
        }
        private int number;
        /// <summary>
        /// Trunk Number, begin with 1
        /// </summary>
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        /// <summary>
        /// The Category Name in the User.conf for this trunk
        /// </summary>
        public string TrunkUserCategory
        {
            get { return "trunk_" + number.ToString(); }
        }

        public string Context
        {
            get { return "DID_trunk_" + number.ToString(); }
        }
        #endregion

        #region Trunk define
        private Tech trunkTech;
        private string comment;
        private bool register;
        private string host;
        private string username;
        private string password;

        public Tech TrunkTech
        {
            get { return trunkTech; }
            set { trunkTech = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public bool Register
        {
            get { return register; }
            set { register = value; }
        }

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion 

        #region Codec and Advanced Option
        private string trunkname;
        private string insecure;
        private string port;
        private string cid;
        private string fromdomain;
        private string fromuser;
        private string contact;
        private bool canreinvite;
        private string allow;
        private string disallow;

        public string Allow
        {
            get { return allow; }
            set { allow = value; }
        }

        public string Disallow
        {
            get { return disallow; }
            set { disallow = value; }
        }

        public string Trunkname
        {
            get { return trunkname; }
            set { trunkname = value; }
        }

        public string Insecure
        {
            get { return insecure; }
            set { insecure = value; }
        }

        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        public string Cid
        {
            get { return cid; }
            set { cid = value; }
        }

        public string Fromdomain
        {
            get { return fromdomain; }
            set { fromdomain = value; }
        }

        public string Fromuser
        {
            get { return fromuser; }
            set { fromuser = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public bool Canreinvite
        {
            get { return canreinvite; }
            set { canreinvite = value; }
        }
        #endregion

        internal void LoadUserConfig(ConfigFile file, string cat)
        {
            //this.Context = file.GetValue(cat, "Context");
            this.canreinvite = ConfigurationUtil.IsTrue(file.GetValue(cat, "canreinvite"));
            
            if (ConfigurationUtil.IsTrue(file.GetValue(cat, "hasiax")))
            {
                this.register = ConfigurationUtil.IsTrue(file.GetValue(cat, "registeriax"));
                this.trunkTech = Tech.IAX;
            }
            else if (ConfigurationUtil.IsTrue(file.GetValue(cat, "hassip")))
            {
                this.register = ConfigurationUtil.IsTrue(file.GetValue(cat, "registersip"));
                this.trunkTech = Tech.SIP;
            }
            else
            {
                this.trunkTech = Tech.ZAP;
            }
            
            this.host = file.GetValue(cat, "host");
            this.port = file.GetValue(cat, "port");
            this.password = file.GetValue(cat, "secret");
            this.username = file.GetValue(cat, "username");

            this.trunkname = file.GetValue(cat, "trunkname");
            this.insecure = file.GetValue(cat, "insecure");
            this.cid = file.GetValue(cat, "cid");
            this.fromdomain = file.GetValue(cat, "fromdomain");
            this.contact = file.GetValue(cat, "contact");

            this.allow = file.GetValue(cat, "allow");
            this.disallow = file.GetValue(cat, "disallow");
            this.fromuser = file.GetValue(cat, "fromuser");
            this.contact = file.GetValue(cat, "contact");
        }

        public override ConfigurationItemBase Copy()
        {
            return new Trunk(this);
        }
    }
}
