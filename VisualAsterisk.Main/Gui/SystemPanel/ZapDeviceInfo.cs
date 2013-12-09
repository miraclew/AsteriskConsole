using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class ZapDeviceInfo : VisualAsterisk.Main.Gui.DialogBase
    {
        private ZapDevice device;

        public ZapDeviceInfo(ZapDevice device)
        {
            InitializeComponent();
            this.device = device;
            this.zapDeviceBindingSource.DataSource = this.device;

            foreach (int item in this.device.PortNumberToType.Keys)
            {
                this.portsListView.Items.Add(new ListViewItem(
                    new string[] { item.ToString(), this.device.PortNumberToType[item]}));
            }
        }
    }
}
