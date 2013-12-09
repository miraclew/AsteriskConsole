using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Main.Gui.Forms;
using System.Net;
using VisualAsterisk.Core.Management;
using System.Diagnostics;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class SystemInfoView : ViewControl
    {
        private VisualAsterisk.Core.Management.LinuxSystem serverSystemInfo;

        public VisualAsterisk.Core.Management.LinuxSystem ServerSystemInfo
        {
            get { return serverSystemInfo; }
            set
            {
                serverSystemInfo = value;
                this.osVersionLabel.Text = serverSystemInfo.OSVersion;
                this.uptimeLabel.Text = serverSystemInfo.Uptime;
                this.asteriskbuildLabel.Text = serverSystemInfo.AsteriskBuild;
                this.serverDateTimeZoneLabel.Text = serverSystemInfo.ServerDateTimeZone;
                this.hostNameLabel.Text = serverSystemInfo.HostName;

                this.ifConfigTextBox.Text = serverSystemInfo.IfConfig;
                this.diskUsageTextBox.Text = serverSystemInfo.DiskUsage;
                this.memoryUsageTextBox.Text = serverSystemInfo.MemoryUsage;
            }
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (!AsteriskManager.Default.IsCurrentControllerOK())
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
                try
                {
                    this.ServerSystemInfo = server.GetSystemInformation(false);

                }
                catch (WebException we)
                {
                    Trace.WriteLine("Error: GetSystemInformation failed! " + we.Message);
                }
                catch (InvalidSystemInfoException isie)
                {
                    Trace.WriteLine("Error: GetSystemInformation failed! " + isie.Message);
                }
            }
        }

        public SystemInfoView()
        {
            InitializeComponent();
        }
    }
}
