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
    public partial class ConnectAsteriskServerProgress : Form
    {
        private AsteriskController asteriskController;
        private TreeNode selectedNode;

        public TreeNode SelectedNode
        {
            get { return selectedNode; }
            set { selectedNode = value; }
        }

        public AsteriskController AsteriskController
        {
            get { return asteriskController; }
            set { asteriskController = value;  }
        }

        public void SetProgressText(string value)
        {
            this.labelProgressText.Text = value;
            labelProgressText.Refresh();
        }

        public void SetProgressPercent(int value)
        {
            this.progressBar1.Value = value;
            progressBar1.Refresh();
        }

        public ConnectAsteriskServerProgress()
        {
            InitializeComponent();
            this.buttonRetry.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetry_Click(object sender, EventArgs e)
        {

        }
    }
}
