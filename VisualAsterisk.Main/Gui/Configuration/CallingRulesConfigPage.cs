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
    public partial class CallingRulesConfigPage : DockPage
    {
        public CallingRulesConfigPage()
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
                this.comboBoxDialplans.DataSource = this.configManager.Dialplans;
            }
        }

        private void comboBoxDialplans_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDictionary<int, CallingRule> rules = this.comboBoxDialplans.SelectedValue as IDictionary<int, CallingRule>;
            this.callingRuleBindingSource.DataSource = rules.Values;
        }

        private void buttonNew_Click(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Do you really want to delete {0} ?", this.comboBoxDialplans.SelectedItem.ToString()), "Delete Dialplan confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CallingRuleDialPlan plan = configManager.FindDailPlan(this.comboBoxDialplans.SelectedItem.ToString());

                if (plan != null && !plan.AddingNew)
                {
                    configManager.ReomveDialPlan(configManager.FindDailPlan(this.comboBoxDialplans.SelectedItem.ToString()));
                    configManager.fireConfigChanged();
                }
            }            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CallingRuleDialPlan plan = configManager.FindDailPlan(this.comboBoxDialplans.SelectedItem.ToString());
            CallingRule rule = new CallingRule(plan.RuleSerialNoCount+1);
            AddCallingRuleDlg dlg = new AddCallingRuleDlg();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                plan.AddRule(rule) ;
            }
            configManager.fireConfigChanged();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            CallingRule rule = this.callingRuleBindingSource.Current as CallingRule;
            if (MessageBox.Show(string.Format("Do you really want to delete {0} from {1}?", rule.Name, this.comboBoxDialplans.SelectedItem.ToString()), "Delete Rule confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                configManager.FindDailPlan(this.comboBoxDialplans.SelectedItem.ToString()).RemoveRule(rule);
                configManager.fireConfigChanged();
            }
            
        }

        private void callingRuleDialPlanBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            CallingRuleDialPlan plan = new CallingRuleDialPlan(callingRuleBindingSource.Count + 1);
            plan.AddingNew = true;
            e.NewObject = plan;
        }
    }
}
