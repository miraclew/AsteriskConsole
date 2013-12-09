using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;
namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class EditAsteriskHostForm
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
            System.Windows.Forms.Label hostLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userLabel;
            this.asteriskHostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            hostLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskHostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hostLabel
            // 
            hostLabel.AutoSize = true;
            hostLabel.Location = new System.Drawing.Point(41, 24);
            hostLabel.Name = "hostLabel";
            hostLabel.Size = new System.Drawing.Size(35, 12);
            hostLabel.TabIndex = 1;
            hostLabel.Text = "Host:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(41, 84);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(59, 12);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(41, 55);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(35, 12);
            userLabel.TabIndex = 5;
            userLabel.Text = "User:";
            // 
            // asteriskHostBindingSource
            // 
            this.asteriskHostBindingSource.DataSource = typeof(ManagerConnectionInfo);
            // 
            // hostTextBox
            // 
            this.hostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asteriskHostBindingSource, "Host", true));
            this.hostTextBox.Location = new System.Drawing.Point(106, 21);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(100, 21);
            this.hostTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asteriskHostBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(106, 81);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 21);
            this.passwordTextBox.TabIndex = 4;
            // 
            // userTextBox
            // 
            this.userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asteriskHostBindingSource, "User", true));
            this.userTextBox.Location = new System.Drawing.Point(106, 52);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 21);
            this.userTextBox.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(25, 130);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(150, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EditAsteriskHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 178);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(hostLabel);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(userLabel);
            this.Controls.Add(this.userTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAsteriskHostForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asterisk Host";
            ((System.ComponentModel.ISupportInitialize)(this.asteriskHostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource asteriskHostBindingSource;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button button2;
    }
}