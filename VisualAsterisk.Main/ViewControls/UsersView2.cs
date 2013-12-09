using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Main.UI.Forms;
using VisualAsterisk.Main.Controller;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class UsersView2 : ViewControl
    {
        private UserExtension defaultUser;

        public UsersView2()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (AsteriskManager.Default.IsCurrentControllerOK())
            {
                this.userExtensionBindingSource.DataSource = configManager.Users;
                defaultUser = configManager.GeneralUser;
            }
        }

        private void userExtensionVisualAsteriskEditDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            UserExtension user = e.DataRow.DataBoundItem as UserExtension;
            if (user == null)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Do you want to delete User {0}", user.Extension),
                "Delete User Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.userExtensionBindingSource.RemoveCurrent();
                if (!user.AddingNew)
                {
                    configManager.RemoveUser(user);
                }
            }
        }

        private void userExtensionVisualAsteriskEditDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            UserExtension user = e.DataRow.DataBoundItem as UserExtension;
            if (user == null)
            {
                return;
            }

            UserEditorForm editor = new UserEditorForm(user, server);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                configManager.UpdateUser(user);
            }
            else
            {
                user.CancelEdit();
            }
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            UserExtension user = new UserExtension(defaultUser);
            user.AddingNew = true;
            UserEditorForm editor = new UserEditorForm(user, server);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                userExtensionBindingSource.Add(user);
                configManager.UpdateUser(user);
            }
        }
    }
}
