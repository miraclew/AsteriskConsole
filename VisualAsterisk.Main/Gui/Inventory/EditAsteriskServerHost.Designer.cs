namespace VisualAsterisk.Main.Gui.Inventory
{
    partial class EditAsteriskServerHost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAsteriskServerHost));
            System.Windows.Forms.Label hostLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label label1;
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            hostLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleDescription = null;
            this.cancelButton.AccessibleName = null;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.BackgroundImage = null;
            this.cancelButton.Font = null;
            // 
            // okButton
            // 
            this.okButton.AccessibleDescription = null;
            this.okButton.AccessibleName = null;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.BackgroundImage = null;
            this.okButton.Font = null;
            // 
            // hostLabel
            // 
            hostLabel.AccessibleDescription = null;
            hostLabel.AccessibleName = null;
            resources.ApplyResources(hostLabel, "hostLabel");
            hostLabel.Font = null;
            hostLabel.Name = "hostLabel";
            // 
            // passwordLabel
            // 
            passwordLabel.AccessibleDescription = null;
            passwordLabel.AccessibleName = null;
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Font = null;
            passwordLabel.Name = "passwordLabel";
            // 
            // userLabel
            // 
            userLabel.AccessibleDescription = null;
            userLabel.AccessibleName = null;
            resources.ApplyResources(userLabel, "userLabel");
            userLabel.Font = null;
            userLabel.Name = "userLabel";
            // 
            // label1
            // 
            label1.AccessibleDescription = null;
            label1.AccessibleName = null;
            resources.ApplyResources(label1, "label1");
            label1.Font = null;
            label1.Name = "label1";
            // 
            // hostTextBox
            // 
            this.hostTextBox.AccessibleDescription = null;
            this.hostTextBox.AccessibleName = null;
            resources.ApplyResources(this.hostTextBox, "hostTextBox");
            this.hostTextBox.BackgroundImage = null;
            this.hostTextBox.Font = null;
            this.hostTextBox.Name = "hostTextBox";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AccessibleDescription = null;
            this.passwordTextBox.AccessibleName = null;
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.BackgroundImage = null;
            this.passwordTextBox.Font = null;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userTextBox
            // 
            this.userTextBox.AccessibleDescription = null;
            this.userTextBox.AccessibleName = null;
            resources.ApplyResources(this.userTextBox, "userTextBox");
            this.userTextBox.BackgroundImage = null;
            this.userTextBox.Font = null;
            this.userTextBox.Name = "userTextBox";
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleDescription = null;
            this.textBoxName.AccessibleName = null;
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.BackgroundImage = null;
            this.textBoxName.Font = null;
            this.textBoxName.Name = "textBoxName";
            // 
            // EditAsteriskServerHost
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(hostLabel);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(userLabel);
            this.Controls.Add(this.userTextBox);
            this.Icon = null;
            this.Name = "EditAsteriskServerHost";
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.userTextBox, 0);
            this.Controls.SetChildIndex(userLabel, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(passwordLabel, 0);
            this.Controls.SetChildIndex(this.hostTextBox, 0);
            this.Controls.SetChildIndex(hostLabel, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox textBoxName;
    }
}