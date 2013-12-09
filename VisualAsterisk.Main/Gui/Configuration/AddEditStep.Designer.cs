namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class AddEditStep
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
            this.comboBoxStep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArg = new System.Windows.Forms.ComboBox();
            this.textBoxArg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(219, 80);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(78, 80);
            // 
            // comboBoxStep
            // 
            this.comboBoxStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStep.FormattingEnabled = true;
            this.comboBoxStep.Location = new System.Drawing.Point(0, 0);
            this.comboBoxStep.Name = "comboBoxStep";
            this.comboBoxStep.Size = new System.Drawing.Size(171, 20);
            this.comboBoxStep.TabIndex = 0;
            this.comboBoxStep.SelectedIndexChanged += new System.EventHandler(this.comboBoxStep_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new Step:";
            // 
            // comboBoxArg
            // 
            this.comboBoxArg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxArg.FormattingEnabled = true;
            this.comboBoxArg.Location = new System.Drawing.Point(0, 0);
            this.comboBoxArg.Name = "comboBoxArg";
            this.comboBoxArg.Size = new System.Drawing.Size(187, 20);
            this.comboBoxArg.TabIndex = 2;
            // 
            // textBoxArg
            // 
            this.textBoxArg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxArg.Location = new System.Drawing.Point(0, 0);
            this.textBoxArg.Name = "textBoxArg";
            this.textBoxArg.Size = new System.Drawing.Size(187, 21);
            this.textBoxArg.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxArg);
            this.panel1.Controls.Add(this.textBoxArg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 27);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxStep);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(14, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 27);
            this.panel2.TabIndex = 28;
            // 
            // AddEditStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 115);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditStep";
            this.Text = "AddEditStep";
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArg;
        private System.Windows.Forms.TextBox textBoxArg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}