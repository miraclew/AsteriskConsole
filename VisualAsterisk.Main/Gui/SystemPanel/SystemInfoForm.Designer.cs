namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class SystemInfoForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zedGraphControlCPUMemoryUsageHistory = new ZedGraph.ZedGraphControl();
            this.labelSwapUsage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMemoryUsage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCPUUsage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUptime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCPUInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zedGraphControlHardDrivers = new ZedGraph.ZedGraphControl();
            this.listViewHardDrivers = new System.Windows.Forms.ListView();
            this.chPartitionName = new System.Windows.Forms.ColumnHeader();
            this.chCapacity = new System.Windows.Forms.ColumnHeader();
            this.chUsage = new System.Windows.Forms.ColumnHeader();
            this.chMountPoint = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.zedGraphControlCPUMemoryUsageHistory);
            this.groupBox1.Controls.Add(this.labelSwapUsage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelMemoryUsage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelCPUUsage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelUptime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelCPUInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Resources";
            // 
            // zedGraphControlCPUMemoryUsageHistory
            // 
            this.zedGraphControlCPUMemoryUsageHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlCPUMemoryUsageHistory.Location = new System.Drawing.Point(231, 20);
            this.zedGraphControlCPUMemoryUsageHistory.Name = "zedGraphControlCPUMemoryUsageHistory";
            this.zedGraphControlCPUMemoryUsageHistory.ScrollGrace = 0;
            this.zedGraphControlCPUMemoryUsageHistory.ScrollMaxX = 0;
            this.zedGraphControlCPUMemoryUsageHistory.ScrollMaxY = 0;
            this.zedGraphControlCPUMemoryUsageHistory.ScrollMaxY2 = 0;
            this.zedGraphControlCPUMemoryUsageHistory.ScrollMinX = 0;
            this.zedGraphControlCPUMemoryUsageHistory.ScrollMinY = 0;
            this.zedGraphControlCPUMemoryUsageHistory.ScrollMinY2 = 0;
            this.zedGraphControlCPUMemoryUsageHistory.Size = new System.Drawing.Size(622, 278);
            this.zedGraphControlCPUMemoryUsageHistory.TabIndex = 10;
            // 
            // labelSwapUsage
            // 
            this.labelSwapUsage.AutoSize = true;
            this.labelSwapUsage.Location = new System.Drawing.Point(98, 242);
            this.labelSwapUsage.Name = "labelSwapUsage";
            this.labelSwapUsage.Size = new System.Drawing.Size(41, 12);
            this.labelSwapUsage.TabIndex = 9;
            this.labelSwapUsage.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Swap Usage:";
            // 
            // labelMemoryUsage
            // 
            this.labelMemoryUsage.AutoSize = true;
            this.labelMemoryUsage.Location = new System.Drawing.Point(98, 189);
            this.labelMemoryUsage.Name = "labelMemoryUsage";
            this.labelMemoryUsage.Size = new System.Drawing.Size(41, 12);
            this.labelMemoryUsage.TabIndex = 7;
            this.labelMemoryUsage.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Memory Usage:";
            // 
            // labelCPUUsage
            // 
            this.labelCPUUsage.AutoSize = true;
            this.labelCPUUsage.Location = new System.Drawing.Point(98, 136);
            this.labelCPUUsage.Name = "labelCPUUsage";
            this.labelCPUUsage.Size = new System.Drawing.Size(41, 12);
            this.labelCPUUsage.TabIndex = 5;
            this.labelCPUUsage.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPU Usage:";
            // 
            // labelUptime
            // 
            this.labelUptime.AutoSize = true;
            this.labelUptime.Location = new System.Drawing.Point(98, 83);
            this.labelUptime.Name = "labelUptime";
            this.labelUptime.Size = new System.Drawing.Size(41, 12);
            this.labelUptime.TabIndex = 3;
            this.labelUptime.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uptime:";
            // 
            // labelCPUInfo
            // 
            this.labelCPUInfo.AutoSize = true;
            this.labelCPUInfo.Location = new System.Drawing.Point(98, 30);
            this.labelCPUInfo.Name = "labelCPUInfo";
            this.labelCPUInfo.Size = new System.Drawing.Size(41, 12);
            this.labelCPUInfo.TabIndex = 1;
            this.labelCPUInfo.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Info:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.zedGraphControlHardDrivers);
            this.groupBox2.Controls.Add(this.listViewHardDrivers);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardware Drivers";
            // 
            // zedGraphControlHardDrivers
            // 
            this.zedGraphControlHardDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlHardDrivers.Location = new System.Drawing.Point(506, 20);
            this.zedGraphControlHardDrivers.Name = "zedGraphControlHardDrivers";
            this.zedGraphControlHardDrivers.ScrollGrace = 0;
            this.zedGraphControlHardDrivers.ScrollMaxX = 0;
            this.zedGraphControlHardDrivers.ScrollMaxY = 0;
            this.zedGraphControlHardDrivers.ScrollMaxY2 = 0;
            this.zedGraphControlHardDrivers.ScrollMinX = 0;
            this.zedGraphControlHardDrivers.ScrollMinY = 0;
            this.zedGraphControlHardDrivers.ScrollMinY2 = 0;
            this.zedGraphControlHardDrivers.Size = new System.Drawing.Size(347, 328);
            this.zedGraphControlHardDrivers.TabIndex = 10;
            // 
            // listViewHardDrivers
            // 
            this.listViewHardDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewHardDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPartitionName,
            this.chCapacity,
            this.chUsage,
            this.chMountPoint});
            this.listViewHardDrivers.FullRowSelect = true;
            this.listViewHardDrivers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewHardDrivers.Location = new System.Drawing.Point(11, 20);
            this.listViewHardDrivers.Name = "listViewHardDrivers";
            this.listViewHardDrivers.Size = new System.Drawing.Size(472, 328);
            this.listViewHardDrivers.TabIndex = 11;
            this.listViewHardDrivers.UseCompatibleStateImageBehavior = false;
            this.listViewHardDrivers.View = System.Windows.Forms.View.Details;
            this.listViewHardDrivers.SelectedIndexChanged += new System.EventHandler(this.listViewHardDrivers_SelectedIndexChanged);
            // 
            // chPartitionName
            // 
            this.chPartitionName.Text = "Partition Name";
            this.chPartitionName.Width = 104;
            // 
            // chCapacity
            // 
            this.chCapacity.Text = "Capacity";
            this.chCapacity.Width = 76;
            // 
            // chUsage
            // 
            this.chUsage.Text = "Usage";
            // 
            // chMountPoint
            // 
            this.chMountPoint.Text = "Mount Point";
            this.chMountPoint.Width = 92;
            // 
            // SystemInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 709);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SystemInfoForm";
            this.TabText = "System Information";
            this.Text = "System Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SystemInfoForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemInfoForm_FormClosing);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCPUInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSwapUsage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMemoryUsage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCPUUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUptime;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl zedGraphControlHardDrivers;
        private System.Windows.Forms.ListView listViewHardDrivers;
        private System.Windows.Forms.ColumnHeader chPartitionName;
        private System.Windows.Forms.ColumnHeader chCapacity;
        private System.Windows.Forms.ColumnHeader chUsage;
        private System.Windows.Forms.ColumnHeader chMountPoint;
        private ZedGraph.ZedGraphControl zedGraphControlCPUMemoryUsageHistory;
    }
}