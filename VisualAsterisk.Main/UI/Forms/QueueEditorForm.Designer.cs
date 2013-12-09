namespace VisualAsterisk.Main.UI.Forms
{
    partial class QueueEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueueEditorForm));
            IC.Controls.SmoothLabel timeoutLabel;
            IC.Controls.SmoothLabel wrapuptimeLabel;
            IC.Controls.SmoothLabel joinemptyLabel;
            IC.Controls.SmoothLabel maxlenLabel;
            IC.Controls.SmoothLabel musicclassLabel;
            IC.Controls.SmoothLabel extensionLabel;
            IC.Controls.SmoothLabel nameLabel;
            IC.Controls.SmoothLabel strategyLabel;
            IC.Controls.SmoothLabel smoothLabel1;
            IC.Controls.SmoothLabel smoothLabel3;
            IC.Controls.SmoothLabel smoothLabel4;
            IC.Controls.SmoothLabel smoothLabel5;
            this.queueExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewAgents = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.autofillCheckBox = new System.Windows.Forms.CheckBox();
            this.autopauseCheckBox = new System.Windows.Forms.CheckBox();
            this.joinemptyTextBox = new System.Windows.Forms.TextBox();
            this.wrapuptimeTextBox = new System.Windows.Forms.TextBox();
            this.reportholdtimeCheckBox = new System.Windows.Forms.CheckBox();
            this.leavewhenemptyCheckBox = new System.Windows.Forms.CheckBox();
            this.maxlenTextBox = new System.Windows.Forms.TextBox();
            this.musicclassTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.strategyTextBox = new System.Windows.Forms.TextBox();
            timeoutLabel = new IC.Controls.SmoothLabel();
            wrapuptimeLabel = new IC.Controls.SmoothLabel();
            joinemptyLabel = new IC.Controls.SmoothLabel();
            maxlenLabel = new IC.Controls.SmoothLabel();
            musicclassLabel = new IC.Controls.SmoothLabel();
            extensionLabel = new IC.Controls.SmoothLabel();
            nameLabel = new IC.Controls.SmoothLabel();
            strategyLabel = new IC.Controls.SmoothLabel();
            smoothLabel1 = new IC.Controls.SmoothLabel();
            smoothLabel3 = new IC.Controls.SmoothLabel();
            smoothLabel4 = new IC.Controls.SmoothLabel();
            smoothLabel5 = new IC.Controls.SmoothLabel();
            this.contentPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingSource)).BeginInit();
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
            this.contentPanel.Controls.Add(this.groupBox2);
            this.contentPanel.Controls.Add(this.groupBox1);
            this.contentPanel.Controls.Add(extensionLabel);
            this.contentPanel.Controls.Add(this.extensionTextBox);
            this.contentPanel.Controls.Add(nameLabel);
            this.contentPanel.Controls.Add(this.nameTextBox);
            this.contentPanel.Controls.Add(strategyLabel);
            this.contentPanel.Controls.Add(this.strategyTextBox);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            // 
            // buttomPanel
            // 
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            // 
            // timeoutLabel
            // 
            timeoutLabel.AntiAliasText = false;
            resources.ApplyResources(timeoutLabel, "timeoutLabel");
            timeoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            timeoutLabel.EnableHelp = true;
            timeoutLabel.Name = "timeoutLabel";
            // 
            // wrapuptimeLabel
            // 
            wrapuptimeLabel.AntiAliasText = false;
            resources.ApplyResources(wrapuptimeLabel, "wrapuptimeLabel");
            wrapuptimeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            wrapuptimeLabel.EnableHelp = true;
            wrapuptimeLabel.Name = "wrapuptimeLabel";
            // 
            // joinemptyLabel
            // 
            joinemptyLabel.AntiAliasText = false;
            resources.ApplyResources(joinemptyLabel, "joinemptyLabel");
            joinemptyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            joinemptyLabel.EnableHelp = true;
            joinemptyLabel.Name = "joinemptyLabel";
            // 
            // maxlenLabel
            // 
            maxlenLabel.AntiAliasText = false;
            resources.ApplyResources(maxlenLabel, "maxlenLabel");
            maxlenLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            maxlenLabel.EnableHelp = true;
            maxlenLabel.Name = "maxlenLabel";
            // 
            // musicclassLabel
            // 
            musicclassLabel.AntiAliasText = false;
            resources.ApplyResources(musicclassLabel, "musicclassLabel");
            musicclassLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            musicclassLabel.EnableHelp = true;
            musicclassLabel.Name = "musicclassLabel";
            // 
            // extensionLabel
            // 
            extensionLabel.AntiAliasText = false;
            resources.ApplyResources(extensionLabel, "extensionLabel");
            extensionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            extensionLabel.EnableHelp = true;
            extensionLabel.Name = "extensionLabel";
            // 
            // nameLabel
            // 
            nameLabel.AntiAliasText = false;
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            nameLabel.EnableHelp = true;
            nameLabel.Name = "nameLabel";
            // 
            // strategyLabel
            // 
            strategyLabel.AntiAliasText = false;
            resources.ApplyResources(strategyLabel, "strategyLabel");
            strategyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            strategyLabel.EnableHelp = true;
            strategyLabel.Name = "strategyLabel";
            // 
            // smoothLabel1
            // 
            smoothLabel1.AntiAliasText = false;
            resources.ApplyResources(smoothLabel1, "smoothLabel1");
            smoothLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel1.EnableHelp = true;
            smoothLabel1.Name = "smoothLabel1";
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
            // queueExtensionBindingSource
            // 
            this.queueExtensionBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.QueueExtension);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewAgents);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // listViewAgents
            // 
            this.listViewAgents.CheckBoxes = true;
            resources.ApplyResources(this.listViewAgents, "listViewAgents");
            this.listViewAgents.Name = "listViewAgents";
            this.listViewAgents.UseCompatibleStateImageBehavior = false;
            this.listViewAgents.View = System.Windows.Forms.View.List;
            this.listViewAgents.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewAgents_ItemChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(smoothLabel5);
            this.groupBox1.Controls.Add(smoothLabel4);
            this.groupBox1.Controls.Add(smoothLabel3);
            this.groupBox1.Controls.Add(smoothLabel1);
            this.groupBox1.Controls.Add(timeoutLabel);
            this.groupBox1.Controls.Add(this.timeoutTextBox);
            this.groupBox1.Controls.Add(this.autofillCheckBox);
            this.groupBox1.Controls.Add(wrapuptimeLabel);
            this.groupBox1.Controls.Add(this.autopauseCheckBox);
            this.groupBox1.Controls.Add(joinemptyLabel);
            this.groupBox1.Controls.Add(this.joinemptyTextBox);
            this.groupBox1.Controls.Add(this.wrapuptimeTextBox);
            this.groupBox1.Controls.Add(this.reportholdtimeCheckBox);
            this.groupBox1.Controls.Add(maxlenLabel);
            this.groupBox1.Controls.Add(this.leavewhenemptyCheckBox);
            this.groupBox1.Controls.Add(this.maxlenTextBox);
            this.groupBox1.Controls.Add(musicclassLabel);
            this.groupBox1.Controls.Add(this.musicclassTextBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Timeout", true));
            resources.ApplyResources(this.timeoutTextBox, "timeoutTextBox");
            this.timeoutTextBox.Name = "timeoutTextBox";
            // 
            // autofillCheckBox
            // 
            this.autofillCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Autofill", true));
            resources.ApplyResources(this.autofillCheckBox, "autofillCheckBox");
            this.autofillCheckBox.Name = "autofillCheckBox";
            this.autofillCheckBox.UseVisualStyleBackColor = true;
            // 
            // autopauseCheckBox
            // 
            this.autopauseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Autopause", true));
            resources.ApplyResources(this.autopauseCheckBox, "autopauseCheckBox");
            this.autopauseCheckBox.Name = "autopauseCheckBox";
            this.autopauseCheckBox.UseVisualStyleBackColor = true;
            // 
            // joinemptyTextBox
            // 
            this.joinemptyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Joinempty", true));
            resources.ApplyResources(this.joinemptyTextBox, "joinemptyTextBox");
            this.joinemptyTextBox.Name = "joinemptyTextBox";
            // 
            // wrapuptimeTextBox
            // 
            this.wrapuptimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Wrapuptime", true));
            resources.ApplyResources(this.wrapuptimeTextBox, "wrapuptimeTextBox");
            this.wrapuptimeTextBox.Name = "wrapuptimeTextBox";
            // 
            // reportholdtimeCheckBox
            // 
            this.reportholdtimeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Reportholdtime", true));
            resources.ApplyResources(this.reportholdtimeCheckBox, "reportholdtimeCheckBox");
            this.reportholdtimeCheckBox.Name = "reportholdtimeCheckBox";
            this.reportholdtimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // leavewhenemptyCheckBox
            // 
            this.leavewhenemptyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Leavewhenempty", true));
            resources.ApplyResources(this.leavewhenemptyCheckBox, "leavewhenemptyCheckBox");
            this.leavewhenemptyCheckBox.Name = "leavewhenemptyCheckBox";
            this.leavewhenemptyCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxlenTextBox
            // 
            this.maxlenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Maxlen", true));
            resources.ApplyResources(this.maxlenTextBox, "maxlenTextBox");
            this.maxlenTextBox.Name = "maxlenTextBox";
            // 
            // musicclassTextBox
            // 
            this.musicclassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Musicclass", true));
            resources.ApplyResources(this.musicclassTextBox, "musicclassTextBox");
            this.musicclassTextBox.Name = "musicclassTextBox";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Extension", true));
            resources.ApplyResources(this.extensionTextBox, "extensionTextBox");
            this.extensionTextBox.Name = "extensionTextBox";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Name", true));
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // strategyTextBox
            // 
            this.strategyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Strategy", true));
            resources.ApplyResources(this.strategyTextBox, "strategyTextBox");
            this.strategyTextBox.Name = "strategyTextBox";
            // 
            // QueueEditorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "QueueEditorForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.buttomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource queueExtensionBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewAgents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.CheckBox autofillCheckBox;
        private System.Windows.Forms.CheckBox autopauseCheckBox;
        private System.Windows.Forms.TextBox joinemptyTextBox;
        private System.Windows.Forms.TextBox wrapuptimeTextBox;
        private System.Windows.Forms.CheckBox reportholdtimeCheckBox;
        private System.Windows.Forms.CheckBox leavewhenemptyCheckBox;
        private System.Windows.Forms.TextBox maxlenTextBox;
        private System.Windows.Forms.TextBox musicclassTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox strategyTextBox;
    }
}