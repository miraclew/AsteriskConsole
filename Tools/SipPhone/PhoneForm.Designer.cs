namespace SipPhone
{
    partial class PhoneForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneForm));
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.numberPad1 = new IC.Controls.NumberPad();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hangupButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.sipUsersComboBox = new System.Windows.Forms.ComboBox();
            this.sipUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.micMuteButton = new System.Windows.Forms.CheckBox();
            this.muteButton = new System.Windows.Forms.CheckBox();
            this.smoothLabel1 = new IC.Controls.SmoothLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callStatusLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.glassPanel1 = new IC.Controls.GlassPanel();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipUsersBindingSource)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.glassPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.volumeTrackBar.LargeChange = 10000;
            this.volumeTrackBar.Location = new System.Drawing.Point(207, 240);
            this.volumeTrackBar.Maximum = 65535;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(168, 45);
            this.volumeTrackBar.SmallChange = 6553;
            this.volumeTrackBar.TabIndex = 1;
            this.volumeTrackBar.TickFrequency = 6553;
            this.volumeTrackBar.ValueChanged += new System.EventHandler(this.volumeTrackBar_ValueChanged);
            // 
            // numberPad1
            // 
            this.numberPad1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numberPad1.BackColor = System.Drawing.Color.Transparent;
            this.numberPad1.KeyPadding = 3;
            this.numberPad1.Location = new System.Drawing.Point(12, 169);
            this.numberPad1.Name = "numberPad1";
            this.numberPad1.Size = new System.Drawing.Size(182, 181);
            this.numberPad1.TabIndex = 2;
            this.numberPad1.Load += new System.EventHandler(this.numberPad1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SipPhone.Properties.Resources.sipphone_32;
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // hangupButton
            // 
            this.hangupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hangupButton.Image = global::SipPhone.Properties.Resources.phone_hang_up_24;
            this.hangupButton.Location = new System.Drawing.Point(313, 291);
            this.hangupButton.Name = "hangupButton";
            this.hangupButton.Size = new System.Drawing.Size(87, 54);
            this.hangupButton.TabIndex = 4;
            this.hangupButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hangupButton.UseVisualStyleBackColor = true;
            this.hangupButton.Click += new System.EventHandler(this.hangupButton_Click);
            // 
            // callButton
            // 
            this.callButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.callButton.Image = global::SipPhone.Properties.Resources.phone_pick_up_24;
            this.callButton.Location = new System.Drawing.Point(210, 291);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(87, 54);
            this.callButton.TabIndex = 3;
            this.callButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // sipUsersComboBox
            // 
            this.sipUsersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sipUsersComboBox.DataSource = this.sipUsersBindingSource;
            this.sipUsersComboBox.DisplayMember = "UserName";
            this.sipUsersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sipUsersComboBox.FormattingEnabled = true;
            this.sipUsersComboBox.Location = new System.Drawing.Point(203, 185);
            this.sipUsersComboBox.Name = "sipUsersComboBox";
            this.sipUsersComboBox.Size = new System.Drawing.Size(128, 22);
            this.sipUsersComboBox.TabIndex = 5;
            this.sipUsersComboBox.ValueMember = "RegState";
            this.sipUsersComboBox.SelectedIndexChanged += new System.EventHandler(this.sipUsersComboBox_SelectedIndexChanged);
            // 
            // sipUsersBindingSource
            // 
            this.sipUsersBindingSource.DataSource = typeof(Sipek.Common.IAccount);
            this.sipUsersBindingSource.CurrentChanged += new System.EventHandler(this.sipUsersBindingSource_CurrentChanged);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(338, 185);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(76, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(200, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a SIP accout to register:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(200, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Audio Volume:";
            // 
            // micMuteButton
            // 
            this.micMuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.micMuteButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.micMuteButton.AutoSize = true;
            this.micMuteButton.Image = global::SipPhone.Properties.Resources.mix_microphone;
            this.micMuteButton.Location = new System.Drawing.Point(381, 256);
            this.micMuteButton.Name = "micMuteButton";
            this.micMuteButton.Size = new System.Drawing.Size(28, 28);
            this.micMuteButton.TabIndex = 11;
            this.micMuteButton.UseVisualStyleBackColor = true;
            this.micMuteButton.CheckedChanged += new System.EventHandler(this.muteButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.muteButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.muteButton.AutoSize = true;
            this.muteButton.Image = ((System.Drawing.Image)(resources.GetObject("muteButton.Image")));
            this.muteButton.Location = new System.Drawing.Point(381, 228);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(28, 28);
            this.muteButton.TabIndex = 12;
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.CheckedChanged += new System.EventHandler(this.muteButton_Click);
            // 
            // smoothLabel1
            // 
            this.smoothLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smoothLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.smoothLabel1.Font = new System.Drawing.Font("Arial", 18F);
            this.smoothLabel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.smoothLabel1.Image = global::SipPhone.Properties.Resources.sipphone_32;
            this.smoothLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smoothLabel1.Location = new System.Drawing.Point(0, 0);
            this.smoothLabel1.Name = "smoothLabel1";
            this.smoothLabel1.Size = new System.Drawing.Size(419, 34);
            this.smoothLabel1.TabIndex = 15;
            this.smoothLabel1.Text = "Sip Phone for VisualAsterisk";
            this.smoothLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "SIP phone is still running, click the icon to open";
            this.notifyIcon1.BalloonTipTitle = "VisualAsterisk SIP phone";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sip phone for VisualAsterisk";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(109, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.hideToolStripMenuItem.Text = "&Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // callStatusLabel
            // 
            this.callStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.callStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.callStatusLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callStatusLabel.ForeColor = System.Drawing.Color.Tomato;
            this.callStatusLabel.Location = new System.Drawing.Point(273, 73);
            this.callStatusLabel.Name = "callStatusLabel";
            this.callStatusLabel.Size = new System.Drawing.Size(128, 26);
            this.callStatusLabel.TabIndex = 2;
            this.callStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountLabel
            // 
            this.accountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.accountLabel.Location = new System.Drawing.Point(4, 73);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(209, 26);
            this.accountLabel.TabIndex = 5;
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberLabel
            // 
            this.numberLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberLabel.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.Color.PaleGreen;
            this.numberLabel.Location = new System.Drawing.Point(0, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Padding = new System.Windows.Forms.Padding(5);
            this.numberLabel.Size = new System.Drawing.Size(406, 66);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // glassPanel1
            // 
            this.glassPanel1.BackColor = System.Drawing.Color.Transparent;
            this.glassPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.glassPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.glassPanel1.BorderSize = 2;
            this.glassPanel1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.glassPanel1.Controls.Add(this.numberLabel);
            this.glassPanel1.Controls.Add(this.accountLabel);
            this.glassPanel1.Controls.Add(this.callStatusLabel);
            this.glassPanel1.Location = new System.Drawing.Point(8, 38);
            this.glassPanel1.Name = "glassPanel1";
            this.glassPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.glassPanel1.Size = new System.Drawing.Size(406, 103);
            this.glassPanel1.TabIndex = 14;
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SipPhone.Properties.Resources.bg02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.smoothLabel1);
            this.Controls.Add(this.numberPad1);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.hangupButton);
            this.Controls.Add(this.sipUsersComboBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.micMuteButton);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.glassPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhoneForm";
            this.Text = "SIP Phone";
            this.Load += new System.EventHandler(this.PhoneForm_Load);
            this.Resize += new System.EventHandler(this.PhoneForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipUsersBindingSource)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.glassPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar volumeTrackBar;
        private IC.Controls.NumberPad numberPad1;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button hangupButton;
        private System.Windows.Forms.ComboBox sipUsersComboBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource sipUsersBindingSource;
        private System.Windows.Forms.CheckBox micMuteButton;
        private System.Windows.Forms.CheckBox muteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private IC.Controls.SmoothLabel smoothLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label callStatusLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label numberLabel;
        private IC.Controls.GlassPanel glassPanel1;
    }
}

