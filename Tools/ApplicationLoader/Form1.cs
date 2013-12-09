using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ApplicationLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(openFileDialog1.FileName);
                this.listView1.Items.Add(item);
                Properties.Settings.Default.ApplicationPathItems.Add(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
                Properties.Settings.Default.ApplicationPathItems.Remove(item.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runSelectedApplication();
        }

        private void runSelectedApplication()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Process process = new Process();
                process.StartInfo.FileName = listView1.SelectedItems[0].Text;
                process.Start();
            }
            else if (listView1.Items.Count > 0)
            {
                Process process = new Process();
                process.StartInfo.FileName = listView1.Items[0].Text;
                process.Start();
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runSelectedApplication();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ApplicationLoader.Properties.Settings.Default.ApplicationPathItems == null)
            {
                ApplicationLoader.Properties.Settings.Default.ApplicationPathItems = new System.Collections.Specialized.StringCollection();
            }

            foreach (string apps in ApplicationLoader.Properties.Settings.Default.ApplicationPathItems)
            {
                ListViewItem item = new ListViewItem(apps);
                this.listView1.Items.Add(item);
            }
            listView1.Select();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationLoader.Properties.Settings.Default.Save();
        }
    }
}
