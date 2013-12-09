using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.UI;
using VisualAsterisk.Main.Controller;
using System.IO;
using System.Collections.Specialized;
using VisualAsterisk.Data.DataProviders;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Data;
using VisualAsterisk.Main.Gui.Forms;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class SummaryView : ViewControl
    {
        public SummaryView()
        {
            InitializeComponent();
            
        }

        private void viewCallHistoryButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.ParentForm).LoadViewControl(new CallDetailRecordView());
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (AsteriskManager.Default.CurrentAsteriskController == null)
            {
                return;
            }

            RegisterAsteriskWizard.CheckToolInstall();
            if (!AsteriskManager.Default.CurrentAsteriskController.ToolInstalled)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = true;
            }

            if (AsteriskManager.Default.IsCurrentControllerOK())
            {

                AsteriskManager.Default.CurrentAsteriskController.Server.LoadCDR(AsteriskManager.Default.CurrentAsteriskController.CDRCsvDirectory, false);
                VisualAsteriskCsvDataProvider dp = new VisualAsteriskCsvDataProvider();
                NameValueCollection nvs = new NameValueCollection();
                nvs.Add("RootDataDirectory", AsteriskManager.Default.CurrentAsteriskController.CDRCsvDirectory);
                dp.Connect(nvs);

                VisualAsteriskDataSet.CallDetailRecordRow[] callHistory = (VisualAsteriskDataSet.CallDetailRecordRow[])dp.Data.CallDetailRecord.Select("", "StartTime DESC");
                toolTip.RemoveAll();
                recentCallsPanel.Controls.Clear();

                // Only display as many as will fit on the screen
                const int labelHeight = 24;
                int maxItems = recentCallsPanel.Height / labelHeight;

                int totalItems = Math.Min(callHistory.Length, maxItems);
                recentCallsPanel.SuspendLayout();
                for (int index = totalItems - 1; index >= 0; index--)
                {
                    Label callItemLabel = CreateCallItemLabel();

                    callItemLabel.Text = callHistory[index].StartTime.ToShortDateString() + " " + callHistory[index].StartTime.ToShortTimeString() + " - ";

                    //if (!callHistory[Index].IsCallerIdNull() && callHistory[Index].CallerId.Length > 0)
                    //    callItemLabel.Text += callHistory[Index].CallerId;
                    //else
                    //    callItemLabel.Text += callHistory[Index].Src;
                    //if (!callHistory[Index].IsAccountCodeNull() && callHistory[Index].CallerUsername.Length > 0)
                    //    callItemLabel.Text += " @ " + ;
                    callItemLabel.Text += callHistory[index].Src + " -> ";
                    callItemLabel.Text += callHistory[index].Destination;
                    callItemLabel.Text += " @ " + callHistory[index].CallerId;
                    toolTip.SetToolTip(callItemLabel, callItemLabel.Text);

                    recentCallsPanel.Controls.Add(callItemLabel);
                }
                recentCallsPanel.ResumeLayout(true);

                //VisualAsterisk.Data.VisualAsteriskDataSet cdrDataSet = new VisualAsterisk.Data.VisualAsteriskDataSet();
                //cdrDataSet.CallDetailRecord.Merge(dp.Data.CallDetailRecord);
                VisualAsteriskDataSet.CallDetailRecordRow[] calls = (VisualAsteriskDataSet.CallDetailRecordRow[])dp.Data.CallDetailRecord.Select("StartTime >= #" + DateTime.Now.ToString("d", System.Globalization.CultureInfo.InvariantCulture) + " 00:00#");
                lblCallsToday.Text = calls.Length.ToString();


                DateTime startDate = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
                calls = (VisualAsteriskDataSet.CallDetailRecordRow[])dp.Data.CallDetailRecord.Select("StartTime >= #" + DateTime.Now.ToString("d", System.Globalization.CultureInfo.InvariantCulture) + "#");
                lblCallsWeek.Text = calls.Length.ToString();

                DateTime now = DateTime.Now;
                startDate = new DateTime(now.Year, now.Month, 1);
                calls = (VisualAsteriskDataSet.CallDetailRecordRow[])dp.Data.CallDetailRecord.Select("StartTime >= #" + DateTime.Now.ToString("d", System.Globalization.CultureInfo.InvariantCulture) + "#");
                lblCallsMonth.Text = calls.Length.ToString();

                lblCallsTotal.Text = dp.Data.CallDetailRecord.Count.ToString();
            }
        }

        private Label CreateCallItemLabel()
        {
            Label label = new Label();

            label.AutoSize = false;
            label.Dock = DockStyle.Top;
            label.AutoEllipsis = true;
            label.Height = 24;

            return label;
        }
    }
}
