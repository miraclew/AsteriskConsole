using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using WeifenLuo.WinFormsUI.Docking;

namespace VisualAsterisk.Main.Gui
{
    public partial class DockPage : DockContent
    {
        public DockPage()
        {
            InitializeComponent();
            this.Enabled = false;
            //this.HideOnClose = true;
        }

        protected IAsteriskServer server;
        protected IAsteriskConfigManager configManager;

        public virtual IAsteriskServer Server
        {
            get { return server; }
            set {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (!value.IsConnected())
                {
                    throw new ArgumentException("Server is not connected", "Server");
                }
                server = value;
                server.StateChanged += new EventHandler<ServerStateEventArg>(server_StateChanged);
                configManager = server.ConfigManager;
                this.Enabled = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Use tooltips to populate the "information provider"
            foreach (Control control in this.Controls)
            {
                string toolTip = this.toolTip.GetToolTip(control);
                if (toolTip.Length == 0) continue;
                this.infoProvider.SetError(control, toolTip);
            }
        }

        protected void UpdateErrorStatus(bool isValid, Control control, CancelEventArgs e)
        {
            string toolTip = this.toolTip.GetToolTip(control);
            if (isValid)
            {
                // Show the info when there is text in the text box
                this.errorProvider.SetError(control, null);
                this.infoProvider.SetError(control, toolTip);
            }
            else
            {
                // Show the error when there is no text in the text box
                this.errorProvider.SetError(control, toolTip);
                this.infoProvider.SetError(control, null);
                e.Cancel = true;
            }
        }

        void server_StateChanged(object sender, ServerStateEventArg e)
        {
            if (e.State != ServerState.Initilized)
            {
                this.Enabled = false;
            }
        }
    }
}
