namespace VisualAsterisk.Main.UI.Forms
{
    partial class VoiceMenuEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.voiceMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new IC.Controls.SmoothLabel();
            this.label3 = new IC.Controls.SmoothLabel();
            this.label4 = new IC.Controls.SmoothLabel();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBoxSteps = new System.Windows.Forms.ListBox();
            this.buttonAddStep = new System.Windows.Forms.Button();
            this.buttonMoveup = new System.Windows.Forms.Button();
            this.buttonDeleteStep = new System.Windows.Forms.Button();
            this.buttonMovedown = new System.Windows.Forms.Button();
            this.smoothLabel1 = new IC.Controls.SmoothLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smoothLabel2 = new IC.Controls.SmoothLabel();
            this.contentPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voiceMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(514, 42);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.groupBox2);
            this.contentPanel.Controls.Add(this.groupBox1);
            this.contentPanel.Controls.Add(this.smoothLabel1);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.textBoxName);
            this.contentPanel.Controls.Add(this.textBoxExtension);
            this.contentPanel.Controls.Add(this.checkBox1);
            this.contentPanel.Size = new System.Drawing.Size(514, 512);
            // 
            // buttomPanel
            // 
            this.buttomPanel.Location = new System.Drawing.Point(0, 505);
            this.buttomPanel.Size = new System.Drawing.Size(514, 49);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(787, 14);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(698, 14);
            // 
            // voiceMenuBindingSource
            // 
            this.voiceMenuBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.VoiceMenu);
            // 
            // label2
            // 
            this.label2.AntiAliasText = false;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.EnableHelp = true;
            this.label2.HelpText = "A name for the Voice Menu";
            this.label2.HelpTitle = "Name:";
            this.label2.Location = new System.Drawing.Point(24, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AntiAliasText = false;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.EnableHelp = true;
            this.label3.HelpText = "If you want this Voicemenu to be accessible by dialing an extension, then enter t" +
                "hat extension number\r\n";
            this.label3.HelpTitle = "Extension(optional):";
            this.label3.Location = new System.Drawing.Point(213, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extension:";
            // 
            // label4
            // 
            this.label4.AntiAliasText = false;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.EnableHelp = true;
            this.label4.HelpText = "A sequence of actions performed when a call enters the menu.";
            this.label4.HelpTitle = "Actions:\r\n";
            this.label4.Location = new System.Drawing.Point(9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Actions:";
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
            this.dataGridViewActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewActions.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.ReadOnly = true;
            this.dataGridViewActions.RowHeadersVisible = false;
            this.dataGridViewActions.RowTemplate.Height = 23;
            this.dataGridViewActions.ShowEditingIcon = false;
            this.dataGridViewActions.Size = new System.Drawing.Size(484, 208);
            this.dataGridViewActions.TabIndex = 19;
            this.dataGridViewActions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActions_CellValueChanged);
            // 
            // column1
            // 
            this.column1.HeaderText = "Key";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Action Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Action";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(114, 21);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(290, 14);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(123, 21);
            this.textBoxExtension.TabIndex = 11;
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(76, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(17, 26);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Allow Dialing other Extensions? ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBoxSteps
            // 
            this.listBoxSteps.FormattingEnabled = true;
            this.listBoxSteps.Location = new System.Drawing.Point(56, 16);
            this.listBoxSteps.Name = "listBoxSteps";
            this.listBoxSteps.Size = new System.Drawing.Size(428, 82);
            this.listBoxSteps.TabIndex = 20;
            // 
            // buttonAddStep
            // 
            this.buttonAddStep.Location = new System.Drawing.Point(74, 108);
            this.buttonAddStep.Name = "buttonAddStep";
            this.buttonAddStep.Size = new System.Drawing.Size(115, 23);
            this.buttonAddStep.TabIndex = 15;
            this.buttonAddStep.Text = "Add new step";
            this.buttonAddStep.UseVisualStyleBackColor = true;
            this.buttonAddStep.Click += new System.EventHandler(this.buttonAddStep_Click);
            // 
            // buttonMoveup
            // 
            this.buttonMoveup.Location = new System.Drawing.Point(5, 29);
            this.buttonMoveup.Name = "buttonMoveup";
            this.buttonMoveup.Size = new System.Drawing.Size(47, 23);
            this.buttonMoveup.TabIndex = 17;
            this.buttonMoveup.Text = "Up";
            this.buttonMoveup.UseVisualStyleBackColor = true;
            this.buttonMoveup.Click += new System.EventHandler(this.buttonMoveup_Click);
            // 
            // buttonDeleteStep
            // 
            this.buttonDeleteStep.Location = new System.Drawing.Point(263, 108);
            this.buttonDeleteStep.Name = "buttonDeleteStep";
            this.buttonDeleteStep.Size = new System.Drawing.Size(129, 23);
            this.buttonDeleteStep.TabIndex = 16;
            this.buttonDeleteStep.Text = "Delete selected step";
            this.buttonDeleteStep.UseVisualStyleBackColor = true;
            this.buttonDeleteStep.Click += new System.EventHandler(this.buttonDeleteStep_Click);
            // 
            // buttonMovedown
            // 
            this.buttonMovedown.Location = new System.Drawing.Point(5, 58);
            this.buttonMovedown.Name = "buttonMovedown";
            this.buttonMovedown.Size = new System.Drawing.Size(47, 23);
            this.buttonMovedown.TabIndex = 18;
            this.buttonMovedown.Text = "Down";
            this.buttonMovedown.UseVisualStyleBackColor = true;
            this.buttonMovedown.Click += new System.EventHandler(this.buttonMovedown_Click);
            // 
            // smoothLabel1
            // 
            this.smoothLabel1.AntiAliasText = false;
            this.smoothLabel1.AutoSize = true;
            this.smoothLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smoothLabel1.EnableHelp = true;
            this.smoothLabel1.HelpText = "Is the caller allowed to dial extensions other than the ones explicitly defined\r\n" +
                "";
            this.smoothLabel1.HelpTitle = "Dial other Extensions:";
            this.smoothLabel1.Location = new System.Drawing.Point(99, 45);
            this.smoothLabel1.Name = "smoothLabel1";
            this.smoothLabel1.Size = new System.Drawing.Size(171, 13);
            this.smoothLabel1.TabIndex = 21;
            this.smoothLabel1.Text = "Allow Dialing other Extensions? ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxSteps);
            this.groupBox1.Controls.Add(this.buttonDeleteStep);
            this.groupBox1.Controls.Add(this.buttonAddStep);
            this.groupBox1.Controls.Add(this.buttonMoveup);
            this.groupBox1.Controls.Add(this.buttonMovedown);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 139);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smoothLabel2);
            this.groupBox2.Controls.Add(this.dataGridViewActions);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 228);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // smoothLabel2
            // 
            this.smoothLabel2.AntiAliasText = false;
            this.smoothLabel2.AutoSize = true;
            this.smoothLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smoothLabel2.EnableHelp = true;
            this.smoothLabel2.HelpText = "Allow key press events will cause the system to listen for DTMF input from the ca" +
                "ller and define the actions that occur when a user presses the corresponding dig" +
                "it.";
            this.smoothLabel2.HelpTitle = "Keypress Events:";
            this.smoothLabel2.Location = new System.Drawing.Point(9, 0);
            this.smoothLabel2.Name = "smoothLabel2";
            this.smoothLabel2.Size = new System.Drawing.Size(100, 13);
            this.smoothLabel2.TabIndex = 21;
            this.smoothLabel2.Text = "Keypress Events";
            // 
            // VoiceMenuEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 554);
            this.Name = "VoiceMenuEditorForm";
            this.Text = "VoiceMenuEditorForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.buttomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voiceMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource voiceMenuBindingSource;
        private IC.Controls.SmoothLabel label2;
        private IC.Controls.SmoothLabel label3;
        private IC.Controls.SmoothLabel label4;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBoxSteps;
        private System.Windows.Forms.Button buttonAddStep;
        private System.Windows.Forms.Button buttonMoveup;
        private System.Windows.Forms.Button buttonDeleteStep;
        private System.Windows.Forms.Button buttonMovedown;
        private IC.Controls.SmoothLabel smoothLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private IC.Controls.SmoothLabel smoothLabel2;
    }
}