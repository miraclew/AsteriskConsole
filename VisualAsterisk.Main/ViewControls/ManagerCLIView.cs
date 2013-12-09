using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Event;
using Asterisk.NET.Manager.Response;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class ManagerCLIView : ViewControl
    {        
        public ManagerCLIView()
        {
            InitializeComponent();
            this.cliShellTextBox.Text = "CLI>";

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (server.IsConnected())
            {
                cliShellTextBox.Text = cliShellTextBox.Text + "\r\n\r\n" + "CLI>" + cmdInputTextBox.Text;
                IList<string> response = server.ExecuteCliCommand(cmdInputTextBox.Text);
                foreach (string item in response)
                {
                    cliShellTextBox.Text = cliShellTextBox.Text + "\r\n" + item;
                    cliShellTextBox.ScrollToCaret();
                }
                cmdInputTextBox.Text = string.Empty;
            }
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            cliShellTextBox.Text = string.Empty;
        }

        private void cmdInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                sendButton_Click(sender, e);
            }
        }
    }
}