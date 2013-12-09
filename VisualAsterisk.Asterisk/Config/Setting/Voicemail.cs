using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("voicemail.conf", "Voicemail Configuration")]
    public class Voicemail : ConfigFileBase
    {
        // [General]
        /*; Formats for writing Voicemail.  Note that when using IMAP storage for
; voicemail, only the First format specified will be used.
;format=g723sf|wav49|wav
*/
        bool format;

        [Category("General")]
        //[DefaultValue(false)]
        //[Description("Default Context for incoming calls")]
        public bool Format
        {
            get { return format; }
            set { format = value; }
        }

        /*Who the e-mail notification should appear to come From*/
        string serveremail;

        [Category("General")]
        [Description("Who the e-mail notification should appear to come from")]
        public string Serveremail
        {
            get { return serveremail; }
            set { serveremail = value; }
        }

        /*Should the email contain the voicemail as an attachment*/
        bool attach;

        [Category("General")]
        [Description("Should the email contain the voicemail as an attachment")]
        public bool Attach
        {
            get { return attach; }
            set { attach = value; }
        }

        /*; Maximum Number of messages per folder.  If not specified, a default Value
; (100) is used.  Maximum Value for this option is 9999.
*/
        int maxmsg;

        public int Maxmsg
        {
            get { return maxmsg; }
            set { maxmsg = value; }
        }
        /**/
        /**/
        /**/
        /**/
        /**/
        /**/
        /**/
        /**/
        /**/
        // [zonemessages]
        string eastern;
        string central;
        string central24;
        string military;
        string european;
        
        // [default]
        //int Maxmsg;

        //[Category("Default")]
        //[Description("Define maximum Number of messages per folder for a particular Context.")]
        //public int Maxmsg
        //{
        //    get { return Maxmsg; }
        //    set { Maxmsg = Value; }
        //}

        Hashtable mailbox;
        // [other]

    }
}
