namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class VoiceMenusConfigPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxMenus = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBoxSteps = new System.Windows.Forms.ListBox();
            this.buttonMoveup = new System.Windows.Forms.Button();
            this.buttonMovedown = new System.Windows.Forms.Button();
            this.buttonAddStep = new System.Windows.Forms.Button();
            this.buttonDeleteStep = new System.Windows.Forms.Button();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(498, 32);
            this.descriptionLabel.Text = "Menus allow for more efficient routing of calls from incoming callers. \r\nAlso kno" +
                "wn as IVR (Interactive Voice Response) menus or Digital Receptionist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voice Menus: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Extension:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Steps:";
            // 
            // listBoxMenus
            // 
            this.listBoxMenus.FormattingEnabled = true;
            this.listBoxMenus.ItemHeight = 12;
            this.listBoxMenus.Location = new System.Drawing.Point(12, 49);
            this.listBoxMenus.Name = "listBoxMenus";
            this.listBoxMenus.Size = new System.Drawing.Size(135, 412);
            this.listBoxMenus.TabIndex = 0;
            this.listBoxMenus.SelectedIndexChanged += new System.EventHandler(this.listBoxMenus_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(207, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(398, 49);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(100, 21);
            this.textBoxExtension.TabIndex = 2;
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(165, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Allow Dialing other Extensions? ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBoxSteps
            // 
            this.listBoxSteps.FormattingEnabled = true;
            this.listBoxSteps.ItemHeight = 12;
            this.listBoxSteps.Location = new System.Drawing.Point(213, 108);
            this.listBoxSteps.Name = "listBoxSteps";
            this.listBoxSteps.Size = new System.Drawing.Size(325, 112);
            this.listBoxSteps.TabIndex = 8;
            // 
            // buttonMoveup
            // 
            this.buttonMoveup.Location = new System.Drawing.Point(157, 160);
            this.buttonMoveup.Name = "buttonMoveup";
            this.buttonMoveup.Size = new System.Drawing.Size(47, 23);
            this.buttonMoveup.TabIndex = 6;
            this.buttonMoveup.Text = "Up";
            this.buttonMoveup.UseVisualStyleBackColor = true;
            this.buttonMoveup.Click += new System.EventHandler(this.buttonMoveup_Click);
            // 
            // buttonMovedown
            // 
            this.buttonMovedown.Location = new System.Drawing.Point(157, 189);
            this.buttonMovedown.Name = "buttonMovedown";
            this.buttonMovedown.Size = new System.Drawing.Size(47, 23);
            this.buttonMovedown.TabIndex = 7;
            this.buttonMovedown.Text = "Down";
            this.buttonMovedown.UseVisualStyleBackColor = true;
            this.buttonMovedown.Click += new System.EventHandler(this.buttonMovedown_Click);
            // 
            // buttonAddStep
            // 
            this.buttonAddStep.Location = new System.Drawing.Point(213, 226);
            this.buttonAddStep.Name = "buttonAddStep";
            this.buttonAddStep.Size = new System.Drawing.Size(134, 23);
            this.buttonAddStep.TabIndex = 4;
            this.buttonAddStep.Text = "Add new step";
            this.buttonAddStep.UseVisualStyleBackColor = true;
            this.buttonAddStep.Click += new System.EventHandler(this.buttonAddStep_Click);
            // 
            // buttonDeleteStep
            // 
            this.buttonDeleteStep.Location = new System.Drawing.Point(379, 226);
            this.buttonDeleteStep.Name = "buttonDeleteStep";
            this.buttonDeleteStep.Size = new System.Drawing.Size(145, 23);
            this.buttonDeleteStep.TabIndex = 5;
            this.buttonDeleteStep.Text = "Delete selected step";
            this.buttonDeleteStep.UseVisualStyleBackColor = true;
            this.buttonDeleteStep.Click += new System.EventHandler(this.buttonDeleteStep_Click);
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.AllowUserToAddRows = false;
            this.dataGridViewActions.AllowUserToDeleteRows = false;
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3});
            this.dataGridViewActions.Location = new System.Drawing.Point(165, 255);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.RowTemplate.Height = 23;
            this.dataGridViewActions.Size = new System.Drawing.Size(373, 208);
            this.dataGridViewActions.TabIndex = 8;
            this.dataGridViewActions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActions_CellValueChanged);
            // 
            // column1
            // 
            this.column1.HeaderText = "Key";
            this.column1.Name = "column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Action Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Action";
            this.Column3.Name = "Column3";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(91, 469);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 469);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(439, 469);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(335, 470);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // VoiceMenusConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 503);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewActions);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddStep);
            this.Controls.Add(this.buttonDeleteStep);
            this.Controls.Add(this.buttonMovedown);
            this.Controls.Add(this.buttonMoveup);
            this.Controls.Add(this.listBoxSteps);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxMenus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoiceMenusConfigPage";
            this.TabText = "VoiceMenus";
            this.Text = "VoiceMenus";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.listBoxMenus, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.textBoxExtension, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.listBoxSteps, 0);
            this.Controls.SetChildIndex(this.buttonMoveup, 0);
            this.Controls.SetChildIndex(this.buttonMovedown, 0);
            this.Controls.SetChildIndex(this.buttonDeleteStep, 0);
            this.Controls.SetChildIndex(this.buttonAddStep, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.dataGridViewActions, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxMenus;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBoxSteps;
        private System.Windows.Forms.Button buttonMoveup;
        private System.Windows.Forms.Button buttonMovedown;
        private System.Windows.Forms.Button buttonAddStep;
        private System.Windows.Forms.Button buttonDeleteStep;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}