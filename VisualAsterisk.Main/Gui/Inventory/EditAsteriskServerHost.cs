using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui.Inventory
{
    public partial class EditAsteriskServerHost : DialogBase
    {
        private ManagerConnectionInfo asteriskConnectionInfo;

        public ManagerConnectionInfo AsteriskConnectionInfo
        {
            get
            {
                asteriskConnectionInfo = new ManagerConnectionInfo(this.hostTextBox.Text,
                    this.userTextBox.Text, this.passwordTextBox.Text);
                asteriskConnectionInfo.Name = this.textBoxName.Text;
                return asteriskConnectionInfo; 
            }
            set 
            { 
                asteriskConnectionInfo = value;
                this.hostTextBox.Text = asteriskConnectionInfo.Host;
                this.userTextBox.Text = asteriskConnectionInfo.User;
                this.passwordTextBox.Text = asteriskConnectionInfo.Password;
                this.textBoxName.Text = asteriskConnectionInfo.Name;
            }
        }

        public EditAsteriskServerHost()
        {
            InitializeComponent();
        }
    }
}
