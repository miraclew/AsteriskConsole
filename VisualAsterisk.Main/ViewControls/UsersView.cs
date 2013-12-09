using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Main.Gui.Configuration;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class UsersView : ViewControl
    {
        public UsersView()
        {
            InitializeComponent();
            dialplanComboBox.SelectionChangeCommitted += new EventHandler(dialplanComboBox_SelectionChangeCommitted);
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

        public override IAsteriskServer Server
        {
            get
            {
                return base.Server;
            }
            set
            {
                base.Server = value;
                this.userExtensionBindingSource.DataSource = configManager.Users;
                defaultUser = configManager.GeneralUser;
                dialplanComboBox.Items.Clear();
                dialplanComboBox.Items.Add(string.Empty);
                foreach (string item in configManager.GetAllDialplanNames())
                {
                    dialplanComboBox.Items.Add(item);
                }
            }
        }

        private BindingList<UserExtension> users;
        private UserExtension defaultUser;

        public UserExtension DefaultUser
        {
            get { return defaultUser; }
            set { defaultUser = value; }
        }

        public BindingList<UserExtension> Users
        {
            get { return users; }
            set
            {
                users = value;
                this.userExtensionBindingSource.DataSource = users;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //            UserExtension User = configManager.Users.AddNew();
            UserExtension user = this.userExtensionBindingSource.AddNew() as UserExtension;
            if (string.IsNullOrEmpty(user.Extension))
            {
            }

        }

        private void userExtensionBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            UserExtension user = new UserExtension(defaultUser);
            user.AddingNew = true;
            e.NewObject = user;
        }

        private void userExtensionBindingSource_ListChanged(object sender, ListChangedEventArgs e)
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //UserExtension User = this.userExtensionBindingSource.Current as UserExtension;
            //if (MessageBox.Show(string.Format("Do you want to delete User {0}", User.Extension),
            //"Delete User Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //}
            //else
            //{
            //}
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!this.Validate() || !this.ValidateChildren(ValidationConstraints.Selectable))
            {
                MessageBox.Show("Please correct input before submit", "Input error");
                return;
            }
            UserExtension user = this.userExtensionBindingSource.Current as UserExtension;
            if (user != null)
            {
                configManager.UpdateUser(user);
                this.buttonSubmit.Enabled = false;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            UserExtension user = this.userExtensionBindingSource.Current as UserExtension;
            if (user != null)
            {
                user.CancelEdit();
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            UserExtension user = this.userExtensionBindingSource.Current as UserExtension;
            if (user != null)
            {
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
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserExtension user = this.userExtensionBindingSource.AddNew() as UserExtension;
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

        private void extensionTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }

        private void fullNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }

        private void userExtensionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UserExtension user = this.userExtensionBindingSource.Current as UserExtension;
            if (user != null)
            {
                if (!string.IsNullOrEmpty(user.Context))
                {
                    CallingRuleDialPlan plan = configManager.FindDailPlanByContext(user.Context);
                    if (plan != null)
                    {
                        dialplanComboBox.SelectedItem = plan.Name;
                    }
                }
                else
                {
                    dialplanComboBox.SelectedItem = string.Empty;
                }
            }
        }
    }
}
