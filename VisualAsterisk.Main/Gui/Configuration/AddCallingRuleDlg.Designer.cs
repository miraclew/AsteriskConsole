namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class AddCallingRuleDlg
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
            System.Windows.Forms.Label beginLabel;
            System.Windows.Forms.Label followLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ruleLabel;
            System.Windows.Forms.Label stripLabel;
            System.Windows.Forms.Label trunkLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.beginTextBox = new System.Windows.Forms.TextBox();
            this.callingRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.followTextBox = new System.Windows.Forms.TextBox();
            this.moreCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.prependTextBox = new System.Windows.Forms.TextBox();
            this.ruleTextBox = new System.Windows.Forms.TextBox();
            this.stripTextBox = new System.Windows.Forms.TextBox();
            this.trunkTextBox = new System.Windows.Forms.TextBox();
            beginLabel = new System.Windows.Forms.Label();
            followLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ruleLabel = new System.Windows.Forms.Label();
            stripLabel = new System.Windows.Forms.Label();
            trunkLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(309, 265);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(112, 265);
            // 
            // beginLabel
            // 
            beginLabel.AutoSize = true;
            beginLabel.Location = new System.Drawing.Point(202, 102);
            beginLabel.Name = "beginLabel";
            beginLabel.Size = new System.Drawing.Size(155, 12);
            beginLabel.TabIndex = 1;
            beginLabel.Text = "If the number begins with";
            // 
            // followLabel
            // 
            followLabel.AutoSize = true;
            followLabel.Location = new System.Drawing.Point(202, 131);
            followLabel.Name = "followLabel";
            followLabel.Size = new System.Drawing.Size(101, 12);
            followLabel.TabIndex = 3;
            followLabel.Text = "and followed by ";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(122, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 12);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Rule Name:";
            // 
            // ruleLabel
            // 
            ruleLabel.AutoSize = true;
            ruleLabel.Location = new System.Drawing.Point(152, 159);
            ruleLabel.Name = "ruleLabel";
            ruleLabel.Size = new System.Drawing.Size(35, 12);
            ruleLabel.TabIndex = 11;
            ruleLabel.Text = "Rule:";
            // 
            // stripLabel
            // 
            stripLabel.AutoSize = true;
            stripLabel.Location = new System.Drawing.Point(42, 209);
            stripLabel.Name = "stripLabel";
            stripLabel.Size = new System.Drawing.Size(41, 12);
            stripLabel.TabIndex = 15;
            stripLabel.Text = "Strip:";
            // 
            // trunkLabel
            // 
            trunkLabel.AutoSize = true;
            trunkLabel.Location = new System.Drawing.Point(38, 43);
            trunkLabel.Name = "trunkLabel";
            trunkLabel.Size = new System.Drawing.Size(149, 12);
            trunkLabel.TabIndex = 17;
            trunkLabel.Text = "Place this call through:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(92, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 12);
            label1.TabIndex = 19;
            label1.Text = "Dialing Rules :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(159, 209);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(203, 12);
            label2.TabIndex = 20;
            label2.Text = "digits from the front and prepend";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(410, 209);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 12);
            label3.TabIndex = 21;
            label3.Text = "before dialing";
            // 
            // beginTextBox
            // 
            this.beginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.callingRuleBindingSource, "Begin", true));
            this.beginTextBox.Location = new System.Drawing.Point(363, 99);
            this.beginTextBox.Name = "beginTextBox";
            this.beginTextBox.Size = new System.Drawing.Size(71, 21);
            this.beginTextBox.TabIndex = 2;
            // 
            // callingRuleBindingSource
            // 
            this.callingRuleBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.CallingRule);
            // 
            // followTextBox
            // 
            this.followTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.callingRuleBindingSource, "Follow", true));
            this.followTextBox.Location = new System.Drawing.Point(309, 126);
            this.followTextBox.Name = "followTextBox";
            this.followTextBox.Size = new System.Drawing.Size(48, 21);
            this.followTextBox.TabIndex = 4;
            // 
            // moreCheckBox
            // 
            this.moreCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.callingRuleBindingSource, "More", true));
            this.moreCheckBox.Location = new System.Drawing.Point(363, 126);
            this.moreCheckBox.Name = "moreCheckBox";
            this.moreCheckBox.Size = new System.Drawing.Size(71, 24);
            this.moreCheckBox.TabIndex = 6;
            this.moreCheckBox.Text = "or more";
            this.moreCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.callingRuleBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(255, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 21);
            this.nameTextBox.TabIndex = 8;
            // 
            // prependTextBox
            // 
            this.prependTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.callingRuleBindingSource, "Prepend", true));
            this.prependTextBox.Location = new System.Drawing.Point(368, 206);
            this.prependTextBox.Name = "prependTextBox";
            this.prependTextBox.Size = new System.Drawing.Size(36, 21);
            this.prependTextBox.TabIndex = 10;
            // 
            // ruleTextBox
            // 
            this.ruleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.callingRuleBindingSource, "Rule", true));
            this.ruleTextBox.Location = new System.Drawing.Point(255, 156);
            this.ruleTextBox.Name = "ruleTextBox";
            this.ruleTextBox.Size = new System.Drawing.Size(179, 21);
            this.ruleTextBox.TabIndex = 12;
            // 
            // stripTextBox
            // 
            this.stripTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.callingRuleBindingSource, "Strip", true));
            this.stripTextBox.Location = new System.Drawing.Point(89, 206);
            this.stripTextBox.Name = "stripTextBox";
            this.stripTextBox.Size = new System.Drawing.Size(53, 21);
            this.stripTextBox.TabIndex = 16;
            // 
            // trunkTextBox
            // 
            this.trunkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.callingRuleBindingSource, "Trunk", true));
            this.trunkTextBox.Location = new System.Drawing.Point(255, 40);
            this.trunkTextBox.Name = "trunkTextBox";
            this.trunkTextBox.Size = new System.Drawing.Size(179, 21);
            this.trunkTextBox.TabIndex = 18;
            // 
            // AddCallingRuleDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 300);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(beginLabel);
            this.Controls.Add(this.beginTextBox);
            this.Controls.Add(followLabel);
            this.Controls.Add(this.followTextBox);
            this.Controls.Add(this.moreCheckBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.prependTextBox);
            this.Controls.Add(ruleLabel);
            this.Controls.Add(this.ruleTextBox);
            this.Controls.Add(stripLabel);
            this.Controls.Add(this.stripTextBox);
            this.Controls.Add(trunkLabel);
            this.Controls.Add(this.trunkTextBox);
            this.Name = "AddCallingRuleDlg";
            this.Text = "AddCallingRuleDlg";
            this.Controls.SetChildIndex(this.trunkTextBox, 0);
            this.Controls.SetChildIndex(trunkLabel, 0);
            this.Controls.SetChildIndex(this.stripTextBox, 0);
            this.Controls.SetChildIndex(stripLabel, 0);
            this.Controls.SetChildIndex(this.ruleTextBox, 0);
            this.Controls.SetChildIndex(ruleLabel, 0);
            this.Controls.SetChildIndex(this.prependTextBox, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(nameLabel, 0);
            this.Controls.SetChildIndex(this.moreCheckBox, 0);
            this.Controls.SetChildIndex(this.followTextBox, 0);
            this.Controls.SetChildIndex(followLabel, 0);
            this.Controls.SetChildIndex(this.beginTextBox, 0);
            this.Controls.SetChildIndex(beginLabel, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(label2, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.callingRuleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource callingRuleBindingSource;
        private System.Windows.Forms.TextBox beginTextBox;
        private System.Windows.Forms.TextBox followTextBox;
        private System.Windows.Forms.CheckBox moreCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox prependTextBox;
        private System.Windows.Forms.TextBox ruleTextBox;
        private System.Windows.Forms.TextBox stripTextBox;
        private System.Windows.Forms.TextBox trunkTextBox;
    }
}