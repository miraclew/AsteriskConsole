using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.Gui.Inventory;

namespace VisualAsterisk.Test.Main.Gui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ConnectAsteriskServerProgress progress = new ConnectAsteriskServerProgress();
        int percentCounter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (progress.Visible)
            {
                progress.Hide();
            }
            else
            {
                progress.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            percentCounter += 10;
            if (percentCounter > 100)
            {
                percentCounter = 0;
            }
            progress.SetProgressPercent(percentCounter);
            progress.SetProgressText(string.Format("Text: {0:D}", percentCounter));
        }
    }
}
