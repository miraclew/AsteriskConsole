using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Main.Gui.Forms;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class AsteriskLogsView : ViewControl
    {
        public AsteriskLogsView()
        {
            InitializeComponent();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.server == null)
            {
                return;
            }
            DateTime dateTime = dateTimePicker.Value;
            
            string command = "/bin/grep /var/log/asterisk/messages -e ";
            command = command + "'" + dateTime.ToString("MMM d", CultureInfo.CreateSpecificCulture("en-US")) +" '";
            command = command + "> /var/lib/asterisk/static-http/config/today_log.html";
            this.server.ExecuteSystemCommand(command);
            List<string> lines = this.server.GetSysInfoOutput("today_log.html", false);
            this.logMessagesTextBox.Lines = lines.ToArray(); 
        }
    }
}
