namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class Hardware
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
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(277, 16);
            this.descriptionLabel.Text = "Configure/setup your T1/E1/Analog Cards.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.zapDevicesListView);
            this.groupBox2.Controls.Add(this.noDeviceLabel);
            this.groupBox2.Location = new System.Drawing.Point(8, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 444);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardware Detected";
            // 
            // zapDevicesListView
            // 
            this.zapDevicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.zapDevicesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zapDevicesListView.FullRowSelect = true;
            this.zapDevicesListView.Location = new System.Drawing.Point(3, 17);
            this.zapDevicesListView.Name = "zapDevicesListView";
            this.zapDevicesListView.Size = new System.Drawing.Size(590, 424);
            this.zapDevicesListView.TabIndex = 3;
            this.zapDevicesListView.UseCompatibleStateImageBehavior = false;
            this.zapDevicesListView.View = System.Windows.Forms.View.Details;
            this.zapDevicesListView.DoubleClick += new System.EventHandler(this.analogDevicesListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total channels";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "State";
            // 
            // noDeviceLabel
            // 
            this.noDeviceLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.noDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noDeviceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noDeviceLabel.Font = new System.Drawing.Font("ËÎÌו", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noDeviceLabel.Location = new System.Drawing.Point(3, 17);
            this.noDeviceLabel.Name = "noDeviceLabel";
            this.noDeviceLabel.Size = new System.Drawing.Size(590, 424);
            this.noDeviceLabel.TabIndex = 2;
            this.noDeviceLabel.Text = "No Analog Hardware detected!!";
            this.noDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 477);
            this.Controls.Add(this.groupBox2);
            this.Name = "Hardware";
            this.TabText = "Hardware";
            this.Text = "Hardware";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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