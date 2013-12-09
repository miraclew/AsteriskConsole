using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using System.Collections;

namespace VisualAsterisk.Main.UI.Forms
{
    public partial class VoiceMenuEditorForm2 : Form
    {
        private List<VoiceMenuActionItem> availableKeyPressAction;

        private void composeAllAvalibleKeyPressEvents()
        {
            availableKeyPressAction = new List<VoiceMenuActionItem>();
            availableKeyPressAction.Add(new VoiceMenuActionItem(null, configManager));

            foreach (var item in configManager.Users)
            {
                VoiceMenuActionItem user = new VoiceMenuActionItem(Goto.Parse(new string[] { "Goto", "default", item.Extension, "1" }), configManager);
                user.OptionsColumnDisplay = "User Extension -- " + item.Extension;
                availableKeyPressAction.Add(user);
                VoiceMenuActionItem voicemailbox = new VoiceMenuActionItem(VoiceMail.Parse(new string[] { "Voicemail", item.Extension, "u" }), configManager);
                voicemailbox.OptionsColumnDisplay = "User VoicemailBox " + item.Extension;
                availableKeyPressAction.Add(voicemailbox);
            }

            foreach (var item in configManager.ConferenceRooms)
            {
                VoiceMenuActionItem conf = new VoiceMenuActionItem(Goto.Parse(new string[] { "Goto", "conferences", item.RoomNumber, "1" }), configManager);
                conf.OptionsColumnDisplay = "Conference Room -- " + item.RoomNumber;
                availableKeyPressAction.Add(conf);
            }

            foreach (var item in configManager.Queues)
            {
                VoiceMenuActionItem queue = new VoiceMenuActionItem(Goto.Parse(new string[] { "Goto", "queues", item.Extension, "1" }), configManager);
                queue.OptionsColumnDisplay = "Queue -- " + item.Extension;
                availableKeyPressAction.Add(queue);
            }

            foreach (var item in configManager.VoiceMenus)
            {
                VoiceMenuActionItem voiceMenu = new VoiceMenuActionItem(Goto.Parse(new string[] { "Goto", item.Context, "s", "1" }), configManager);
                voiceMenu.OptionsColumnDisplay = "VoiceMenu -- " + item.Name;
                availableKeyPressAction.Add(voiceMenu);
            }
            foreach (var item in configManager.RingGroups)
            {
                VoiceMenuActionItem ringGroup = new VoiceMenuActionItem(Goto.Parse(new string[] { "Goto", item.Context, "s", "1" }), configManager);
                ringGroup.OptionsColumnDisplay = "RingGroup -- " + item.Name;
                availableKeyPressAction.Add(ringGroup);
            }

            VoiceMenuActionItem checkVoicemail = new VoiceMenuActionItem(Goto.Parse(new string[] { "Goto", "default", configManager.VoiceMailSetting.Extension, "1" }), configManager);
            checkVoicemail.OptionsColumnDisplay = "CheckVoicemail";
            VoiceMenuActionItem goToOperator = new VoiceMenuActionItem(Goto.Parse(new string[] { "Goto", "default", "o", "1" }), configManager);
            goToOperator.OptionsColumnDisplay = "Operator";
            availableKeyPressAction.Add(new VoiceMenuActionItem(new Hangup(), configManager));
            availableKeyPressAction.Add(new VoiceMenuActionItem(new Congestion(1), configManager));
        }

        private IAsteriskServer server;
        private IAsteriskConfigManager configManager;
        private VoiceMenu menu;
        public VoiceMenuEditorForm2(VoiceMenu menu, IAsteriskServer server)
        {
            this.server = server;
            this.configManager = server.ConfigManager;
            this.menu = menu;
            InitializeComponent();
            this.SuspendLayout();

            //keyPressEventsDataGrid.ReadOnly = false;
            keyPressEventsDataGrid.RowTemplate.Height = 23;
            this.voiceMenuBindingSource.DataSource = menu;
            foreach (var item in menu.Actions.Values)
            {
                voiceMenuActionBindingSource.Add(item);
            }

            comboBox1.DataSource = new VoiceMenuStepsHelper().StepChoices;
            comboBox1.DisplayMember = "Name";

            List<VoiceMenuActionItem> keyPressActions = new List<VoiceMenuActionItem>();
            foreach (var item in menu.KeyPressActions.Keys)
            {
                var vma = new VoiceMenuActionItem(menu.KeyPressActions[item].Action, configManager);
                vma.Key = item;
                keyPressActions.Add(vma);
            }
            keyPressEventBindingSource.DataSource = keyPressActions;

            composeAllAvalibleKeyPressEvents();
            argComboBox2.DataSource = availableKeyPressAction;
            argComboBox2.DisplayMember = "OptionsColumnDisplay";

            addNewActionPanel.Visible = false;
            chooseStepPanel.Visible = true;
            this.ResumeLayout(true);
        }

        private void allowKeyPressEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = (sender as CheckBox).Checked;
        }

