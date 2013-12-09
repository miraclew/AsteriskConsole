namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class RecordVoiceMenuDlg
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
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(192, 98);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(66, 98);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 67);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(65, 12);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "File Name:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(95, 64);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(161, 21);
            this.fileNameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Extension:";
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Location = new System.Drawing.Point(95, 35);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(161, 20);
            this.extensionComboBox.TabIndex = 9;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(12, 9);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(41, 12);
            this.informationLabel.TabIndex = 10;
            this.informationLabel.Text = "label3";
            // 
            // RecordVoiceMenuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 133);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Name = "RecordVoiceMenuDlg";
            this.Text = "RecordVoiceMenuDlg";
            this.Load += new System.EventHandler(this.RecordNewVoiceMenuDlg_Load);
            this.Controls.SetChildIndex(this.fileNameTextBox, 0);
            this.Controls.SetChildIndex(this.extensionComboBox, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.fileNameLabel, 0);
            this.Controls.SetChildIndex(this.informationLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Label informationLabel;
    }
}