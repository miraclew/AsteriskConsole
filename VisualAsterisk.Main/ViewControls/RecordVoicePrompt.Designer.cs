namespace VisualAsterisk.Main.ViewControls
{
    partial class RecordVoicePrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordVoicePrompt));
            this.visualAsteriskDataGrid1 = new VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.recordAgainColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.recordVoicePromptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addNewVoicePromptButton = new IC.Controls.LinkButton();
            this.refreshButton = new IC.Controls.LinkButton();
            this.buttomPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualAsteriskDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordVoicePromptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            this.buttomPanel.AccessibleDescription = null;
            this.buttomPanel.AccessibleName = null;
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            this.buttomPanel.BackgroundImage = null;
            this.buttomPanel.Controls.Add(this.refreshButton);
            this.buttomPanel.Controls.Add(this.addNewVoicePromptButton);
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
            this.contentPanel.Controls.Add(this.visualAsteriskDataGrid1);
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
            // visualAsteriskDataGrid1
            // 
            this.visualAsteriskDataGrid1.AccessibleDescription = null;
            this.visualAsteriskDataGrid1.AccessibleName = null;
            this.visualAsteriskDataGrid1.AllowUserToAddRows = false;
            this.visualAsteriskDataGrid1.AllowUserToDeleteRows = false;
            this.visualAsteriskDataGrid1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.visualAsteriskDataGrid1, "visualAsteriskDataGrid1");
            this.visualAsteriskDataGrid1.AutoGenerateColumns = false;
            this.visualAsteriskDataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.visualAsteriskDataGrid1.BackgroundImage = null;
            this.visualAsteriskDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visualAsteriskDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.visualAsteriskDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.visualAsteriskDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualAsteriskDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.playColumn,
            this.recordAgainColumn,
            this.deleteColumn});
            this.visualAsteriskDataGrid1.DataSource = this.recordVoicePromptBindingSource;
            this.errorProvider.SetError(this.visualAsteriskDataGrid1, resources.GetString("visualAsteriskDataGrid1.Error"));
            this.infoProvider.SetError(this.visualAsteriskDataGrid1, resources.GetString("visualAsteriskDataGrid1.Error1"));
            this.visualAsteriskDataGrid1.Font = null;
            this.infoProvider.SetIconAlignment(this.visualAsteriskDataGrid1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("visualAsteriskDataGrid1.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.visualAsteriskDataGrid1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("visualAsteriskDataGrid1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.visualAsteriskDataGrid1, ((int)(resources.GetObject("visualAsteriskDataGrid1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.visualAsteriskDataGrid1, ((int)(resources.GetObject("visualAsteriskDataGrid1.IconPadding1"))));
            this.visualAsteriskDataGrid1.Name = "visualAsteriskDataGrid1";
            this.visualAsteriskDataGrid1.ReadOnly = true;
            this.visualAsteriskDataGrid1.RowHeadersVisible = false;
            this.visualAsteriskDataGrid1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.visualAsteriskDataGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.visualAsteriskDataGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.visualAsteriskDataGrid1.RowTemplate.Height = 32;
            this.visualAsteriskDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip.SetToolTip(this.visualAsteriskDataGrid1, resources.GetString("visualAsteriskDataGrid1.ToolTip"));
            this.visualAsteriskDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visualAsteriskDataGrid1_CellContentClick);
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            resources.ApplyResources(this.fileNameDataGridViewTextBoxColumn, "fileNameDataGridViewTextBoxColumn");
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playColumn
            // 
            this.playColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.playColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.playColumn.LinkColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.playColumn, "playColumn");
            this.playColumn.Name = "playColumn";
            this.playColumn.ReadOnly = true;
            this.playColumn.Text = "";
            this.playColumn.TrackVisitedState = false;
            this.playColumn.UseColumnTextForLinkValue = true;
            // 
            // recordAgainColumn
            // 
            this.recordAgainColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recordAgainColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.recordAgainColumn.LinkColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.recordAgainColumn, "recordAgainColumn");
            this.recordAgainColumn.Name = "recordAgainColumn";
            this.recordAgainColumn.ReadOnly = true;
            this.recordAgainColumn.Text = "";
            this.recordAgainColumn.TrackVisitedState = false;
            this.recordAgainColumn.UseColumnTextForLinkValue = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deleteColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.deleteColumn.LinkColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.deleteColumn, "deleteColumn");
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Text = "";
            this.deleteColumn.TrackVisitedState = false;
            this.deleteColumn.UseColumnTextForLinkValue = true;
            // 
            // recordVoicePromptBindingSource
            // 
            this.recordVoicePromptBindingSource.DataSource = typeof(VisualAsterisk.Main.ViewControls.VoicePrompt);
            // 
            // addNewVoicePromptButton
            // 
            this.addNewVoicePromptButton.AccessibleDescription = null;
            this.addNewVoicePromptButton.AccessibleName = null;
            resources.ApplyResources(this.addNewVoicePromptButton, "addNewVoicePromptButton");
            this.addNewVoicePromptButton.AntiAliasText = false;
            this.addNewVoicePromptButton.BackgroundImage = null;
            this.addNewVoicePromptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider.SetError(this.addNewVoicePromptButton, resources.GetString("addNewVoicePromptButton.Error"));
            this.infoProvider.SetError(this.addNewVoicePromptButton, resources.GetString("addNewVoicePromptButton.Error1"));
            this.addNewVoicePromptButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoProvider.SetIconAlignment(this.addNewVoicePromptButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewVoicePromptButton.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.addNewVoicePromptButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewVoicePromptButton.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.addNewVoicePromptButton, ((int)(resources.GetObject("addNewVoicePromptButton.IconPadding"))));
            this.errorProvider.SetIconPadding(this.addNewVoicePromptButton, ((int)(resources.GetObject("addNewVoicePromptButton.IconPadding1"))));
            this.addNewVoicePromptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewVoicePromptButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewVoicePromptButton.Name = "addNewVoicePromptButton";
            this.addNewVoicePromptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.addNewVoicePromptButton, resources.GetString("addNewVoicePromptButton.ToolTip"));
            this.addNewVoicePromptButton.UnderlineOnHover = true;
            this.addNewVoicePromptButton.Click += new System.EventHandler(this.addNewVoicePromptButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleDescription = null;
            this.refreshButton.AccessibleName = null;
            resources.ApplyResources(this.refreshButton, "refreshButton");
            this.refreshButton.AntiAliasText = false;
            this.refreshButton.BackgroundImage = null;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider.SetError(this.refreshButton, resources.GetString("refreshButton.Error"));
            this.infoProvider.SetError(this.refreshButton, resources.GetString("refreshButton.Error1"));
            this.refreshButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoProvider.SetIconAlignment(this.refreshButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("refreshButton.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.refreshButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("refreshButton.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.refreshButton, ((int)(resources.GetObject("refreshButton.IconPadding"))));
            this.errorProvider.SetIconPadding(this.refreshButton, ((int)(resources.GetObject("refreshButton.IconPadding1"))));
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.refreshButton, resources.GetString("refreshButton.ToolTip"));
            this.refreshButton.UnderlineOnHover = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // RecordVoicePrompt
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.record_voice_48;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "RecordVoicePrompt";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.buttomPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualAsteriskDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordVoicePromptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid visualAsteriskDataGrid1;
        private System.Windows.Forms.BindingSource recordVoicePromptBindingSource;
        private IC.Controls.LinkButton addNewVoicePromptButton;
        private IC.Controls.LinkButton refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn playColumn;
        private System.Windows.Forms.DataGridViewLinkColumn recordAgainColumn;
        private System.Windows.Forms.DataGridViewLinkColumn deleteColumn;

    }
}