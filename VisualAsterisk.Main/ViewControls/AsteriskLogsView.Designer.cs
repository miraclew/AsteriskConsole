namespace VisualAsterisk.Main.ViewControls
{
    partial class AsteriskLogsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsteriskLogsView));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.logMessagesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // dateTimePicker
            // 
            this.dateTimePicker.AccessibleDescription = null;
            this.dateTimePicker.AccessibleName = null;
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.BackgroundImage = null;
            this.dateTimePicker.CalendarFont = null;
            this.dateTimePicker.CustomFormat = null;
            this.infoProvider.SetError(this.dateTimePicker, resources.GetString("dateTimePicker.Error"));
            this.errorProvider.SetError(this.dateTimePicker, resources.GetString("dateTimePicker.Error1"));
            this.dateTimePicker.Font = null;
            this.infoProvider.SetIconAlignment(this.dateTimePicker, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.dateTimePicker, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.dateTimePicker, ((int)(resources.GetObject("dateTimePicker.IconPadding"))));
            this.infoProvider.SetIconPadding(this.dateTimePicker, ((int)(resources.GetObject("dateTimePicker.IconPadding1"))));
            this.dateTimePicker.Name = "dateTimePicker";
            this.toolTip.SetToolTip(this.dateTimePicker, resources.GetString("dateTimePicker.ToolTip"));
            // 
            // logMessagesTextBox
            // 
            this.logMessagesTextBox.AccessibleDescription = null;
            this.logMessagesTextBox.AccessibleName = null;
            resources.ApplyResources(this.logMessagesTextBox, "logMessagesTextBox");
            this.logMessagesTextBox.BackgroundImage = null;
            this.errorProvider.SetError(this.logMessagesTextBox, resources.GetString("logMessagesTextBox.Error"));
            this.infoProvider.SetError(this.logMessagesTextBox, resources.GetString("logMessagesTextBox.Error1"));
            this.logMessagesTextBox.Font = null;
            this.errorProvider.SetIconAlignment(this.logMessagesTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("logMessagesTextBox.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.logMessagesTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("logMessagesTextBox.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.logMessagesTextBox, ((int)(resources.GetObject("logMessagesTextBox.IconPadding"))));
            this.infoProvider.SetIconPadding(this.logMessagesTextBox, ((int)(resources.GetObject("logMessagesTextBox.IconPadding1"))));
            this.logMessagesTextBox.Name = "logMessagesTextBox";
            this.logMessagesTextBox.ReadOnly = true;
            this.toolTip.SetToolTip(this.logMessagesTextBox, resources.GetString("logMessagesTextBox.ToolTip"));
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.infoProvider.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errorProvider.SetError(this.groupBox1, resources.GetString("groupBox1.Error1"));
            this.groupBox1.Font = null;
            this.errorProvider.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment1"))));
            this.infoProvider.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.errorProvider.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding1"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // button1
            // 
            this.button1.AccessibleDescription = null;
            this.button1.AccessibleName = null;
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = null;
            this.infoProvider.SetError(this.button1, resources.GetString("button1.Error"));
            this.errorProvider.SetError(this.button1, resources.GetString("button1.Error1"));
            this.button1.Font = null;
            this.errorProvider.SetIconAlignment(this.button1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button1.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.button1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.button1, ((int)(resources.GetObject("button1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.button1, ((int)(resources.GetObject("button1.IconPadding1"))));
            this.button1.Name = "button1";
            this.toolTip.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AsteriskLogsView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.logMessagesTextBox);
            this.Controls.Add(this.groupBox1);
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.logfile_48;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "AsteriskLogsView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox logMessagesTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}