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
    public partial class RingGroupEditorForm : EditorWizardFormBase
    {
        private List<ListViewItem> allAvaliableChannelItems = new List<ListViewItem>();
        private IAsteriskConfigManager configManager;
        public RingGroupEditorForm(RingGroup g, IAsteriskConfigManager configManager)
        {
            if (g == null)
            {
                throw new ArgumentNullException("RingGoup should not be null");
            }
            this.configManager = configManager;
            InitializeComponent();

            initUI();

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
            this.ringGroupBindingSource.DataSource = g;
        }

        private void initUI()
        {
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
        }
    }
}
