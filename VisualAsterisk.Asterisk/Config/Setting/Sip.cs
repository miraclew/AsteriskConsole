using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("sip.conf", "sip configuration file")]
    public class Sip : ConfigFileBase
    {
        public Sip()
        {
            List<PropertyInfo> general = new List<PropertyInfo>();
            categories.Add("General", general);

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
        }
        #region [General]
        string context;

        [Category("General")]
        //[DefaultValue(false)]
        [Description("Default context for incoming calls")]
        public string Context
        {
            get { return context; }
            set { context = value; }
        }
        bool allowguest;

        [Category("General")]
        [DefaultValue(true)]
        [Description("Allow or reject guest calls (default is yes)")]
        public bool Allowguest
        {
            get { return allowguest; }
            set { allowguest = value; }
        }
        bool allowoverlap;

        [Category("General")]
        [DefaultValue(true)]
        [Description(" Disable overlap dialing support. (Default is yes)")]
        public bool Allowoverlap
        {
            get { return allowoverlap; }
            set { allowoverlap = value; }
        }
        bool allowtransfer;
        [Category("General")]
        [DefaultValue(true)]
        [Description("Disable all transfers (unless enabled in peers or users) Default is enabled")]
        public bool Allowtransfer
        {
            get { return allowtransfer; }
            set { allowtransfer = value; }
        }

        /*; Realm for digest authentication
				; defaults to "asterisk". If you set a system Name in
				; asterisk.conf, it defaults to that system Name
				; Realms MUST be globally unique according to RFC 3261
				; Set this to your Host Name or domain Name*/
        string realm;

        [Category("General")]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Realm
        {
            get { return realm; }
            set { realm = value; }
        }
        int bindport;

        [Category("General")]
        [DefaultValue(5060)]
        [Description("UDP Port to bind to (SIP standard port is 5060) bindport is the local UDP port that Asterisk will listen on")]
        public int Bindport
        {
            get { return bindport; }
            set { bindport = value; }
        }
        string bindaddr;

        [Category("General")]
        [Description("IP address to bind to (0.0.0.0 binds to all")]
        public string Bindaddr
        {
            get { return bindaddr; }
            set { bindaddr = value; }
        }
        /*; Enable DNS SRV lookups on outbound calls
				; Note: Asterisk only uses the First Host 
				; in SRV records
				; Disabling DNS SRV lookups disables the 
				; ability to place SIP calls based on domain 
				; names to some other SIP Users on the Internet*/
        bool srvlookup;

        [Category("General")]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Srvlookup
        {
            get { return srvlookup; }
            set { srvlookup = value; }
        }
        /*; Set default domain for this Host
				; If configured, Asterisk will only Allow
				; INVITE and REFER to non-local domains
				; Use "sip show domains" to list local domains*/
        string domain;

        [Category("General")]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        /*; Enable checking of tags in headers, 
				; international character conversions in URIs
				; and multiline formatted headers for strict
				; SIP compatibility (defaults to "no")*/
        bool pedantic;

        [Category("General")]
        [DefaultValue(false)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Pedantic
        {
            get { return pedantic; }
            set { pedantic = value; }
        }
        string tos_sip;

        [Category("General")]
        [Description("Sets TOS for SIP packets.")]
        public string Tos_sip
        {
            get { return tos_sip; }
            set { tos_sip = value; }
        }
        string tos_audio;

        [Category("General")]
        [Description("Sets TOS for RTP audio packets.")]
        public string Tos_audio
        {
            get { return tos_audio; }
            set { tos_audio = value; }
        }
        string tos_video;

        [Category("General")]
        [Description("Sets TOS for RTP video packets.")]
        public string Tos_video
        {
            get { return tos_video; }
            set { tos_video = value; }
        }

        int maxexpiry;

        [Category("General")]
        [Description("Maximum allowed time of incoming registrations and subscriptions (seconds)")]
        public int Maxexpiry
        {
            get { return maxexpiry; }
            set { maxexpiry = value; }
        }
        int minexpiry;

        [Category("General")]
        [DefaultValue(60)]
        [Description("Minimum length of registrations/subscriptions (default 60)")]
        public int Minexpiry
        {
            get { return minexpiry; }
            set { minexpiry = value; }
        }
        int defaultexpiry;

        [Category("General")]
        [Description("Default length of incoming/outgoing registration")]
        public int Defaultexpiry
        {
            get { return defaultexpiry; }
            set { defaultexpiry = value; }
        }
        int t1min;

        [Category("General")]
        [DefaultValue(100)]
        [Description("Minimum roundtrip time for messages to monitored hosts Defaults to 100 ms")]
        public int T1min
        {
            get { return t1min; }
            set { t1min = value; }
        }
        string notifymimetype;

        [Category("General")]
        [Description("Allow overriding of mime type in MWI NOTIFY")]
        public string Notifymimetype
        {
            get { return notifymimetype; }
            set { notifymimetype = value; }
        }
        int checkmwi;

        [Category("General")]
        [Description("Default time between mailbox checks for peers")]
        public int Checkmwi
        {
            get { return checkmwi; }
            set { checkmwi = value; }
        }

        /*Cisco SIP firmware doesn't support the MWI RFC
				; fully. Enable this option to not get error messages
				; when sending MWI to phones with this bug.*/
        int buggymwi;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public int Buggymwi
        {
            get { return buggymwi; }
            set { buggymwi = value; }
        }
        // TODO: miss some 
        string language;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        List<string> registers;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        [AstConfigProperty(AstConfigPropertyClass.Object, Name = "register")]
        public List<string> Registers
        {
            get { return registers; }
            set { registers = value; }
        }
        int registertimeout;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public int Registertimeout
        {
            get { return registertimeout; }
            set { registertimeout = value; }
        }
        int registerattempts;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public int Registerattempts
        {
            get { return registerattempts; }
            set { registerattempts = value; }
        }
        /// ----- NAT support -----
        string externip;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Externip
        {
            get { return externip; }
            set { externip = value; }
        }
        string externhost;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Externhost
        {
            get { return externhost; }
            set { externhost = value; }
        }
        int externrefresh;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public int Externrefresh
        {
            get { return externrefresh; }
            set { externrefresh = value; }
        }
        string localnet;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Localnet
        {
            get { return localnet; }
            set { localnet = value; }
        }

        /*; Global NAT settings  (Affects all peers and Users)
                                ; yes = Always ignore info and assume NAT
                                ; no = Use NAT mode only according to RFC3581 (;rport)
                                ; never = Never attempt NAT mode or RFC3581 support
				; route = Assume NAT, don't send rport 
				; (work around More UNIDEN bugs)*/
        bool nat;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Nat
        {
            get { return nat; }
            set { nat = value; }
        }
        /// ------- MEDIA HANDLING -------
        /*; Asterisk by default tries to redirect the
				; RTP media stream (audio) to go directly From
				; the caller to the callee.  Some devices do not
				; support this (especially if one of them is behind a NAT).
				; The default setting is YES. If you have all clients
				; behind a NAT, or for some other reason wants Asterisk to
				; stay in the audio path, you may want to turn this off.

				; In Asterisk 1.4 this setting also affect direct RTP
				; at call setup (a new feature in 1.4 - setting up the
				; call directly between the endpoints instead of sending
				; a re-INVITE).*/
        bool canreinvite;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Canreinvite
        {
            get { return canreinvite; }
            set { canreinvite = value; }
        }
        
        /*; Enable the new experimental direct RTP setup. This sets up
				; the call directly with media Peer-2-Peer without re-invites.
				; Will not work for video and cases where the callee sends 
				; RTP payloads and fmtp headers in the 200 OK that does not Match the
				; callers INVITE. This will also fail if Canreinvite is enabled when
				; the device is actually behind NAT.*/
        bool directrtpsetup;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Directrtpsetup
        {
            get { return directrtpsetup; }
            set { directrtpsetup = value; }
        }

        /*; An additional option is to Allow media path redirection
				; (reinvite) but only when the Peer where the media is being
				; sent is known to not be behind a NAT (as the RTP core can
				; determine it based on the apparent IP address the media
				; arrives From).*/

        /*;----------------------------------------- REALTIME SUPPORT ------------------------
; For additional information on ARA, the Asterisk Realtime Architecture,
; please Read realtime.txt and extconfig.txt in the /doc directory of the
; source code.
;*/
        /*; Cache realtime friends by adding them to the internal list
				; just like friends added From the config file only on a
				; as-needed basis? (yes|no)*/
        bool rtcachefriends;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Rtcachefriends
        {
            get { return rtcachefriends; }
            set { rtcachefriends = value; }
        }

        /*; Save systemname in realtime database at registration
				; Default= no*/
        bool rtsavesysname;

        [Category("General")]
        [DefaultValue(false)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Rtsavesysname
        {
            get { return rtsavesysname; }
            set { rtsavesysname = value; }
        }
        
        /*; Send registry updates to database using realtime? (yes|no)
				; If set to yes, when a SIP UA registers successfully, the ip address,
				; the origination Port, the registration period, and the Username of
				; the UA will be set to database via realtime. 
				; If not present, defaults to 'yes'.*/
        bool rtupdate;

        [Category("General")]
        [DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Rtupdate
        {
            get { return rtupdate; }
            set { rtupdate = value; }
        }

        /*; Enabling this setting has two functions:
                ;
                ; For non-realtime peers, when their registration expires, the
                ; information will _not_ be removed From memory or the Asterisk database
                ; if you attempt to place a call to the Peer, the existing information
                ; will be used in spite of it having expired
                ;
                ; For realtime peers, when the Peer is retrieved From realtime storage,
                ; the registration information will be used regardless of whether
                ; it has expired or not; if it expires while the realtime Peer 
                ; is still in memory (due to caching or other reasons), the 
                ; information will not be removed From realtime storage*/
        bool ignoreregexpire;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Ignoreregexpire
        {
            get { return ignoreregexpire; }
            set { ignoreregexpire = value; }
        }
        /*;----------------------------------------- SIP DOMAIN SUPPORT ------------------------
; Incoming INVITE and REFER messages can be matched against a list of 'allowed'
; domains, each of which can direct the call to a specific Context if desired.
; By default, all domains are accepted and sent to the default Context or the
; Context associated with the User/Peer placing the call.
; Domains can be specified using:
; domain=<domain>[,<Context>]
; Examples:
; domain=myasterisk.dom
; domain=customer.com,customer-Context
;
; In addition, all the 'default' domains associated with a server should be
; added if incoming request filtering is desired.
; autodomain=yes
;
; To Disallow requests for domains not serviced by this server:
; allowexternaldomains=no*/

        /*; Add domain and configure incoming Context
				; for external calls to this domain
                ; Add IP address as local domain
				; You can have several "domain" settings*/
        List<string> domains;

        [Category("General")]
        //[Description("Allow or reject guest calls (default is yes)")]
        public List<string> Domains
        {
            get { return domains; }
            set { domains = value; }
        }
        
        /*; Disable INVITE and REFER to non-local domains
				; Default is yes*/
        bool allowexternaldomains;

        [Category("General")]
        [DefaultValue(true)]
        [Description("Disable INVITE and REFER to non-local domains(default is yes)")]
        public bool Allowexternaldomains
        {
            get { return allowexternaldomains; }
            set { allowexternaldomains = value; }
        }

        /*; Turn this on to have Asterisk add local Host
				; Name and local IP to domain list.*/
        bool autodomain;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Autodomain
        {
            get { return autodomain; }
            set { autodomain = value; }
        }

        /*; When making outbound SIP INVITEs to
                          	; non-peers, use your primary domain "identity"
                          	; for From: headers instead of just your IP
                          	; address. This is to be polite and
                          	; it may be a mandatory requirement for some
                          	; destinations which do not have a prior
                          	; account relationship with your server.*/
        string fromdomain;

        [Category("General")]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Fromdomain
        {
            get { return fromdomain; }
            set { fromdomain = value; }
        }
        /*;------------------------------ JITTER BUFFER CONFIGURATION --------------------------*/

        /* ; Enables the use of a jitterbuffer on the receiving side of a
                              ; SIP Channel. Defaults to "no". An enabled jitterbuffer will
                              ; be used only if the sending side can create and the receiving
                              ; side can not accept jitter. The SIP Channel can accept jitter,
                              ; thus a jitterbuffer on the receive SIP side will be used only
                              ; if it is forced and enabled.*/
        bool jbenable;

        [Category("General")]
        //[DefaultValue(true)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public bool Jbenable
        {
            get { return jbenable; }
            set { jbenable = value; }
        }
        
        /*; Forces the use of a jitterbuffer on the receive side of a SIP
                              ; Channel. Defaults to "no".*/
        bool jbforce;

        [Category("General")]
        [DefaultValue(false)]
        [Description("Forces the use of a jitterbuffer on the receive side of a SIP channel. Defaults to \"no\".")]
        public bool Jbforce
        {
            get { return jbforce; }
            set { jbforce = value; }
        }

        /*; Max length of the jitterbuffer in milliseconds.*/
        int jbmaxsize;

        [Category("General")]
        [Description("Max length of the jitterbuffer in milliseconds.")]
        public int Jbmaxsize
        {
            get { return jbmaxsize; }
            set { jbmaxsize = value; }
        }

        /*; Jump in the frame timestamps over which the jitterbuffer is
                              ; resynchronized. Useful to improve the quality of the voice, with
                              ; big jumps in/broken timestamps, usually sent From exotic devices
                              ; and programs. Defaults to 1000.*/
        int jbresyncthreshold;

        [Category("General")]
        [DefaultValue(1000)]
        //[Description("Allow or reject guest calls (default is yes)")]
        public int Jbresyncthreshold
        {
            get { return jbresyncthreshold; }
            set { jbresyncthreshold = value; }
        }

        /*; Jitterbuffer implementation, used on the receiving side of a SIP
                              ; Channel. Two implementations are currently available - "fixed"
                              ; (with size always equals to jbmaxsize) and "adaptive" (with
                              ; Variable size, actually the new jb of IAX2). Defaults to fixed.*/
        string jbimpl;

        [Category("General")]
        //[Description("Allow or reject guest calls (default is yes)")]
        public string Jbimpl
        {
            get { return jbimpl; }
            set { jbimpl = value; }
        }

        /*; Enables jitterbuffer frame logging. Defaults to "no".*/
        bool jblog;

        [Category("General")]
        [DefaultValue(false)]
        [Description("Enables jitterbuffer frame logging. Defaults to \"no\"")]
        public bool Jblog
        {
            get { return jblog; }
            set { jblog = value; }
        }
        /**/
        #endregion

        // [authentication]
        // TODO: 

        /// ------- SIP devices -------
        protected override void LoadCategory(AstCategory cat)
        {

        }



    }
}
