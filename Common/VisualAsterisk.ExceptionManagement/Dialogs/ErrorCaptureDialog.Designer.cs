namespace VisualAsterisk.ExceptionManagement.Dialogs
{
    partial class ErrorCaptureDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lnkShowErrorContent = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDontSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkShowErrorContent
            // 
            this.lnkShowErrorContent.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkShowErrorContent.AutoSize = true;
            this.lnkShowErrorContent.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkShowErrorContent.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkShowErrorContent.Location = new System.Drawing.Point(12, 145);
            this.lnkShowErrorContent.Name = "lnkShowErrorContent";
            this.lnkShowErrorContent.Size = new System.Drawing.Size(207, 13);
            this.lnkShowErrorContent.TabIndex = 35;
            this.lnkShowErrorContent.TabStop = true;
            this.lnkShowErrorContent.Text = "What data does this error report contain?";
            this.lnkShowErrorContent.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkShowErrorContent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowErrorContent_LinkClicked_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "We have created an error report that you can send to help us improve our products" +
                ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Please tell us about this problem.";
            // 
            // btnDontSend
            // 
            this.btnDontSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDontSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDontSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDontSend.Location = new System.Drawing.Point(418, 167);
            this.btnDontSend.Name = "btnDontSend";
            this.btnDontSend.Size = new System.Drawing.Size(75, 25);
            this.btnDontSend.TabIndex = 32;
            this.btnDontSend.Text = "Don\'t Send";
            this.btnDontSend.UseVisualStyleBackColor = true;
            this.btnDontSend.Click += new System.EventHandler(this.btnDontSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(241, 167);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(146, 25);
            this.btnSend.TabIndex = 31;
            this.btnSend.Text = "Send Error Report";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(509, 79);
            this.pnlHeader.TabIndex = 30;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(66, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(382, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "{0} has encountered a problem and needs to close.  We are sorry for the inconveni" +
                "ence.";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualAsterisk.ExceptionManagement.Properties.Resources.doctor;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorCaptureDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(509, 205);
            this.Controls.Add(this.lnkShowErrorContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDontSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorCaptureDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkShowErrorContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDontSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}