using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;

namespace VisualAsterisk.Main.Gui.Configuration
{
    public partial class CallQueuesConfigPage : DockPage
    {
        public CallQueuesConfigPage()
        {
            InitializeComponent();
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
                this.listViewAgents.Items.Clear();
                foreach (UserExtension exten in this.configManager.Users)
                {
                    ListViewItem item = new ListViewItem(exten.Extension + " - " + exten.FullName);
                    item.Tag = exten;
                    this.listViewAgents.Items.Add(item);
                }
                this.queueExtensionBindingSource.DataSource = this.configManager.Queues;
            }
        }

        private void queueExtensionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;
            foreach (ListViewItem item in this.listViewAgents.Items)
            {
                UserExtension exten = item.Tag as UserExtension;
                if (queue.Members.Contains("Agent/" + exten.Extension))
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
            }
        }

        private void queueExtensionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;
            queue.Members.Clear();
            foreach (ListViewItem item in this.listViewAgents.CheckedItems)
            {
                queue.Members.Add(item.Text); 
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;

            if (MessageBox.Show(string.Format("Do you really want to delete {0} ?", queue.Name), "Delete Queue confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                configManager.RemoveQueue(queue);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            QueueExtension queue = this.queueExtensionBindingSource.AddNew() as QueueExtension;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;
            if (queue != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete Queue {0}", queue.Name),
                    "Delete Queue Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.queueExtensionBindingSource.RemoveCurrent();
                    if (!queue.AddingNew)
                    {
                        configManager.RemoveQueue(queue);
                    }
                }
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;
            if (queue != null)
            {
                configManager.UpdateQueue(queue);
                this.buttonSubmit.Enabled = false;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;
            if (queue != null)
            {
                queue.CancelEdit();
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = false;
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
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = true;
            }
        }

        private void queueExtensionBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            QueueExtension queue = new QueueExtension();
            queue.AddingNew = true;
            e.NewObject = queue;
        }

        private void queueExtensionBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemChanged:
                case ListChangedType.ItemDeleted:
                    this.buttonSubmit.Enabled = true;
                    this.buttonCancel.Enabled = true;
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.Reset:
                    break;
                default:
                    break;
            }
        }

        private void extensionTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }
    }
}
