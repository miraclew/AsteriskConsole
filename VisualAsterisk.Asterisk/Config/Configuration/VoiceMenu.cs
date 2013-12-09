using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;
using VisualAsterisk.Asterisk.Config.Dialplan;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public enum AnswerActionType
    {
        Disabled, GotoMenu, GotoExtension, Hangup, PlayInvalid
    }

    public class VocieMenuKeyPressEvent
    {
        public VocieMenuKeyPressEvent(VocieMenuKeyPressEvent keyPressEvent)
        {
            // TODO: this.action = action.action;
            this.key = keyPressEvent.key;
            this.type = keyPressEvent.type;
        }

        public VocieMenuKeyPressEvent(string key, AnswerActionType type, VoiceMenuAction action)
        {
            this.key = key;
            this.type = type;
            this.action = action;
        }

        private string key;
        private AnswerActionType type;
        private VoiceMenuAction action;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public AnswerActionType Type
        {
            get { return type; }
            set { type = value; }
        }

        public VoiceMenuAction Action
        {
            get { return action; }
            set { action = value; }
        }
    }

    public class VoiceMenu : ConfigurationItemBase, IConfiguration
    {
        public VoiceMenu(VoiceMenu menu)
        {
            copy(menu);
        }

        public override ConfigurationItemBase Copy()
        {
            return new VoiceMenu(this);
        }

        protected override void copy(ConfigurationItemBase obj)
        {
            VoiceMenu menu = obj as VoiceMenu;
            initActions();
            // TODO: NEED to do some thing to actions to nofity property change
            foreach (string key in menu.KeyPressActions.Keys)
            {
                this.keyPressActions[key] = new VocieMenuKeyPressEvent(menu.KeyPressActions[key]);
            }
            this.DialOtherAllowed = menu.dialOtherAllowed;
            this.Extension = menu.extension;
            this.Name = menu.name;
            this.SerialNo = menu.serialNo;
            this.server = menu.server;
            this.actions = menu.actions; // TODO: 
        }

        private int serialNo;

        public int SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

        // The Context in extensions.conf
        public string Context
        {
            get
            {
                return "voicemenu-custom-" + serialNo.ToString();
            }
        }

        public const string KEY_0 = "0";
        public const string KEY_1 = "1";
        public const string KEY_2 = "2";
        public const string KEY_3 = "3";
        public const string KEY_4 = "4";
        public const string KEY_5 = "5";
        public const string KEY_6 = "6";
        public const string KEY_7 = "7";
        public const string KEY_8 = "8";
        public const string KEY_9 = "9";
        public const string KEY_STAR = "*";
        public const string KEY_POUND = "#";
        public const string KEY_T = "t";
        public const string KEY_I = "i";
        private Dictionary<string, VocieMenuKeyPressEvent> keyPressActions = new Dictionary<string, VocieMenuKeyPressEvent>();
        private Dictionary<int, VoiceMenuAction> actions = new Dictionary<int, VoiceMenuAction>();
        private string name;
        private string extension;
        private bool dialOtherAllowed;

        /// <summary>
        /// Name of the voicemenu.
        /// Map to "comment" var in Extension.conf
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                
                if (!string.IsNullOrEmpty(name) && name.Equals(value))
                {
                    return;
                }
                name = value;
                addChange(new ConfigurationChange("extensions.conf", UpdateConfigAction.ACTION_UPDATE, 
                    this.Context, "comment", name));
            }
        }

        /// <summary>
        /// Extension 
        /// Map to "alias_exten" var in Extension.conf
        /// </summary>
        public string Extension
        {
            get { return extension; }
            set {
                if (!string.IsNullOrEmpty(value) && value.Equals(extension))
                {
                    addChange(new ConfigurationChange("extensions.conf", UpdateConfigAction.ACTION_UPDATE,
                this.Context, "alias_exten", extension));                    
                }
                extension = value;
            }
        }

        public bool DialOtherAllowed
        {
            get { return dialOtherAllowed; }
            set
            { 
                dialOtherAllowed = value;
                addChange(new ConfigurationChange("extensions.conf",
                    dialOtherAllowed? UpdateConfigAction.ACTION_APPEND:UpdateConfigAction.ACTION_DELETE , 
                    this.Context, "include", "default"));
            }
        }

        public IDictionary<string, VocieMenuKeyPressEvent> KeyPressActions
        {
            get { return keyPressActions; }
        }

        public IDictionary<int, VoiceMenuAction> Actions
        {
            get { return actions; }
        }

        public VoiceMenu()
        {
            initActions();
        }

        private void initActions()
        {
            keyPressActions = new Dictionary<string, VocieMenuKeyPressEvent>();
            keyPressActions.Add(KEY_0, new VocieMenuKeyPressEvent(KEY_0, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_1, new VocieMenuKeyPressEvent(KEY_1, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_2, new VocieMenuKeyPressEvent(KEY_2, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_3, new VocieMenuKeyPressEvent(KEY_3, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_4, new VocieMenuKeyPressEvent(KEY_4, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_5, new VocieMenuKeyPressEvent(KEY_5, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_6, new VocieMenuKeyPressEvent(KEY_6, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_7, new VocieMenuKeyPressEvent(KEY_7, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_8, new VocieMenuKeyPressEvent(KEY_8, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_9, new VocieMenuKeyPressEvent(KEY_9, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_STAR, new VocieMenuKeyPressEvent(KEY_STAR, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_POUND, new VocieMenuKeyPressEvent(KEY_POUND, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_T, new VocieMenuKeyPressEvent(KEY_T, AnswerActionType.Disabled, null));
            keyPressActions.Add(KEY_I, new VocieMenuKeyPressEvent(KEY_I, AnswerActionType.Disabled, null));
        }

        #region IConfiguration 成员

        public void LoadUsersConfig(ConfigFile file, string cat)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Note: two different metod to load name a Extension
        /// 1. use two special exten "comment" and "alias_exten" (asterisk-gui 1.0)
        /// 2. use NoOp to save name. eg. exten = s,1,NoOp(vm1) (asterisk-gui 2.0)
        /// </summary>
        /// <param name="file"></param>
        /// <param name="cat"></param>
        public void LoadExtensionsConfig(ExtensionsConfigFile file, Category cat)
        {
            int count = 0;
            foreach (ConfigElement e in cat.Elements)
            {
                if (e is ConfigExtension)
                {
                    ConfigExtension exten = e as ConfigExtension;
                    if (exten.Name == "s")
                    {
                        if (exten.Application.Length == 2 && exten.Application[0] == "NoOp")
                        {
                            name = exten.Application[1];
                        }
                        else
                        {
                            actions.Add(count++, VoiceMenuAction.Parse(exten.Application));
                            // TODO: refactor/integrate Config.Configuration.VoiceMenuStep with DialPlan.Appplication 
                        }
                    }
                    else if (this.keyPressActions.ContainsKey(exten.Name))
                    {
                        this.keyPressActions[exten.Name].Action = VoiceMenuAction.Parse(exten.Application);
                    }
                }
                else if (e is ConfigVariable)
                {
                    ConfigVariable var = e as ConfigVariable;
                    if (var.Name == "comment")
                    {
                        this.name = var.Value;
                    }
                    else if (var.Name == "alias_exten")
                    {
                        this.extension = var.Value;
                    }
                }
            }
        }

        #endregion

    }
}
