namespace VisualAsterisk.Main.ViewControls
{
    partial class ManagerCLIView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerCLIView));
            this.cmdInputTextBox = new System.Windows.Forms.TextBox();
            this.cliShellTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            // cmdInputTextBox
            // 
            this.cmdInputTextBox.AcceptsReturn = true;
            this.cmdInputTextBox.AcceptsTab = true;
            this.cmdInputTextBox.AccessibleDescription = null;
            this.cmdInputTextBox.AccessibleName = null;
            resources.ApplyResources(this.cmdInputTextBox, "cmdInputTextBox");
            this.cmdInputTextBox.BackgroundImage = null;
            this.errorProvider.SetError(this.cmdInputTextBox, resources.GetString("cmdInputTextBox.Error"));
            this.infoProvider.SetError(this.cmdInputTextBox, resources.GetString("cmdInputTextBox.Error1"));
            this.cmdInputTextBox.Font = null;
            this.errorProvider.SetIconAlignment(this.cmdInputTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmdInputTextBox.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.cmdInputTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmdInputTextBox.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.cmdInputTextBox, ((int)(resources.GetObject("cmdInputTextBox.IconPadding"))));
            this.infoProvider.SetIconPadding(this.cmdInputTextBox, ((int)(resources.GetObject("cmdInputTextBox.IconPadding1"))));
            this.cmdInputTextBox.Name = "cmdInputTextBox";
            this.toolTip.SetToolTip(this.cmdInputTextBox, resources.GetString("cmdInputTextBox.ToolTip"));
            this.cmdInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdInputTextBox_KeyPress);
            // 
            // cliShellTextBox
            // 
            this.cliShellTextBox.AccessibleDescription = null;
            this.cliShellTextBox.AccessibleName = null;
            resources.ApplyResources(this.cliShellTextBox, "cliShellTextBox");
            this.cliShellTextBox.BackgroundImage = null;
            this.errorProvider.SetError(this.cliShellTextBox, resources.GetString("cliShellTextBox.Error"));
            this.infoProvider.SetError(this.cliShellTextBox, resources.GetString("cliShellTextBox.Error1"));
            this.cliShellTextBox.Font = null;
            this.errorProvider.SetIconAlignment(this.cliShellTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cliShellTextBox.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.cliShellTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cliShellTextBox.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.cliShellTextBox, ((int)(resources.GetObject("cliShellTextBox.IconPadding"))));
            this.infoProvider.SetIconPadding(this.cliShellTextBox, ((int)(resources.GetObject("cliShellTextBox.IconPadding1"))));
            this.cliShellTextBox.Name = "cliShellTextBox";
            this.cliShellTextBox.ReadOnly = true;
            this.toolTip.SetToolTip(this.cliShellTextBox, resources.GetString("cliShellTextBox.ToolTip"));
            // 
            // sendButton
            // 
            this.sendButton.AccessibleDescription = null;
            this.sendButton.AccessibleName = null;
            resources.ApplyResources(this.sendButton, "sendButton");
            this.sendButton.BackgroundImage = null;
            this.infoProvider.SetError(this.sendButton, resources.GetString("sendButton.Error"));
            this.errorProvider.SetError(this.sendButton, resources.GetString("sendButton.Error1"));
            this.sendButton.Font = null;
            this.errorProvider.SetIconAlignment(this.sendButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("sendButton.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.sendButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("sendButton.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.sendButton, ((int)(resources.GetObject("sendButton.IconPadding"))));
            this.infoProvider.SetIconPadding(this.sendButton, ((int)(resources.GetObject("sendButton.IconPadding1"))));
            this.sendButton.Name = "sendButton";
            this.toolTip.SetToolTip(this.sendButton, resources.GetString("sendButton.ToolTip"));
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearTextButton
            // 
            this.clearTextButton.AccessibleDescription = null;
            this.clearTextButton.AccessibleName = null;
            resources.ApplyResources(this.clearTextButton, "clearTextButton");
            this.clearTextButton.BackgroundImage = null;
            this.infoProvider.SetError(this.clearTextButton, resources.GetString("clearTextButton.Error"));
            this.errorProvider.SetError(this.clearTextButton, resources.GetString("clearTextButton.Error1"));
            this.clearTextButton.Font = null;
            this.errorProvider.SetIconAlignment(this.clearTextButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("clearTextButton.IconAlignment"))));
            this.infoProvider.SetIconAlignment(this.clearTextButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("clearTextButton.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.clearTextButton, ((int)(resources.GetObject("clearTextButton.IconPadding"))));
            this.infoProvider.SetIconPadding(this.clearTextButton, ((int)(resources.GetObject("clearTextButton.IconPadding1"))));
            this.clearTextButton.Name = "clearTextButton";
            this.toolTip.SetToolTip(this.clearTextButton, resources.GetString("clearTextButton.ToolTip"));
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider.SetError(this.label1, resources.GetString("label1.Error"));
            this.infoProvider.SetError(this.label1, resources.GetString("label1.Error1"));
            this.label1.Font = null;
            this.infoProvider.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // ManagerCLIView
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cliShellTextBox);
            this.Controls.Add(this.cmdInputTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.clearTextButton);
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.cli_48;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "ManagerCLIView";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmdInputTextBox;
        private System.Windows.Forms.TextBox cliShellTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.Label label1;
    }
}