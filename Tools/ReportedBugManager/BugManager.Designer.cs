namespace ReportedBugManager
{
    partial class BugManager
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.synchronizeButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.bugStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 396);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bug ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Application";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Occur Time";
            this.columnHeader3.Width = 77;
            // 
            // synchronizeButton
            // 
            this.synchronizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.synchronizeButton.Location = new System.Drawing.Point(541, 219);
            this.synchronizeButton.Name = "synchronizeButton";
            this.synchronizeButton.Size = new System.Drawing.Size(134, 52);
            this.synchronizeButton.TabIndex = 1;
            this.synchronizeButton.Text = "Synchronize";
            this.synchronizeButton.UseVisualStyleBackColor = true;
            this.synchronizeButton.Click += new System.EventHandler(this.synchronizeButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewButton.Location = new System.Drawing.Point(541, 299);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(134, 52);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "&View bug file";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // bugStatusComboBox
            // 
            this.bugStatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bugStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bugStatusComboBox.FormattingEnabled = true;
            this.bugStatusComboBox.Location = new System.Drawing.Point(520, 71);
            this.bugStatusComboBox.Name = "bugStatusComboBox";
            this.bugStatusComboBox.Size = new System.Drawing.Size(155, 20);
            this.bugStatusComboBox.TabIndex = 3;
            this.bugStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.bugStatusComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change status";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Version";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "State";
            // 
            // BugManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bugStatusComboBox);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.synchronizeButton);
            this.Controls.Add(this.listView1);
            this.Name = "BugManager";
            this.Text = "Bugs Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BugManager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button synchronizeButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox bugStatusComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

