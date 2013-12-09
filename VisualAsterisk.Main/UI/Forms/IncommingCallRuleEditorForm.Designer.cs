namespace VisualAsterisk.Main.UI.Forms
{
    partial class IncommingCallRuleEditorForm
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
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.provideLabel = new System.Windows.Forms.Label();
            this.routeLabel = new System.Windows.Forms.Label();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.routeComboBox = new System.Windows.Forms.ComboBox();
            this.contentPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(323, 42);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.extensionComboBox);
            this.contentPanel.Controls.Add(this.extensionLabel);
            this.contentPanel.Controls.Add(this.provideLabel);
            this.contentPanel.Controls.Add(this.routeLabel);
            this.contentPanel.Controls.Add(this.providerComboBox);
            this.contentPanel.Controls.Add(this.routeComboBox);
            this.contentPanel.Size = new System.Drawing.Size(323, 200);
            // 
            // buttomPanel
            // 
            this.buttomPanel.Location = new System.Drawing.Point(0, 193);
            this.buttomPanel.Size = new System.Drawing.Size(323, 49);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(227, 14);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(114, 14);
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Location = new System.Drawing.Point(130, 104);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(121, 21);
            this.extensionComboBox.TabIndex = 15;
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(41, 104);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(67, 13);
            this.extensionLabel.TabIndex = 17;
            this.extensionLabel.Text = "to extension";
            // 
            // provideLabel
            // 
            this.provideLabel.AutoSize = true;
            this.provideLabel.Location = new System.Drawing.Point(41, 63);
            this.provideLabel.Name = "provideLabel";
            this.provideLabel.Size = new System.Drawing.Size(72, 13);
            this.provideLabel.TabIndex = 16;
            this.provideLabel.Text = "from provider";
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Location = new System.Drawing.Point(41, 28);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(36, 13);
            this.routeLabel.TabIndex = 14;
            this.routeLabel.Text = "Route";
            // 
            // providerComboBox
            // 
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(130, 63);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(121, 21);
            this.providerComboBox.TabIndex = 13;
            // 
            // routeComboBox
            // 
            this.routeComboBox.FormattingEnabled = true;
            this.routeComboBox.Location = new System.Drawing.Point(130, 28);
            this.routeComboBox.Name = "routeComboBox";
            this.routeComboBox.Size = new System.Drawing.Size(121, 21);
            this.routeComboBox.TabIndex = 12;
            // 
            // IncommingCallRuleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 242);
            this.Name = "IncommingCallRuleEditorForm";
            this.Text = "IncommingCallRuleEditorForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.buttomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Label provideLabel;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.ComboBox routeComboBox;
    }
}