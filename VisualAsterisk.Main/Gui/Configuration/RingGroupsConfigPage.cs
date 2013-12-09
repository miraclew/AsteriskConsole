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
    public partial class RingGroupsConfigPage : DockPage
    {
        private List<ListViewItem> allAvaliableChannelItems = new List<ListViewItem>();

        public RingGroupsConfigPage()
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
                this.comboBoxMenus.Items.Clear();
                this.comboBoxMenus.Items.Add("");
                foreach (VoiceMenu menu in this.configManager.VoiceMenus)
                {
                    this.comboBoxMenus.Items.Add(menu.Context);
                }

                allAvaliableChannelItems.Clear();
                foreach (UserExtension exten in this.configManager.Users)
                {
                    string tech;
                    if (exten.HasSip)
                    {
                        tech = "SIP/";
                        //ListViewItem item = new ListViewItem(tech + exten.Extension + " - " + exten.FullName);
                        ListViewItem item = new ListViewItem(tech + exten.Extension);
                        allAvaliableChannelItems.Add(item);
                    }
                    
                    if (exten.Hasiax)
                    {
                        tech = "IAX2/";
                        ListViewItem item = new ListViewItem(tech + exten.Extension);
                        allAvaliableChannelItems.Add(item);
                    }

                    if (exten.Zapchan != null)
                    {
                        tech = "ZAP/";
                        ListViewItem item = new ListViewItem(tech + exten.Extension);
                        allAvaliableChannelItems.Add(item);
                    }
                }
                this.ringGroupBindingSource.DataSource = this.configManager.RingGroups;
            }
        }

        private void ringGroupBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.Current as RingGroup;
            if (g == null)
            {
                return;
            }
            if (g.Action == NotAnsweredActionOption.GotoIvrMenu)
            {
                this.radioButtonGotoIvrMenu.Checked = true;
                this.comboBoxMenus.SelectedItem = g.IvrMenu;
            }
            else if (g.Action == NotAnsweredActionOption.GotoVoicemail)
            {
                this.radioButtonGotoVoicemail.Checked = true;
                //this.comboBoxMenus.SelectedIndex = 0;
            }
            else
            {
                this.radioButtonHangup.Checked = true;
                //this.comboBoxMenus.SelectedIndex = 0;
            }

            this.listViewRingGroupMembers.Items.Clear();
            this.listViewAvailiableChannels.Items.Clear();
            foreach (ListViewItem item in allAvaliableChannelItems)
            {
                foreach (string m in g.Members)
                {
                    if (item.Text == m)
                    {
                        listViewRingGroupMembers.Items.Add(item);
                        break;
                    }
                }
                if (!listViewRingGroupMembers.Items.Contains(item))
                {
                    listViewAvailiableChannels.Items.Add(item);
                }
            }
        }

        private void buttonAddSelected_Click(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.Current as RingGroup;

            foreach (ListViewItem item in this.listViewAvailiableChannels.SelectedItems)
            {
                this.listViewAvailiableChannels.Items.Remove(item);
                this.listViewRingGroupMembers.Items.Add(item);
                g.Members.Add(item.Text);
            }
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.Current as RingGroup;

            foreach (ListViewItem item in this.listViewRingGroupMembers.SelectedItems)
            {
                this.listViewRingGroupMembers.Items.Remove(item);
                this.listViewAvailiableChannels.Items.Add(item);
                g.Members.Remove(item.Text);
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.Current as RingGroup;

            foreach (ListViewItem item in this.listViewRingGroupMembers.Items)
            {
                this.listViewRingGroupMembers.Items.Remove(item);
                this.listViewAvailiableChannels.Items.Add(item);
                g.Members.Remove(item.Text);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.AddNew() as RingGroup;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.Current as RingGroup; 
            if (g != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete RingGroup {0}", g.Name),
                    "Delete RingGroup Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK
                )
                {
                    this.ringGroupBindingSource.RemoveCurrent();
                    if (!g.AddingNew)
                    {
                        configManager.RemoveRingGroup(g);                        
                    }
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.Current as RingGroup;
            if (g != null)
            {
                configManager.UpdateRingGroup(g);
                this.buttonSubmit.Enabled = false;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            RingGroup g = this.ringGroupBindingSource.Current as RingGroup;
            if (g != null)
            {
                g.CancelEdit();
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = false;
            }
        }

        private void ringGroupBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            RingGroup group = new RingGroup();
            group.AddingNew = true;
            e.NewObject = group;
        }

        private void ringGroupBindingSource_ListChanged(object sender, ListChangedEventArgs e)
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
    }
}
