namespace VisualAsterisk.Main.ViewControls
{
    partial class HardwareView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareView));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zapDevicesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.noDeviceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.zapDevicesListView);
            this.groupBox2.Controls.Add(this.noDeviceLabel);
            this.infoProvider.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorProvider.SetError(this.groupBox2, resources.GetString("groupBox2.Error1"));
            this.groupBox2.Font = null;
            this.errorProvider.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.errorProvider.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding1"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // zapDevicesListView
            // 
            this.zapDevicesListView.AccessibleDescription = null;
            this.zapDevicesListView.AccessibleName = null;
            resources.ApplyResources(this.zapDevicesListView, "zapDevicesListView");
            this.zapDevicesListView.BackgroundImage = null;
            this.zapDevicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.errorProvider.SetError(this.zapDevicesListView, resources.GetString("zapDevicesListView.Error"));
            this.infoProvider.SetError(this.zapDevicesListView, resources.GetString("zapDevicesListView.Error1"));
            this.zapDevicesListView.Font = null;
            this.zapDevicesListView.FullRowSelect = true;
            this.errorProvider.SetIconAlignment(this.zapDevicesListView, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("zapDevicesListView.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.zapDevicesListView, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("zapDevicesListView.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.zapDevicesListView, ((int)(resources.GetObject("zapDevicesListView.IconPadding"))));
            this.infoProvider.SetIconPadding(this.zapDevicesListView, ((int)(resources.GetObject("zapDevicesListView.IconPadding1"))));
            this.zapDevicesListView.Name = "zapDevicesListView";
            this.toolTip.SetToolTip(this.zapDevicesListView, resources.GetString("zapDevicesListView.ToolTip"));
            this.zapDevicesListView.UseCompatibleStateImageBehavior = false;
            this.zapDevicesListView.View = System.Windows.Forms.View.Details;
            this.zapDevicesListView.DoubleClick += new System.EventHandler(this.analogDevicesListView_DoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // noDeviceLabel
            // 
            this.noDeviceLabel.AccessibleDescription = null;
            this.noDeviceLabel.AccessibleName = null;
            resources.ApplyResources(this.noDeviceLabel, "noDeviceLabel");
            this.noDeviceLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.noDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider.SetError(this.noDeviceLabel, resources.GetString("noDeviceLabel.Error"));
            this.infoProvider.SetError(this.noDeviceLabel, resources.GetString("noDeviceLabel.Error1"));
            this.infoProvider.SetIconAlignment(this.noDeviceLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("noDeviceLabel.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.noDeviceLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("noDeviceLabel.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.noDeviceLabel, ((int)(resources.GetObject("noDeviceLabel.IconPadding"))));
            this.infoProvider.SetIconPadding(this.noDeviceLabel, ((int)(resources.GetObject("noDeviceLabel.IconPadding1"))));
            this.noDeviceLabel.Name = "noDeviceLabel";
            this.toolTip.SetToolTip(this.noDeviceLabel, resources.GetString("noDeviceLabel.ToolTip"));
            // 
            // HardwareView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox2);
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.hardware_48;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "HardwareView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label noDeviceLabel;
        private System.Windows.Forms.ListView zapDevicesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}