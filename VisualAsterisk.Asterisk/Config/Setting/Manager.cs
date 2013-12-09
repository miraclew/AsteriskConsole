using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using VisualAsterisk.Asterisk.Config.Configuration;

namespace VisualAsterisk.Asterisk.Config
{
    /*
; AMI - The Asterisk Manager Interface
; 
; Third party Application call management support and PBX event supervision
;
; This configuration file is Read every time someone logs in
;
; Use the "manager list commands" at the CLI to list available manager commands
; and their authorization levels.
;
; "manager show command <command>" will show a help text.
;
; ---------------------------- SECURITY NOTE -------------------------------
; Note that you should not enable the AMI on a public IP address. If needed,
; block this TCP Port with iptables (or another FW software) and reach it
; with IPsec, SSH, or SSL vpn tunnel.  You can also make the manager 
; interface available over http if Asterisk's http server is enabled in
; http.conf and if both "enabled" and "webenabled" are set to yes in
; this file.  Both default to no.  httptimeout provides the maximum 
; Timeout1 in seconds before a web based session is discarded.  The 
; default is 60 seconds.
    */

    [AstConfigFile("manager.conf", "AMI - The Asterisk Manager Interface")]
    public class Manager : ConfigFileBase
    {
        public Manager()
        {

        }
        #region general category

        bool displaysystemname;

        [Category("General")]
        [Description("")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "displaysystemname")]
        public bool Displaysystemname
        {
            get { return displaysystemname; }
            set { displaysystemname = value; }
        }
        bool enabled;

        [Category("General")]
        [Description("")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "enabled")]
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }
        bool webenabled;

        [Category("General")]
        [Description("")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "webenabled")]
        public bool Webenabled
        {
            get { return webenabled; }
            set { webenabled = value; }
        }
        int port;

        [Category("General")]
        [Description("")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "port")]
        public int Port
        {
            get { return port; }
            set { port = value; }
        }
        /*
; a) httptimeout sets the Max-Age of the http cookie
; b) httptimeout is the amount of time the webserver waits 
;    on a Action=waitevent request (actually its httptimeout-10)
; c) httptimeout is also the amount of time the webserver keeps 
;    a http session alive after completing a successful Action
         */
        int httptimeout;

        [Category("General")]
        [Description(@" a) httptimeout sets the Max-Age of the http cookie
 b) httptimeout is the amount of time the webserver waits 
    on a action=waitevent request (actually its httptimeout-10)
 c) httptimeout is also the amount of time the webserver keeps 
    a http session alive after completing a successful action
")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "httptimeout")]
        public int Httptimeout
        {
            get { return httptimeout; }
            set { httptimeout = value; }
        }

        string bindaddr;

        [Category("General")]
        [Description("")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "bindaddr")]
        public string Bindaddr
        {
            get { return bindaddr; }
            set { bindaddr = value; }
        }
        bool displayconnects;

        [Category("General")]
        [Description("")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "displayconnects")]
        public bool Displayconnects
        {
            get { return displayconnects; }
            set { displayconnects = value; }
        }
        /*Add a Unix epoch timestamp to events (not Action responses)*/
        bool timestampevents;

        [Category("General")]
        [Description("")]
        [ConfigurationProperty(ConfigurationPropertyType.Var, "timestampevents")]
        public bool Timestampevents
        {
            get { return timestampevents; }
            set { timestampevents = value; }
        }
        #endregion

        #region manager user category
        private string secret;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "secret")]
        public string Secret
        {
            get { return secret; }
            set { secret = value; }
        }
        private string deny;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "deny")]
        public string Deny
        {
            get { return deny; }
            set { deny = value; }
        }
        private string permit;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "permit")]
        public string Permit
        {
            get { return permit; }
            set { permit = value; }
        }
        private int writetimeout;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "writetimeout")]
        public int Writetimeout
        {
            get { return writetimeout; }
            set { writetimeout = value; }
        }
        private string read;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "read")]
        public string Read
        {
            get { return read; }
            set { read = value; }
        }
        private string write;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "write")]
        public string Write
        {
            get { return write; }
            set { write = value; }
        }
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[{0}]\n", "general");
            foreach (PropertyInfo var in this.GetType().GetProperties())
            {
                sb.AppendFormat("{0}", ConfigFileBase.PropertyToString(var, this));
            }
            return sb.ToString();
        }
    }
}
