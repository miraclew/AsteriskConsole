namespace VisualAsterisk.Main.ViewControls
{
    partial class UsersView2
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param Name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersView2));
            this.userExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addNewUserButton = new IC.Controls.LinkButton();
            this.userExtensionVisualAsteriskEditDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionVisualAsteriskEditDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // infoProvider
            // 
            resources.ApplyResources(this.infoProvider, "infoProvider");
            // 
            // errorProvider
            // 
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // userExtensionBindingSource
            // 
            this.userExtensionBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.UserExtension);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.errorProvider.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.infoProvider.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.panel1.Font = null;
            this.errorProvider.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.panel1.Name = "panel1";
            this.toolTip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = null;
            this.panel2.AccessibleName = null;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackgroundImage = null;
            this.panel2.Controls.Add(this.addNewUserButton);
            this.errorProvider.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.infoProvider.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.panel2.Font = null;
            this.errorProvider.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.infoProvider.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.panel2.Name = "panel2";
            this.toolTip.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.AccessibleDescription = null;
            this.addNewUserButton.AccessibleName = null;
            resources.ApplyResources(this.addNewUserButton, "addNewUserButton");
            this.addNewUserButton.AntiAliasText = false;
            this.addNewUserButton.BackgroundImage = null;
            this.addNewUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider.SetError(this.addNewUserButton, resources.GetString("addNewUserButton.Error"));
            this.infoProvider.SetError(this.addNewUserButton, resources.GetString("addNewUserButton.Error1"));
            this.addNewUserButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoProvider.SetIconAlignment(this.addNewUserButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewUserButton.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.addNewUserButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addNewUserButton.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.addNewUserButton, ((int)(resources.GetObject("addNewUserButton.IconPadding"))));
            this.errorProvider.SetIconPadding(this.addNewUserButton, ((int)(resources.GetObject("addNewUserButton.IconPadding1"))));
            this.addNewUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewUserButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.addNewUserButton, resources.GetString("addNewUserButton.ToolTip"));
            this.addNewUserButton.UnderlineOnHover = true;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // userExtensionVisualAsteriskEditDataGrid
            // 
            this.userExtensionVisualAsteriskEditDataGrid.AccessibleDescription = null;
            this.userExtensionVisualAsteriskEditDataGrid.AccessibleName = null;
            this.userExtensionVisualAsteriskEditDataGrid.AllowUserToAddRows = false;
            this.userExtensionVisualAsteriskEditDataGrid.AllowUserToDeleteRows = false;
            this.userExtensionVisualAsteriskEditDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.userExtensionVisualAsteriskEditDataGrid, "userExtensionVisualAsteriskEditDataGrid");
            this.userExtensionVisualAsteriskEditDataGrid.AutoGenerateColumns = false;
            this.userExtensionVisualAsteriskEditDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.userExtensionVisualAsteriskEditDataGrid.BackgroundImage = null;
            this.userExtensionVisualAsteriskEditDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userExtensionVisualAsteriskEditDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userExtensionVisualAsteriskEditDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userExtensionVisualAsteriskEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userExtensionVisualAsteriskEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.userExtensionVisualAsteriskEditDataGrid.DataSource = this.userExtensionBindingSource;
            this.infoProvider.SetError(this.userExtensionVisualAsteriskEditDataGrid, resources.GetString("userExtensionVisualAsteriskEditDataGrid.Error"));
            this.errorProvider.SetError(this.userExtensionVisualAsteriskEditDataGrid, resources.GetString("userExtensionVisualAsteriskEditDataGrid.Error1"));
            this.userExtensionVisualAsteriskEditDataGrid.Font = null;
            this.errorProvider.SetIconAlignment(this.userExtensionVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("userExtensionVisualAsteriskEditDataGrid.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.userExtensionVisualAsteriskEditDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("userExtensionVisualAsteriskEditDataGrid.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.userExtensionVisualAsteriskEditDataGrid, ((int)(resources.GetObject("userExtensionVisualAsteriskEditDataGrid.IconPadding"))));
            this.infoProvider.SetIconPadding(this.userExtensionVisualAsteriskEditDataGrid, ((int)(resources.GetObject("userExtensionVisualAsteriskEditDataGrid.IconPadding1"))));
            this.userExtensionVisualAsteriskEditDataGrid.MultiSelect = false;
            this.userExtensionVisualAsteriskEditDataGrid.Name = "userExtensionVisualAsteriskEditDataGrid";
            this.userExtensionVisualAsteriskEditDataGrid.ReadOnly = true;
            this.userExtensionVisualAsteriskEditDataGrid.RowHeadersVisible = false;
            this.userExtensionVisualAsteriskEditDataGrid.RowImage = global::VisualAsterisk.Main.Properties.Resources.user_24;
            this.userExtensionVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userExtensionVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.userExtensionVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.userExtensionVisualAsteriskEditDataGrid.RowTemplate.Height = 32;
            this.userExtensionVisualAsteriskEditDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userExtensionVisualAsteriskEditDataGrid.ShowDeleteColumn = true;
            this.userExtensionVisualAsteriskEditDataGrid.ShowEditColumn = true;
            this.toolTip.SetToolTip(this.userExtensionVisualAsteriskEditDataGrid, resources.GetString("userExtensionVisualAsteriskEditDataGrid.ToolTip"));
            this.userExtensionVisualAsteriskEditDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.userExtensionVisualAsteriskEditDataGrid_DeleteDataRow);
            this.userExtensionVisualAsteriskEditDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.userExtensionVisualAsteriskEditDataGrid_EditDataRow);
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Extension";
            resources.ApplyResources(this.dataGridViewTextBoxColumn18, "dataGridViewTextBoxColumn18");
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FullName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Password";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Vmsecret";
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Email";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CidNumber";
            resources.ApplyResources(this.dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Zapchan";
            resources.ApplyResources(this.dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // UsersView2
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.userExtensionVisualAsteriskEditDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.user1_telephone_48_shadow;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "UsersView2";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionVisualAsteriskEditDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource userExtensionBindingSource;
        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid userExtensionVisualAsteriskEditDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private IC.Controls.LinkButton addNewUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

    }
}
