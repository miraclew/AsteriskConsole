namespace VisualAsterisk.Main.ViewControls
{
    partial class BackupRestoreView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRestoreView));
            this.addNewBackupButton = new IC.Controls.LinkButton();
            this.backupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backupVisualAsteriskDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restoreColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttomPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupVisualAsteriskDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            this.buttomPanel.Controls.Add(this.addNewBackupButton);
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            // 
            // topPanel
            // 
            resources.ApplyResources(this.topPanel, "topPanel");
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.backupVisualAsteriskDataGrid);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            // 
            // addNewBackupButton
            // 
            this.addNewBackupButton.AntiAliasText = false;
            resources.ApplyResources(this.addNewBackupButton, "addNewBackupButton");
            this.addNewBackupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewBackupButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addNewBackupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBackupButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewBackupButton.Name = "addNewBackupButton";
            this.addNewBackupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBackupButton.UnderlineOnHover = true;
            this.addNewBackupButton.Click += new System.EventHandler(this.addNewBackupButton_Click);
            // 
            // backupBindingSource
            // 
            this.backupBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Backup);
            // 
            // backupVisualAsteriskDataGrid
            // 
            this.backupVisualAsteriskDataGrid.AllowUserToAddRows = false;
            this.backupVisualAsteriskDataGrid.AllowUserToDeleteRows = false;
            this.backupVisualAsteriskDataGrid.AllowUserToResizeRows = false;
            this.backupVisualAsteriskDataGrid.AutoGenerateColumns = false;
            this.backupVisualAsteriskDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.backupVisualAsteriskDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backupVisualAsteriskDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.backupVisualAsteriskDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.backupVisualAsteriskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.backupVisualAsteriskDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.restoreColumn,
            this.deleteColumn});
            this.backupVisualAsteriskDataGrid.DataSource = this.backupBindingSource;
            resources.ApplyResources(this.backupVisualAsteriskDataGrid, "backupVisualAsteriskDataGrid");
            this.backupVisualAsteriskDataGrid.Name = "backupVisualAsteriskDataGrid";
            this.backupVisualAsteriskDataGrid.ReadOnly = true;
            this.backupVisualAsteriskDataGrid.RowHeadersVisible = false;
            this.backupVisualAsteriskDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backupVisualAsteriskDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.backupVisualAsteriskDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.backupVisualAsteriskDataGrid.RowTemplate.Height = 32;
            this.backupVisualAsteriskDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.backupVisualAsteriskDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.backupVisualAsteriskDataGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TakenTime";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // restoreColumn
            // 
            this.restoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.restoreColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.restoreColumn.LinkColor = System.Drawing.Color.RoyalBlue;
            this.restoreColumn.Name = "restoreColumn";
            this.restoreColumn.ReadOnly = true;
            this.restoreColumn.Text = "Restore";
            this.restoreColumn.HeaderText = "";
            this.restoreColumn.TrackVisitedState = false;
            this.restoreColumn.UseColumnTextForLinkValue = true;
            resources.ApplyResources(this.restoreColumn, "restoreColumn");
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deleteColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.deleteColumn.LinkColor = System.Drawing.Color.RoyalBlue;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Text = "Delete";
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.TrackVisitedState = false;
            this.deleteColumn.UseColumnTextForLinkValue = true;
            resources.ApplyResources(this.deleteColumn, "deleteColumn");
            // 
            // BackupRestoreView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.folder_tar_48;
            this.Name = "BackupRestoreView";
            this.buttomPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupVisualAsteriskDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private IC.Controls.LinkButton addNewBackupButton;
        private VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid backupVisualAsteriskDataGrid;
        private System.Windows.Forms.BindingSource backupBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn restoreColumn;
        private System.Windows.Forms.DataGridViewLinkColumn deleteColumn;


    }
}