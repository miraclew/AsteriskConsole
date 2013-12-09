using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Main.Controller;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class DialPlanView : ViewControl
    {
        public DialPlanView()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (AsteriskManager.Default.IsCurrentControllerOK())
            {
                this.callingRuleDialPlanBindingSource.DataSource = configManager.Dialplans;
                this.callingRuleBindingSource.DataSource = configManager.CallingRules;
                this.incomingCallRuleBindingSource.DataSource = this.configManager.IncomingCallRules;
            }
        }

        #region outgoing rules

        private void callingRuleDialPlanBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            CallingRuleDialPlan plan = new CallingRuleDialPlan(callingRuleBindingSource.Count + 1);
            plan.AddingNew = true;
            e.NewObject = plan;
        }
        #endregion

        private void callingRuleVisualAsteriskEditDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            CallingRule rule = e.DataRow.DataBoundItem as CallingRule;
            if (MessageBox.Show(string.Format("Do you really want to delete {0}?", rule.Name), "Delete Rule confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                configManager.RemoveCallingRule(rule);
                configManager.fireConfigChanged();
            }
        }

        private void callingRuleVisualAsteriskEditDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            CallingRule rule = e.DataRow.DataBoundItem as CallingRule;
        }

        private void addNewRuleButton_Click(object sender, EventArgs e)
        {
            CallingRule rule = new CallingRule(1);
            AddCallingRuleDlg dlg = new AddCallingRuleDlg();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                configManager.AddCallingRule(rule);
            }
            configManager.fireConfigChanged();
        }

        private void dialPlanDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dialPlanDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            var plan = e.DataRow.DataBoundItem as CallingRuleDialPlan;
            if (plan == null)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Do you want to delete DialPlan {0}", plan.Name),
                "Delete DialPlan Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.callingRuleDialPlanBindingSource.RemoveCurrent();
                if (!plan.AddingNew)
                {
                    configManager.ReomveDialPlan(plan);
                }
            }
        }

        private void dialPlanDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            var plan = e.DataRow.DataBoundItem as CallingRuleDialPlan;
            if (plan == null)
            {
                return;
            }

            //UserEditorForm editor = new UserEditorForm(user, server);
            //if (editor.ShowDialog() == DialogResult.OK)
            //{
            //    configManager.UpdateUser(user);
            //}
            //else
            //{
            //    user.CancelEdit();
            //}

        }

        private void addNewDialPlanButton_Click(object sender, EventArgs e)
        {
            AddDialPlanDlg dlg = new AddDialPlanDlg();
            dlg.DialPlanName = "DialPlan" + (CallingRuleDialPlan.MaxSerialNo + 1).ToString();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CallingRuleDialPlan plan = new CallingRuleDialPlan(CallingRuleDialPlan.MaxSerialNo + 1);
                plan.AddingNew = true;
                plan.Name = dlg.DialPlanName;
                configManager.AddDailPlan(plan);
                configManager.fireConfigChanged();
            }
        }
    }
}
