using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;
using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.UI.Forms
{
    public partial class VoiceMenuEditorForm : EditorWizardFormBase
    {
        private IAsteriskServer server;
        private IAsteriskConfigManager configManager;
        public VoiceMenuEditorForm(VoiceMenu menu, IAsteriskServer server)
        {
            this.server = server;
            this.configManager = server.ConfigManager;
            InitializeComponent();
            DataGridViewComboBoxColumn col = this.dataGridViewActions.Columns[1] as DataGridViewComboBoxColumn;
            List<string> actionTypes = new List<string>();
            actionTypes.AddRange(new string[] {AnswerActionType.Disabled.ToString(), 
                AnswerActionType.GotoExtension.ToString(), AnswerActionType.GotoMenu.ToString(), 
                AnswerActionType.PlayInvalid.ToString(), AnswerActionType.Hangup.ToString()
            });
            if (col != null)
            {
                col.DataSource = actionTypes;
            }

            this.textBoxName.Text = menu.Name;
            this.textBoxExtension.Text = menu.Extension;
            this.listBoxSteps.Items.Clear();
            foreach (VoiceMenuAction s in menu.Actions.Values)
            {
                this.listBoxSteps.Items.Add(s.Name);
            }

            this.dataGridViewActions.Rows.Clear();
            foreach (string key in menu.KeyPressActions.Keys)
            {
                VocieMenuKeyPressEvent action = menu.KeyPressActions[key];
                //this.dataGridViewActions.Rows.Add(new string[] { Key, Action.Type });
                this.dataGridViewActions.Rows.Add(key, action.Type.ToString());
            }
            this.voiceMenuBindingSource.DataSource = menu;
        }

        private void buttonMoveup_Click(object sender, EventArgs e)
        {
            if (this.listBoxSteps.SelectedIndices.Count <= 0)
            {
                return;
            }
            int firstIndex = this.listBoxSteps.SelectedIndices[0];
            int lastIndex = this.listBoxSteps.SelectedIndices[this.listBoxSteps.SelectedIndices.Count - 1];
            if (firstIndex == 0)
            {
                return;
            }
            // 1. copy/insert the item before the first selected item next to the last selected item
            this.listBoxSteps.Items.Insert(lastIndex + 1, this.listBoxSteps.Items[firstIndex - 1]);
            this.listBoxSteps.Items.RemoveAt(firstIndex - 1);
            configManager.fireConfigChanged();
        }

        private void buttonMovedown_Click(object sender, EventArgs e)
        {
            if (this.listBoxSteps.SelectedIndices.Count <= 0)
            {
                return;
            }
            int firstIndex = this.listBoxSteps.SelectedIndices[0];
            int lastIndex = this.listBoxSteps.SelectedIndices[this.listBoxSteps.SelectedIndices.Count - 1];
            if (lastIndex == this.listBoxSteps.Items.Count - 1)
            {
                return;
            }

            this.listBoxSteps.Items.Insert(firstIndex, this.listBoxSteps.Items[lastIndex + 1]);
            this.listBoxSteps.Items.RemoveAt(lastIndex + 2);
            configManager.fireConfigChanged();
        }

        private void buttonAddStep_Click(object sender, EventArgs e)
        {
            VoiceMenu m = this.voiceMenuBindingSource.Current as VoiceMenu;
            if (m == null) return;

            AddEditStep dlg = new AddEditStep();
            dlg.Musicfiles = server.GetAllMusicFiles();
            dlg.Extensions = configManager.GetAllExtensions();
            dlg.Voicemenus = configManager.GetAllVoiceMenus();
            dlg.Ringgroups = configManager.GetAllRingGroups();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.Step.Priority = m.KeyPressActions.Count + 1;
                m.Actions[dlg.Step.Priority] = dlg.Step;
            }
            configManager.fireConfigChanged();
            this.listBoxSteps.Items.Add(dlg.Step.Name);
        }

        private void buttonDeleteStep_Click(object sender, EventArgs e)
        {
            foreach (object item in this.listBoxSteps.SelectedItems)
            {
                this.listBoxSteps.Items.Remove(item);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            VoiceMenu menu = this.voiceMenuBindingSource.Current as VoiceMenu;
            if (menu != null)
            {
                menu.DialOtherAllowed = checkBox1.Checked;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            VoiceMenu menu = this.voiceMenuBindingSource.Current as VoiceMenu;
            if (menu != null)
            {
                menu.Name = textBoxName.Text;
            }
        }

        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            VoiceMenu menu = this.voiceMenuBindingSource.Current as VoiceMenu;
            if (menu != null)
            {
                menu.Extension = textBoxExtension.Text;
            }
        }

        private void dataGridViewActions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                VoiceMenu m = this.voiceMenuBindingSource.Current as VoiceMenu;
                if (m == null)
                {
                    return;
                }
                DataGridViewComboBoxColumn col = this.dataGridViewActions.Columns[2] as DataGridViewComboBoxColumn;

                if ((AnswerActionType)Enum.Parse(typeof(AnswerActionType), this.dataGridViewActions.CurrentCell.Value as string) == AnswerActionType.Disabled)
                {
                    DataGridViewComboBoxCell cell = this.dataGridViewActions.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                    cell.DataSource = null;
                }
                else if ((AnswerActionType)Enum.Parse(typeof(AnswerActionType), this.dataGridViewActions.CurrentCell.Value as string) == AnswerActionType.GotoExtension)
                {
                    DataGridViewComboBoxCell cell = this.dataGridViewActions.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                    cell.DataSource = configManager.GetAllExtensions();
                }
                else if ((AnswerActionType)Enum.Parse(typeof(AnswerActionType), this.dataGridViewActions.CurrentCell.Value as string) == AnswerActionType.GotoMenu)
                {
                    DataGridViewComboBoxCell cell = this.dataGridViewActions.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                    cell.DataSource = configManager.GetAllVoiceMenus();
                }
                else if ((AnswerActionType)Enum.Parse(typeof(AnswerActionType), this.dataGridViewActions.CurrentCell.Value as string) == AnswerActionType.PlayInvalid)
                {
                    DataGridViewComboBoxCell cell = this.dataGridViewActions.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                    cell.DataSource = null;
                }
                else if ((AnswerActionType)Enum.Parse(typeof(AnswerActionType), this.dataGridViewActions.CurrentCell.Value as string) == AnswerActionType.Hangup)
                {
                    DataGridViewComboBoxCell cell = this.dataGridViewActions.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                    cell.DataSource = null;
                }
            }
        }
    }
}
