namespace VisualAsterisk.Main.Gui.SystemPanel
{
    partial class RecordVoiceMenu
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
            this.recordedVoiceListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.playButton = new System.Windows.Forms.Button();
            this.recordAgainButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.recordNewButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(351, 16);
            this.descriptionLabel.Text = "Allows you to record custom voicemenus over a phone";
            // 
            // recordedVoiceListView
            // 
            this.recordedVoiceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordedVoiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.recordedVoiceListView.Location = new System.Drawing.Point(15, 20);
            this.recordedVoiceListView.Name = "recordedVoiceListView";
            this.recordedVoiceListView.Size = new System.Drawing.Size(373, 264);
            this.recordedVoiceListView.TabIndex = 1;
            this.recordedVoiceListView.UseCompatibleStateImageBehavior = false;
            this.recordedVoiceListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Recorded File";
            this.columnHeader1.Width = 291;
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(403, 88);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(105, 31);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "&Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // recordAgainButton
            // 
            this.recordAgainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recordAgainButton.Location = new System.Drawing.Point(403, 144);
            this.recordAgainButton.Name = "recordAgainButton";
            this.recordAgainButton.Size = new System.Drawing.Size(105, 31);
            this.recordAgainButton.TabIndex = 3;
            this.recordAgainButton.Text = "&Record Again";
            this.recordAgainButton.UseVisualStyleBackColor = true;
            this.recordAgainButton.Click += new System.EventHandler(this.recordAgainButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(403, 200);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 31);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // recordNewButton
            // 
            this.recordNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordNewButton.Location = new System.Drawing.Point(104, 347);
            this.recordNewButton.Name = "recordNewButton";
            this.recordNewButton.Size = new System.Drawing.Size(344, 34);
            this.recordNewButton.TabIndex = 5;
            this.recordNewButton.Text = "Record a &new VoiceMenu";
            this.recordNewButton.UseVisualStyleBackColor = true;
            this.recordNewButton.Click += new System.EventHandler(this.recordNewButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.recordedVoiceListView);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.recordAgainButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 290);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Recorded VoiceMenus";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(403, 32);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(105, 31);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Re&fresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RecordVoiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recordNewButton);
            this.Name = "RecordVoiceMenu";
            this.TabText = "RecordVoiceMenu";
            this.Text = "RecordVoiceMenu";
            this.Controls.SetChildIndex(this.recordNewButton, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView recordedVoiceListView;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button recordAgainButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button recordNewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button refreshButton;
    }
}