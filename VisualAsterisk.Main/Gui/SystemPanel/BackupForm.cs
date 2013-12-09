using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class BackupForm : DockPage
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        public override VisualAsterisk.Asterisk.IAsteriskServer Server
        {
            get
            {
                return base.Server;
            }
            set
            {
                base.Server = value;
                loadListView();
            }
        }

        private void loadListView()
        {
            this.backupsListView.Items.Clear();
            foreach (string item in server.GetAllBackupFiles())
            {
                // aa__2008dec14.tar
                int index = item.IndexOf("__");
                string fileName = item.Substring(0, index);
                string year = item.Substring(index + 2, 4);
                string month = item.Substring(index + 6, 3).ToUpperInvariant();
                string day = item.Substring(index + 9, item.IndexOf('.') - index - 9);
                ListViewItem listViewItem = new ListViewItem(new string[] { fileName, month + " " + day + "," + year });
                listViewItem.Tag = item;
                this.backupsListView.Items.Add(listViewItem);
            }
        }

        private void newBackupButton_Click(object sender, EventArgs e)
        {
            CreateBackupDlg dlg = new CreateBackupDlg();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                server.CreateBackup(dlg.FileName);
                loadListView();
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (this.backupsListView.SelectedItems.Count <= 0)
            {
                return;
            }
            string fileName = this.backupsListView.SelectedItems[0].Text;
            server.RestoreConfig(fileName);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.backupsListView.SelectedItems.Count <= 0)
            {
                return;
            }
            string fileName = this.backupsListView.SelectedItems[0].Text;

            if (MessageBox.Show("Delete selected file ?",
                "Delete Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                server.RemoveBackupFile(fileName);
                this.backupsListView.Items.Remove(this.backupsListView.SelectedItems[0]);
            }
        }
    }
}
