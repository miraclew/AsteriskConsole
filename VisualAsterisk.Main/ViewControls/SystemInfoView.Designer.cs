namespace VisualAsterisk.Main.ViewControls
{
    partial class SystemInfoView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param Name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemInfoView));
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
            // infoProvider
            // 
            resources.ApplyResources(this.infoProvider, "infoProvider");
            // 
            // errorProvider
            // 
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = null;
            this.tabControl1.AccessibleName = null;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.BackgroundImage = null;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.errorProvider.SetError(this.tabControl1, resources.GetString("tabControl1.Error"));
            this.infoProvider.SetError(this.tabControl1, resources.GetString("tabControl1.Error1"));
            this.tabControl1.Font = null;
            this.errorProvider.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding"))));
            this.errorProvider.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding1"))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.toolTip.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = null;
            this.tabPage1.AccessibleName = null;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackgroundImage = null;
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
            this.infoProvider.SetError(this.tabPage1, resources.GetString("tabPage1.Error"));
            this.errorProvider.SetError(this.tabPage1, resources.GetString("tabPage1.Error1"));
            this.tabPage1.Font = null;
            this.infoProvider.SetIconAlignment(this.tabPage1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage1.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.tabPage1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.tabPage1, ((int)(resources.GetObject("tabPage1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.tabPage1, ((int)(resources.GetObject("tabPage1.IconPadding1"))));
            this.tabPage1.Name = "tabPage1";
            this.toolTip.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AccessibleDescription = null;
            this.hostNameLabel.AccessibleName = null;
            resources.ApplyResources(this.hostNameLabel, "hostNameLabel");
            this.errorProvider.SetError(this.hostNameLabel, resources.GetString("hostNameLabel.Error"));
            this.infoProvider.SetError(this.hostNameLabel, resources.GetString("hostNameLabel.Error1"));
            this.hostNameLabel.Font = null;
            this.infoProvider.SetIconAlignment(this.hostNameLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("hostNameLabel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.hostNameLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("hostNameLabel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.hostNameLabel, ((int)(resources.GetObject("hostNameLabel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.hostNameLabel, ((int)(resources.GetObject("hostNameLabel.IconPadding1"))));
            this.hostNameLabel.Name = "hostNameLabel";
            this.toolTip.SetToolTip(this.hostNameLabel, resources.GetString("hostNameLabel.ToolTip"));
            // 
            // serverDateTimeZoneLabel
            // 
            this.serverDateTimeZoneLabel.AccessibleDescription = null;
            this.serverDateTimeZoneLabel.AccessibleName = null;
            resources.ApplyResources(this.serverDateTimeZoneLabel, "serverDateTimeZoneLabel");
            this.errorProvider.SetError(this.serverDateTimeZoneLabel, resources.GetString("serverDateTimeZoneLabel.Error"));
            this.infoProvider.SetError(this.serverDateTimeZoneLabel, resources.GetString("serverDateTimeZoneLabel.Error1"));
            this.serverDateTimeZoneLabel.Font = null;
            this.infoProvider.SetIconAlignment(this.serverDateTimeZoneLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("serverDateTimeZoneLabel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.serverDateTimeZoneLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("serverDateTimeZoneLabel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.serverDateTimeZoneLabel, ((int)(resources.GetObject("serverDateTimeZoneLabel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.serverDateTimeZoneLabel, ((int)(resources.GetObject("serverDateTimeZoneLabel.IconPadding1"))));
            this.serverDateTimeZoneLabel.Name = "serverDateTimeZoneLabel";
            this.toolTip.SetToolTip(this.serverDateTimeZoneLabel, resources.GetString("serverDateTimeZoneLabel.ToolTip"));
            // 
            // asteriskbuildLabel
            // 
            this.asteriskbuildLabel.AccessibleDescription = null;
            this.asteriskbuildLabel.AccessibleName = null;
            resources.ApplyResources(this.asteriskbuildLabel, "asteriskbuildLabel");
            this.errorProvider.SetError(this.asteriskbuildLabel, resources.GetString("asteriskbuildLabel.Error"));
            this.infoProvider.SetError(this.asteriskbuildLabel, resources.GetString("asteriskbuildLabel.Error1"));
            this.asteriskbuildLabel.Font = null;
            this.infoProvider.SetIconAlignment(this.asteriskbuildLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("asteriskbuildLabel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.asteriskbuildLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("asteriskbuildLabel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.asteriskbuildLabel, ((int)(resources.GetObject("asteriskbuildLabel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.asteriskbuildLabel, ((int)(resources.GetObject("asteriskbuildLabel.IconPadding1"))));
            this.asteriskbuildLabel.Name = "asteriskbuildLabel";
            this.toolTip.SetToolTip(this.asteriskbuildLabel, resources.GetString("asteriskbuildLabel.ToolTip"));
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AccessibleDescription = null;
            this.uptimeLabel.AccessibleName = null;
            resources.ApplyResources(this.uptimeLabel, "uptimeLabel");
            this.errorProvider.SetError(this.uptimeLabel, resources.GetString("uptimeLabel.Error"));
            this.infoProvider.SetError(this.uptimeLabel, resources.GetString("uptimeLabel.Error1"));
            this.uptimeLabel.Font = null;
            this.infoProvider.SetIconAlignment(this.uptimeLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("uptimeLabel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.uptimeLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("uptimeLabel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.uptimeLabel, ((int)(resources.GetObject("uptimeLabel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.uptimeLabel, ((int)(resources.GetObject("uptimeLabel.IconPadding1"))));
            this.uptimeLabel.Name = "uptimeLabel";
            this.toolTip.SetToolTip(this.uptimeLabel, resources.GetString("uptimeLabel.ToolTip"));
            // 
            // osVersionLabel
            // 
            this.osVersionLabel.AccessibleDescription = null;
            this.osVersionLabel.AccessibleName = null;
            resources.ApplyResources(this.osVersionLabel, "osVersionLabel");
            this.errorProvider.SetError(this.osVersionLabel, resources.GetString("osVersionLabel.Error"));
            this.infoProvider.SetError(this.osVersionLabel, resources.GetString("osVersionLabel.Error1"));
            this.osVersionLabel.Font = null;
            this.infoProvider.SetIconAlignment(this.osVersionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("osVersionLabel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.osVersionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("osVersionLabel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.osVersionLabel, ((int)(resources.GetObject("osVersionLabel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.osVersionLabel, ((int)(resources.GetObject("osVersionLabel.IconPadding1"))));
            this.osVersionLabel.Name = "osVersionLabel";
            this.toolTip.SetToolTip(this.osVersionLabel, resources.GetString("osVersionLabel.ToolTip"));
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider.SetError(this.label5, resources.GetString("label5.Error"));
            this.infoProvider.SetError(this.label5, resources.GetString("label5.Error1"));
            this.label5.Font = null;
            this.infoProvider.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.label5.Name = "label5";
            this.toolTip.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider.SetError(this.label4, resources.GetString("label4.Error"));
            this.infoProvider.SetError(this.label4, resources.GetString("label4.Error1"));
            this.label4.Font = null;
            this.infoProvider.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.label4.Name = "label4";
            this.toolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider.SetError(this.label3, resources.GetString("label3.Error"));
            this.infoProvider.SetError(this.label3, resources.GetString("label3.Error1"));
            this.label3.Font = null;
            this.infoProvider.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider.SetError(this.label2, resources.GetString("label2.Error"));
            this.infoProvider.SetError(this.label2, resources.GetString("label2.Error1"));
            this.label2.Font = null;
            this.infoProvider.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.label2.Name = "label2";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.infoProvider.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider.SetError(this.label1, resources.GetString("label1.Error1"));
            this.label1.Font = null;
            this.infoProvider.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleDescription = null;
            this.tabPage2.AccessibleName = null;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackgroundImage = null;
            this.tabPage2.Controls.Add(this.ifConfigTextBox);
            this.infoProvider.SetError(this.tabPage2, resources.GetString("tabPage2.Error"));
            this.errorProvider.SetError(this.tabPage2, resources.GetString("tabPage2.Error1"));
            this.tabPage2.Font = null;
            this.infoProvider.SetIconAlignment(this.tabPage2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage2.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.tabPage2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage2.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.tabPage2, ((int)(resources.GetObject("tabPage2.IconPadding"))));
            this.infoProvider.SetIconPadding(this.tabPage2, ((int)(resources.GetObject("tabPage2.IconPadding1"))));
            this.tabPage2.Name = "tabPage2";
            this.toolTip.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ifConfigTextBox
            // 
            this.ifConfigTextBox.AccessibleDescription = null;
            this.ifConfigTextBox.AccessibleName = null;
            resources.ApplyResources(this.ifConfigTextBox, "ifConfigTextBox");
            this.ifConfigTextBox.BackgroundImage = null;
            this.errorProvider.SetError(this.ifConfigTextBox, resources.GetString("ifConfigTextBox.Error"));
            this.infoProvider.SetError(this.ifConfigTextBox, resources.GetString("ifConfigTextBox.Error1"));
            this.ifConfigTextBox.Font = null;
            this.errorProvider.SetIconAlignment(this.ifConfigTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ifConfigTextBox.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.ifConfigTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ifConfigTextBox.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.ifConfigTextBox, ((int)(resources.GetObject("ifConfigTextBox.IconPadding"))));
            this.infoProvider.SetIconPadding(this.ifConfigTextBox, ((int)(resources.GetObject("ifConfigTextBox.IconPadding1"))));
            this.ifConfigTextBox.Name = "ifConfigTextBox";
            this.ifConfigTextBox.ReadOnly = true;
            this.toolTip.SetToolTip(this.ifConfigTextBox, resources.GetString("ifConfigTextBox.ToolTip"));
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleDescription = null;
            this.tabPage3.AccessibleName = null;
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.BackgroundImage = null;
            this.tabPage3.Controls.Add(this.memoryUsageTextBox);
            this.tabPage3.Controls.Add(this.diskUsageTextBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.infoProvider.SetError(this.tabPage3, resources.GetString("tabPage3.Error"));
            this.errorProvider.SetError(this.tabPage3, resources.GetString("tabPage3.Error1"));
            this.tabPage3.Font = null;
            this.infoProvider.SetIconAlignment(this.tabPage3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage3.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.tabPage3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage3.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.tabPage3, ((int)(resources.GetObject("tabPage3.IconPadding"))));
            this.infoProvider.SetIconPadding(this.tabPage3, ((int)(resources.GetObject("tabPage3.IconPadding1"))));
            this.tabPage3.Name = "tabPage3";
            this.toolTip.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // memoryUsageTextBox
            // 
            this.memoryUsageTextBox.AccessibleDescription = null;
            this.memoryUsageTextBox.AccessibleName = null;
            resources.ApplyResources(this.memoryUsageTextBox, "memoryUsageTextBox");
            this.memoryUsageTextBox.BackgroundImage = null;
            this.errorProvider.SetError(this.memoryUsageTextBox, resources.GetString("memoryUsageTextBox.Error"));
            this.infoProvider.SetError(this.memoryUsageTextBox, resources.GetString("memoryUsageTextBox.Error1"));
            this.memoryUsageTextBox.Font = null;
            this.errorProvider.SetIconAlignment(this.memoryUsageTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("memoryUsageTextBox.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.memoryUsageTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("memoryUsageTextBox.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.memoryUsageTextBox, ((int)(resources.GetObject("memoryUsageTextBox.IconPadding"))));
            this.infoProvider.SetIconPadding(this.memoryUsageTextBox, ((int)(resources.GetObject("memoryUsageTextBox.IconPadding1"))));
            this.memoryUsageTextBox.Name = "memoryUsageTextBox";
            this.memoryUsageTextBox.ReadOnly = true;
            this.toolTip.SetToolTip(this.memoryUsageTextBox, resources.GetString("memoryUsageTextBox.ToolTip"));
            // 
            // diskUsageTextBox
            // 
            this.diskUsageTextBox.AccessibleDescription = null;
            this.diskUsageTextBox.AccessibleName = null;
            resources.ApplyResources(this.diskUsageTextBox, "diskUsageTextBox");
            this.diskUsageTextBox.BackgroundImage = null;
            this.errorProvider.SetError(this.diskUsageTextBox, resources.GetString("diskUsageTextBox.Error"));
            this.infoProvider.SetError(this.diskUsageTextBox, resources.GetString("diskUsageTextBox.Error1"));
            this.diskUsageTextBox.Font = null;
            this.errorProvider.SetIconAlignment(this.diskUsageTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("diskUsageTextBox.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.diskUsageTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("diskUsageTextBox.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.diskUsageTextBox, ((int)(resources.GetObject("diskUsageTextBox.IconPadding"))));
            this.infoProvider.SetIconPadding(this.diskUsageTextBox, ((int)(resources.GetObject("diskUsageTextBox.IconPadding1"))));
            this.diskUsageTextBox.Name = "diskUsageTextBox";
            this.diskUsageTextBox.ReadOnly = true;
            this.toolTip.SetToolTip(this.diskUsageTextBox, resources.GetString("diskUsageTextBox.ToolTip"));
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider.SetError(this.label7, resources.GetString("label7.Error"));
            this.infoProvider.SetError(this.label7, resources.GetString("label7.Error1"));
            this.label7.Font = null;
            this.infoProvider.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding1"))));
            this.label7.Name = "label7";
            this.toolTip.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider.SetError(this.label6, resources.GetString("label6.Error"));
            this.infoProvider.SetError(this.label6, resources.GetString("label6.Error1"));
            this.label6.Font = null;
            this.infoProvider.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding1"))));
            this.label6.Name = "label6";
            this.toolTip.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // SystemInfoView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.tabControl1);
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.gauge_48_shadow;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "SystemInfoView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.Label serverDateTimeZoneLabel;
        private System.Windows.Forms.Label asteriskbuildLabel;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.Label osVersionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ifConfigTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox memoryUsageTextBox;
        private System.Windows.Forms.TextBox diskUsageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
