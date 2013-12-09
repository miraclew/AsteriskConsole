using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.UI.Forms
{
    public partial class UserEditorForm : EditorWizardFormBase
    {
        private IAsteriskConfigManager configManager;
        private IAsteriskServer server;

        public UserEditorForm(UserExtension user, IAsteriskServer server)
        {
            InitializeComponent();
            this.userExtensionBindingSource.DataSource = user;
            this.server = server;
            this.configManager = server.ConfigManager;

            dialplanComboBox.SelectionChangeCommitted += new EventHandler(dialplanComboBox_SelectionChangeCommitted);
            dialplanComboBox.Items.Clear();
            dialplanComboBox.Items.Add(string.Empty);
            foreach (string item in configManager.GetAllDialplanNames())
            {
                dialplanComboBox.Items.Add(item);
            }
        }

        void dialplanComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UserExtension user = this.userExtensionBindingSource.Current as UserExtension;
            if (user != null)
            {
                string dialplanName = dialplanComboBox.SelectedItem as string;
                if (string.IsNullOrEmpty(dialplanName))
                {
                    user.Context = null;
                }
                else
                {
                    CallingRuleDialPlan plan = configManager.FindDailPlan(dialplanName);
                    if (plan != null)
                    {
                        user.Context = plan.Context;
                    }
                }
            }
        }

        private void editCodecButton_Click(object sender, EventArgs e)
        {
            UserExtension user = this.userExtensionBindingSource.Current as UserExtension;
            if (user != null)
            {
                EditCodecDlg dlg = new EditCodecDlg(server.GetAllCodecs());
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    user.Disallow = dlg.Disallow;
                    user.Allow = dlg.Allow;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

    }
}
