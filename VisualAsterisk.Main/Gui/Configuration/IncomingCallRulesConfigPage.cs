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
    public partial class IncomingCallRulesConfigPage : DockPage
    {
        public IncomingCallRulesConfigPage()
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
                this.incomingCallRuleBindingSource.DataSource = this.configManager.IncomingCallRules;
            }
        }

        private void incomingCallRuleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            IncomingCallRule incomingCallRule = this.incomingCallRuleBindingSource.AddNew() as IncomingCallRule;
            incomingCallRule.AddingNew = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            IncomingCallRule incomingCallRule = this.incomingCallRuleBindingSource.Current as IncomingCallRule;
            if (incomingCallRule != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete IncomingCallRule {0}", incomingCallRule.Trunk),
                    "Delete IncomingCallRule Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.incomingCallRuleBindingSource.RemoveCurrent();
                    if (!incomingCallRule.AddingNew)
                    {
                        configManager.RemoveIncomingCallRule(incomingCallRule);                        
                    }
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            IncomingCallRule incomingCallRule = this.incomingCallRuleBindingSource.Current as IncomingCallRule;
            if (incomingCallRule != null)
            {
                configManager.UpdateIncomingCallRule(incomingCallRule);
                this.buttonSubmit.Enabled = false;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IncomingCallRule incomingCallRule = this.incomingCallRuleBindingSource.Current as IncomingCallRule;
            if (incomingCallRule != null)
            {
                incomingCallRule.CancelEdit();
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = false;
            }
        }

        private void incomingCallRuleBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            IncomingCallRule rule = new IncomingCallRule();
            rule.AddingNew = true;
            e.NewObject = rule;
        }

        private void incomingCallRuleBindingSource_ListChanged(object sender, ListChangedEventArgs e)
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
