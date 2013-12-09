using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Diagnostics;
using VisualAsterisk.Core.Management;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class SystemInfo2 : DockPage
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

        public SystemInfo2()
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
    }
}
