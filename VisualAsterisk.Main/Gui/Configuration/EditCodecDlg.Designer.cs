namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class EditCodecDlg
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
            this.allowedCodeListBox = new System.Windows.Forms.ListBox();
            this.disallowedCodeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allowSelectedCodecButton = new System.Windows.Forms.Button();
            this.disallowSelectedCodecButton = new System.Windows.Forms.Button();
            this.disallowAllCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allowedCodeListBox
            // 
            this.allowedCodeListBox.FormattingEnabled = true;
            this.allowedCodeListBox.ItemHeight = 12;
            this.allowedCodeListBox.Location = new System.Drawing.Point(12, 39);
            this.allowedCodeListBox.Name = "allowedCodeListBox";
            this.allowedCodeListBox.Size = new System.Drawing.Size(81, 136);
            this.allowedCodeListBox.TabIndex = 6;
            // 
            // disallowedCodeListBox
            // 
            this.disallowedCodeListBox.FormattingEnabled = true;
            this.disallowedCodeListBox.ItemHeight = 12;
            this.disallowedCodeListBox.Location = new System.Drawing.Point(169, 39);
            this.disallowedCodeListBox.Name = "disallowedCodeListBox";
            this.disallowedCodeListBox.Size = new System.Drawing.Size(87, 136);
            this.disallowedCodeListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Allowed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Disallowed";
            // 
            // allowSelectedCodecButton
            // 
            this.allowSelectedCodecButton.Location = new System.Drawing.Point(107, 58);
            this.allowSelectedCodecButton.Name = "allowSelectedCodecButton";
            this.allowSelectedCodecButton.Size = new System.Drawing.Size(50, 23);
            this.allowSelectedCodecButton.TabIndex = 10;
            this.allowSelectedCodecButton.Text = "<";
            this.allowSelectedCodecButton.UseVisualStyleBackColor = true;
            this.allowSelectedCodecButton.Click += new System.EventHandler(this.allowSelectedCodecButton_Click);
            // 
            // disallowSelectedCodecButton
            // 
            this.disallowSelectedCodecButton.Location = new System.Drawing.Point(108, 95);
            this.disallowSelectedCodecButton.Name = "disallowSelectedCodecButton";
            this.disallowSelectedCodecButton.Size = new System.Drawing.Size(49, 23);
            this.disallowSelectedCodecButton.TabIndex = 11;
            this.disallowSelectedCodecButton.Text = ">";
            this.disallowSelectedCodecButton.UseVisualStyleBackColor = true;
            this.disallowSelectedCodecButton.Click += new System.EventHandler(this.disallowSelectedCodecButton_Click);
            // 
            // disallowAllCodeButton
            // 
            this.disallowAllCodeButton.Location = new System.Drawing.Point(108, 129);
            this.disallowAllCodeButton.Name = "disallowAllCodeButton";
            this.disallowAllCodeButton.Size = new System.Drawing.Size(49, 24);
            this.disallowAllCodeButton.TabIndex = 12;
            this.disallowAllCodeButton.Text = ">>>";
            this.disallowAllCodeButton.UseVisualStyleBackColor = true;
            this.disallowAllCodeButton.Click += new System.EventHandler(this.disallowAllCodeButton_Click);
            // 
            // EditCodecDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.disallowAllCodeButton);
            this.Controls.Add(this.disallowSelectedCodecButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disallowedCodeListBox);
            this.Controls.Add(this.allowedCodeListBox);
            this.Controls.Add(this.allowSelectedCodecButton);
            this.Name = "EditCodecDlg";
            this.Text = "Codec Perferences";
            this.Controls.SetChildIndex(this.allowSelectedCodecButton, 0);
            this.Controls.SetChildIndex(this.allowedCodeListBox, 0);
            this.Controls.SetChildIndex(this.disallowedCodeListBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.disallowSelectedCodecButton, 0);
            this.Controls.SetChildIndex(this.disallowAllCodeButton, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allowedCodeListBox;
        private System.Windows.Forms.ListBox disallowedCodeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allowSelectedCodecButton;
        private System.Windows.Forms.Button disallowSelectedCodecButton;
        private System.Windows.Forms.Button disallowAllCodeButton;
    }
}