        private void addNewActionButton_Click(object sender, EventArgs e)
        {
            switchPanel();
            // TODO: ADD NEW ACTION
            //argTextBox1.Visible = false;
            //argTextBox2.Visible = false;
            //argComboBox1.Visible = false;
            //argComboBox2.Visible = false;
            if (argComboBox2.Tag != null)
            {
                var gotoItem = argComboBox2.SelectedItem as VoiceMenuActionItem;
                voiceMenuActionBindingSource.Add(gotoItem.Action);
            }
            else
            {
                VoiceMenuAction action;
                var select = comboBox1.SelectedItem as VoiceMenuAction;
                if (select is DigitsTimeout)
                {
                    action = new DigitsTimeout(int.Parse(argTextBox1.Text));
                }
                else if (select is ResponseTimeout)
                {
                    action = new ResponseTimeout(int.Parse(argTextBox1.Text));
                }
                else if (select is SetLanguage)
                {
                    action = new SetLanguage(argComboBox1.SelectedItem as string);
                }
                else
                {
                    ArrayList args = new ArrayList();
                    args.Add(select.ApplicationString[0]);
                    if (argTextBox1.Tag != null)
                    {
                        args.Add(argTextBox1.Text);
                    }
                    if (argTextBox2.Tag != null)
                    {
                        args.Add(argTextBox2.Text);
                    }
                    if (argComboBox1.Tag != null)
                    {
                        args.Add(argComboBox1.SelectedItem as string);
                    }
                    action = VoiceMenuAction.Parse((string[])args.ToArray(typeof(string)));
                }
                voiceMenuActionBindingSource.Add(action);
            }

            argTextBox1.Text = "";
            argTextBox2.Text = "";
        }

        /// <summary>
        /// Switch between chooseStepPanel and addNewActionPanel
        /// </summary>
        private void switchPanel()
        {
            chooseStepPanel.Visible = !chooseStepPanel.Visible;
            addNewActionPanel.Visible = !chooseStepPanel.Visible;
        }

        private void cancelNewActionButton_Click(object sender, EventArgs e)
        {
            switchPanel();
            //comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex >= 0)
            {
                selectedActionLabel.Text = (sender as ComboBox).Text;
                var action = comboBox1.SelectedItem as VoiceMenuAction;
                if (!string.IsNullOrEmpty(action.HelpText))
                {
                    stepHelpTextLabel.Text = action.HelpText;
                }
                else
                    stepHelpTextLabel.Visible = false;

                switchPanel();
                displayArgForStep(action);
            }
        }

        private void displayArgForStep(VoiceMenuAction action)
        {
            arg2Label.Visible = false;
            argTextBox1.Visible = false;
            argTextBox1.Tag = null;
            argTextBox2.Visible = false;
            argTextBox2.Tag = null;
            argComboBox1.Visible = false;
            argComboBox1.Tag = null;
            argComboBox1.SelectedItem = null;
            argComboBox2.Visible = false;
            argComboBox2.Tag = null;
            if (action.ParameterCount == 0) // no args
            {
                // nothing
            }
            else if (action.ParameterCount == 1)
            {
                if (action is Authenticate || action is SayAlpha)
                {
                    // string
                    this.argTextBox1.Visible = true;
                    this.argTextBox1.Tag = this;
                }
                else if (action is DigitsTimeout || action is Congestion || action is Wait ||
                    action is WaitExten || action is Busy || action is ResponseTimeout ||
                    action is SayDigits || action is SayNumber)
                {
                    // int
                    this.argTextBox1.Visible = true;
                    this.argTextBox1.Tag = this;
                }
                else // autocomplete
                {
                    IList<string> items = null;

                    if (action is Background || action is Playback)
                    {
                        items = server.GetAllMusicFiles();
                    }
                    else if (action is Agi)
                    {
                        items = server.GetAllAgiScripts();
                    }
                    else if (action is Macro)
                    {
                        items = configManager.GetAllMacros();
                    }
                    else if (action is SetLanguage)
                    {
                        // FixMe:
                        items = new List<string>();
                        items.Add("en");
                        items.Add("zh-ch");
                    }
                    else if (action is SetMusicOnHold)
                    {
                        // FixMe:
                        items = new List<string>();
                        items.Add("default");
                    }

                    this.argComboBox1.Items.Clear();
                    this.argComboBox1.Visible = true;
                    this.argComboBox1.Tag = this;
                    foreach (var item in items)
                    {
                        this.argComboBox1.Items.Add(item);
                    }
                }
            }
            else if (action.ParameterCount == 2)
            {
                if (action is UserEvent)
                {
                    arg2Label.Text = "Body";
                    this.arg2Label.Visible = true;
                    this.argTextBox1.Visible = true;
                    this.argTextBox2.Visible = true;
                    this.argTextBox1.Tag = this;
                    this.argTextBox2.Tag = this;
                }
                else if (action is DISA)
                {
                    this.argTextBox1.Visible = true;
                    this.argComboBox1.Items.Clear();
                    this.argComboBox1.Visible = true;
                    this.argComboBox1.Tag = this;
                    foreach (var item in configManager.GetAllDialplanNames())
                    {
                        this.argComboBox1.Items.Add(item);
                    }
                }
            }
            else if (action.ParameterCount == 3)
            {
                if (action is Goto)
                {
                    this.argComboBox2.Visible = true;
                    this.argComboBox2.Tag = this;
                }
            }
        }

