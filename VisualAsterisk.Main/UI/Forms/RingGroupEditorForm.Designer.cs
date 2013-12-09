namespace VisualAsterisk.Main.UI.Forms
{
    partial class RingGroupEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RingGroupEditorForm));
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label howLongLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label strategyLabel;
            this.ringGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewRingGroupMembers = new System.Windows.Forms.ListView();
            this.listViewAvailiableChannels = new System.Windows.Forms.ListView();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonAddSelected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMenus = new System.Windows.Forms.ComboBox();
            this.radioButtonHangup = new System.Windows.Forms.RadioButton();
            this.radioButtonGotoIvrMenu = new System.Windows.Forms.RadioButton();
            this.radioButtonGotoVoicemail = new System.Windows.Forms.RadioButton();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.howLongTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.strategyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            howLongLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            strategyLabel = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.AccessibleDescription = null;
            this.headerPanel.AccessibleName = null;
            resources.ApplyResources(this.headerPanel, "headerPanel");
            this.headerPanel.BackgroundImage = null;
            this.headerPanel.Font = null;
            // 
            // contentPanel
            // 
            this.contentPanel.AccessibleDescription = null;
            this.contentPanel.AccessibleName = null;
            resources.ApplyResources(this.contentPanel, "contentPanel");
            this.contentPanel.BackgroundImage = null;
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.label4);
            this.contentPanel.Controls.Add(this.listViewRingGroupMembers);
            this.contentPanel.Controls.Add(this.listViewAvailiableChannels);
            this.contentPanel.Controls.Add(this.buttonDeleteAll);
            this.contentPanel.Controls.Add(this.buttonDeleteSelected);
            this.contentPanel.Controls.Add(this.buttonAddSelected);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.groupBox1);
            this.contentPanel.Controls.Add(extensionLabel);
            this.contentPanel.Controls.Add(this.extensionTextBox);
            this.contentPanel.Controls.Add(howLongLabel);
            this.contentPanel.Controls.Add(this.howLongTextBox);
            this.contentPanel.Controls.Add(nameLabel);
            this.contentPanel.Controls.Add(this.nameTextBox);
            this.contentPanel.Controls.Add(strategyLabel);
            this.contentPanel.Controls.Add(this.strategyTextBox);
            this.contentPanel.Font = null;
            // 
            // buttomPanel
            // 
            this.buttomPanel.AccessibleDescription = null;
            this.buttomPanel.AccessibleName = null;
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            this.buttomPanel.BackgroundImage = null;
            this.buttomPanel.Font = null;
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
            // extensionLabel
            // 
            extensionLabel.AccessibleDescription = null;
            extensionLabel.AccessibleName = null;
            resources.ApplyResources(extensionLabel, "extensionLabel");
            extensionLabel.Font = null;
            extensionLabel.Name = "extensionLabel";
            // 
            // howLongLabel
            // 
            howLongLabel.AccessibleDescription = null;
            howLongLabel.AccessibleName = null;
            resources.ApplyResources(howLongLabel, "howLongLabel");
            howLongLabel.Font = null;
            howLongLabel.Name = "howLongLabel";
            // 
            // nameLabel
            // 
            nameLabel.AccessibleDescription = null;
            nameLabel.AccessibleName = null;
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Font = null;
            nameLabel.Name = "nameLabel";
            // 
            // strategyLabel
            // 
            strategyLabel.AccessibleDescription = null;
            strategyLabel.AccessibleName = null;
            resources.ApplyResources(strategyLabel, "strategyLabel");
            strategyLabel.Font = null;
            strategyLabel.Name = "strategyLabel";
            // 
            // ringGroupBindingSource
            // 
            this.ringGroupBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.RingGroup);
            // 
            // listViewRingGroupMembers
            // 
            this.listViewRingGroupMembers.AccessibleDescription = null;
            this.listViewRingGroupMembers.AccessibleName = null;
            resources.ApplyResources(this.listViewRingGroupMembers, "listViewRingGroupMembers");
            this.listViewRingGroupMembers.BackgroundImage = null;
            this.listViewRingGroupMembers.Font = null;
            this.listViewRingGroupMembers.Name = "listViewRingGroupMembers";
            this.listViewRingGroupMembers.UseCompatibleStateImageBehavior = false;
            this.listViewRingGroupMembers.View = System.Windows.Forms.View.List;
            // 
            // listViewAvailiableChannels
            // 
            this.listViewAvailiableChannels.AccessibleDescription = null;
            this.listViewAvailiableChannels.AccessibleName = null;
            resources.ApplyResources(this.listViewAvailiableChannels, "listViewAvailiableChannels");
            this.listViewAvailiableChannels.BackgroundImage = null;
            this.listViewAvailiableChannels.Font = null;
            this.listViewAvailiableChannels.Name = "listViewAvailiableChannels";
            this.listViewAvailiableChannels.UseCompatibleStateImageBehavior = false;
            this.listViewAvailiableChannels.View = System.Windows.Forms.View.List;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.AccessibleDescription = null;
            this.buttonDeleteAll.AccessibleName = null;
            resources.ApplyResources(this.buttonDeleteAll, "buttonDeleteAll");
            this.buttonDeleteAll.BackgroundImage = null;
            this.buttonDeleteAll.Font = null;
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.AccessibleDescription = null;
            this.buttonDeleteSelected.AccessibleName = null;
            resources.ApplyResources(this.buttonDeleteSelected, "buttonDeleteSelected");
            this.buttonDeleteSelected.BackgroundImage = null;
            this.buttonDeleteSelected.Font = null;
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // buttonAddSelected
            // 
            this.buttonAddSelected.AccessibleDescription = null;
            this.buttonAddSelected.AccessibleName = null;
            resources.ApplyResources(this.buttonAddSelected, "buttonAddSelected");
            this.buttonAddSelected.BackgroundImage = null;
            this.buttonAddSelected.Font = null;
            this.buttonAddSelected.Name = "buttonAddSelected";
            this.buttonAddSelected.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.comboBoxMenus);
            this.groupBox1.Controls.Add(this.radioButtonHangup);
            this.groupBox1.Controls.Add(this.radioButtonGotoIvrMenu);
            this.groupBox1.Controls.Add(this.radioButtonGotoVoicemail);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // comboBoxMenus
            // 
            this.comboBoxMenus.AccessibleDescription = null;
            this.comboBoxMenus.AccessibleName = null;
            resources.ApplyResources(this.comboBoxMenus, "comboBoxMenus");
            this.comboBoxMenus.BackgroundImage = null;
            this.comboBoxMenus.Font = null;
            this.comboBoxMenus.FormattingEnabled = true;
            this.comboBoxMenus.Name = "comboBoxMenus";
            // 
            // radioButtonHangup
            // 
            this.radioButtonHangup.AccessibleDescription = null;
            this.radioButtonHangup.AccessibleName = null;
            resources.ApplyResources(this.radioButtonHangup, "radioButtonHangup");
            this.radioButtonHangup.BackgroundImage = null;
            this.radioButtonHangup.Font = null;
            this.radioButtonHangup.Name = "radioButtonHangup";
            this.radioButtonHangup.TabStop = true;
            this.radioButtonHangup.UseVisualStyleBackColor = true;
            // 
            // radioButtonGotoIvrMenu
            // 
            this.radioButtonGotoIvrMenu.AccessibleDescription = null;
            this.radioButtonGotoIvrMenu.AccessibleName = null;
            resources.ApplyResources(this.radioButtonGotoIvrMenu, "radioButtonGotoIvrMenu");
            this.radioButtonGotoIvrMenu.BackgroundImage = null;
            this.radioButtonGotoIvrMenu.Font = null;
            this.radioButtonGotoIvrMenu.Name = "radioButtonGotoIvrMenu";
            this.radioButtonGotoIvrMenu.TabStop = true;
            this.radioButtonGotoIvrMenu.UseVisualStyleBackColor = true;
            // 
            // radioButtonGotoVoicemail
            // 
            this.radioButtonGotoVoicemail.AccessibleDescription = null;
            this.radioButtonGotoVoicemail.AccessibleName = null;
            resources.ApplyResources(this.radioButtonGotoVoicemail, "radioButtonGotoVoicemail");
            this.radioButtonGotoVoicemail.BackgroundImage = null;
            this.radioButtonGotoVoicemail.Font = null;
            this.radioButtonGotoVoicemail.Name = "radioButtonGotoVoicemail";
            this.radioButtonGotoVoicemail.TabStop = true;
            this.radioButtonGotoVoicemail.UseVisualStyleBackColor = true;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.AccessibleDescription = null;
            this.extensionTextBox.AccessibleName = null;
            resources.ApplyResources(this.extensionTextBox, "extensionTextBox");
            this.extensionTextBox.BackgroundImage = null;
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "Extension", true));
            this.extensionTextBox.Font = null;
            this.extensionTextBox.Name = "extensionTextBox";
            // 
            // howLongTextBox
            // 
            this.howLongTextBox.AccessibleDescription = null;
            this.howLongTextBox.AccessibleName = null;
            resources.ApplyResources(this.howLongTextBox, "howLongTextBox");
            this.howLongTextBox.BackgroundImage = null;
            this.howLongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "HowLong", true));
            this.howLongTextBox.Font = null;
            this.howLongTextBox.Name = "howLongTextBox";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AccessibleDescription = null;
            this.nameTextBox.AccessibleName = null;
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.BackgroundImage = null;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "Name", true));
            this.nameTextBox.Font = null;
            this.nameTextBox.Name = "nameTextBox";
            // 
            // strategyTextBox
            // 
            this.strategyTextBox.AccessibleDescription = null;
            this.strategyTextBox.AccessibleName = null;
            resources.ApplyResources(this.strategyTextBox, "strategyTextBox");
            this.strategyTextBox.BackgroundImage = null;
            this.strategyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "Strategy", true));
            this.strategyTextBox.Font = null;
            this.strategyTextBox.Name = "strategyTextBox";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // RingGroupEditorForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Icon = null;
            this.Name = "RingGroupEditorForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.buttomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ringGroupBindingSource;
        private System.Windows.Forms.ListView listViewRingGroupMembers;
        private System.Windows.Forms.ListView listViewAvailiableChannels;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonAddSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMenus;
        private System.Windows.Forms.RadioButton radioButtonHangup;
        private System.Windows.Forms.RadioButton radioButtonGotoIvrMenu;
        private System.Windows.Forms.RadioButton radioButtonGotoVoicemail;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox howLongTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox strategyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}