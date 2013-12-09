using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;

namespace VisualAsterisk.Main.Gui.Configuration
{
    public partial class VoiceMenusConfigPage : DockPage
    {
        public VoiceMenusConfigPage()
        {
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
        }

        public override VisualAsterisk.Asterisk.IAsteriskServer Server
        {
            get
            {
                return base.Server;
            }
            set
            {
                base.Server = value;
                this.listBoxMenus.Items.Clear();
                foreach (VoiceMenu m in this.configManager.VoiceMenus)
                {
                    this.listBoxMenus.Items.Add(m.Name);
                }
            }
        }

        private void listBoxMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.listBoxMenus.SelectedItem as string;
            if (name == null) return;                

            VoiceMenu m = this.configManager.FindVoiceMenu(name);
            this.textBoxName.Text = name;
            this.textBoxExtension.Text = m.Extension;
            this.listBoxSteps.Items.Clear();
            foreach (VoiceMenuAction s in m.Actions.Values)
            {
                this.listBoxSteps.Items.Add(s.Name);
            }

            this.dataGridViewActions.Rows.Clear();
            foreach (string key in m.KeyPressActions.Keys)
            {
                VocieMenuKeyPressEvent action = m.KeyPressActions[key];
                //this.dataGridViewActions.Rows.Add(new string[] { Key, Action.Type });
                this.dataGridViewActions.Rows.Add(key, action.Type.ToString());
            }
        }

        private void buttonMoveup_Click(object sender, EventArgs e)
        {
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
            int firstIndex = this.listBoxSteps.SelectedIndices[0];
            int lastIndex = this.listBoxSteps.SelectedIndices[this.listBoxSteps.SelectedIndices.Count - 1];
            if (lastIndex == this.listBoxSteps.SelectedIndices.Count - 1)
            {
                return;
            }

            this.listBoxSteps.Items.Insert(firstIndex, this.listBoxSteps.Items[lastIndex + 1]);
            this.listBoxSteps.Items.RemoveAt(lastIndex + 2);
            configManager.fireConfigChanged();
        }

        private void buttonAddStep_Click(object sender, EventArgs e)
        {
            string name = this.listBoxMenus.SelectedItem as string;
            if (name == null) return;                

            VoiceMenu m = this.configManager.FindVoiceMenu(name);

            AddEditStep dlg = new AddEditStep();
            dlg.Musicfiles = server.GetAllMusicFiles();
            dlg.Extensions = configManager.GetAllExtensions();
            dlg.Voicemenus = configManager.GetAllVoiceMenus();
            dlg.Ringgroups = configManager.GetAllRingGroups();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m.Actions[dlg.Step.Priority] = dlg.Step;
            }
            configManager.fireConfigChanged();
        }

        private void buttonDeleteStep_Click(object sender, EventArgs e)
        {
            foreach (object item in this.listBoxSteps.SelectedItems)
            {
                this.listBoxSteps.Items.Remove(item);
            }
        }

        private void dataGridViewActions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string name = this.listBoxMenus.SelectedItem as string;
                if (name == null)
                {
                    return;
                }
                VoiceMenu m = this.configManager.FindVoiceMenu(name);
                DataGridViewComboBoxColumn col = this.dataGridViewActions.Columns[2] as DataGridViewComboBoxColumn;

                if ((AnswerActionType) Enum.Parse(typeof(AnswerActionType), this.dataGridViewActions.CurrentCell.Value as string) == AnswerActionType.Disabled)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            VoiceMenu menu = new VoiceMenu();
            menu.Name = "voicemenu" + configManager.VoiceMenus.Count+1;
            menu.AddingNew = true;
            configManager.VoiceMenus.Add(menu);
            int index = this.listBoxMenus.Items.Add(menu.Name);
            this.listBoxMenus.SelectedIndex = index;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = this.listBoxMenus.SelectedIndex;
            VoiceMenu menu = configManager.VoiceMenus[index];
            if (menu != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete VoiceMenu {0}", menu.Name),
    "Delete VoiceMenu Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.listBoxMenus.Items.RemoveAt(index);
                    if (!menu.AddingNew)
                    {
                        configManager.RemoveVoiceMenu(menu);                        
                    }
                }
            }

            if (index < this.listBoxMenus.Items.Count)
            {
                this.listBoxMenus.SelectedIndex = index;
            }
            else if (index - 1 >= 0)
            {
                this.listBoxMenus.SelectedIndex = index - 1;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            VoiceMenu menu = configManager.VoiceMenus[this.listBoxMenus.SelectedIndex];
            if (menu != null)
            {
                configManager.UpdateVoiceMenu(menu);
                this.buttonSubmit.Enabled = false;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            VoiceMenu menu = configManager.VoiceMenus[this.listBoxMenus.SelectedIndex];
            if (menu != null)
            {
                menu.CancelEdit();
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            VoiceMenu menu = configManager.VoiceMenus[this.listBoxMenus.SelectedIndex];
            if (menu != null)
            {
                menu.DialOtherAllowed = checkBox1.Checked;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            VoiceMenu menu = configManager.VoiceMenus[this.listBoxMenus.SelectedIndex];
            if (menu != null)
            {
                menu.Name = textBoxName.Text;
            }
        }

        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            VoiceMenu menu = configManager.VoiceMenus[this.listBoxMenus.SelectedIndex];
            if (menu != null)
            {
                menu.Extension = textBoxExtension.Text;
            }
        }
    }
}
