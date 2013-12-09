using IC.Controls.Wizard;

namespace VisualAsterisk.Main.Gui.Forms
{
    partial class RegisterAsteriskWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAsteriskWizard));
            this.wizard1 = new IC.Controls.Wizard.Wizard();
            this.completedPage = new IC.Controls.Wizard.WizardPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkingPage = new IC.Controls.Wizard.WizardPage();
            this.installLabel1 = new System.Windows.Forms.Label();
            this.transmitFIleLabel = new System.Windows.Forms.Label();
            this.sshConnectLabel = new System.Windows.Forms.Label();
            this.connectionFailedInfoLabel = new System.Windows.Forms.Label();
            this.checkPreInstallConditionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.connectPage = new IC.Controls.Wizard.WizardPage();
            this.connectServerLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomePage = new IC.Controls.Wizard.WizardPage();
            this.useExistConfigurationButton = new System.Windows.Forms.Button();
            this.newConfigurationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wizard1.SuspendLayout();
            this.completedPage.SuspendLayout();
            this.checkingPage.SuspendLayout();
            this.connectPage.SuspendLayout();
            this.welcomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard1
            // 
            this.wizard1.AccessibleDescription = null;
            this.wizard1.AccessibleName = null;
            this.wizard1.AlwaysShowFinishButton = false;
            resources.ApplyResources(this.wizard1, "wizard1");
            this.wizard1.BackgroundImage = null;
            this.wizard1.CloseOnCancel = true;
            this.wizard1.CloseOnFinish = true;
            this.wizard1.Controls.Add(this.completedPage);
            this.wizard1.Controls.Add(this.checkingPage);
            this.wizard1.Controls.Add(this.connectPage);
            this.wizard1.Controls.Add(this.welcomePage);
            this.wizard1.DisplayButtons = true;
            this.wizard1.Name = "wizard1";
            this.wizard1.PageIndex = 3;
            this.wizard1.Pages.AddRange(new IC.Controls.Wizard.WizardPage[] {
            this.welcomePage,
            this.connectPage,
            this.checkingPage,
            this.completedPage});
            this.wizard1.ShowTabs = false;
            this.wizard1.TabBackColor = System.Drawing.SystemColors.Control;
            this.wizard1.TabBackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
           // this.wizard1.TabDividerLineType = IC.Controls.Wizard.WizardTabDividerLineType.SingleLine;
            // 
            // completedPage
            // 
            this.completedPage.AccessibleDescription = null;
            this.completedPage.AccessibleName = null;
            resources.ApplyResources(this.completedPage, "completedPage");
            this.completedPage.BackgroundImage = null;
            this.completedPage.Controls.Add(this.label15);
            this.completedPage.Controls.Add(this.label14);
            this.completedPage.IsFinishPage = false;
            this.completedPage.Name = "completedPage";
            this.completedPage.TabLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            // 
            // label15
            // 
            this.label15.AccessibleDescription = null;
            this.label15.AccessibleName = null;
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            this.label14.AccessibleDescription = null;
            this.label14.AccessibleName = null;
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Name = "label14";
            // 
            // checkingPage
            // 
            this.checkingPage.AccessibleDescription = null;
            this.checkingPage.AccessibleName = null;
            resources.ApplyResources(this.checkingPage, "checkingPage");
            this.checkingPage.BackgroundImage = null;
            this.checkingPage.Controls.Add(this.installLabel1);
            this.checkingPage.Controls.Add(this.transmitFIleLabel);
            this.checkingPage.Controls.Add(this.sshConnectLabel);
            this.checkingPage.Controls.Add(this.connectionFailedInfoLabel);
            this.checkingPage.Controls.Add(this.checkPreInstallConditionLabel);
            this.checkingPage.Controls.Add(this.label8);
            this.checkingPage.IsFinishPage = false;
            this.checkingPage.Name = "checkingPage";
            this.checkingPage.TabLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            // 
            // installLabel1
            // 
            this.installLabel1.AccessibleDescription = null;
            this.installLabel1.AccessibleName = null;
            resources.ApplyResources(this.installLabel1, "installLabel1");
            this.installLabel1.Font = null;
            this.installLabel1.Name = "installLabel1";
            // 
            // transmitFIleLabel
            // 
            this.transmitFIleLabel.AccessibleDescription = null;
            this.transmitFIleLabel.AccessibleName = null;
            resources.ApplyResources(this.transmitFIleLabel, "transmitFIleLabel");
            this.transmitFIleLabel.Font = null;
            this.transmitFIleLabel.Name = "transmitFIleLabel";
            // 
            // sshConnectLabel
            // 
            this.sshConnectLabel.AccessibleDescription = null;
            this.sshConnectLabel.AccessibleName = null;
            resources.ApplyResources(this.sshConnectLabel, "sshConnectLabel");
            this.sshConnectLabel.Font = null;
            this.sshConnectLabel.Name = "sshConnectLabel";
            // 
            // connectionFailedInfoLabel
            // 
            this.connectionFailedInfoLabel.AccessibleDescription = null;
            this.connectionFailedInfoLabel.AccessibleName = null;
            resources.ApplyResources(this.connectionFailedInfoLabel, "connectionFailedInfoLabel");
            this.connectionFailedInfoLabel.Font = null;
            this.connectionFailedInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionFailedInfoLabel.Name = "connectionFailedInfoLabel";
            // 
            // checkPreInstallConditionLabel
            // 
            this.checkPreInstallConditionLabel.AccessibleDescription = null;
            this.checkPreInstallConditionLabel.AccessibleName = null;
            resources.ApplyResources(this.checkPreInstallConditionLabel, "checkPreInstallConditionLabel");
            this.checkPreInstallConditionLabel.Font = null;
            this.checkPreInstallConditionLabel.Name = "checkPreInstallConditionLabel";
            // 
            // label8
            // 
            this.label8.AccessibleDescription = null;
            this.label8.AccessibleName = null;
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Name = "label8";
            // 
            // connectPage
            // 
            this.connectPage.AccessibleDescription = null;
            this.connectPage.AccessibleName = null;
            resources.ApplyResources(this.connectPage, "connectPage");
            this.connectPage.BackgroundImage = null;
            this.connectPage.Controls.Add(this.connectServerLabel);
            this.connectPage.Controls.Add(this.label6);
            this.connectPage.Controls.Add(this.passwordTextBox);
            this.connectPage.Controls.Add(this.label5);
            this.connectPage.Controls.Add(this.userTextBox);
            this.connectPage.Controls.Add(this.label4);
            this.connectPage.Controls.Add(this.hostTextBox);
            this.connectPage.Controls.Add(this.label1);
            this.connectPage.IsFinishPage = false;
            this.connectPage.Name = "connectPage";
            this.connectPage.TabLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            // 
            // connectServerLabel
            // 
            this.connectServerLabel.AccessibleDescription = null;
            this.connectServerLabel.AccessibleName = null;
            resources.ApplyResources(this.connectServerLabel, "connectServerLabel");
            this.connectServerLabel.Name = "connectServerLabel";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Name = "label6";
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
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Font = null;
            this.label5.Name = "label5";
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
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
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
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // welcomePage
            // 
            this.welcomePage.AccessibleDescription = null;
            this.welcomePage.AccessibleName = null;
            resources.ApplyResources(this.welcomePage, "welcomePage");
            this.welcomePage.BackgroundImage = null;
            this.welcomePage.Controls.Add(this.useExistConfigurationButton);
            this.welcomePage.Controls.Add(this.newConfigurationButton);
            this.welcomePage.Controls.Add(this.label3);
            this.welcomePage.Controls.Add(this.label2);
            this.welcomePage.IsFinishPage = false;
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.TabLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            // 
            // useExistConfigurationButton
            // 
            this.useExistConfigurationButton.AccessibleDescription = null;
            this.useExistConfigurationButton.AccessibleName = null;
            resources.ApplyResources(this.useExistConfigurationButton, "useExistConfigurationButton");
            this.useExistConfigurationButton.BackgroundImage = null;
            this.useExistConfigurationButton.Font = null;
            this.useExistConfigurationButton.Name = "useExistConfigurationButton";
            this.useExistConfigurationButton.UseVisualStyleBackColor = true;
            this.useExistConfigurationButton.Click += new System.EventHandler(this.useExistConfigurationButton_Click);
            // 
            // newConfigurationButton
            // 
            this.newConfigurationButton.AccessibleDescription = null;
            this.newConfigurationButton.AccessibleName = null;
            resources.ApplyResources(this.newConfigurationButton, "newConfigurationButton");
            this.newConfigurationButton.BackgroundImage = null;
            this.newConfigurationButton.Font = null;
            this.newConfigurationButton.Name = "newConfigurationButton";
            this.newConfigurationButton.UseVisualStyleBackColor = true;
            this.newConfigurationButton.Click += new System.EventHandler(this.newConfigurationButton_Click);
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Name = "label2";
            // 
            // RegisterAsteriskWizard
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.wizard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterAsteriskWizard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.wizard1.ResumeLayout(false);
            this.completedPage.ResumeLayout(false);
            this.completedPage.PerformLayout();
            this.checkingPage.ResumeLayout(false);
            this.checkingPage.PerformLayout();
            this.connectPage.ResumeLayout(false);
            this.connectPage.PerformLayout();
            this.welcomePage.ResumeLayout(false);
            this.welcomePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private IC.Controls.Wizard.Wizard wizard1;
        private IC.Controls.Wizard.WizardPage connectPage;
        private IC.Controls.Wizard.WizardPage welcomePage;
        private IC.Controls.Wizard.WizardPage completedPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label connectServerLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private WizardPage checkingPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label connectionFailedInfoLabel;
        private System.Windows.Forms.Label sshConnectLabel;
        private System.Windows.Forms.Label installLabel1;
        private System.Windows.Forms.Label transmitFIleLabel;
        private System.Windows.Forms.Label checkPreInstallConditionLabel;
        private System.Windows.Forms.Button useExistConfigurationButton;
        private System.Windows.Forms.Button newConfigurationButton;
    }
}