namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class VoiceMailConfigPage
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
            System.Windows.Forms.Label attachLabel;
            System.Windows.Forms.Label attachfmtLabel;
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label maxGreetLabel;
            System.Windows.Forms.Label maxmessageLabel;
            System.Windows.Forms.Label maxmsgLabel;
            System.Windows.Forms.Label minmessageLabel;
            System.Windows.Forms.Label operatorLabel;
            this.attachCheckBox = new System.Windows.Forms.CheckBox();
            this.voiceMailSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachfmtTextBox = new System.Windows.Forms.TextBox();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.envelopeCheckBox = new System.Windows.Forms.CheckBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.maxGreetTextBox = new System.Windows.Forms.TextBox();
            this.maxmessageTextBox = new System.Windows.Forms.TextBox();
            this.maxmsgTextBox = new System.Windows.Forms.TextBox();
            this.minmessageTextBox = new System.Windows.Forms.TextBox();
            this.operatorCheckBox = new System.Windows.Forms.CheckBox();
            this.reviewCheckBox = new System.Windows.Forms.CheckBox();
            this.saycidCheckBox = new System.Windows.Forms.CheckBox();
            this.saydurationCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            attachLabel = new System.Windows.Forms.Label();
            attachfmtLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            maxGreetLabel = new System.Windows.Forms.Label();
            maxmessageLabel = new System.Windows.Forms.Label();
            maxmsgLabel = new System.Windows.Forms.Label();
            minmessageLabel = new System.Windows.Forms.Label();
            operatorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceMailSettingBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(195, 16);
            this.descriptionLabel.Text = "General settings for voicemail";
            // 
            // attachLabel
            // 
            attachLabel.AutoSize = true;
            attachLabel.Location = new System.Drawing.Point(32, 69);
            attachLabel.Name = "attachLabel";
            attachLabel.Size = new System.Drawing.Size(173, 12);
            attachLabel.TabIndex = 1;
            attachLabel.Text = "Attach recordings to e-mail:";
            // 
            // attachfmtLabel
            // 
            attachfmtLabel.AutoSize = true;
            attachfmtLabel.Location = new System.Drawing.Point(27, 32);
            attachfmtLabel.Name = "attachfmtLabel";
            attachfmtLabel.Size = new System.Drawing.Size(89, 12);
            attachfmtLabel.TabIndex = 3;
            attachfmtLabel.Text = "Attach Format:";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Location = new System.Drawing.Point(32, 37);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(197, 12);
            extensionLabel.TabIndex = 11;
            extensionLabel.Text = "Extension for checking messages:";
            // 
            // maxGreetLabel
            // 
            maxGreetLabel.AutoSize = true;
            maxGreetLabel.Location = new System.Drawing.Point(32, 101);
            maxGreetLabel.Name = "maxGreetLabel";
            maxGreetLabel.Size = new System.Drawing.Size(143, 12);
            maxGreetLabel.TabIndex = 13;
            maxGreetLabel.Text = "Max greeting (seconds):";
            // 
            // maxmessageLabel
            // 
            maxmessageLabel.AutoSize = true;
            maxmessageLabel.Location = new System.Drawing.Point(9, 62);
            maxmessageLabel.Name = "maxmessageLabel";
            maxmessageLabel.Size = new System.Drawing.Size(107, 12);
            maxmessageLabel.TabIndex = 15;
            maxmessageLabel.Text = "Maximum messages:";
            // 
            // maxmsgLabel
            // 
            maxmsgLabel.AutoSize = true;
            maxmsgLabel.Location = new System.Drawing.Point(9, 92);
            maxmsgLabel.Name = "maxmsgLabel";
            maxmsgLabel.Size = new System.Drawing.Size(107, 12);
            maxmsgLabel.TabIndex = 17;
            maxmsgLabel.Text = "Max message time:";
            // 
            // minmessageLabel
            // 
            minmessageLabel.AutoSize = true;
            minmessageLabel.Location = new System.Drawing.Point(9, 122);
            minmessageLabel.Name = "minmessageLabel";
            minmessageLabel.Size = new System.Drawing.Size(107, 12);
            minmessageLabel.TabIndex = 19;
            minmessageLabel.Text = "Min message time:";
            // 
            // operatorLabel
            // 
            operatorLabel.AutoSize = true;
            operatorLabel.Location = new System.Drawing.Point(32, 133);
            operatorLabel.Name = "operatorLabel";
            operatorLabel.Size = new System.Drawing.Size(137, 12);
            operatorLabel.TabIndex = 21;
            operatorLabel.Text = "Dial \'0\' for Operator:";
            // 
            // attachCheckBox
            // 
            this.attachCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voiceMailSettingBindingSource, "Attach", true));
            this.attachCheckBox.Location = new System.Drawing.Point(266, 66);
            this.attachCheckBox.Name = "attachCheckBox";
            this.attachCheckBox.Size = new System.Drawing.Size(104, 24);
            this.attachCheckBox.TabIndex = 1;
            this.attachCheckBox.UseVisualStyleBackColor = true;
            // 
            // voiceMailSettingBindingSource
            // 
            this.voiceMailSettingBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.VoiceMailSetting);
            // 
            // attachfmtTextBox
            // 
            this.attachfmtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMailSettingBindingSource, "Attachfmt", true));
            this.attachfmtTextBox.Location = new System.Drawing.Point(122, 29);
            this.attachfmtTextBox.Name = "attachfmtTextBox";
            this.attachfmtTextBox.Size = new System.Drawing.Size(104, 21);
            this.attachfmtTextBox.TabIndex = 0;
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voiceMailSettingBindingSource, "Delete", true));
            this.deleteCheckBox.Location = new System.Drawing.Point(6, 21);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(197, 24);
            this.deleteCheckBox.TabIndex = 0;
            this.deleteCheckBox.Text = "Send messages by e-mail only";
            this.deleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // envelopeCheckBox
            // 
            this.envelopeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voiceMailSettingBindingSource, "Envelope", true));
            this.envelopeCheckBox.Location = new System.Drawing.Point(6, 96);
            this.envelopeCheckBox.Name = "envelopeCheckBox";
            this.envelopeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.envelopeCheckBox.TabIndex = 3;
            this.envelopeCheckBox.Text = "Play envelope";
            this.envelopeCheckBox.UseVisualStyleBackColor = true;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMailSettingBindingSource, "Extension", true));
            this.extensionTextBox.Location = new System.Drawing.Point(266, 37);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(203, 21);
            this.extensionTextBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.extensionTextBox, "This option, i.e. \"2345,\" defines the extension that Users call in order to acces" +
                    "s their voicemail accounts.");
            this.extensionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.extensionTextBox_Validating);
            // 
            // maxGreetTextBox
            // 
            this.maxGreetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMailSettingBindingSource, "MaxGreet", true));
            this.maxGreetTextBox.Location = new System.Drawing.Point(266, 98);
            this.maxGreetTextBox.Name = "maxGreetTextBox";
            this.maxGreetTextBox.Size = new System.Drawing.Size(203, 21);
            this.maxGreetTextBox.TabIndex = 2;
            // 
            // maxmessageTextBox
            // 
            this.maxmessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMailSettingBindingSource, "Maxmessage", true));
            this.maxmessageTextBox.Location = new System.Drawing.Point(122, 59);
            this.maxmessageTextBox.Name = "maxmessageTextBox";
            this.maxmessageTextBox.Size = new System.Drawing.Size(104, 21);
            this.maxmessageTextBox.TabIndex = 1;
            // 
            // maxmsgTextBox
            // 
            this.maxmsgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMailSettingBindingSource, "Maxmsg", true));
            this.maxmsgTextBox.Location = new System.Drawing.Point(122, 89);
            this.maxmsgTextBox.Name = "maxmsgTextBox";
            this.maxmsgTextBox.Size = new System.Drawing.Size(104, 21);
            this.maxmsgTextBox.TabIndex = 2;
            // 
            // minmessageTextBox
            // 
            this.minmessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMailSettingBindingSource, "Minmessage", true));
            this.minmessageTextBox.Location = new System.Drawing.Point(122, 119);
            this.minmessageTextBox.Name = "minmessageTextBox";
            this.minmessageTextBox.Size = new System.Drawing.Size(104, 21);
            this.minmessageTextBox.TabIndex = 3;
            // 
            // operatorCheckBox
            // 
            this.operatorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voiceMailSettingBindingSource, "Operator", true));
            this.operatorCheckBox.Location = new System.Drawing.Point(266, 127);
            this.operatorCheckBox.Name = "operatorCheckBox";
            this.operatorCheckBox.Size = new System.Drawing.Size(104, 24);
            this.operatorCheckBox.TabIndex = 3;
            this.operatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // reviewCheckBox
            // 
            this.reviewCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voiceMailSettingBindingSource, "Review", true));
            this.reviewCheckBox.Location = new System.Drawing.Point(6, 121);
            this.reviewCheckBox.Name = "reviewCheckBox";
            this.reviewCheckBox.Size = new System.Drawing.Size(104, 24);
            this.reviewCheckBox.TabIndex = 4;
            this.reviewCheckBox.Text = "Allow users to review";
            this.reviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // saycidCheckBox
            // 
            this.saycidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voiceMailSettingBindingSource, "Saycid", true));
            this.saycidCheckBox.Location = new System.Drawing.Point(6, 46);
            this.saycidCheckBox.Name = "saycidCheckBox";
            this.saycidCheckBox.Size = new System.Drawing.Size(197, 24);
            this.saycidCheckBox.TabIndex = 1;
            this.saycidCheckBox.Text = "Say message Caller-ID";
            this.saycidCheckBox.UseVisualStyleBackColor = true;
            // 
            // saydurationCheckBox
            // 
            this.saydurationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voiceMailSettingBindingSource, "Sayduration", true));
            this.saydurationCheckBox.Location = new System.Drawing.Point(6, 71);
            this.saydurationCheckBox.Name = "saydurationCheckBox";
            this.saydurationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.saydurationCheckBox.TabIndex = 2;
            this.saydurationCheckBox.Text = "Say message duration";
            this.saydurationCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(attachfmtLabel);
            this.groupBox1.Controls.Add(this.attachfmtTextBox);
            this.groupBox1.Controls.Add(maxmessageLabel);
            this.groupBox1.Controls.Add(this.minmessageTextBox);
            this.groupBox1.Controls.Add(minmessageLabel);
            this.groupBox1.Controls.Add(this.maxmsgTextBox);
            this.groupBox1.Controls.Add(maxmsgLabel);
            this.groupBox1.Controls.Add(this.maxmessageTextBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saydurationCheckBox);
            this.groupBox2.Controls.Add(this.saycidCheckBox);
            this.groupBox2.Controls.Add(this.deleteCheckBox);
            this.groupBox2.Controls.Add(this.reviewCheckBox);
            this.groupBox2.Controls.Add(this.envelopeCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(266, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 152);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playback Options";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(233, 332);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(113, 332);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // VoiceMailConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 367);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(operatorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(attachLabel);
            this.Controls.Add(this.attachCheckBox);
            this.Controls.Add(extensionLabel);
            this.Controls.Add(this.operatorCheckBox);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(maxGreetLabel);
            this.Controls.Add(this.maxGreetTextBox);
            this.Name = "VoiceMailConfigPage";
            this.TabText = "VoiceMail";
            this.Text = "VoiceMail";
            this.Controls.SetChildIndex(this.maxGreetTextBox, 0);
            this.Controls.SetChildIndex(maxGreetLabel, 0);
            this.Controls.SetChildIndex(this.extensionTextBox, 0);
            this.Controls.SetChildIndex(this.operatorCheckBox, 0);
            this.Controls.SetChildIndex(extensionLabel, 0);
            this.Controls.SetChildIndex(this.attachCheckBox, 0);
            this.Controls.SetChildIndex(attachLabel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(operatorLabel, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceMailSettingBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource voiceMailSettingBindingSource;
        private System.Windows.Forms.CheckBox attachCheckBox;
        private System.Windows.Forms.TextBox attachfmtTextBox;
        private System.Windows.Forms.CheckBox deleteCheckBox;
        private System.Windows.Forms.CheckBox envelopeCheckBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox maxGreetTextBox;
        private System.Windows.Forms.TextBox maxmessageTextBox;
        private System.Windows.Forms.TextBox maxmsgTextBox;
        private System.Windows.Forms.TextBox minmessageTextBox;
        private System.Windows.Forms.CheckBox operatorCheckBox;
        private System.Windows.Forms.CheckBox reviewCheckBox;
        private System.Windows.Forms.CheckBox saycidCheckBox;
        private System.Windows.Forms.CheckBox saydurationCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}