namespace VisualAsterisk.Main.ViewControls
{
    partial class ConferenceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceView));
            this.conferenceRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conferenceRoomVisualAsteriskEditDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.addNewConferenceButton = new IC.Controls.LinkButton();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttomPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomVisualAsteriskEditDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            this.buttomPanel.AccessibleDescription = null;
            this.buttomPanel.AccessibleName = null;
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            this.buttomPanel.BackgroundImage = null;
            this.buttomPanel.Controls.Add(this.addNewConferenceButton);
            this.infoProvider.SetError(this.buttomPanel, resources.GetString("buttomPanel.Error"));
            this.errorProvider.SetError(this.buttomPanel, resources.GetString("buttomPanel.Error1"));
            this.buttomPanel.Font = null;
            this.infoProvider.SetIconAlignment(this.buttomPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttomPanel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.buttomPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttomPanel.IconAlignment1"))));
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
            this.contentPanel.Controls.Add(this.conferenceRoomVisualAsteriskEditDataGrid);
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
            // conferenceRoomBindingSource
            // 
            this.conferenceRoomBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.ConferenceRoom);
            // 
            // conferenceRoomVisualAsteriskEditDataGrid
            // 
            this.conferenceRoomVisualAsteriskEditDataGrid.AccessibleDescription = null;
            this.conferenceRoomVisualAsteriskEditDataGrid.AccessibleName = null;
            this.conferenceRoomVisualAsteriskEditDataGrid.AllowUserToAddRows = false;
            this.conferenceRoomVisualAsteriskEditDataGrid.AllowUserToDeleteRows = false;
            this.conferenceRoomVisualAsteriskEditDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.conferenceRoomVisualAsteriskEditDataGrid, "conferenceRoomVisualAsteriskEditDataGrid");
            this.conferenceRoomVisualAsteriskEditDataGrid.AutoGenerateColumns = false;
            this.conferenceRoomVisualAsteriskEditDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.conferenceRoomVisualAsteriskEditDataGrid.BackgroundImage = null;
            this.conferenceRoomVisualAsteriskEditDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conferenceRoomVisualAsteriskEditDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.conferenceRoomVisualAsteriskEditDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.conferenceRoomVisualAsteriskEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conferenceRoomVisualAsteriskEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn7});
            this.conferenceRoomVisualAsteriskEditDataGrid.DataSource = this.conferenceRoomBindingSource;
            this.infoProvider.SetError(this.conferenceRoomVisualAsteriskEditDataGrid, resources.GetString("conferenceRoomVisualAsteriskEditDataGrid.Error"));
            this.errorProvider.SetError(this.conferenceRoomVisualAsteriskEditDataGrid, resources.GetString("conferenceRoomVisualAsteriskEditDataGrid.Error1"));
            this.conferenceRoomVisualAsteriskEditDataGrid.Font = null;
            this.errorProvider.SetIconAlignment(this.conferenceRoomVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("conferenceRoomVisualAsteriskEditDataGrid.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.conferenceRoomVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("conferenceRoomVisualAsteriskEditDataGrid.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.conferenceRoomVisualAsteriskEditDataGrid, ((int)(resources.GetObject("conferenceRoomVisualAsteriskEditDataGrid.IconPadding"))));
            this.infoProvider.SetIconPadding(this.conferenceRoomVisualAsteriskEditDataGrid, ((int)(resources.GetObject("conferenceRoomVisualAsteriskEditDataGrid.IconPadding1"))));
            this.conferenceRoomVisualAsteriskEditDataGrid.MultiSelect = false;
            this.conferenceRoomVisualAsteriskEditDataGrid.Name = "conferenceRoomVisualAsteriskEditDataGrid";
            this.conferenceRoomVisualAsteriskEditDataGrid.ReadOnly = true;
            this.conferenceRoomVisualAsteriskEditDataGrid.RowHeadersVisible = false;
            this.conferenceRoomVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.conferenceRoomVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.conferenceRoomVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.conferenceRoomVisualAsteriskEditDataGrid.RowTemplate.Height = 32;
            this.conferenceRoomVisualAsteriskEditDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conferenceRoomVisualAsteriskEditDataGrid.ShowDeleteColumn = true;
            this.conferenceRoomVisualAsteriskEditDataGrid.ShowEditColumn = true;
            this.toolTip.SetToolTip(this.conferenceRoomVisualAsteriskEditDataGrid, resources.GetString("conferenceRoomVisualAsteriskEditDataGrid.ToolTip"));
            this.conferenceRoomVisualAsteriskEditDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.conferenceRoomVisualAsteriskEditDataGrid_DeleteDataRow);
            this.conferenceRoomVisualAsteriskEditDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.conferenceRoomVisualAsteriskEditDataGrid_EditDataRow);
            // 
            // addNewConferenceButton
            // 
            this.addNewConferenceButton.AccessibleDescription = null;
            this.addNewConferenceButton.AccessibleName = null;
            resources.ApplyResources(this.addNewConferenceButton, "addNewConferenceButton");
            this.addNewConferenceButton.AntiAliasText = false;
            this.addNewConferenceButton.BackgroundImage = null;
            this.addNewConferenceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider.SetError(this.addNewConferenceButton, resources.GetString("addNewConferenceButton.Error"));
            this.infoProvider.SetError(this.addNewConferenceButton, resources.GetString("addNewConferenceButton.Error1"));
            this.addNewConferenceButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoProvider.SetIconAlignment(this.addNewConferenceButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewConferenceButton.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.addNewConferenceButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewConferenceButton.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.addNewConferenceButton, ((int)(resources.GetObject("addNewConferenceButton.IconPadding"))));
            this.errorProvider.SetIconPadding(this.addNewConferenceButton, ((int)(resources.GetObject("addNewConferenceButton.IconPadding1"))));
            this.addNewConferenceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewConferenceButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewConferenceButton.Name = "addNewConferenceButton";
            this.addNewConferenceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.addNewConferenceButton, resources.GetString("addNewConferenceButton.ToolTip"));
            this.addNewConferenceButton.UnderlineOnHover = true;
            this.addNewConferenceButton.Click += new System.EventHandler(this.addNewConferenceButton_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RoomNumber";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pin";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AdminPin";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.DataPropertyName = "AddingNew";
            resources.ApplyResources(this.dataGridViewCheckBoxColumn7, "dataGridViewCheckBoxColumn7");
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            this.dataGridViewCheckBoxColumn7.ReadOnly = true;
            // 
            // ConferenceView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.infoProvider.SetError(this, resources.GetString("$this.Error"));
            this.errorProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.ringgoup_48;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "ConferenceView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.buttomPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomVisualAsteriskEditDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource conferenceRoomBindingSource;
        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid conferenceRoomVisualAsteriskEditDataGrid;
        private IC.Controls.LinkButton addNewConferenceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;

    }
}