namespace VisualAsterisk.Main.UI.Forms
{
    partial class UserEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditorForm));
            IC.Controls.SmoothLabel disallowLabel;
            IC.Controls.SmoothLabel allowLabel;
            IC.Controls.SmoothLabel insecureLabel;
            IC.Controls.SmoothLabel dtmfmodeLabel;
            IC.Controls.SmoothLabel extensionLabel;
            IC.Controls.SmoothLabel fullNameLabel;
            IC.Controls.SmoothLabel contextLabel;
            IC.Controls.SmoothLabel vmsecretLabel;
            IC.Controls.SmoothLabel passwordLabel;
            IC.Controls.SmoothLabel emailLabel;
            IC.Controls.SmoothLabel cidNumberLabel;
            IC.Controls.SmoothLabel zapchanLabel;
            IC.Controls.SmoothLabel smoothLabel1;
            IC.Controls.SmoothLabel smoothLabel2;
            IC.Controls.SmoothLabel smoothLabel3;
            IC.Controls.SmoothLabel smoothLabel4;
            IC.Controls.SmoothLabel smoothLabel5;
            IC.Controls.SmoothLabel smoothLabel6;
            IC.Controls.SmoothLabel smoothLabel7;
            IC.Controls.SmoothLabel smoothLabel8;
            IC.Controls.SmoothLabel smoothLabel9;
            IC.Controls.SmoothLabel smoothLabel10;
            this.userExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editCodecButton = new System.Windows.Forms.Button();
            this.disallowTextBox = new System.Windows.Forms.TextBox();
            this.allowTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.natCheckBox = new System.Windows.Forms.CheckBox();
            this.hasCTICheckBox = new System.Windows.Forms.CheckBox();
            this.hasVoicemailCheckBox = new System.Windows.Forms.CheckBox();
            this.hasdirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.hasSipCheckBox = new System.Windows.Forms.CheckBox();
            this.hasiaxCheckBox = new System.Windows.Forms.CheckBox();
            this.hasagentCheckBox = new System.Windows.Forms.CheckBox();
            this.callWaitingCheckBox = new System.Windows.Forms.CheckBox();
            this.canreinviteCheckBox = new System.Windows.Forms.CheckBox();
            this.threeWayCallingCheckBox = new System.Windows.Forms.CheckBox();
            this.insecureTextBox = new System.Windows.Forms.TextBox();
            this.dtmfmodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dialplanComboBox = new System.Windows.Forms.ComboBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.vmsecretTextBox = new System.Windows.Forms.TextBox();
            this.cidNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.zapchanTextBox = new System.Windows.Forms.TextBox();
            disallowLabel = new IC.Controls.SmoothLabel();
            allowLabel = new IC.Controls.SmoothLabel();
            insecureLabel = new IC.Controls.SmoothLabel();
            dtmfmodeLabel = new IC.Controls.SmoothLabel();
            extensionLabel = new IC.Controls.SmoothLabel();
            fullNameLabel = new IC.Controls.SmoothLabel();
            contextLabel = new IC.Controls.SmoothLabel();
            vmsecretLabel = new IC.Controls.SmoothLabel();
            passwordLabel = new IC.Controls.SmoothLabel();
            emailLabel = new IC.Controls.SmoothLabel();
            cidNumberLabel = new IC.Controls.SmoothLabel();
            zapchanLabel = new IC.Controls.SmoothLabel();
            smoothLabel1 = new IC.Controls.SmoothLabel();
            smoothLabel2 = new IC.Controls.SmoothLabel();
            smoothLabel3 = new IC.Controls.SmoothLabel();
            smoothLabel4 = new IC.Controls.SmoothLabel();
            smoothLabel5 = new IC.Controls.SmoothLabel();
            smoothLabel6 = new IC.Controls.SmoothLabel();
            smoothLabel7 = new IC.Controls.SmoothLabel();
            smoothLabel8 = new IC.Controls.SmoothLabel();
            smoothLabel9 = new IC.Controls.SmoothLabel();
            smoothLabel10 = new IC.Controls.SmoothLabel();
            this.contentPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            resources.ApplyResources(this.headerPanel, "headerPanel");
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.groupBox1);
            this.contentPanel.Controls.Add(this.groupBox2);
            this.contentPanel.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            // 
            // buttomPanel
            // 
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // disallowLabel
            // 
            disallowLabel.AntiAliasText = false;
            resources.ApplyResources(disallowLabel, "disallowLabel");
            disallowLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            disallowLabel.EnableHelp = true;
            disallowLabel.Name = "disallowLabel";
            // 
            // allowLabel
            // 
            allowLabel.AntiAliasText = false;
            resources.ApplyResources(allowLabel, "allowLabel");
            allowLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            allowLabel.EnableHelp = true;
            allowLabel.Name = "allowLabel";
            // 
            // insecureLabel
            // 
            insecureLabel.AntiAliasText = false;
            resources.ApplyResources(insecureLabel, "insecureLabel");
            insecureLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            insecureLabel.EnableHelp = true;
            insecureLabel.Name = "insecureLabel";
            // 
            // dtmfmodeLabel
            // 
            dtmfmodeLabel.AntiAliasText = false;
            resources.ApplyResources(dtmfmodeLabel, "dtmfmodeLabel");
            dtmfmodeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            dtmfmodeLabel.EnableHelp = true;
            dtmfmodeLabel.Name = "dtmfmodeLabel";
            // 
            // extensionLabel
            // 
            extensionLabel.AntiAliasText = false;
            resources.ApplyResources(extensionLabel, "extensionLabel");
            extensionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            extensionLabel.EnableHelp = true;
            extensionLabel.Name = "extensionLabel";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AntiAliasText = false;
            resources.ApplyResources(fullNameLabel, "fullNameLabel");
            fullNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            fullNameLabel.EnableHelp = true;
            fullNameLabel.Name = "fullNameLabel";
            // 
            // contextLabel
            // 
            contextLabel.AntiAliasText = false;
            resources.ApplyResources(contextLabel, "contextLabel");
            contextLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            contextLabel.EnableHelp = true;
            contextLabel.Name = "contextLabel";
            // 
            // vmsecretLabel
            // 
            vmsecretLabel.AntiAliasText = false;
            resources.ApplyResources(vmsecretLabel, "vmsecretLabel");
            vmsecretLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            vmsecretLabel.EnableHelp = true;
            vmsecretLabel.Name = "vmsecretLabel";
            // 
            // passwordLabel
            // 
            passwordLabel.AntiAliasText = false;
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            passwordLabel.EnableHelp = true;
            passwordLabel.Name = "passwordLabel";
            // 
            // emailLabel
            // 
            emailLabel.AntiAliasText = false;
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            emailLabel.EnableHelp = true;
            emailLabel.Name = "emailLabel";
            // 
            // cidNumberLabel
            // 
            cidNumberLabel.AntiAliasText = false;
            resources.ApplyResources(cidNumberLabel, "cidNumberLabel");
            cidNumberLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            cidNumberLabel.EnableHelp = true;
            cidNumberLabel.Name = "cidNumberLabel";
            // 
            // zapchanLabel
            // 
            zapchanLabel.AntiAliasText = false;
            resources.ApplyResources(zapchanLabel, "zapchanLabel");
            zapchanLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            zapchanLabel.EnableHelp = true;
            zapchanLabel.Name = "zapchanLabel";
            // 
            // smoothLabel1
            // 
            smoothLabel1.AntiAliasText = false;
            resources.ApplyResources(smoothLabel1, "smoothLabel1");
            smoothLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel1.EnableHelp = true;
            smoothLabel1.Name = "smoothLabel1";
            // 
            // smoothLabel2
            // 
            smoothLabel2.AntiAliasText = false;
            resources.ApplyResources(smoothLabel2, "smoothLabel2");
            smoothLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel2.EnableHelp = true;
            smoothLabel2.Name = "smoothLabel2";
            // 
            // smoothLabel3
            // 
            smoothLabel3.AntiAliasText = false;
            resources.ApplyResources(smoothLabel3, "smoothLabel3");
            smoothLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel3.EnableHelp = true;
            smoothLabel3.Name = "smoothLabel3";
            // 
            // smoothLabel4
            // 
            smoothLabel4.AntiAliasText = false;
            resources.ApplyResources(smoothLabel4, "smoothLabel4");
            smoothLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel4.EnableHelp = true;
            smoothLabel4.Name = "smoothLabel4";
            // 
            // smoothLabel5
            // 
            smoothLabel5.AntiAliasText = false;
            resources.ApplyResources(smoothLabel5, "smoothLabel5");
            smoothLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel5.EnableHelp = true;
            smoothLabel5.Name = "smoothLabel5";
            // 
            // smoothLabel6
            // 
            smoothLabel6.AntiAliasText = false;
            resources.ApplyResources(smoothLabel6, "smoothLabel6");
            smoothLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel6.EnableHelp = true;
            smoothLabel6.Name = "smoothLabel6";
            // 
            // smoothLabel7
            // 
            smoothLabel7.AntiAliasText = false;
            resources.ApplyResources(smoothLabel7, "smoothLabel7");
            smoothLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel7.EnableHelp = true;
            smoothLabel7.Name = "smoothLabel7";
            // 
            // smoothLabel8
            // 
            smoothLabel8.AntiAliasText = false;
            resources.ApplyResources(smoothLabel8, "smoothLabel8");
            smoothLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel8.EnableHelp = true;
            smoothLabel8.Name = "smoothLabel8";
            // 
            // smoothLabel9
            // 
            smoothLabel9.AntiAliasText = false;
            resources.ApplyResources(smoothLabel9, "smoothLabel9");
            smoothLabel9.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel9.EnableHelp = true;
            smoothLabel9.Name = "smoothLabel9";
            // 
            // smoothLabel10
            // 
            smoothLabel10.AntiAliasText = false;
            resources.ApplyResources(smoothLabel10, "smoothLabel10");
            smoothLabel10.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel10.EnableHelp = true;
            smoothLabel10.Name = "smoothLabel10";
            // 
            // userExtensionBindingSource
            // 
            this.userExtensionBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.UserExtension);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editCodecButton);
            this.groupBox3.Controls.Add(this.disallowTextBox);
            this.groupBox3.Controls.Add(disallowLabel);
            this.groupBox3.Controls.Add(this.allowTextBox);
            this.groupBox3.Controls.Add(allowLabel);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // editCodecButton
            // 
            resources.ApplyResources(this.editCodecButton, "editCodecButton");
            this.editCodecButton.Name = "editCodecButton";
            this.editCodecButton.UseVisualStyleBackColor = true;
            this.editCodecButton.Click += new System.EventHandler(this.editCodecButton_Click);
            // 
            // disallowTextBox
            // 
            this.disallowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Disallow", true));
            resources.ApplyResources(this.disallowTextBox, "disallowTextBox");
            this.disallowTextBox.Name = "disallowTextBox";
            // 
            // allowTextBox
            // 
            this.allowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Allow", true));
            resources.ApplyResources(this.allowTextBox, "allowTextBox");
            this.allowTextBox.Name = "allowTextBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(smoothLabel10);
            this.groupBox2.Controls.Add(smoothLabel9);
            this.groupBox2.Controls.Add(smoothLabel8);
            this.groupBox2.Controls.Add(smoothLabel7);
            this.groupBox2.Controls.Add(smoothLabel6);
            this.groupBox2.Controls.Add(smoothLabel5);
            this.groupBox2.Controls.Add(smoothLabel4);
            this.groupBox2.Controls.Add(smoothLabel3);
            this.groupBox2.Controls.Add(smoothLabel2);
            this.groupBox2.Controls.Add(smoothLabel1);
            this.groupBox2.Controls.Add(this.natCheckBox);
            this.groupBox2.Controls.Add(this.hasCTICheckBox);
            this.groupBox2.Controls.Add(this.hasVoicemailCheckBox);
            this.groupBox2.Controls.Add(this.hasdirectoryCheckBox);
            this.groupBox2.Controls.Add(this.hasSipCheckBox);
            this.groupBox2.Controls.Add(this.hasiaxCheckBox);
            this.groupBox2.Controls.Add(this.hasagentCheckBox);
            this.groupBox2.Controls.Add(this.callWaitingCheckBox);
            this.groupBox2.Controls.Add(this.canreinviteCheckBox);
            this.groupBox2.Controls.Add(this.threeWayCallingCheckBox);
            this.groupBox2.Controls.Add(insecureLabel);
            this.groupBox2.Controls.Add(this.insecureTextBox);
            this.groupBox2.Controls.Add(dtmfmodeLabel);
            this.groupBox2.Controls.Add(this.dtmfmodeTextBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // natCheckBox
            // 
            this.natCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Nat", true));
            resources.ApplyResources(this.natCheckBox, "natCheckBox");
            this.natCheckBox.Name = "natCheckBox";
            this.natCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasCTICheckBox
            // 
            this.hasCTICheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "HasCTI", true));
            resources.ApplyResources(this.hasCTICheckBox, "hasCTICheckBox");
            this.hasCTICheckBox.Name = "hasCTICheckBox";
            this.hasCTICheckBox.UseVisualStyleBackColor = true;
            // 
            // hasVoicemailCheckBox
            // 
            this.hasVoicemailCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "HasVoicemail", true));
            resources.ApplyResources(this.hasVoicemailCheckBox, "hasVoicemailCheckBox");
            this.hasVoicemailCheckBox.Name = "hasVoicemailCheckBox";
            this.hasVoicemailCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasdirectoryCheckBox
            // 
            this.hasdirectoryCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Hasdirectory", true));
            resources.ApplyResources(this.hasdirectoryCheckBox, "hasdirectoryCheckBox");
            this.hasdirectoryCheckBox.Name = "hasdirectoryCheckBox";
            this.hasdirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasSipCheckBox
            // 
            this.hasSipCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "HasSip", true));
            resources.ApplyResources(this.hasSipCheckBox, "hasSipCheckBox");
            this.hasSipCheckBox.Name = "hasSipCheckBox";
            this.hasSipCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasiaxCheckBox
            // 
            this.hasiaxCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Hasiax", true));
            resources.ApplyResources(this.hasiaxCheckBox, "hasiaxCheckBox");
            this.hasiaxCheckBox.Name = "hasiaxCheckBox";
            this.hasiaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasagentCheckBox
            // 
            this.hasagentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Hasagent", true));
            resources.ApplyResources(this.hasagentCheckBox, "hasagentCheckBox");
            this.hasagentCheckBox.Name = "hasagentCheckBox";
            this.hasagentCheckBox.UseVisualStyleBackColor = true;
            // 
            // callWaitingCheckBox
            // 
            this.callWaitingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "CallWaiting", true));
            resources.ApplyResources(this.callWaitingCheckBox, "callWaitingCheckBox");
            this.callWaitingCheckBox.Name = "callWaitingCheckBox";
            this.callWaitingCheckBox.UseVisualStyleBackColor = true;
            // 
            // canreinviteCheckBox
            // 
            this.canreinviteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Canreinvite", true));
            resources.ApplyResources(this.canreinviteCheckBox, "canreinviteCheckBox");
            this.canreinviteCheckBox.Name = "canreinviteCheckBox";
            this.canreinviteCheckBox.UseVisualStyleBackColor = true;
            // 
            // threeWayCallingCheckBox
            // 
            this.threeWayCallingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "ThreeWayCalling", true));
            resources.ApplyResources(this.threeWayCallingCheckBox, "threeWayCallingCheckBox");
            this.threeWayCallingCheckBox.Name = "threeWayCallingCheckBox";
            this.threeWayCallingCheckBox.UseVisualStyleBackColor = true;
            // 
            // insecureTextBox
            // 
            this.insecureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Insecure", true));
            resources.ApplyResources(this.insecureTextBox, "insecureTextBox");
            this.insecureTextBox.Name = "insecureTextBox";
            // 
            // dtmfmodeTextBox
            // 
            this.dtmfmodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Dtmfmode", true));
            resources.ApplyResources(this.dtmfmodeTextBox, "dtmfmodeTextBox");
            this.dtmfmodeTextBox.Name = "dtmfmodeTextBox";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dialplanComboBox);
            this.groupBox1.Controls.Add(extensionLabel);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(fullNameLabel);
            this.groupBox1.Controls.Add(this.extensionTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.vmsecretTextBox);
            this.groupBox1.Controls.Add(contextLabel);
            this.groupBox1.Controls.Add(vmsecretLabel);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(cidNumberLabel);
            this.groupBox1.Controls.Add(this.cidNumberTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(zapchanLabel);
            this.groupBox1.Controls.Add(this.zapchanTextBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dialplanComboBox
            // 
            this.dialplanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dialplanComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.dialplanComboBox, "dialplanComboBox");
            this.dialplanComboBox.Name = "dialplanComboBox";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "FullName", true));
            resources.ApplyResources(this.fullNameTextBox, "fullNameTextBox");
            this.fullNameTextBox.Name = "fullNameTextBox";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Extension", true));
            resources.ApplyResources(this.extensionTextBox, "extensionTextBox");
            this.extensionTextBox.Name = "extensionTextBox";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Password", true));
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            // 
            // vmsecretTextBox
            // 
            this.vmsecretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Vmsecret", true));
            resources.ApplyResources(this.vmsecretTextBox, "vmsecretTextBox");
            this.vmsecretTextBox.Name = "vmsecretTextBox";
            // 
            // cidNumberTextBox
            // 
            this.cidNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "CidNumber", true));
            resources.ApplyResources(this.cidNumberTextBox, "cidNumberTextBox");
            this.cidNumberTextBox.Name = "cidNumberTextBox";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Email", true));
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // zapchanTextBox
            // 
            this.zapchanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Zapchan", true));
            resources.ApplyResources(this.zapchanTextBox, "zapchanTextBox");
            this.zapchanTextBox.Name = "zapchanTextBox";
            // 
            // UserEditorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserEditorForm";
            this.contentPanel.ResumeLayout(false);
            this.buttomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource userExtensionBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button editCodecButton;
        private System.Windows.Forms.TextBox disallowTextBox;
        private System.Windows.Forms.TextBox allowTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox natCheckBox;
        private System.Windows.Forms.CheckBox hasCTICheckBox;
        private System.Windows.Forms.CheckBox hasVoicemailCheckBox;
        private System.Windows.Forms.CheckBox hasdirectoryCheckBox;
        private System.Windows.Forms.CheckBox hasSipCheckBox;
        private System.Windows.Forms.CheckBox hasiaxCheckBox;
        private System.Windows.Forms.CheckBox hasagentCheckBox;
        private System.Windows.Forms.CheckBox callWaitingCheckBox;
        private System.Windows.Forms.CheckBox canreinviteCheckBox;
        private System.Windows.Forms.CheckBox threeWayCallingCheckBox;
        private System.Windows.Forms.TextBox insecureTextBox;
        private System.Windows.Forms.TextBox dtmfmodeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dialplanComboBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox vmsecretTextBox;
        private System.Windows.Forms.TextBox cidNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox zapchanTextBox;
    }
}