        private void actionsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VoiceMenuAction action = this.actionsDataGrid.Rows[e.RowIndex].DataBoundItem as VoiceMenuAction;
            if (action == null)
            {
                return;
            }

            if (e.ColumnIndex == this.moveDownColumn.Index)
            {
                if (voiceMenuActionBindingSource.Position + 1 < voiceMenuActionBindingSource.Count)
                {
                    voiceMenuActionBindingSource.RemoveCurrent();
                    voiceMenuActionBindingSource.Insert(voiceMenuActionBindingSource.Position + 1, action);
                    voiceMenuActionBindingSource.MoveNext();
                }
            }
            else if (e.ColumnIndex == this.moveUpColumn.Index)
            {
                if (voiceMenuActionBindingSource.Position > 0)
                {
                    voiceMenuActionBindingSource.RemoveCurrent();
                    voiceMenuActionBindingSource.Insert(voiceMenuActionBindingSource.Position - 1, action);
                    voiceMenuActionBindingSource.Position -= 2;
                }
            }
            else if (e.ColumnIndex == this.deleteColumn.Index)
            {
                voiceMenuActionBindingSource.RemoveCurrent();
            }
            this.Invalidate();
        }

        private void keyPressEventsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == keyPressEventEditColumn.Index)
            {
                VoiceMenuActionItem vma = keyPressEventsDataGrid.CurrentRow.DataBoundItem as VoiceMenuActionItem;
                ChooseKeyPressAction dlg = new ChooseKeyPressAction();
                dlg.Action = vma;
                dlg.Choices = availableKeyPressAction;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    vma.Action = dlg.Action.Action;
                    vma.KeyPressEventColumnDisplay = dlg.Action.KeyPressEventColumnDisplay;
                    vma.OptionsColumnDisplay = dlg.Action.OptionsColumnDisplay;
                    menu.KeyPressActions[vma.Key].Action = dlg.Action.Action;
                    keyPressEventsDataGrid.Invalidate();
                }
            }
        }

        private void keyPressEventsDataGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (menu.FileChanges.Count > 0)
            {
                configManager.UpdateVoiceMenu(menu);
            }
        }
    }

    public class VoiceMenuActionItem
    {
        private string key;
        private VoiceMenuAction action;
        private string keyPressEventColumnDisplay;
        private string optionsColumnDisplay;
        private IAsteriskConfigManager configManager;

        public VoiceMenuActionItem(VoiceMenuAction action, IAsteriskConfigManager configManager)
        {
            this.configManager = configManager;
            Action = action;
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public string KeyPressEventColumnDisplay
        {
            get { return keyPressEventColumnDisplay; }
            set { keyPressEventColumnDisplay = value; }
        }

        public string OptionsColumnDisplay
        {
            get
            {
                if (optionsColumnDisplay != null)
                {
                    return optionsColumnDisplay;
                }
                else
                    return action.Name;
            }
            set { optionsColumnDisplay = value; }
        }

        public VoiceMenuAction Action
        {
            get { return action; }
            set
            {
                action = value;
                if (action != null)
                {
                    keyPressEventColumnDisplay = getKeyPressEventColumnDisplay(action);
                }
                else
                {
                    keyPressEventColumnDisplay = " -- ";
                    optionsColumnDisplay = "None";
                }
            }
        }

        private string getKeyPressEventColumnDisplay(VoiceMenuAction action)
        {
            if (action is Goto)
            {
                string context = (action as Goto).Context;
                string extension = (action as Goto).Extension;
                if (context.ToLower().Equals("default"))
                {
                    if (extension == "o")
                    {
                        return "Goto Operator";
                    }
                    else if (configManager.VoiceMailSetting.Extension == extension)
                    {
                        return "Check Voicemails -- " + extension;
                    }
                    else
                    {
                        return "Goto User " + extension;
                    }
                }
                else if (context.ToLower().Equals("conferences"))
                {
                    return "Goto Conference " + extension;
                }
                else if (context.ToLower().Equals("queues"))
                {
                    return "Goto Queue " + extension;
                }
                else if (context.ToLower().StartsWith("ringroups-custom-"))
                {
                    return "Goto RingGroup " + context;
                }
                else if (context.ToLower().StartsWith("voicemenu-custom-"))
                {
                    return "Goto VoiceMenu " + context;
                }
                else
                {
                    return "Goto " + extension;
                }
            }
            else if (action is Hangup)
            {
                return "Hangup call";
            }
            else if (action is Congestion)
            {
                return "Indicate congestion indefinetely";
            }
            else if (action is VoiceMail)
            {
                return "Leave Voicemail for user " + (action as VoiceMail).Extension;

            }
            else
            {
                return action.Name;
            }
        }
    }

}
