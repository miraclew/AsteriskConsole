namespace VisualAsterisk.Main.ViewControls
{
    partial class DialPlanView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialPlanView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dialPlansTabPage = new System.Windows.Forms.TabPage();
            this.addNewDialPlanButton = new IC.Controls.LinkButton();
            this.dialPlanDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allRulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callingRuleDialPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewRuleButton = new IC.Controls.LinkButton();
            this.callingRuleVisualAsteriskEditDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrunkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callingRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addNewIncomingCallRuleButton = new IC.Controls.LinkButton();
            this.incomingCallRuleVisualAsteriskEditDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.incomingCallRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.dialPlansTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlanDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleDialPlanBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleVisualAsteriskEditDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleVisualAsteriskEditDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // infoProvider
            // 
            resources.ApplyResources(this.infoProvider, "infoProvider");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dialPlansTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // dialPlansTabPage
            // 
            this.dialPlansTabPage.Controls.Add(this.addNewDialPlanButton);
            this.dialPlansTabPage.Controls.Add(this.dialPlanDataGrid);
            resources.ApplyResources(this.dialPlansTabPage, "dialPlansTabPage");
            this.dialPlansTabPage.Name = "dialPlansTabPage";
            this.dialPlansTabPage.UseVisualStyleBackColor = true;
            // 
            // addNewDialPlanButton
            // 
            resources.ApplyResources(this.addNewDialPlanButton, "addNewDialPlanButton");
            this.addNewDialPlanButton.AntiAliasText = false;
            this.addNewDialPlanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewDialPlanButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addNewDialPlanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewDialPlanButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewDialPlanButton.Name = "addNewDialPlanButton";
            this.addNewDialPlanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewDialPlanButton.UnderlineOnHover = true;
            this.addNewDialPlanButton.Click += new System.EventHandler(this.addNewDialPlanButton_Click);
            // 
            // dialPlanDataGrid
            // 
            this.dialPlanDataGrid.AllowUserToAddRows = false;
            this.dialPlanDataGrid.AllowUserToDeleteRows = false;
            this.dialPlanDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dialPlanDataGrid, "dialPlanDataGrid");
            this.dialPlanDataGrid.AutoGenerateColumns = false;
            this.dialPlanDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dialPlanDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dialPlanDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dialPlanDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dialPlanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dialPlanDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.allRulesDataGridViewTextBoxColumn,
            this.SerialNo});
            this.dialPlanDataGrid.DataSource = this.callingRuleDialPlanBindingSource;
            this.dialPlanDataGrid.MultiSelect = false;
            this.dialPlanDataGrid.Name = "dialPlanDataGrid";
            this.dialPlanDataGrid.ReadOnly = true;
            this.dialPlanDataGrid.RowHeadersVisible = false;
            this.dialPlanDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dialPlanDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dialPlanDataGrid.RowTemplate.Height = 32;
            this.dialPlanDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dialPlanDataGrid.ShowDeleteColumn = true;
            this.dialPlanDataGrid.ShowEditColumn = true;
            this.dialPlanDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.dialPlanDataGrid_DeleteDataRow);
            this.dialPlanDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.dialPlanDataGrid_EditDataRow);
            this.dialPlanDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dialPlanDataGrid_DataError);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allRulesDataGridViewTextBoxColumn
            // 
            this.allRulesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allRulesDataGridViewTextBoxColumn.DataPropertyName = "AllRules";
            resources.ApplyResources(this.allRulesDataGridViewTextBoxColumn, "allRulesDataGridViewTextBoxColumn");
            this.allRulesDataGridViewTextBoxColumn.Name = "allRulesDataGridViewTextBoxColumn";
            this.allRulesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SerialNo
            // 
            this.SerialNo.DataPropertyName = "SerialNo";
            resources.ApplyResources(this.SerialNo, "SerialNo");
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            // 
            // callingRuleDialPlanBindingSource
            // 
            this.callingRuleDialPlanBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.CallingRuleDialPlan);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.callingRuleVisualAsteriskEditDataGrid);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addNewRuleButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // addNewRuleButton
            // 
            this.addNewRuleButton.AntiAliasText = false;
            resources.ApplyResources(this.addNewRuleButton, "addNewRuleButton");
            this.addNewRuleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewRuleButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addNewRuleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewRuleButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewRuleButton.Name = "addNewRuleButton";
            this.addNewRuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewRuleButton.UnderlineOnHover = true;
            this.addNewRuleButton.Click += new System.EventHandler(this.addNewRuleButton_Click);
            // 
            // callingRuleVisualAsteriskEditDataGrid
            // 
            this.callingRuleVisualAsteriskEditDataGrid.AllowUserToAddRows = false;
            this.callingRuleVisualAsteriskEditDataGrid.AllowUserToDeleteRows = false;
            this.callingRuleVisualAsteriskEditDataGrid.AllowUserToResizeRows = false;
            this.callingRuleVisualAsteriskEditDataGrid.AutoGenerateColumns = false;
            this.callingRuleVisualAsteriskEditDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.callingRuleVisualAsteriskEditDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.callingRuleVisualAsteriskEditDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.callingRuleVisualAsteriskEditDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.callingRuleVisualAsteriskEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callingRuleVisualAsteriskEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.TrunkName,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn1});
            this.callingRuleVisualAsteriskEditDataGrid.DataSource = this.callingRuleBindingSource;
            resources.ApplyResources(this.callingRuleVisualAsteriskEditDataGrid, "callingRuleVisualAsteriskEditDataGrid");
            this.callingRuleVisualAsteriskEditDataGrid.MultiSelect = false;
            this.callingRuleVisualAsteriskEditDataGrid.Name = "callingRuleVisualAsteriskEditDataGrid";
            this.callingRuleVisualAsteriskEditDataGrid.ReadOnly = true;
            this.callingRuleVisualAsteriskEditDataGrid.RowHeadersVisible = false;
            this.callingRuleVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.callingRuleVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.callingRuleVisualAsteriskEditDataGrid.RowTemplate.Height = 32;
            this.callingRuleVisualAsteriskEditDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.callingRuleVisualAsteriskEditDataGrid.ShowDeleteColumn = true;
            this.callingRuleVisualAsteriskEditDataGrid.ShowEditColumn = true;
            this.callingRuleVisualAsteriskEditDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.callingRuleVisualAsteriskEditDataGrid_DeleteDataRow);
            this.callingRuleVisualAsteriskEditDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.callingRuleVisualAsteriskEditDataGrid_EditDataRow);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // TrunkName
            // 
            this.TrunkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrunkName.DataPropertyName = "TrunkName";
            resources.ApplyResources(this.TrunkName, "TrunkName");
            this.TrunkName.Name = "TrunkName";
            this.TrunkName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Pattern";
            resources.ApplyResources(this.dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SerialNo";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // callingRuleBindingSource
            // 
            this.callingRuleBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.CallingRule);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.incomingCallRuleVisualAsteriskEditDataGrid);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addNewIncomingCallRuleButton);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // addNewIncomingCallRuleButton
            // 
            this.addNewIncomingCallRuleButton.AntiAliasText = false;
            resources.ApplyResources(this.addNewIncomingCallRuleButton, "addNewIncomingCallRuleButton");
            this.addNewIncomingCallRuleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewIncomingCallRuleButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addNewIncomingCallRuleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewIncomingCallRuleButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.new_user_24;
            this.addNewIncomingCallRuleButton.Name = "addNewIncomingCallRuleButton";
            this.addNewIncomingCallRuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewIncomingCallRuleButton.UnderlineOnHover = true;
            // 
            // incomingCallRuleVisualAsteriskEditDataGrid
            // 
            this.incomingCallRuleVisualAsteriskEditDataGrid.AllowUserToAddRows = false;
            this.incomingCallRuleVisualAsteriskEditDataGrid.AllowUserToDeleteRows = false;
            this.incomingCallRuleVisualAsteriskEditDataGrid.AllowUserToResizeRows = false;
            this.incomingCallRuleVisualAsteriskEditDataGrid.AutoGenerateColumns = false;
            this.incomingCallRuleVisualAsteriskEditDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.incomingCallRuleVisualAsteriskEditDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incomingCallRuleVisualAsteriskEditDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.incomingCallRuleVisualAsteriskEditDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.incomingCallRuleVisualAsteriskEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomingCallRuleVisualAsteriskEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.incomingCallRuleVisualAsteriskEditDataGrid.DataSource = this.incomingCallRuleBindingSource;
            resources.ApplyResources(this.incomingCallRuleVisualAsteriskEditDataGrid, "incomingCallRuleVisualAsteriskEditDataGrid");
            this.incomingCallRuleVisualAsteriskEditDataGrid.MultiSelect = false;
            this.incomingCallRuleVisualAsteriskEditDataGrid.Name = "incomingCallRuleVisualAsteriskEditDataGrid";
            this.incomingCallRuleVisualAsteriskEditDataGrid.ReadOnly = true;
            this.incomingCallRuleVisualAsteriskEditDataGrid.RowHeadersVisible = false;
            this.incomingCallRuleVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomingCallRuleVisualAsteriskEditDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.incomingCallRuleVisualAsteriskEditDataGrid.RowTemplate.Height = 32;
            this.incomingCallRuleVisualAsteriskEditDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.incomingCallRuleVisualAsteriskEditDataGrid.ShowDeleteColumn = true;
            this.incomingCallRuleVisualAsteriskEditDataGrid.ShowEditColumn = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SerialNo";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Trunk";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Extension";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pattern";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "AddingNew";
            resources.ApplyResources(this.dataGridViewCheckBoxColumn1, "dataGridViewCheckBoxColumn1");
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // incomingCallRuleBindingSource
            // 
            this.incomingCallRuleBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.IncomingCallRule);
            // 
            // DialPlanView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.branch_48_shadow;
            this.Name = "DialPlanView";
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.dialPlansTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dialPlanDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleDialPlanBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleVisualAsteriskEditDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleVisualAsteriskEditDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource callingRuleDialPlanBindingSource;
        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid callingRuleVisualAsteriskEditDataGrid;
        private System.Windows.Forms.BindingSource callingRuleBindingSource;
        private System.Windows.Forms.Panel panel1;
        private IC.Controls.LinkButton addNewRuleButton;
        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid incomingCallRuleVisualAsteriskEditDataGrid;
        private System.Windows.Forms.BindingSource incomingCallRuleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel2;
        private IC.Controls.LinkButton addNewIncomingCallRuleButton;
        private System.Windows.Forms.TabPage dialPlansTabPage;
        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid dialPlanDataGrid;
        private IC.Controls.LinkButton addNewDialPlanButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allRulesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrunkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
