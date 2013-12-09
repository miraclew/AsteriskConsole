using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Asterisk.Config;

namespace VisualAsterisk.Main.UI.Forms
{
    public partial class QueueEditorForm : EditorWizardFormBase
    {
        private IAsteriskConfigManager configManager;
        public QueueEditorForm(QueueExtension queue, IAsteriskConfigManager configManager)
        {
            InitializeComponent();
            this.configManager = configManager;
            this.queueExtensionBindingSource.DataSource = queue;

            this.listViewAgents.Items.Clear();
            foreach (UserExtension exten in configManager.Users)
            {
                ListViewItem item = new ListViewItem(exten.Extension + " - " + exten.FullName);
                item.Tag = exten;
                if (queue.Members.Contains("Agent/" + exten.Extension))
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
                this.listViewAgents.Items.Add(item);
            }
        }

        private void listViewAgents_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!listViewAgents.Focused)
            {
                return;
            }

            QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;
            if (queue != null)
            {
                if (e.Item.Checked)
                {
                    UserExtension exten = e.Item.Tag as UserExtension;
                    if (exten != null)
                    {
                        queue.AddMember("Agent/" + exten.Extension);
                    }
                }
                else
                {
                    UserExtension exten = e.Item.Tag as UserExtension;
                    if (exten != null)
                    {
                        queue.RemoveMember("Agent/" + exten.Extension);
                    }
                }
                this.okButton.Enabled = true;
                this.cancelButton.Enabled = true;
            }
        }
    }
}
