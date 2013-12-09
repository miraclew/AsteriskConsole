namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class SystemInfo2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.serverDateTimeZoneLabel = new System.Windows.Forms.Label();
            this.asteriskbuildLabel = new System.Windows.Forms.Label();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.osVersionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ifConfigTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.memoryUsageTextBox = new System.Windows.Forms.TextBox();
            this.diskUsageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(132, 16);
            this.descriptionLabel.Text = "System Information.";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 399);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hostNameLabel);
            this.tabPage1.Controls.Add(this.serverDateTimeZoneLabel);
            this.tabPage1.Controls.Add(this.asteriskbuildLabel);
            this.tabPage1.Controls.Add(this.uptimeLabel);
            this.tabPage1.Controls.Add(this.osVersionLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Location = new System.Drawing.Point(27, 315);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(0, 12);
            this.hostNameLabel.TabIndex = 9;
            // 
            // serverDateTimeZoneLabel
            // 
            this.serverDateTimeZoneLabel.AutoSize = true;
            this.serverDateTimeZoneLabel.Location = new System.Drawing.Point(27, 249);
            this.serverDateTimeZoneLabel.Name = "serverDateTimeZoneLabel";
            this.serverDateTimeZoneLabel.Size = new System.Drawing.Size(0, 12);
            this.serverDateTimeZoneLabel.TabIndex = 8;
            // 
            // asteriskbuildLabel
            // 
            this.asteriskbuildLabel.AutoSize = true;
            this.asteriskbuildLabel.Location = new System.Drawing.Point(27, 183);
            this.asteriskbuildLabel.Name = "asteriskbuildLabel";
            this.asteriskbuildLabel.Size = new System.Drawing.Size(0, 12);
            this.asteriskbuildLabel.TabIndex = 7;
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Location = new System.Drawing.Point(27, 117);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(0, 12);
            this.uptimeLabel.TabIndex = 6;
            // 
            // osVersionLabel
            // 
            this.osVersionLabel.AutoSize = true;
            this.osVersionLabel.Location = new System.Drawing.Point(27, 51);
            this.osVersionLabel.Name = "osVersionLabel";
            this.osVersionLabel.Size = new System.Drawing.Size(0, 12);
            this.osVersionLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hostname: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Server Date/TimeZone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asterisk Build: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uptime: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "OS Version:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ifConfigTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Network";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ifConfigTextBox
            // 
            this.ifConfigTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ifConfigTextBox.Location = new System.Drawing.Point(3, 3);
            this.ifConfigTextBox.Multiline = true;
            this.ifConfigTextBox.Name = "ifConfigTextBox";
            this.ifConfigTextBox.ReadOnly = true;
            this.ifConfigTextBox.Size = new System.Drawing.Size(645, 367);
            this.ifConfigTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.memoryUsageTextBox);
            this.tabPage3.Controls.Add(this.diskUsageTextBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(651, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resource";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // memoryUsageTextBox
            // 
            this.memoryUsageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryUsageTextBox.Location = new System.Drawing.Point(20, 228);
            this.memoryUsageTextBox.Multiline = true;
            this.memoryUsageTextBox.Name = "memoryUsageTextBox";
            this.memoryUsageTextBox.ReadOnly = true;
            this.memoryUsageTextBox.Size = new System.Drawing.Size(613, 124);
            this.memoryUsageTextBox.TabIndex = 3;
            // 
            // diskUsageTextBox
            // 
            this.diskUsageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.diskUsageTextBox.Location = new System.Drawing.Point(20, 47);
            this.diskUsageTextBox.Multiline = true;
            this.diskUsageTextBox.Name = "diskUsageTextBox";
            this.diskUsageTextBox.ReadOnly = true;
            this.diskUsageTextBox.Size = new System.Drawing.Size(613, 132);
            this.diskUsageTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Memory Usage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Disk Usage:";
            // 
            // SystemInfo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "SystemInfo2";
            this.TabText = "System Information";
            this.Text = "System Information";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.Label serverDateTimeZoneLabel;
        private System.Windows.Forms.Label asteriskbuildLabel;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.Label osVersionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ifConfigTextBox;
        private System.Windows.Forms.TextBox memoryUsageTextBox;
        private System.Windows.Forms.TextBox diskUsageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}