namespace VisualAsterisk.Main.ViewControls
{
    partial class TrunksView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrunksView));
            this.trunkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trunkVisualAsteriskEditDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.addNewTrunkButton = new IC.Controls.LinkButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttomPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkVisualAsteriskEditDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            this.buttomPanel.AccessibleDescription = null;
            this.buttomPanel.AccessibleName = null;
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            this.buttomPanel.BackgroundImage = null;
            this.buttomPanel.Controls.Add(this.addNewTrunkButton);
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
            this.contentPanel.Controls.Add(this.trunkVisualAsteriskEditDataGrid);
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
            // trunkBindingSource
            // 
            this.trunkBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.Trunk);
            // 
            // trunkVisualAsteriskEditDataGrid
            // 
            this.trunkVisualAsteriskEditDataGrid.AccessibleDescription = null;
            this.trunkVisualAsteriskEditDataGrid.AccessibleName = null;
            this.trunkVisualAsteriskEditDataGrid.AllowUserToAddRows = false;
            this.trunkVisualAsteriskEditDataGrid.AllowUserToDeleteRows = false;
            this.trunkVisualAsteriskEditDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.trunkVisualAsteriskEditDataGrid, "trunkVisualAsteriskEditDataGrid");
            this.trunkVisualAsteriskEditDataGrid.AutoGenerateColumns = false;
            this.trunkVisualAsteriskEditDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.trunkVisualAsteriskEditDataGrid.BackgroundImage = null;
            this.trunkVisualAsteriskEditDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trunkVisualAsteriskEditDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.trunkVisualAsteriskEditDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.trunkVisualAsteriskEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trunkVisualAsteriskEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn17});
            this.trunkVisualAsteriskEditDataGrid.DataSource = this.trunkBindingSource;
            this.infoProvider.SetError(this.trunkVisualAsteriskEditDataGrid, resources.GetString("trunkVisualAsteriskEditDataGrid.Error"));
            this.errorProvider.SetError(this.trunkVisualAsteriskEditDataGrid, resources.GetString("trunkVisualAsteriskEditDataGrid.Error1"));
            this.trunkVisualAsteriskEditDataGrid.Font = null;
            this.errorProvider.SetIconAlignment(this.trunkVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("trunkVisualAsteriskEditDataGrid.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.trunkVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("trunkVisualAsteriskEditDataGrid.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.trunkVisualAsteriskEditDataGrid, ((int)(resources.GetObject("trunkVisualAsteriskEditDataGrid.IconPadding"))));
            this.infoProvider.SetIconPadding(this.trunkVisualAsteriskEditDataGrid, ((int)(resources.GetObject("trunkVisualAsteriskEditDataGrid.IconPadding1"))));
            this.trunkVisualAsteriskEditDataGrid.MultiSelect = false;
            this.trunkVisualAsteriskEditDataGrid.Name = "trunkVisualAsteriskEditDataGrid";
            this.trunkVisualAsteriskEditDataGrid.ReadOnly = true;
            this.trunkVisualAsteriskEditDataGrid.RowHeadersVisible = false;
            this.trunkVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trunkVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.trunkVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.trunkVisualAsteriskEditDataGrid.RowTemplate.Height = 32;
            this.trunkVisualAsteriskEditDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trunkVisualAsteriskEditDataGrid.ShowDeleteColumn = true;
            this.trunkVisualAsteriskEditDataGrid.ShowEditColumn = true;
            this.toolTip.SetToolTip(this.trunkVisualAsteriskEditDataGrid, resources.GetString("trunkVisualAsteriskEditDataGrid.ToolTip"));
            this.trunkVisualAsteriskEditDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.trunkVisualAsteriskEditDataGrid_DeleteDataRow);
            this.trunkVisualAsteriskEditDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.trunkVisualAsteriskEditDataGrid_EditDataRow);
            // 
            // addNewTrunkButton
            // 
            this.addNewTrunkButton.AccessibleDescription = null;
            this.addNewTrunkButton.AccessibleName = null;
            resources.ApplyResources(this.addNewTrunkButton, "addNewTrunkButton");
            this.addNewTrunkButton.AntiAliasText = false;
            this.addNewTrunkButton.BackgroundImage = null;
            this.addNewTrunkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider.SetError(this.addNewTrunkButton, resources.GetString("addNewTrunkButton.Error"));
            this.infoProvider.SetError(this.addNewTrunkButton, resources.GetString("addNewTrunkButton.Error1"));
            this.addNewTrunkButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoProvider.SetIconAlignment(this.addNewTrunkButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewTrunkButton.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.addNewTrunkButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewTrunkButton.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.addNewTrunkButton, ((int)(resources.GetObject("addNewTrunkButton.IconPadding"))));
            this.errorProvider.SetIconPadding(this.addNewTrunkButton, ((int)(resources.GetObject("addNewTrunkButton.IconPadding1"))));
            this.addNewTrunkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewTrunkButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewTrunkButton.Name = "addNewTrunkButton";
            this.addNewTrunkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.addNewTrunkButton, resources.GetString("addNewTrunkButton.ToolTip"));
            this.addNewTrunkButton.UnderlineOnHover = true;
            this.addNewTrunkButton.Click += new System.EventHandler(this.addNewTrunkButton_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TrunkTech";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Trunkname";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Host";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Username";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Cid";
            resources.ApplyResources(this.dataGridViewTextBoxColumn14, "dataGridViewTextBoxColumn14");
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Contact";
            resources.ApplyResources(this.dataGridViewTextBoxColumn17, "dataGridViewTextBoxColumn17");
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // TrunksView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.earth_connection_48_shadow;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "TrunksView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.buttomPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkVisualAsteriskEditDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource trunkBindingSource;
        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid trunkVisualAsteriskEditDataGrid;
        private IC.Controls.LinkButton addNewTrunkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

    }
}