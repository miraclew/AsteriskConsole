namespace VisualAsterisk.Main.Gui.PbxPanel
{
    partial class QueueDetailInfoDlg
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.asteriskQueueEntryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asteriskQueueEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.asteriskQueueMemberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallsTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastCall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asteriskQueueMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueEntryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueMemberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.cancelButton.Location = new System.Drawing.Point(58, 461);
            this.cancelButton.Visible = false;
            // 
            // button1
            // 
            this.okButton.Location = new System.Drawing.Point(266, 456);
            this.okButton.Size = new System.Drawing.Size(216, 32);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.asteriskQueueEntryDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.asteriskQueueMemberDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(782, 446);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "QueueEntries:";
            // 
            // asteriskQueueEntryDataGridView
            // 
            this.asteriskQueueEntryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asteriskQueueEntryDataGridView.AutoGenerateColumns = false;
            this.asteriskQueueEntryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asteriskQueueEntryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.asteriskQueueEntryDataGridView.DataSource = this.asteriskQueueEntryBindingSource;
            this.asteriskQueueEntryDataGridView.Location = new System.Drawing.Point(14, 27);
            this.asteriskQueueEntryDataGridView.Name = "asteriskQueueEntryDataGridView";
            this.asteriskQueueEntryDataGridView.RowTemplate.Height = 23;
            this.asteriskQueueEntryDataGridView.Size = new System.Drawing.Size(747, 160);
            this.asteriskQueueEntryDataGridView.TabIndex = 0;
            this.asteriskQueueEntryDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.asteriskQueueEntryDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Channel";
            this.dataGridViewTextBoxColumn7.HeaderText = "Channel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateJoined";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateJoined";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateLeft";
            this.dataGridViewTextBoxColumn9.HeaderText = "DateLeft";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn10.HeaderText = "State";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ReportedPosition";
            this.dataGridViewTextBoxColumn11.HeaderText = "ReportedPosition";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn12.HeaderText = "Position";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // asteriskQueueEntryBindingSource
            // 
            this.asteriskQueueEntryBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.AsteriskQueueEntry);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "QueueMembers:";
            // 
            // asteriskQueueMemberDataGridView
            // 
            this.asteriskQueueMemberDataGridView.AllowUserToAddRows = false;
            this.asteriskQueueMemberDataGridView.AllowUserToDeleteRows = false;
            this.asteriskQueueMemberDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asteriskQueueMemberDataGridView.AutoGenerateColumns = false;
            this.asteriskQueueMemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asteriskQueueMemberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.CallsTaken,
            this.LastCall,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.asteriskQueueMemberDataGridView.DataSource = this.asteriskQueueMemberBindingSource;
            this.asteriskQueueMemberDataGridView.Location = new System.Drawing.Point(14, 34);
            this.asteriskQueueMemberDataGridView.Name = "asteriskQueueMemberDataGridView";
            this.asteriskQueueMemberDataGridView.ReadOnly = true;
            this.asteriskQueueMemberDataGridView.RowTemplate.Height = 23;
            this.asteriskQueueMemberDataGridView.Size = new System.Drawing.Size(747, 189);
            this.asteriskQueueMemberDataGridView.TabIndex = 0;
            this.asteriskQueueMemberDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.asteriskQueueMemberDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // CallsTaken
            // 
            this.CallsTaken.DataPropertyName = "CallsTaken";
            this.CallsTaken.HeaderText = "CallsTaken";
            this.CallsTaken.Name = "CallsTaken";
            this.CallsTaken.ReadOnly = true;
            // 
            // LastCall
            // 
            this.LastCall.DataPropertyName = "LastCall";
            this.LastCall.HeaderText = "LastCall";
            this.LastCall.Name = "LastCall";
            this.LastCall.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn2.HeaderText = "State";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Penalty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Penalty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Paused";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Paused";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Membership";
            this.dataGridViewTextBoxColumn5.HeaderText = "Membership";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // asteriskQueueMemberBindingSource
            // 
            this.asteriskQueueMemberBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.AsteriskQueueMember);
            // 
            // QueueDetailInfoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 496);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QueueDetailInfoDlg";
            this.Text = "Queue Details";
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueEntryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueMemberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteriskQueueMemberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource asteriskQueueMemberBindingSource;
        private System.Windows.Forms.DataGridView asteriskQueueMemberDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView asteriskQueueEntryDataGridView;
        private System.Windows.Forms.BindingSource asteriskQueueEntryBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallsTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCall;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}