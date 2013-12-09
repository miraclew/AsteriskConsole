namespace VisualAsterisk.Main.ViewControls
{
    partial class QueuesView
    {
        /// <summary>
        /// Required designer Variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueuesView));
            this.queueExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queueExtensionVisualAsteriskEditDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewQueueButton = new IC.Controls.LinkButton();
            this.buttomPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionVisualAsteriskEditDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            this.buttomPanel.AccessibleDescription = null;
            this.buttomPanel.AccessibleName = null;
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            this.buttomPanel.BackgroundImage = null;
            this.buttomPanel.Controls.Add(this.addNewQueueButton);
            this.errorProvider.SetError(this.buttomPanel, resources.GetString("buttomPanel.Error"));
            this.infoProvider.SetError(this.buttomPanel, resources.GetString("buttomPanel.Error1"));
            this.buttomPanel.Font = null;
            this.errorProvider.SetIconAlignment(this.buttomPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttomPanel.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.buttomPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttomPanel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.buttomPanel, ((int)(resources.GetObject("buttomPanel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.buttomPanel, ((int)(resources.GetObject("buttomPanel.IconPadding1"))));
            this.toolTip.SetToolTip(this.buttomPanel, resources.GetString("buttomPanel.ToolTip"));
            // 
            // topPanel
            // 
            this.topPanel.AccessibleDescription = null;
            this.topPanel.AccessibleName = null;
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.BackgroundImage = null;
            this.errorProvider.SetError(this.topPanel, resources.GetString("topPanel.Error"));
            this.infoProvider.SetError(this.topPanel, resources.GetString("topPanel.Error1"));
            this.topPanel.Font = null;
            this.errorProvider.SetIconAlignment(this.topPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("topPanel.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.topPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("topPanel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.topPanel, ((int)(resources.GetObject("topPanel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.topPanel, ((int)(resources.GetObject("topPanel.IconPadding1"))));
            this.toolTip.SetToolTip(this.topPanel, resources.GetString("topPanel.ToolTip"));
            // 
            // contentPanel
            // 
            this.contentPanel.AccessibleDescription = null;
            this.contentPanel.AccessibleName = null;
            resources.ApplyResources(this.contentPanel, "contentPanel");
            this.contentPanel.BackgroundImage = null;
            this.contentPanel.Controls.Add(this.queueExtensionVisualAsteriskEditDataGrid);
            this.errorProvider.SetError(this.contentPanel, resources.GetString("contentPanel.Error"));
            this.infoProvider.SetError(this.contentPanel, resources.GetString("contentPanel.Error1"));
            this.contentPanel.Font = null;
            this.errorProvider.SetIconAlignment(this.contentPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("contentPanel.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.contentPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("contentPanel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.contentPanel, ((int)(resources.GetObject("contentPanel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.contentPanel, ((int)(resources.GetObject("contentPanel.IconPadding1"))));
            this.toolTip.SetToolTip(this.contentPanel, resources.GetString("contentPanel.ToolTip"));
            // 
            // infoProvider
            // 
            resources.ApplyResources(this.infoProvider, "infoProvider");
            // 
            // errorProvider
            // 
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // queueExtensionBindingSource
            // 
            this.queueExtensionBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.QueueExtension);
            // 
            // queueExtensionVisualAsteriskEditDataGrid
            // 
            this.queueExtensionVisualAsteriskEditDataGrid.AccessibleDescription = null;
            this.queueExtensionVisualAsteriskEditDataGrid.AccessibleName = null;
            this.queueExtensionVisualAsteriskEditDataGrid.AllowUserToAddRows = false;
            this.queueExtensionVisualAsteriskEditDataGrid.AllowUserToDeleteRows = false;
            this.queueExtensionVisualAsteriskEditDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.queueExtensionVisualAsteriskEditDataGrid, "queueExtensionVisualAsteriskEditDataGrid");
            this.queueExtensionVisualAsteriskEditDataGrid.AutoGenerateColumns = false;
            this.queueExtensionVisualAsteriskEditDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.queueExtensionVisualAsteriskEditDataGrid.BackgroundImage = null;
            this.queueExtensionVisualAsteriskEditDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queueExtensionVisualAsteriskEditDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.queueExtensionVisualAsteriskEditDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.queueExtensionVisualAsteriskEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queueExtensionVisualAsteriskEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Timeout});
            this.queueExtensionVisualAsteriskEditDataGrid.DataSource = this.queueExtensionBindingSource;
            this.infoProvider.SetError(this.queueExtensionVisualAsteriskEditDataGrid, resources.GetString("queueExtensionVisualAsteriskEditDataGrid.Error"));
            this.errorProvider.SetError(this.queueExtensionVisualAsteriskEditDataGrid, resources.GetString("queueExtensionVisualAsteriskEditDataGrid.Error1"));
            this.queueExtensionVisualAsteriskEditDataGrid.Font = null;
            this.errorProvider.SetIconAlignment(this.queueExtensionVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("queueExtensionVisualAsteriskEditDataGrid.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.queueExtensionVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("queueExtensionVisualAsteriskEditDataGrid.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.queueExtensionVisualAsteriskEditDataGrid, ((int)(resources.GetObject("queueExtensionVisualAsteriskEditDataGrid.IconPadding"))));
            this.infoProvider.SetIconPadding(this.queueExtensionVisualAsteriskEditDataGrid, ((int)(resources.GetObject("queueExtensionVisualAsteriskEditDataGrid.IconPadding1"))));
            this.queueExtensionVisualAsteriskEditDataGrid.MultiSelect = false;
            this.queueExtensionVisualAsteriskEditDataGrid.Name = "queueExtensionVisualAsteriskEditDataGrid";
            this.queueExtensionVisualAsteriskEditDataGrid.ReadOnly = true;
            this.queueExtensionVisualAsteriskEditDataGrid.RowHeadersVisible = false;
            this.queueExtensionVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queueExtensionVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.queueExtensionVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.queueExtensionVisualAsteriskEditDataGrid.RowTemplate.Height = 32;
            this.queueExtensionVisualAsteriskEditDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queueExtensionVisualAsteriskEditDataGrid.ShowDeleteColumn = true;
            this.queueExtensionVisualAsteriskEditDataGrid.ShowEditColumn = true;
            this.toolTip.SetToolTip(this.queueExtensionVisualAsteriskEditDataGrid, resources.GetString("queueExtensionVisualAsteriskEditDataGrid.ToolTip"));
            this.queueExtensionVisualAsteriskEditDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.queueExtensionVisualAsteriskEditDataGrid_DeleteDataRow);
            this.queueExtensionVisualAsteriskEditDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.queueExtensionVisualAsteriskEditDataGrid_EditDataRow);
            this.queueExtensionVisualAsteriskEditDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.queueExtensionVisualAsteriskEditDataGrid_DataError);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Extension";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Strategy";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Timeout
            // 
            this.Timeout.DataPropertyName = "Timeout";
            resources.ApplyResources(this.Timeout, "Timeout");
            this.Timeout.Name = "Timeout";
            this.Timeout.ReadOnly = true;
            // 
            // addNewQueueButton
            // 
            this.addNewQueueButton.AccessibleDescription = null;
            this.addNewQueueButton.AccessibleName = null;
            resources.ApplyResources(this.addNewQueueButton, "addNewQueueButton");
            this.addNewQueueButton.AntiAliasText = false;
            this.addNewQueueButton.BackgroundImage = null;
            this.addNewQueueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider.SetError(this.addNewQueueButton, resources.GetString("addNewQueueButton.Error"));
            this.infoProvider.SetError(this.addNewQueueButton, resources.GetString("addNewQueueButton.Error1"));
            this.addNewQueueButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoProvider.SetIconAlignment(this.addNewQueueButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewQueueButton.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.addNewQueueButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewQueueButton.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.addNewQueueButton, ((int)(resources.GetObject("addNewQueueButton.IconPadding"))));
            this.errorProvider.SetIconPadding(this.addNewQueueButton, ((int)(resources.GetObject("addNewQueueButton.IconPadding1"))));
            this.addNewQueueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewQueueButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewQueueButton.Name = "addNewQueueButton";
            this.addNewQueueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.addNewQueueButton, resources.GetString("addNewQueueButton.ToolTip"));
            this.addNewQueueButton.UnderlineOnHover = true;
            this.addNewQueueButton.Click += new System.EventHandler(this.addNewQueueButton_Click);
            // 
            // QueuesView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.office_chair_48_shadow;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "QueuesView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.buttomPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionVisualAsteriskEditDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid queueExtensionVisualAsteriskEditDataGrid;
        private System.Windows.Forms.BindingSource queueExtensionBindingSource;
        private IC.Controls.LinkButton addNewQueueButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timeout;

    }
}