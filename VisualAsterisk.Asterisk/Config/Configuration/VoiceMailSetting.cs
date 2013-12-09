using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class VoiceMailSetting : IExtension
    {
        #region Voice Mail define
        private string extension;
        private bool attach;
        private int maxgreet;
        private bool _operator;

        /// <summary>
        /// Attach recording to e-mail: This option defines whether or not voicemails are sent to the Users' e-mail addresses as attachments.
        /// </summary>
        /// 
        [ConfigurationProperty(ConfigurationPropertyType.Var, "attach")]
        public bool Attach
        {
            get { return attach; }
            set { attach = value; }
        }

        /// <summary>
        /// Max Greeting (seconds): Defining this option sets a maximum time for a users's voicemail away message.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "maxgreet")]
        public int MaxGreet
        {
            get { return maxgreet; }
            set { maxgreet = value; }
        }

        /// <summary>
        /// Dail 'O' for Operator: Checking this option enables callers entering the voicemail application to dial '0' to back out of the application and be sent to a voicemenu or operator.
        /// Note:You have to configure an Operator Extension from the 'Options' panel.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "operator")]
        public bool Operator
        {
            get { return _operator; }
            set { _operator = value; }
        }

        #endregion

        #region Message Options
        private string attachfmt;
        private int maxmsg;
        private int maxmessage;
        private int minmessage;

        /// <summary>
        /// Attach Format: This selection box controls the format in which messages are delivered by e-mail.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "attachfmt")]
        public string Attachfmt
        {
            get { return attachfmt; }
            set { attachfmt = value; }
        }

        /// <summary>
        /// Maximum messages per folder: This select box sets the maximum Number of messages that a User may have in any of their folders.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "maxmsg")]
        public int Maxmsg
        {
            get { return maxmsg; }
            set { maxmsg = value; }
        }

        /// <summary>
        /// Maximum Message Time: This select box sets the maximum duration of a voicemail message. Message recording will not occur for times greater than this amount.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "maxmessage")]
        public int Maxmessage
        {
            get { return maxmessage; }
            set { maxmessage = value; }
        }

        /// <summary>
        /// Minimum message Time: This select box sets the minimum duration of a voicemail message. Messages below this threshold will be automatically deleted.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "minmessage")]
        public int Minmessage
        {
            get { return minmessage; }
            set { minmessage = value; }
        }
        #endregion

        #region Playback Options
        private bool delete;
        private bool saycid;
        private bool sayduration;
        private bool envelope;
        private bool review;

        /// <summary>
        /// Send messages by e-mail only: If this option is set, then voicemails will not be checkable using a Phone. Messages will be sent via e-mail, only.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "delete")]
        public bool Delete
        {
            get { return delete; }
            set { delete = value; }
        }

        /// <summary>
        /// Say Message Caller-ID: If this option is enabled, the Caller ID of the party that left the message will be played back before the voicemail message begins playing back.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "saycid")]
        public bool Saycid
        {
            get { return saycid; }
            set { saycid = value; }
        }

        /// <summary>
        /// Say Message Duration: If this optino is set, the duration of the message will be played back before the voicemail message begins playing back.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "sayduration")]
        public bool Sayduration
        {
            get { return sayduration; }
            set { sayduration = value; }
        }

        /// <summary>
        /// Play Envelope: Selecting this option causes Asterisk not to play introductions about each message when accessing them from the voicemail application.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "envelope")]
        public bool Envelope
        {
            get { return envelope; }
            set { envelope = value; }
        }

        /// <summary>
        /// Allow Users to Review: Checking this option allows the caller leaving the voicemail the opportunity to review their recorded message before it is submitted as a voicemail message.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "review")]
        public bool Review
        {
            get { return review; }
            set { review = value; }
        }

        #endregion
        #region IExtension 成员
        /// <summary>
        /// Extension for checking Message:This option, i.e. "2345," defines the Extension that Users call in order to access their voicemail accounts.
        /// </summary>
        public string Extension
        {
            get
            {
                return extension;
            }
            set
            {
                extension = value;
            }
        }

        #endregion

        #region IExtension 成员


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
    }
}
