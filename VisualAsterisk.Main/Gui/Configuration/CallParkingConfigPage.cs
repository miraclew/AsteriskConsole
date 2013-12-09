using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.Configuration
{
    public partial class CallParkingConfigPage : DockPage
    {
        public CallParkingConfigPage()
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
                this.textBoxExtension.Text = configManager.CallParkSetting.Extension;
                this.textBoxParkPos.Text = configManager.CallParkSetting.First + " - " + configManager.CallParkSetting.Last;
                this.textBoxTimeout.Text = configManager.CallParkSetting.Timeout.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            configManager.CallParkSetting.Extension = this.textBoxExtension.Text;
            configManager.CallParkSetting.First = this.textBoxParkPos.Text.Substring(0, this.textBoxParkPos.Text.IndexOf('-')).Trim();
            configManager.CallParkSetting.Last = this.textBoxParkPos.Text.Substring(this.textBoxParkPos.Text.IndexOf('-')+1).Trim();
            configManager.CallParkSetting.Timeout = int.Parse(this.textBoxTimeout.Text);
            configManager.fireConfigChanged();
        }
    }
}
