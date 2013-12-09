using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Asterisk.NET.Manager;
using Asterisk.NET.Manager.Event;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string address = this.tbAddress.Text;
            int port = int.Parse(this.tbPort.Text);
            string user = this.tbUser.Text;
            string secret = this.tbSecret.Text;

            btnOk.Enabled = false;
            //AsteriskManager manager = new AsteriskManager(address, Port, User, Secret);
            //manager.SkipChannels = false;
            //manager.SkipQueues = false;

            //manager.Events += new ManagerConnectionEventHandler(manager_Events);
            try
            {
                // Remove next 2 line comments to Disable Timeout (debug mode)
                // manager.Connection.DefaultTimeout = 0;
                // manager.Connection.DefaultEventTimeout = 0;
                //asteriskClient.Login();	// Login only (fast)
               // manager.Initialize();		// Login and initialize Queue and channels (slow)
//                ((AdminForm)this.Owner).Manager = manager;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connect\n" + ex.Message);
               // manager.Logoff();
                this.Close();
            }
        }
       
        void manager_Events(object sender, ManagerEvent e)
        {
            Debug.Write("\nEvent : " + e.GetType().Name);
            Debug.Write(e.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}