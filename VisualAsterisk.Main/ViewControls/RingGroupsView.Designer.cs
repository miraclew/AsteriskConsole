namespace VisualAsterisk.Main.ViewControls
{
    partial class RingGroupsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RingGroupsView));
            this.ringGroupVisualAsteriskEditDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.ringGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addNewRingGroupButton = new IC.Controls.LinkButton();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttomPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupVisualAsteriskEditDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            this.buttomPanel.AccessibleDescription = null;
            this.buttomPanel.AccessibleName = null;
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            this.buttomPanel.BackgroundImage = null;
            this.buttomPanel.Controls.Add(this.addNewRingGroupButton);
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
            this.infoProvider.SetIconAlignment(this.topPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("topPanel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.topPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("topPanel.IconAlignment1"))));
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
            this.contentPanel.Controls.Add(this.ringGroupVisualAsteriskEditDataGrid);
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
            // ringGroupVisualAsteriskEditDataGrid
            // 
            this.ringGroupVisualAsteriskEditDataGrid.AccessibleDescription = null;
            this.ringGroupVisualAsteriskEditDataGrid.AccessibleName = null;
            this.ringGroupVisualAsteriskEditDataGrid.AllowUserToAddRows = false;
            this.ringGroupVisualAsteriskEditDataGrid.AllowUserToDeleteRows = false;
            this.ringGroupVisualAsteriskEditDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.ringGroupVisualAsteriskEditDataGrid, "ringGroupVisualAsteriskEditDataGrid");
            this.ringGroupVisualAsteriskEditDataGrid.AutoGenerateColumns = false;
            this.ringGroupVisualAsteriskEditDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ringGroupVisualAsteriskEditDataGrid.BackgroundImage = null;
            this.ringGroupVisualAsteriskEditDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ringGroupVisualAsteriskEditDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ringGroupVisualAsteriskEditDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ringGroupVisualAsteriskEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ringGroupVisualAsteriskEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.SerialNo});
            this.ringGroupVisualAsteriskEditDataGrid.DataSource = this.ringGroupBindingSource;
            this.infoProvider.SetError(this.ringGroupVisualAsteriskEditDataGrid, resources.GetString("ringGroupVisualAsteriskEditDataGrid.Error"));
            this.errorProvider.SetError(this.ringGroupVisualAsteriskEditDataGrid, resources.GetString("ringGroupVisualAsteriskEditDataGrid.Error1"));
            this.ringGroupVisualAsteriskEditDataGrid.Font = null;
            this.errorProvider.SetIconAlignment(this.ringGroupVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ringGroupVisualAsteriskEditDataGrid.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.ringGroupVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ringGroupVisualAsteriskEditDataGrid.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.ringGroupVisualAsteriskEditDataGrid, ((int)(resources.GetObject("ringGroupVisualAsteriskEditDataGrid.IconPadding"))));
            this.infoProvider.SetIconPadding(this.ringGroupVisualAsteriskEditDataGrid, ((int)(resources.GetObject("ringGroupVisualAsteriskEditDataGrid.IconPadding1"))));
            this.ringGroupVisualAsteriskEditDataGrid.MultiSelect = false;
            this.ringGroupVisualAsteriskEditDataGrid.Name = "ringGroupVisualAsteriskEditDataGrid";
            this.ringGroupVisualAsteriskEditDataGrid.ReadOnly = true;
            this.ringGroupVisualAsteriskEditDataGrid.RowHeadersVisible = false;
            this.ringGroupVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ringGroupVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.ringGroupVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ringGroupVisualAsteriskEditDataGrid.RowTemplate.Height = 32;
            this.ringGroupVisualAsteriskEditDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ringGroupVisualAsteriskEditDataGrid.ShowDeleteColumn = true;
            this.ringGroupVisualAsteriskEditDataGrid.ShowEditColumn = true;
            this.toolTip.SetToolTip(this.ringGroupVisualAsteriskEditDataGrid, resources.GetString("ringGroupVisualAsteriskEditDataGrid.ToolTip"));
            this.ringGroupVisualAsteriskEditDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.ringGroupVisualAsteriskEditDataGrid_DeleteDataRow);
            this.ringGroupVisualAsteriskEditDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.ringGroupVisualAsteriskEditDataGrid_EditDataRow);
            // 
            // ringGroupBindingSource
            // 
            this.ringGroupBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.RingGroup);
            // 
            // addNewRingGroupButton
            // 
            this.addNewRingGroupButton.AccessibleDescription = null;
            this.addNewRingGroupButton.AccessibleName = null;
            resources.ApplyResources(this.addNewRingGroupButton, "addNewRingGroupButton");
            this.addNewRingGroupButton.AntiAliasText = false;
            this.addNewRingGroupButton.BackgroundImage = null;
            this.addNewRingGroupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider.SetError(this.addNewRingGroupButton, resources.GetString("addNewRingGroupButton.Error"));
            this.infoProvider.SetError(this.addNewRingGroupButton, resources.GetString("addNewRingGroupButton.Error1"));
            this.addNewRingGroupButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoProvider.SetIconAlignment(this.addNewRingGroupButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewRingGroupButton.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.addNewRingGroupButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewRingGroupButton.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.addNewRingGroupButton, ((int)(resources.GetObject("addNewRingGroupButton.IconPadding"))));
            this.errorProvider.SetIconPadding(this.addNewRingGroupButton, ((int)(resources.GetObject("addNewRingGroupButton.IconPadding1"))));
            this.addNewRingGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewRingGroupButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewRingGroupButton.Name = "addNewRingGroupButton";
            this.addNewRingGroupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.addNewRingGroupButton, resources.GetString("addNewRingGroupButton.ToolTip"));
            this.addNewRingGroupButton.UnderlineOnHover = true;
            this.addNewRingGroupButton.Click += new System.EventHandler(this.addNewRingGroupButton_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Strategy";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Members";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "HowLong";
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // SerialNo
            // 
            this.SerialNo.DataPropertyName = "SerialNo";
            resources.ApplyResources(this.SerialNo, "SerialNo");
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            // 
            // RingGroupsView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.ringgoup_48;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "RingGroupsView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.buttomPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupVisualAsteriskEditDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid ringGroupVisualAsteriskEditDataGrid;
        private System.Windows.Forms.BindingSource ringGroupBindingSource;
        private IC.Controls.LinkButton addNewRingGroupButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
    }
}