namespace VisualAsterisk.Main.Gui
{
    partial class CheckUpdatesDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckUpdatesDlg));
            this.label1 = new System.Windows.Forms.Label();
            this.checkForUpdatesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.installUpdatesButton = new System.Windows.Forms.Button();
            this.readyLabel = new System.Windows.Forms.Label();
            this.downloadingLabel = new System.Windows.Forms.Label();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // checkForUpdatesButton
            // 
            this.checkForUpdatesButton.AccessibleDescription = null;
            this.checkForUpdatesButton.AccessibleName = null;
            resources.ApplyResources(this.checkForUpdatesButton, "checkForUpdatesButton");
            this.checkForUpdatesButton.BackgroundImage = null;
            this.checkForUpdatesButton.Name = "checkForUpdatesButton";
            this.checkForUpdatesButton.UseVisualStyleBackColor = true;
            this.checkForUpdatesButton.Click += new System.EventHandler(this.checkForUpdatesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.installUpdatesButton);
            this.groupBox1.Controls.Add(this.readyLabel);
            this.groupBox1.Controls.Add(this.downloadingLabel);
            this.groupBox1.Controls.Add(this.checkingLabel);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // installUpdatesButton
            // 
            this.installUpdatesButton.AccessibleDescription = null;
            this.installUpdatesButton.AccessibleName = null;
            resources.ApplyResources(this.installUpdatesButton, "installUpdatesButton");
            this.installUpdatesButton.BackgroundImage = null;
            this.installUpdatesButton.Font = null;
            this.installUpdatesButton.Name = "installUpdatesButton";
            this.installUpdatesButton.UseVisualStyleBackColor = true;
            this.installUpdatesButton.Click += new System.EventHandler(this.installUpdatesButton_Click);
            // 
            // readyLabel
            // 
            this.readyLabel.AccessibleDescription = null;
            this.readyLabel.AccessibleName = null;
            resources.ApplyResources(this.readyLabel, "readyLabel");
            this.readyLabel.Font = null;
            this.readyLabel.Name = "readyLabel";
            // 
            // downloadingLabel
            // 
            this.downloadingLabel.AccessibleDescription = null;
            this.downloadingLabel.AccessibleName = null;
            resources.ApplyResources(this.downloadingLabel, "downloadingLabel");
            this.downloadingLabel.Font = null;
            this.downloadingLabel.Name = "downloadingLabel";
            // 
            // checkingLabel
            // 
            this.checkingLabel.AccessibleDescription = null;
            this.checkingLabel.AccessibleName = null;
            resources.ApplyResources(this.checkingLabel, "checkingLabel");
            this.checkingLabel.Font = null;
            this.checkingLabel.Name = "checkingLabel";
            // 
            // exitButton
            // 
            this.exitButton.AccessibleDescription = null;
            this.exitButton.AccessibleName = null;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackgroundImage = null;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = null;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // CheckUpdatesDlg
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CancelButton = this.exitButton;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkForUpdatesButton);
            this.Controls.Add(this.label1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckUpdatesDlg";
            this.ShowIcon = false;
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.checkForUpdatesButton, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkForUpdatesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Button installUpdatesButton;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Label downloadingLabel;
        private System.Windows.Forms.Button exitButton;
    }
}