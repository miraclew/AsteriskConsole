using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Manager.Controls;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Main.Gui.Forms;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class BackupRestoreView : DataViewControl
    {
        public BackupRestoreView()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (!AsteriskManager.Default.IsCurrentControllerOK())
            {
                return;
            }

            RegisterAsteriskWizard.CheckToolInstall();
            if (!AsteriskManager.Default.CurrentAsteriskController.ToolInstalled)
            {
                this.Enabled = false;
            }
            else
            {
                this.backupBindingSource.DataSource = server.Backups;
                this.Enabled = true;
            }
        }

        private void addNewBackupButton_Click(object sender, EventArgs e)
        {
            CreateBackupDlg dlg = new CreateBackupDlg();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Backup backup = Backup.CreateNew(dlg.FileName);
                server.CreateBackup(backup.FileName);
                this.backupBindingSource.Add(backup);
            }
        }

        private void backupVisualAsteriskDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Backup backup = this.backupVisualAsteriskDataGrid.Rows[e.RowIndex].DataBoundItem as Backup;
            if (backup == null)
            {
                return;                
            }

            if (e.ColumnIndex == restoreColumn.Index)
            {
                server.RestoreConfig(backup.FileName);
            }
            else if (e.ColumnIndex == deleteColumn.Index)
            {
                if (MessageBox.Show("Delete selected file ?",
                    "Delete Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    server.RemoveBackupFile(backup.FileName);
                    this.backupBindingSource.Remove(backup);
                }
            }
        }
    }
}
