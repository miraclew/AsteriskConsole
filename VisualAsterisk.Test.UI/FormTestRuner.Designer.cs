namespace VisualAsterisk.Test.UI
{
    partial class FormTestRuner
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup2", System.Windows.Forms.HorizontalAlignment.Left);
            this.testcasesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.runButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.realServerRadioButton = new System.Windows.Forms.RadioButton();
            this.mocServerRadioButton = new System.Windows.Forms.RadioButton();
            this.autoConneectCheckBox = new System.Windows.Forms.CheckBox();
            this.traceTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // testcasesListView
            // 
            this.testcasesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.testcasesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testcasesListView.FullRowSelect = true;
            listViewGroup3.Header = "ListViewGroup1";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "ListViewGroup2";
            listViewGroup4.Name = "listViewGroup2";
            this.testcasesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.testcasesListView.Location = new System.Drawing.Point(200, 0);
            this.testcasesListView.Name = "testcasesListView";
            this.testcasesListView.Size = new System.Drawing.Size(452, 393);
            this.testcasesListView.TabIndex = 0;
            this.testcasesListView.UseCompatibleStateImageBehavior = false;
            this.testcasesListView.View = System.Windows.Forms.View.Details;
            this.testcasesListView.SelectedIndexChanged += new System.EventHandler(this.testcasesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Test Case";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Namespace";
            this.columnHeader3.Width = 245;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.Color.Lime;
            this.runButton.Location = new System.Drawing.Point(23, 170);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(155, 60);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "&Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "UI Test Runer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.realServerRadioButton);
            this.groupBox1.Controls.Add(this.mocServerRadioButton);
            this.groupBox1.Controls.Add(this.autoConneectCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Server:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(121, 49);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "&connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // realServerRadioButton
            // 
            this.realServerRadioButton.AutoSize = true;
            this.realServerRadioButton.Location = new System.Drawing.Point(19, 53);
            this.realServerRadioButton.Name = "realServerRadioButton";
            this.realServerRadioButton.Size = new System.Drawing.Size(89, 16);
            this.realServerRadioButton.TabIndex = 2;
            this.realServerRadioButton.Text = "Real Server";
            this.realServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // mocServerRadioButton
            // 
            this.mocServerRadioButton.AutoSize = true;
            this.mocServerRadioButton.Checked = true;
            this.mocServerRadioButton.Location = new System.Drawing.Point(18, 29);
            this.mocServerRadioButton.Name = "mocServerRadioButton";
            this.mocServerRadioButton.Size = new System.Drawing.Size(89, 16);
            this.mocServerRadioButton.TabIndex = 1;
            this.mocServerRadioButton.TabStop = true;
            this.mocServerRadioButton.Text = "Mock Server";
            this.mocServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoConneectCheckBox
            // 
            this.autoConneectCheckBox.AutoSize = true;
            this.autoConneectCheckBox.Location = new System.Drawing.Point(19, 83);
            this.autoConneectCheckBox.Name = "autoConneectCheckBox";
            this.autoConneectCheckBox.Size = new System.Drawing.Size(96, 16);
            this.autoConneectCheckBox.TabIndex = 4;
            this.autoConneectCheckBox.Text = "Auto Connect";
            this.autoConneectCheckBox.UseVisualStyleBackColor = true;
            this.autoConneectCheckBox.CheckedChanged += new System.EventHandler(this.autoConneectCheckBox_CheckedChanged);
            // 
            // traceTextBox
            // 
            this.traceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.traceTextBox.Location = new System.Drawing.Point(3, 9);
            this.traceTextBox.Multiline = true;
            this.traceTextBox.Name = "traceTextBox";
            this.traceTextBox.Size = new System.Drawing.Size(750, 75);
            this.traceTextBox.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.testcasesListView);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clearButton);
            this.splitContainer1.Panel2.Controls.Add(this.traceTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(878, 494);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 393);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.reloadButton);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(652, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 393);
            this.panel1.TabIndex = 6;
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadButton.Location = new System.Drawing.Point(26, 122);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(780, 39);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 393);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // FormTestRuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "FormTestRuner";
            this.Text = "UI TestRuner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTestRuner_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTestRuner_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView testcasesListView;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.RadioButton realServerRadioButton;
        private System.Windows.Forms.RadioButton mocServerRadioButton;
        private System.Windows.Forms.TextBox traceTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.CheckBox autoConneectCheckBox;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}