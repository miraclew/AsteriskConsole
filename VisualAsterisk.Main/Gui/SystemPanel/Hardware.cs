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
    public partial class Hardware : DockPage
    {
        // "Name", "Location", "Type","Total channels",  "State"
        public Hardware()
        {
            InitializeComponent();
            foreach (ColumnHeader  item in this.zapDevicesListView.Columns)
            {
                item.Width = -1;
            }
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
                IList<ZapDevice> zapDevices = configManager.GetAllZapDevices(false);
                this.SuspendLayout();
                this.zapDevicesListView.Items.Clear();
                foreach (ZapDevice item in zapDevices)
                {
                    ListViewItem viewItem = new ListViewItem(
                        new string[] { item.Name+" "+item.Description, 
                                item.Location, item.Type, item.Totchans.ToString(), 
                                item.Active?"Active":"Unknow" });
                    viewItem.Tag = item;
                    this.zapDevicesListView.Items.Add(viewItem);
                }
                if (this.zapDevicesListView.Items.Count > 0)
                {
                    this.zapDevicesListView.BringToFront();
                }
                else
                {
                    this.noDeviceLabel.BringToFront();
                }
                this.ResumeLayout(true);
            }
        }

        private void analogDevicesListView_DoubleClick(object sender, EventArgs e)
        {
            if (zapDevicesListView.SelectedItems.Count <= 0) return;
            ZapDevice zapDevice = zapDevicesListView.SelectedItems[0].Tag as ZapDevice;
            if (zapDevice != null)
            {
                ZapDeviceInfo dlg = new ZapDeviceInfo(zapDevice);
                dlg.ShowDialog();
            }
        }
    }
}