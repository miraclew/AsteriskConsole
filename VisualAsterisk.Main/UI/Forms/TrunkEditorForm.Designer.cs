namespace VisualAsterisk.Main.UI.Forms
{
    partial class TrunkEditorForm
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
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label trunkTechLabel;
            System.Windows.Forms.Label registerLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label hostLabel;
            System.Windows.Forms.Label trunknameLabel;
            System.Windows.Forms.Label fromuserLabel;
            System.Windows.Forms.Label canreinviteLabel;
            System.Windows.Forms.Label insecureLabel;
            System.Windows.Forms.Label fromdomainLabel;
            System.Windows.Forms.Label cidLabel;
            System.Windows.Forms.Label portLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label disallowLabel;
            System.Windows.Forms.Label allowLabel;
            this.trunkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.trunkTechTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trunknameTextBox = new System.Windows.Forms.TextBox();
            this.insecureTextBox = new System.Windows.Forms.TextBox();
            this.fromdomainTextBox = new System.Windows.Forms.TextBox();
            this.fromuserTextBox = new System.Windows.Forms.TextBox();
            this.canreinviteCheckBox = new System.Windows.Forms.CheckBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.cidTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.disallowTextBox = new System.Windows.Forms.TextBox();
            this.allowTextBox = new System.Windows.Forms.TextBox();
            commentLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            trunkTechLabel = new System.Windows.Forms.Label();
            registerLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            hostLabel = new System.Windows.Forms.Label();
            trunknameLabel = new System.Windows.Forms.Label();
            fromuserLabel = new System.Windows.Forms.Label();
            canreinviteLabel = new System.Windows.Forms.Label();
            insecureLabel = new System.Windows.Forms.Label();
            fromdomainLabel = new System.Windows.Forms.Label();
            cidLabel = new System.Windows.Forms.Label();
            portLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            disallowLabel = new System.Windows.Forms.Label();
            allowLabel = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(354, 42);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.tabControl1);
            this.contentPanel.Size = new System.Drawing.Size(354, 328);
            // 
            // buttomPanel
            // 
            this.buttomPanel.Location = new System.Drawing.Point(0, 321);
            this.buttomPanel.Size = new System.Drawing.Size(354, 49);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(265, 14);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(152, 14);
            // 
            // trunkBindingSource
            // 
            this.trunkBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.Trunk);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 328);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commentTextBox);
            this.tabPage1.Controls.Add(commentLabel);
            this.tabPage1.Controls.Add(this.trunkTechTextBox);
            this.tabPage1.Controls.Add(passwordLabel);
            this.tabPage1.Controls.Add(trunkTechLabel);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(registerLabel);
            this.tabPage1.Controls.Add(usernameLabel);
            this.tabPage1.Controls.Add(this.registerCheckBox);
            this.tabPage1.Controls.Add(this.usernameTextBox);
            this.tabPage1.Controls.Add(this.hostTextBox);
            this.tabPage1.Controls.Add(hostLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trunk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(103, 22);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(153, 21);
            this.commentTextBox.TabIndex = 0;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(20, 25);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(56, 13);
            commentLabel.TabIndex = 8;
            commentLabel.Text = "Comment:";
            // 
            // trunkTechTextBox
            // 
            this.trunkTechTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "TrunkTech", true));
            this.trunkTechTextBox.Location = new System.Drawing.Point(103, 51);
            this.trunkTechTextBox.Name = "trunkTechTextBox";
            this.trunkTechTextBox.Size = new System.Drawing.Size(153, 21);
            this.trunkTechTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(20, 164);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 13);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Password:";
            // 
            // trunkTechLabel
            // 
            trunkTechLabel.AutoSize = true;
            trunkTechLabel.Location = new System.Drawing.Point(20, 54);
            trunkTechLabel.Name = "trunkTechLabel";
            trunkTechLabel.Size = new System.Drawing.Size(64, 13);
            trunkTechLabel.TabIndex = 28;
            trunkTechLabel.Text = "Trunk Tech:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(103, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(153, 21);
            this.passwordTextBox.TabIndex = 5;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Location = new System.Drawing.Point(20, 79);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new System.Drawing.Size(51, 13);
            registerLabel.TabIndex = 24;
            registerLabel.Text = "Register:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(20, 134);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(59, 13);
            usernameLabel.TabIndex = 30;
            usernameLabel.Text = "Username:";
            // 
            // registerCheckBox
            // 
            this.registerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.trunkBindingSource, "Register", true));
            this.registerCheckBox.Location = new System.Drawing.Point(103, 74);
            this.registerCheckBox.Name = "registerCheckBox";
            this.registerCheckBox.Size = new System.Drawing.Size(153, 24);
            this.registerCheckBox.TabIndex = 2;
            this.registerCheckBox.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(103, 131);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(153, 21);
            this.usernameTextBox.TabIndex = 4;
            // 
            // hostTextBox
            // 
            this.hostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Host", true));
            this.hostTextBox.Location = new System.Drawing.Point(103, 104);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(153, 21);
            this.hostTextBox.TabIndex = 3;
            // 
            // hostLabel
            // 
            hostLabel.AutoSize = true;
            hostLabel.Location = new System.Drawing.Point(20, 107);
            hostLabel.Name = "hostLabel";
            hostLabel.Size = new System.Drawing.Size(33, 13);
            hostLabel.TabIndex = 16;
            hostLabel.Text = "Host:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(trunknameLabel);
            this.tabPage2.Controls.Add(this.trunknameTextBox);
            this.tabPage2.Controls.Add(this.insecureTextBox);
            this.tabPage2.Controls.Add(fromuserLabel);
            this.tabPage2.Controls.Add(canreinviteLabel);
            this.tabPage2.Controls.Add(this.fromdomainTextBox);
            this.tabPage2.Controls.Add(insecureLabel);
            this.tabPage2.Controls.Add(this.fromuserTextBox);
            this.tabPage2.Controls.Add(this.canreinviteCheckBox);
            this.tabPage2.Controls.Add(fromdomainLabel);
            this.tabPage2.Controls.Add(this.portTextBox);
            this.tabPage2.Controls.Add(this.contactTextBox);
            this.tabPage2.Controls.Add(cidLabel);
            this.tabPage2.Controls.Add(this.cidTextBox);
            this.tabPage2.Controls.Add(portLabel);
            this.tabPage2.Controls.Add(contactLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trunknameLabel
            // 
            trunknameLabel.AutoSize = true;
            trunknameLabel.Location = new System.Drawing.Point(28, 31);
            trunknameLabel.Name = "trunknameLabel";
            trunknameLabel.Size = new System.Drawing.Size(64, 13);
            trunknameLabel.TabIndex = 26;
            trunknameLabel.Text = "Trunkname:";
            // 
            // trunknameTextBox
            // 
            this.trunknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Trunkname", true));
            this.trunknameTextBox.Location = new System.Drawing.Point(111, 28);
            this.trunknameTextBox.Name = "trunknameTextBox";
            this.trunknameTextBox.Size = new System.Drawing.Size(156, 21);
            this.trunknameTextBox.TabIndex = 0;
            // 
            // insecureTextBox
            // 
            this.insecureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Insecure", true));
            this.insecureTextBox.Location = new System.Drawing.Point(111, 55);
            this.insecureTextBox.Name = "insecureTextBox";
            this.insecureTextBox.Size = new System.Drawing.Size(156, 21);
            this.insecureTextBox.TabIndex = 1;
            // 
            // fromuserLabel
            // 
            fromuserLabel.AutoSize = true;
            fromuserLabel.Location = new System.Drawing.Point(28, 168);
            fromuserLabel.Name = "fromuserLabel";
            fromuserLabel.Size = new System.Drawing.Size(56, 13);
            fromuserLabel.TabIndex = 14;
            fromuserLabel.Text = "Fromuser:";
            // 
            // canreinviteLabel
            // 
            canreinviteLabel.AutoSize = true;
            canreinviteLabel.Location = new System.Drawing.Point(28, 224);
            canreinviteLabel.Name = "canreinviteLabel";
            canreinviteLabel.Size = new System.Drawing.Size(66, 13);
            canreinviteLabel.TabIndex = 2;
            canreinviteLabel.Text = "Canreinvite:";
            // 
            // fromdomainTextBox
            // 
            this.fromdomainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Fromdomain", true));
            this.fromdomainTextBox.Location = new System.Drawing.Point(111, 138);
            this.fromdomainTextBox.Name = "fromdomainTextBox";
            this.fromdomainTextBox.Size = new System.Drawing.Size(156, 21);
            this.fromdomainTextBox.TabIndex = 4;
            // 
            // insecureLabel
            // 
            insecureLabel.AutoSize = true;
            insecureLabel.Location = new System.Drawing.Point(28, 58);
            insecureLabel.Name = "insecureLabel";
            insecureLabel.Size = new System.Drawing.Size(53, 13);
            insecureLabel.TabIndex = 18;
            insecureLabel.Text = "Insecure:";
            // 
            // fromuserTextBox
            // 
            this.fromuserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Fromuser", true));
            this.fromuserTextBox.Location = new System.Drawing.Point(111, 165);
            this.fromuserTextBox.Name = "fromuserTextBox";
            this.fromuserTextBox.Size = new System.Drawing.Size(156, 21);
            this.fromuserTextBox.TabIndex = 5;
            // 
            // canreinviteCheckBox
            // 
            this.canreinviteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.trunkBindingSource, "Canreinvite", true));
            this.canreinviteCheckBox.Location = new System.Drawing.Point(111, 219);
            this.canreinviteCheckBox.Name = "canreinviteCheckBox";
            this.canreinviteCheckBox.Size = new System.Drawing.Size(104, 24);
            this.canreinviteCheckBox.TabIndex = 7;
            this.canreinviteCheckBox.UseVisualStyleBackColor = true;
            // 
            // fromdomainLabel
            // 
            fromdomainLabel.AutoSize = true;
            fromdomainLabel.Location = new System.Drawing.Point(28, 141);
            fromdomainLabel.Name = "fromdomainLabel";
            fromdomainLabel.Size = new System.Drawing.Size(69, 13);
            fromdomainLabel.TabIndex = 12;
            fromdomainLabel.Text = "Fromdomain:";
            // 
            // portTextBox
            // 
            this.portTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Port", true));
            this.portTextBox.Location = new System.Drawing.Point(111, 82);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(156, 21);
            this.portTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(111, 192);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(156, 21);
            this.contactTextBox.TabIndex = 6;
            // 
            // cidLabel
            // 
            cidLabel.AutoSize = true;
            cidLabel.Location = new System.Drawing.Point(28, 112);
            cidLabel.Name = "cidLabel";
            cidLabel.Size = new System.Drawing.Size(26, 13);
            cidLabel.TabIndex = 4;
            cidLabel.Text = "Cid:";
            // 
            // cidTextBox
            // 
            this.cidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Cid", true));
            this.cidTextBox.Location = new System.Drawing.Point(111, 109);
            this.cidTextBox.Name = "cidTextBox";
            this.cidTextBox.Size = new System.Drawing.Size(156, 21);
            this.cidTextBox.TabIndex = 3;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new System.Drawing.Point(28, 85);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(31, 13);
            portLabel.TabIndex = 22;
            portLabel.Text = "Port:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(28, 195);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(49, 13);
            contactLabel.TabIndex = 10;
            contactLabel.Text = "Contact:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(disallowLabel);
            this.tabPage3.Controls.Add(this.disallowTextBox);
            this.tabPage3.Controls.Add(allowLabel);
            this.tabPage3.Controls.Add(this.allowTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(346, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Codec";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // disallowLabel
            // 
            disallowLabel.AutoSize = true;
            disallowLabel.Location = new System.Drawing.Point(29, 35);
            disallowLabel.Name = "disallowLabel";
            disallowLabel.Size = new System.Drawing.Size(49, 13);
            disallowLabel.TabIndex = 8;
            disallowLabel.Text = "Disallow:";
            // 
            // disallowTextBox
            // 
            this.disallowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Disallow", true));
            this.disallowTextBox.Location = new System.Drawing.Point(94, 32);
            this.disallowTextBox.Name = "disallowTextBox";
            this.disallowTextBox.Size = new System.Drawing.Size(171, 21);
            this.disallowTextBox.TabIndex = 0;
            // 
            // allowLabel
            // 
            allowLabel.AutoSize = true;
            allowLabel.Location = new System.Drawing.Point(47, 81);
            allowLabel.Name = "allowLabel";
            allowLabel.Size = new System.Drawing.Size(36, 13);
            allowLabel.TabIndex = 7;
            allowLabel.Text = "Allow:";
            // 
            // allowTextBox
            // 
            this.allowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Allow", true));
            this.allowTextBox.Location = new System.Drawing.Point(94, 78);
            this.allowTextBox.Name = "allowTextBox";
            this.allowTextBox.Size = new System.Drawing.Size(171, 21);
            this.allowTextBox.TabIndex = 1;
            // 
            // TrunkEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 370);
            this.Name = "TrunkEditorForm";
            this.Text = "TrunkEditorForm";
            this.contentPanel.ResumeLayout(false);
            this.buttomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource trunkBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox trunkTechTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox registerCheckBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox trunknameTextBox;
        private System.Windows.Forms.TextBox insecureTextBox;
        private System.Windows.Forms.TextBox fromdomainTextBox;
        private System.Windows.Forms.TextBox fromuserTextBox;
        private System.Windows.Forms.CheckBox canreinviteCheckBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox cidTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox disallowTextBox;
        private System.Windows.Forms.TextBox allowTextBox;
    }
}