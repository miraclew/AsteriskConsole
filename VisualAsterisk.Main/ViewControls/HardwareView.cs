using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Main.Gui.Forms;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class HardwareView  : ViewControl
    {
        // "Name", "Location", "Type","Total channels",  "State"
        public HardwareView()
        {
            InitializeComponent();
            foreach (ColumnHeader  item in this.zapDevicesListView.Columns)
            {
                item.Width = -1;
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
                this.Enabled = true;
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