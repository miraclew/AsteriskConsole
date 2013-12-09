using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class CreateBackupDlg : DialogBase
    {
        public CreateBackupDlg()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get { return this.textBox1.Text; }
        }
        private void CreateBackupDlg_Load(object sender, EventArgs e)
        {

        }
    }
}
