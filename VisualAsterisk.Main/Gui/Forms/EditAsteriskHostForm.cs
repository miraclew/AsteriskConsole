using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using  VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class EditAsteriskHostForm : Form
    {
        public EditAsteriskHostForm()
        {
            InitializeComponent();
            asteriskHostInstance = new ManagerConnectionInfo();
            this.asteriskHostBindingSource.DataSource = asteriskHostInstance;
        }

        private ManagerConnectionInfo asteriskHostInstance;

        public ManagerConnectionInfo AsteriskHostInstance
        {
            get { return asteriskHostInstance; }
            set { asteriskHostInstance = value; }
        }
    }
}