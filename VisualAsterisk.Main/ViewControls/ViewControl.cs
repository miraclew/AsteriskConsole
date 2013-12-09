using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.ExceptionManagement;

namespace VisualAsterisk.Main.ViewControls
{
    [Localizable(true)]
    public partial class ViewControl : UserControl
    {
        private Image headerIcon = null;
        private string headerTitle = "";
        private string headerCaption = "";
        protected IAsteriskServer server;
        protected IAsteriskConfigManager configManager;

        public ViewControl()
        {
            InitializeComponent();
            //this.Enabled = false;
        }

        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image HeaderIcon
        {
            get
            {
                return headerIcon;
            }
            set
            {
                headerIcon = value;
            }
        }

        [Localizable(true)]
        public string HeaderTitle
        {
            get
            {
                return headerTitle;
            }
            set
            {
                headerTitle = value;
            }
        }

        [Localizable(true)]
        public string HeaderCaption
        {
            get
            {
                return headerCaption;
            }
            set
            {
                headerCaption = value;
            }
        }

        public bool LoadData()
        {
            Cursor.Current = Cursors.WaitCursor;
            OnLoadData();
            Cursor.Current = Cursors.Default;

            return true;
        }

        public bool SaveData()
        {
            Cursor.Current = Cursors.WaitCursor;

            OnSaveData();
            Cursor.Current = Cursors.Default;

            return true;
        }

        protected virtual void OnLoadData()
        {
            if (AsteriskManager.Default.IsCurrentControllerOK())
            {
                Server = AsteriskManager.Default.CurrentAsteriskController.Server;
            }
            else
            {
                Server = null;
                this.Enabled = false;
            }
        }

        protected virtual void OnSaveData()
        {
        }

        public virtual IAsteriskServer Server
        {
            get { return server; }
            set
            {
                server = value;
                if (server == null)
                {
                    this.Enabled = false;
                }
                else
                {
                    if (!value.IsConnected())
                    {
                        throw new ArgumentException("Server is not connected", "Server");
                    }
                    server.StateChanged += new EventHandler<ServerStateEventArg>(server_StateChanged);
                    configManager = server.ConfigManager;
                    this.Enabled = true;
                }
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
