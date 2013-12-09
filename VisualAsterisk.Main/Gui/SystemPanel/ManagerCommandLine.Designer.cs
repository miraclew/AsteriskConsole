namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class ManagerCommandLine
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
            this.cmdInputTextBox = new System.Windows.Forms.TextBox();
            this.cliShellTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Visible = false;
            // 
            // cmdInputTextBox
            // 
            this.cmdInputTextBox.AcceptsReturn = true;
            this.cmdInputTextBox.AcceptsTab = true;
            this.cmdInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdInputTextBox.Location = new System.Drawing.Point(12, 387);
            this.cmdInputTextBox.Name = "cmdInputTextBox";
            this.cmdInputTextBox.Size = new System.Drawing.Size(393, 21);
            this.cmdInputTextBox.TabIndex = 0;
            this.cmdInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdInputTextBox_KeyPress);
            // 
            // cliShellTextBox
            // 
            this.cliShellTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cliShellTextBox.Location = new System.Drawing.Point(3, 1);
            this.cliShellTextBox.Multiline = true;
            this.cliShellTextBox.Name = "cliShellTextBox";
            this.cliShellTextBox.ReadOnly = true;
            this.cliShellTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cliShellTextBox.Size = new System.Drawing.Size(595, 346);
            this.cliShellTextBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(422, 387);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(74, 21);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearTextButton
            // 
            this.clearTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearTextButton.Location = new System.Drawing.Point(515, 387);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(74, 21);
            this.clearTextButton.TabIndex = 3;
            this.clearTextButton.Text = "ClearText";
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter the command:";
            // 
            // ManagerCommandLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cliShellTextBox);
            this.Controls.Add(this.cmdInputTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.clearTextButton);
            this.Name = "ManagerCommandLine";
            this.TabText = "Manager CLI";
            this.Text = "Manager CLI";
            this.Controls.SetChildIndex(this.clearTextButton, 0);
            this.Controls.SetChildIndex(this.sendButton, 0);
            this.Controls.SetChildIndex(this.cmdInputTextBox, 0);
            this.Controls.SetChildIndex(this.cliShellTextBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmdInputTextBox;
        private System.Windows.Forms.TextBox cliShellTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.Label label1;
    }
}