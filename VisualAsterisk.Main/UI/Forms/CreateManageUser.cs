using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.UI.Forms
{
    public partial class CreateManageUser : Form
    {
        public string User
        {
            get { return userTextBox.Text; }
        }

        public string Password
        {
            get { return passwordTextBox.Text; }
        }

        public CreateManageUser()
        {
            InitializeComponent();
        }
    }
}
