using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Dialplan;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public enum NotAnsweredActionOption
    {
        GotoVoicemail, GotoIvrMenu, Hangup
    }
    public class RingGroup : ConfigurationItemBase, IConfiguration
    {
        public RingGroup()
        {
            action = NotAnsweredActionOption.Hangup;
        }

        public RingGroup(RingGroup group)
        {
            copy(group);
        }

        protected override void copy(ConfigurationItemBase obj)
        {
            RingGroup group = obj as RingGroup;
            this.Action = group.action;
            this.Extension = group.extension;
            this.HowLong = group.howLong;
            this.IvrMenu = group.ivrMenu;
            // TODO: NEED to do someting for members
            foreach (string item in group.members)
            {
                this.members.Add(item);
            }
            this.Name = group.name;
            this.serialNo = group.serialNo;
            this.Strategy = group.strategy;
            this.VoiceMailUser = group.voiceMailUser;
        }

        private int serialNo;

        public int SerialNo
        {
            get { return serialNo; }
        }

        public string Context
        {
            get
            {
                return "ringroups-custom-" + serialNo.ToString();
            }
        }

        private string name;
        private RingStrategy strategy;
        private IList<string> members = new List<string>();
        private IExtension extension; // Extension for this ring group (optional)
        private int howLong; // Ring (each/all) for these many seconds
        private NotAnsweredActionOption action; // If not answered
        private IExtension voiceMailUser;
        private string ivrMenu;

        public IExtension VoiceMailUser
        {
            get { return voiceMailUser; }
            set
            {
                voiceMailUser = value;
                changNoAnswerExtenString();
            }
        }

        public string IvrMenu
        {
            get { return ivrMenu; }
            set 
            {
                ivrMenu = value;
                changNoAnswerExtenString();
            }
        }

        /// <summary>
        /// Map to "gui_ring_groupname" in extensions.conf
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                firePropertyChange("gui_ring_groupname", name, value);
                name = value; 
            }
        }

        public RingStrategy Strategy
        {
            get { return strategy; }
            set { strategy = value; }
        }

        public IList<string> Members
        {
            get { return members; }
            set
            {
                members = value;
                changeDialExtenString();
            }
        }

        public IExtension Extension
        {
            get { return extension; }
            set { extension = value; }
        }

        public int HowLong
        {
            get { return howLong; }
            set
            {
                howLong = value;
                changeDialExtenString();
            }
        }

        private void changeDialExtenString()
        {
            ConfigurationChange change = new ConfigurationChange();
            change.Action = UpdateConfigAction.ACTION_UPDATE;
            change.Category = this.Context;
            change.Variable = "exten";
            change.Value = getDialExtenString();
            change.Match = "Dial";
            addChange(change);
        }

        private void changNoAnswerExtenString()
        {
            ConfigurationChange removeGoto = new ConfigurationChange();
            removeGoto.Action = UpdateConfigAction.ACTION_DELETE;
            removeGoto.Category = this.Context;
            removeGoto.Variable = "exten";
            removeGoto.Match = "Goto";
            addChange(removeGoto);

            ConfigurationChange removeVoicemail = new ConfigurationChange();
            removeVoicemail.Action = UpdateConfigAction.ACTION_DELETE;
            removeVoicemail.Category = this.Context;
            removeVoicemail.Variable = "exten";
            removeVoicemail.Match = "Voicemail";
            addChange(removeVoicemail);

            ConfigurationChange removeHangup = new ConfigurationChange();
            removeHangup.Action = UpdateConfigAction.ACTION_DELETE;
            removeHangup.Category = this.Context;
            removeHangup.Variable = "exten";
            removeHangup.Match = "Hangup";
            addChange(removeHangup);

            ConfigurationChange change = new ConfigurationChange();
            change.Action = UpdateConfigAction.ACTION_APPEND;
            change.Category = this.Context;
            change.Variable = "exten";
            change.Value = getNoAnswerExtenString();
            addChange(change);
        }

        public NotAnsweredActionOption Action
        {
            get { return action; }
            set { action = value; }
        }

        public override ConfigurationItemBase Copy()
        {
            return new RingGroup(this);
        }

        #region IConfiguration 成员

        public void LoadUsersConfig(ConfigFile file, string cat)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> ToExtensionConfig()
        {
            Dictionary<string, string> extenConfig = new Dictionary<string, string>();
            extenConfig.Add("gui_ring_groupname", name);
            extenConfig.Add("exten", string.Format("s,1,NoOp(RINGGROUP)"));

            extenConfig.Add("exten", getDialExtenString() );
            extenConfig.Add("exten",getNoAnswerExtenString());
            return extenConfig;
        }

        private string getNoAnswerExtenString()
        {
            string noansweraction;
            if (action == NotAnsweredActionOption.GotoIvrMenu)
            {
                noansweraction = string.Format("s,n,Goto({0}|s|1)", ivrMenu);
            }
            else if (action == NotAnsweredActionOption.GotoVoicemail)
            {
                noansweraction = string.Format("s,n,Voicemail({0},b)", extension.Extension);
            }
            else
            {
                noansweraction = "s,n,Hangup";
            }
            return noansweraction;
        }

        private string getDialExtenString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < members.Count; i++)
            {
                sb.Append(members[i]);
                if (i < members.Count - 1)
                {
                    sb.Append("&");
                }
            }
            return string.Format("s,n,Dial({0},{1})", sb.ToString(), howLong);
        }

        public void LoadExtensionsConfig(ExtensionsConfigFile file, Category cat)
        {
            this.members.Clear();

            foreach (ConfigElement e in cat.Elements)
            {
                if (e is ConfigExtension)
                {
                    ConfigExtension exten = e as ConfigExtension;
                    if (exten.Application[0] == "Dial")
                    {
                        Dial dial = Dial.Parse(exten.Application);
                        this.howLong = dial.RingTimeout;
                        foreach (string m in dial.DialedMembers)
                        {
                            this.members.Add(m);
                        }
                    }
                    else if (exten.Application[0] == "Hangup")
                    {
                        this.Action = NotAnsweredActionOption.Hangup;
                    }
                    else if (exten.Application[0] == "Voicemail")
                    {
                        this.Action = NotAnsweredActionOption.GotoVoicemail;
                    }
                    else if (exten.Application[0] == "Goto")
                    {
                        this.Action = NotAnsweredActionOption.GotoIvrMenu;
                        this.ivrMenu = exten.Application[1];
                    }                    
                }
                else if (e is ConfigVariable)
                {
                    ConfigVariable var = e as ConfigVariable;
                    if (var.Name == "gui_ring_groupname")
                    {
                        this.name = var.Value;
                    }
                }
            }
        }

        #endregion
    }
}
