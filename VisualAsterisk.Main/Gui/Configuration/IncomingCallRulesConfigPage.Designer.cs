namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class IncomingCallRulesConfigPage
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
            this.incomingCallRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomingCallRuleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.routeComboBox = new System.Windows.Forms.ComboBox();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.routeLabel = new System.Windows.Forms.Label();
            this.provideLabel = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(560, 16);
            this.descriptionLabel.Text = "Define how your incoming calls should be handled & configure DID (Direct inward D" +
                "ialing)";
            // 
            // incomingCallRuleBindingSource
            // 
            this.incomingCallRuleBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.IncomingCallRule);
            this.incomingCallRuleBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.incomingCallRuleBindingSource_AddingNew);
            this.incomingCallRuleBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.incomingCallRuleBindingSource_ListChanged);
            // 
            // incomingCallRuleDataGridView
            // 
            this.incomingCallRuleDataGridView.AllowUserToAddRows = false;
            this.incomingCallRuleDataGridView.AllowUserToDeleteRows = false;
            this.incomingCallRuleDataGridView.AutoGenerateColumns = false;
            this.incomingCallRuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomingCallRuleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.buttonEdit});
            this.incomingCallRuleDataGridView.DataSource = this.incomingCallRuleBindingSource;
            this.incomingCallRuleDataGridView.Location = new System.Drawing.Point(12, 35);
            this.incomingCallRuleDataGridView.Name = "incomingCallRuleDataGridView";
            this.incomingCallRuleDataGridView.ReadOnly = true;
            this.incomingCallRuleDataGridView.RowTemplate.Height = 23;
            this.incomingCallRuleDataGridView.Size = new System.Drawing.Size(348, 316);
            this.incomingCallRuleDataGridView.TabIndex = 0;
            this.incomingCallRuleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomingCallRuleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Extension";
            this.dataGridViewTextBoxColumn2.HeaderText = "Extension";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pattern";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pattern";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.HeaderText = "Options";
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ReadOnly = true;
            this.buttonEdit.Text = "Edit";
            // 
            // routeComboBox
            // 
            this.routeComboBox.DataSource = this.incomingCallRuleBindingSource;
            this.routeComboBox.DisplayMember = "Pattern";
            this.routeComboBox.FormattingEnabled = true;
            this.routeComboBox.Location = new System.Drawing.Point(464, 40);
            this.routeComboBox.Name = "routeComboBox";
            this.routeComboBox.Size = new System.Drawing.Size(121, 20);
            this.routeComboBox.TabIndex = 1;
            // 
            // providerComboBox
            // 
            this.providerComboBox.DataSource = this.incomingCallRuleBindingSource;
            this.providerComboBox.DisplayMember = "Trunk";
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(464, 75);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(121, 20);
            this.providerComboBox.TabIndex = 2;
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Location = new System.Drawing.Point(375, 40);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(35, 12);
            this.routeLabel.TabIndex = 3;
            this.routeLabel.Text = "Route";
            // 
            // provideLabel
            // 
            this.provideLabel.AutoSize = true;
            this.provideLabel.Location = new System.Drawing.Point(375, 75);
            this.provideLabel.Name = "provideLabel";
            this.provideLabel.Size = new System.Drawing.Size(83, 12);
            this.provideLabel.TabIndex = 4;
            this.provideLabel.Text = "from provider";
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(375, 116);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(77, 12);
            this.extensionLabel.TabIndex = 5;
            this.extensionLabel.Text = "to extension";
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.DataSource = this.incomingCallRuleBindingSource;
            this.extensionComboBox.DisplayMember = "Extension";
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Location = new System.Drawing.Point(464, 116);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(121, 20);
            this.extensionComboBox.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(170, 375);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(36, 375);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "&Add";
            this.toolTip.SetToolTip(this.buttonAdd, "Define a new Rule for handling Incoming calls based on service provider and/or th" +
                    "e number called.");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(503, 375);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(383, 375);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // IncomingCallRulesConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 422);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.provideLabel);
            this.Controls.Add(this.routeLabel);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.routeComboBox);
            this.Controls.Add(this.incomingCallRuleDataGridView);
            this.Name = "IncomingCallRulesConfigPage";
            this.TabText = "IncomingCallRules";
            this.Text = "IncomingCallRules";
            this.Controls.SetChildIndex(this.incomingCallRuleDataGridView, 0);
            this.Controls.SetChildIndex(this.routeComboBox, 0);
            this.Controls.SetChildIndex(this.providerComboBox, 0);
            this.Controls.SetChildIndex(this.routeLabel, 0);
            this.Controls.SetChildIndex(this.provideLabel, 0);
            this.Controls.SetChildIndex(this.extensionLabel, 0);
            this.Controls.SetChildIndex(this.extensionComboBox, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingCallRuleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource incomingCallRuleBindingSource;
        private System.Windows.Forms.DataGridView incomingCallRuleDataGridView;
        private System.Windows.Forms.ComboBox routeComboBox;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.Label provideLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}