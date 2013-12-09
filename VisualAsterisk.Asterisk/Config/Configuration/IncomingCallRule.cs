using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Dialplan;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class IncomingCallRule : ConfigurationItemBase, IConfiguration
    {
        public IncomingCallRule()
        {
        }

        public IncomingCallRule(IncomingCallRule rule)
        {
            copy(rule);
        }

        public string Name
        {
            get
            {
                return pattern + serialNo.ToString();
            }
        }
        private int serialNo;
        /// <summary>
        /// The serial number of this rule, which is the Priority of the extensions.conf
        /// </summary>
        public int SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }
        // "exten", string.Format("{0},{1},Goto(default|{2}|1)", rule.Pattern, rule.SerialNo.ToString(), rule.Extension));

        public const string AllUnmatchedIncomingCallPattern = "AllUnmatchedIncomingCall";
        private Trunk trunk; // Trunk of the incoming call
        private string extension; // Destination of the call
        private string pattern;

        public Trunk Trunk
        {
            get { return trunk; }
            set
            {
                trunk = value; 
                changeExtenString();
            }
        }

        public string Extension
        {
            get { return extension; }
            set
            {
                extension = value; 
                changeExtenString();
            }
        }

        public string Pattern
        {
            get { return pattern; }
            set 
            {
                pattern = value;
                changeExtenString();
            }
        }


        public string GetGotoExtenString()
        {
            return string.Format("{0},{1},Goto(default|{2}|1)", pattern, serialNo.ToString(), extension);
        }



        #region IConfiguration 成员

        public void LoadUsersConfig(ConfigFile file, string cat)
        {
            throw new NotImplementedException();
        }

        public void LoadExtensionsConfig(ExtensionsConfigFile file, Category cat)
        {
            foreach (ConfigElement e in cat.Elements)
            {
                if (e is ConfigExtension)
                {
                    ConfigExtension exten = e as ConfigExtension;
                    pattern = exten.Name;
                    extension = exten.Application[2];

                    if (exten.Name == "_X.")
                    {
                        pattern = AllUnmatchedIncomingCallPattern;
                    }
                }
            }
        }

        #endregion

        #region IEditableObject memebers
        public override ConfigurationItemBase Copy()
        {
            return new IncomingCallRule(this);
        }
        private void changeExtenString()
        {

            if (!editing) return;
            ConfigurationChange change = new ConfigurationChange();
            change.Action = UpdateConfigAction.ACTION_UPDATE;
            change.Category = trunk.Context;
            change.Variable = "exten";
            change.Value = GetGotoExtenString();
            change.Match = "Goto";
            addChange(change);
        }

        #endregion

        protected override void copy(ConfigurationItemBase obj)
        {
            IncomingCallRule rule = obj as IncomingCallRule;
            this.Extension = rule.extension;
            this.Pattern = rule.pattern;
            this.SerialNo = rule.serialNo;
            this.server = rule.server;
            this.Trunk = rule.trunk;
        }

    }
}
