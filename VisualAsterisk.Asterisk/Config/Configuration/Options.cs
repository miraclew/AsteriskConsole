using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class Options
    {
        private IAsteriskConfigManager configManager;

        public Options(IAsteriskConfigManager configManager)
        {
            this.configManager = configManager;
        }

        #region Local Extension Settings
        public int LocalExtenDigits
        {
            get { return configManager.GeneralUser.LocalExtenLength; }
            set { configManager.GeneralUser.LocalExtenLength = value; }
        }

        public string FirstExensionNumber
        {
            get { return configManager.GeneralUser.Userbase; }
            set { configManager.GeneralUser.Userbase = value; }
        }

        public string OperatorExtension
        {
            get { return configManager.GeneralUser.OperatorExtension; }
            set { configManager.GeneralUser.OperatorExtension = value; }
        }

        public bool AnalogMultipleExtenAllowed
        {
            get { return configManager.GeneralUser.AllowAliasExtns; }
            set { configManager.GeneralUser.AllowAliasExtns = value; }
        }

        public bool AlphaNumericAllowed
        {
            get { return configManager.GeneralUser.AllowAlphaNumericExtns; }
            set { configManager.GeneralUser.AllowAlphaNumericExtns = value; }
        }
        #endregion

        #region Agent Login Settings
        private string agentLoginExtension;
        private string agentCallbackLoginExtension;

        public string AgentLoginExtension
        {
            get { return configManager.GeneralUser.LoginExten; }
            set { configManager.GeneralUser.LoginExten = value; }
        }

        public string AgentCallbackLoginExtension
        {
            get { return configManager.GeneralUser.LoginCallbackExten; }
            set { configManager.GeneralUser.LoginCallbackExten = value; }
        }
        /// <summary>
        /// Agent Logout
        /// # To logout of Agent Login Hangup your phone.
        /// # To Logout of Agent Callback Login Dial the same Extension used to login, 
        ///   specify your Extension and Password when prompted, and hit # when asked 
        ///   for your callback Extension. This will successfully log you out of all queues you are apart of.
        /// </summary>
        //private string logout;
        #endregion

        #region Default Settings for a New User
        public bool IsAgent
        {
            get { return configManager.GeneralUser.Hasagent; }
            set { configManager.GeneralUser.Hasagent = value; }
        }

        public bool HasVoicemail
        {
            get { return configManager.GeneralUser.HasVoicemail; }
            set { configManager.GeneralUser.HasVoicemail = value; }
        }

        public bool InDirectory
        {
            get { return configManager.GeneralUser.Hasdirectory; }
            set { configManager.GeneralUser.Hasdirectory = value; }
        }

        public bool IsCTI
        {
            get { return configManager.GeneralUser.HasCTI; }
            set { configManager.GeneralUser.HasCTI = value; }
        }

        public bool HasSip
        {
            get { return configManager.GeneralUser.HasSip; }
            set { configManager.GeneralUser.HasSip = value; }
        }

        public bool HasIax
        {
            get { return configManager.GeneralUser.Hasiax; }
            set { configManager.GeneralUser.Hasiax = value; }
        }

        public bool IsCallWaiting
        {
            get { return configManager.GeneralUser.CallWaiting; }
            set { configManager.GeneralUser.CallWaiting = value; }
        }

        public bool ThreeWayCalling
        {
            get { return configManager.GeneralUser.ThreeWayCalling; }
            set { configManager.GeneralUser.ThreeWayCalling = value; }
        }

        public string VoicemailPassword
        {
            get { return configManager.GeneralUser.Vmsecret; }
            set { configManager.GeneralUser.Vmsecret = value; }
        }
        #endregion
    }
}
