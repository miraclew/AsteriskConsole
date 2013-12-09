namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class ZapDeviceInfo
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label alarmsLabel;
            System.Windows.Forms.Label basechanLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label devicetypeLabel;
            System.Windows.Forms.Label irqLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label totchansLabel;
            System.Windows.Forms.Label typeLabel;
            this.zapDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeLabel1 = new System.Windows.Forms.Label();
            this.alarmsTextBox = new System.Windows.Forms.TextBox();
            this.basechanTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.devicetypeTextBox = new System.Windows.Forms.TextBox();
            this.irqTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.totchansTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.portsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            activeLabel = new System.Windows.Forms.Label();
            alarmsLabel = new System.Windows.Forms.Label();
            basechanLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            devicetypeLabel = new System.Windows.Forms.Label();
            irqLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            totchansLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zapDeviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(250, 339);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(101, 339);
            // 
            // zapDeviceBindingSource
            // 
            this.zapDeviceBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.ZapDevice);
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(12, 73);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(47, 12);
            activeLabel.TabIndex = 6;
            activeLabel.Text = "Active:";
            // 
            // activeLabel1
            // 
            this.activeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Active", true));
            this.activeLabel1.Location = new System.Drawing.Point(101, 73);
            this.activeLabel1.Name = "activeLabel1";
            this.activeLabel1.Size = new System.Drawing.Size(100, 23);
            this.activeLabel1.TabIndex = 7;
            this.activeLabel1.Text = "label1";
            // 
            // alarmsLabel
            // 
            alarmsLabel.AutoSize = true;
            alarmsLabel.Location = new System.Drawing.Point(12, 102);
            alarmsLabel.Name = "alarmsLabel";
            alarmsLabel.Size = new System.Drawing.Size(47, 12);
            alarmsLabel.TabIndex = 8;
            alarmsLabel.Text = "Alarms:";
            // 
            // alarmsTextBox
            // 
            this.alarmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Alarms", true));
            this.alarmsTextBox.Location = new System.Drawing.Point(101, 99);
            this.alarmsTextBox.Name = "alarmsTextBox";
            this.alarmsTextBox.Size = new System.Drawing.Size(100, 21);
            this.alarmsTextBox.TabIndex = 9;
            // 
            // basechanLabel
            // 
            basechanLabel.AutoSize = true;
            basechanLabel.Location = new System.Drawing.Point(12, 129);
            basechanLabel.Name = "basechanLabel";
            basechanLabel.Size = new System.Drawing.Size(59, 12);
            basechanLabel.TabIndex = 10;
            basechanLabel.Text = "Basechan:";
            // 
            // basechanTextBox
            // 
            this.basechanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Basechan", true));
            this.basechanTextBox.Location = new System.Drawing.Point(101, 126);
            this.basechanTextBox.Name = "basechanTextBox";
            this.basechanTextBox.Size = new System.Drawing.Size(100, 21);
            this.basechanTextBox.TabIndex = 11;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 156);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(77, 12);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(101, 153);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 21);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // devicetypeLabel
            // 
            devicetypeLabel.AutoSize = true;
            devicetypeLabel.Location = new System.Drawing.Point(12, 183);
            devicetypeLabel.Name = "devicetypeLabel";
            devicetypeLabel.Size = new System.Drawing.Size(71, 12);
            devicetypeLabel.TabIndex = 14;
            devicetypeLabel.Text = "Devicetype:";
            // 
            // devicetypeTextBox
            // 
            this.devicetypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Devicetype", true));
            this.devicetypeTextBox.Location = new System.Drawing.Point(101, 180);
            this.devicetypeTextBox.Name = "devicetypeTextBox";
            this.devicetypeTextBox.Size = new System.Drawing.Size(100, 21);
            this.devicetypeTextBox.TabIndex = 15;
            // 
            // irqLabel
            // 
            irqLabel.AutoSize = true;
            irqLabel.Location = new System.Drawing.Point(12, 210);
            irqLabel.Name = "irqLabel";
            irqLabel.Size = new System.Drawing.Size(29, 12);
            irqLabel.TabIndex = 16;
            irqLabel.Text = "Irq:";
            // 
            // irqTextBox
            // 
            this.irqTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Irq", true));
            this.irqTextBox.Location = new System.Drawing.Point(101, 207);
            this.irqTextBox.Name = "irqTextBox";
            this.irqTextBox.Size = new System.Drawing.Size(100, 21);
            this.irqTextBox.TabIndex = 17;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(12, 49);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(59, 12);
            locationLabel.TabIndex = 18;
            locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(103, 46);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 21);
            this.locationTextBox.TabIndex = 19;
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(12, 236);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(83, 12);
            manufacturerLabel.TabIndex = 20;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(101, 233);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 21);
            this.manufacturerTextBox.TabIndex = 21;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 12);
            nameLabel.TabIndex = 22;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(101, 11);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 23;
            // 
            // totchansLabel
            // 
            totchansLabel.AutoSize = true;
            totchansLabel.Location = new System.Drawing.Point(12, 263);
            totchansLabel.Name = "totchansLabel";
            totchansLabel.Size = new System.Drawing.Size(59, 12);
            totchansLabel.TabIndex = 24;
            totchansLabel.Text = "Totchans:";
            // 
            // totchansTextBox
            // 
            this.totchansTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Totchans", true));
            this.totchansTextBox.Location = new System.Drawing.Point(101, 260);
            this.totchansTextBox.Name = "totchansTextBox";
            this.totchansTextBox.Size = new System.Drawing.Size(100, 21);
            this.totchansTextBox.TabIndex = 25;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(12, 295);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(35, 12);
            typeLabel.TabIndex = 26;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapDeviceBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(103, 292);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 21);
            this.typeTextBox.TabIndex = 27;
            // 
            // portsListView
            // 
            this.portsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.portsListView.Location = new System.Drawing.Point(223, 11);
            this.portsListView.Name = "portsListView";
            this.portsListView.Size = new System.Drawing.Size(178, 302);
            this.portsListView.TabIndex = 28;
            this.portsListView.UseCompatibleStateImageBehavior = false;
            this.portsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Port";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 78;
            // 
            // ZapDeviceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(415, 377);
            this.Controls.Add(this.portsListView);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeLabel1);
            this.Controls.Add(alarmsLabel);
            this.Controls.Add(this.alarmsTextBox);
            this.Controls.Add(basechanLabel);
            this.Controls.Add(this.basechanTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(devicetypeLabel);
            this.Controls.Add(this.devicetypeTextBox);
            this.Controls.Add(irqLabel);
            this.Controls.Add(this.irqTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(manufacturerLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(totchansLabel);
            this.Controls.Add(this.totchansTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Name = "ZapDeviceInfo";
            this.Text = "Device Information";
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.typeTextBox, 0);
            this.Controls.SetChildIndex(typeLabel, 0);
            this.Controls.SetChildIndex(this.totchansTextBox, 0);
            this.Controls.SetChildIndex(totchansLabel, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(nameLabel, 0);
            this.Controls.SetChildIndex(this.manufacturerTextBox, 0);
            this.Controls.SetChildIndex(manufacturerLabel, 0);
            this.Controls.SetChildIndex(this.locationTextBox, 0);
            this.Controls.SetChildIndex(locationLabel, 0);
            this.Controls.SetChildIndex(this.irqTextBox, 0);
            this.Controls.SetChildIndex(irqLabel, 0);
            this.Controls.SetChildIndex(this.devicetypeTextBox, 0);
            this.Controls.SetChildIndex(devicetypeLabel, 0);
            this.Controls.SetChildIndex(this.descriptionTextBox, 0);
            this.Controls.SetChildIndex(descriptionLabel, 0);
            this.Controls.SetChildIndex(this.basechanTextBox, 0);
            this.Controls.SetChildIndex(basechanLabel, 0);
            this.Controls.SetChildIndex(this.alarmsTextBox, 0);
            this.Controls.SetChildIndex(alarmsLabel, 0);
            this.Controls.SetChildIndex(this.activeLabel1, 0);
            this.Controls.SetChildIndex(activeLabel, 0);
            this.Controls.SetChildIndex(this.portsListView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.zapDeviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource zapDeviceBindingSource;
        private System.Windows.Forms.Label activeLabel1;
        private System.Windows.Forms.TextBox alarmsTextBox;
        private System.Windows.Forms.TextBox basechanTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox devicetypeTextBox;
        private System.Windows.Forms.TextBox irqTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox totchansTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.ListView portsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
