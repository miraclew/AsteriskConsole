namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class ConferencingConfigPage
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
            System.Windows.Forms.Label adminPinLabel;
            System.Windows.Forms.Label pinLabel;
            System.Windows.Forms.Label roomNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferencingConfigPage));
            this.conferenceRoomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.conferenceRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.conferenceRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPinTextBox = new System.Windows.Forms.TextBox();
            this.announcecallersCheckBox = new System.Windows.Forms.CheckBox();
            this.enablecallermenuCheckBox = new System.Windows.Forms.CheckBox();
            this.musicforfirstuserCheckBox = new System.Windows.Forms.CheckBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.quietmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.setmarkeduserCheckBox = new System.Windows.Forms.CheckBox();
            this.waitformarkeduserCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            adminPinLabel = new System.Windows.Forms.Label();
            pinLabel = new System.Windows.Forms.Label();
            roomNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingNavigator)).BeginInit();
            this.conferenceRoomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(544, 16);
            this.descriptionLabel.Text = "MeetMe conference bridging allow quick, ad-hoc conferences with or without securi" +
                "ty.";
            // 
            // adminPinLabel
            // 
            adminPinLabel.AutoSize = true;
            adminPinLabel.Location = new System.Drawing.Point(28, 52);
            adminPinLabel.Name = "adminPinLabel";
            adminPinLabel.Size = new System.Drawing.Size(65, 12);
            adminPinLabel.TabIndex = 2;
            adminPinLabel.Text = "Admin Pin:";
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new System.Drawing.Point(64, 74);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new System.Drawing.Size(29, 12);
            pinLabel.TabIndex = 14;
            pinLabel.Text = "Pin:";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Location = new System.Drawing.Point(16, 26);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new System.Drawing.Size(77, 12);
            roomNumberLabel.TabIndex = 18;
            roomNumberLabel.Text = "Room Number:";
            // 
            // conferenceRoomBindingNavigator
            // 
            this.conferenceRoomBindingNavigator.AddNewItem = null;
            this.conferenceRoomBindingNavigator.BindingSource = this.conferenceRoomBindingSource;
            this.conferenceRoomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.conferenceRoomBindingNavigator.DeleteItem = null;
            this.conferenceRoomBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.conferenceRoomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.conferenceRoomBindingNavigator.Location = new System.Drawing.Point(12, 38);
            this.conferenceRoomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.conferenceRoomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.conferenceRoomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.conferenceRoomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.conferenceRoomBindingNavigator.Name = "conferenceRoomBindingNavigator";
            this.conferenceRoomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.conferenceRoomBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.conferenceRoomBindingNavigator.TabIndex = 0;
            this.conferenceRoomBindingNavigator.Text = "bindingNavigator1";
            // 
            // conferenceRoomBindingSource
            // 
            this.conferenceRoomBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.ConferenceRoom);
            this.conferenceRoomBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.conferenceRoomBindingSource_AddingNew);
            this.conferenceRoomBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.conferenceRoomBindingSource_ListChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // conferenceRoomDataGridView
            // 
            this.conferenceRoomDataGridView.AllowUserToAddRows = false;
            this.conferenceRoomDataGridView.AllowUserToDeleteRows = false;
            this.conferenceRoomDataGridView.AutoGenerateColumns = false;
            this.conferenceRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conferenceRoomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.conferenceRoomDataGridView.DataSource = this.conferenceRoomBindingSource;
            this.conferenceRoomDataGridView.Location = new System.Drawing.Point(12, 66);
            this.conferenceRoomDataGridView.Name = "conferenceRoomDataGridView";
            this.conferenceRoomDataGridView.ReadOnly = true;
            this.conferenceRoomDataGridView.RowTemplate.Height = 23;
            this.conferenceRoomDataGridView.Size = new System.Drawing.Size(344, 289);
            this.conferenceRoomDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pin";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AdminPin";
            this.dataGridViewTextBoxColumn3.HeaderText = "AdminPin";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // adminPinTextBox
            // 
            this.adminPinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conferenceRoomBindingSource, "AdminPin", true));
            this.adminPinTextBox.Location = new System.Drawing.Point(125, 48);
            this.adminPinTextBox.Name = "adminPinTextBox";
            this.adminPinTextBox.Size = new System.Drawing.Size(104, 21);
            this.adminPinTextBox.TabIndex = 1;
            // 
            // announcecallersCheckBox
            // 
            this.announcecallersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Announcecallers", true));
            this.announcecallersCheckBox.Location = new System.Drawing.Point(6, 80);
            this.announcecallersCheckBox.Name = "announcecallersCheckBox";
            this.announcecallersCheckBox.Size = new System.Drawing.Size(228, 24);
            this.announcecallersCheckBox.TabIndex = 2;
            this.announcecallersCheckBox.Text = "Announce callers";
            this.announcecallersCheckBox.UseVisualStyleBackColor = true;
            // 
            // enablecallermenuCheckBox
            // 
            this.enablecallermenuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Enablecallermenu", true));
            this.enablecallermenuCheckBox.Location = new System.Drawing.Point(6, 50);
            this.enablecallermenuCheckBox.Name = "enablecallermenuCheckBox";
            this.enablecallermenuCheckBox.Size = new System.Drawing.Size(228, 24);
            this.enablecallermenuCheckBox.TabIndex = 1;
            this.enablecallermenuCheckBox.Text = "Enable caller menu";
            this.enablecallermenuCheckBox.UseVisualStyleBackColor = true;
            // 
            // musicforfirstuserCheckBox
            // 
            this.musicforfirstuserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Musicforfirstuser", true));
            this.musicforfirstuserCheckBox.Location = new System.Drawing.Point(6, 20);
            this.musicforfirstuserCheckBox.Name = "musicforfirstuserCheckBox";
            this.musicforfirstuserCheckBox.Size = new System.Drawing.Size(228, 24);
            this.musicforfirstuserCheckBox.TabIndex = 0;
            this.musicforfirstuserCheckBox.Text = "Play hold music for first caller";
            this.musicforfirstuserCheckBox.UseVisualStyleBackColor = true;
            // 
            // pinTextBox
            // 
            this.pinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conferenceRoomBindingSource, "Pin", true));
            this.pinTextBox.Location = new System.Drawing.Point(125, 73);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(104, 21);
            this.pinTextBox.TabIndex = 2;
            // 
            // quietmodeCheckBox
            // 
            this.quietmodeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Quietmode", true));
            this.quietmodeCheckBox.Location = new System.Drawing.Point(6, 110);
            this.quietmodeCheckBox.Name = "quietmodeCheckBox";
            this.quietmodeCheckBox.Size = new System.Drawing.Size(228, 24);
            this.quietmodeCheckBox.TabIndex = 3;
            this.quietmodeCheckBox.Text = "Quiet Mode";
            this.quietmodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conferenceRoomBindingSource, "RoomNumber", true));
            this.roomNumberTextBox.Location = new System.Drawing.Point(125, 23);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(104, 21);
            this.roomNumberTextBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.roomNumberTextBox, "This is the number dialed to reach this Conference Bridge.");
            this.roomNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.roomNumberTextBox_Validating);
            // 
            // setmarkeduserCheckBox
            // 
            this.setmarkeduserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Setmarkeduser", true));
            this.setmarkeduserCheckBox.Location = new System.Drawing.Point(5, 170);
            this.setmarkeduserCheckBox.Name = "setmarkeduserCheckBox";
            this.setmarkeduserCheckBox.Size = new System.Drawing.Size(228, 24);
            this.setmarkeduserCheckBox.TabIndex = 5;
            this.setmarkeduserCheckBox.Text = "Set marked user";
            this.setmarkeduserCheckBox.UseVisualStyleBackColor = true;
            // 
            // waitformarkeduserCheckBox
            // 
            this.waitformarkeduserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Waitformarkeduser", true));
            this.waitformarkeduserCheckBox.Location = new System.Drawing.Point(6, 140);
            this.waitformarkeduserCheckBox.Name = "waitformarkeduserCheckBox";
            this.waitformarkeduserCheckBox.Size = new System.Drawing.Size(228, 24);
            this.waitformarkeduserCheckBox.TabIndex = 4;
            this.waitformarkeduserCheckBox.Text = "Wait for marked user";
            this.waitformarkeduserCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(roomNumberLabel);
            this.groupBox1.Controls.Add(this.roomNumberTextBox);
            this.groupBox1.Controls.Add(adminPinLabel);
            this.groupBox1.Controls.Add(this.pinTextBox);
            this.groupBox1.Controls.Add(this.adminPinTextBox);
            this.groupBox1.Controls.Add(pinLabel);
            this.groupBox1.Location = new System.Drawing.Point(376, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conference Bridge";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waitformarkeduserCheckBox);
            this.groupBox2.Controls.Add(this.announcecallersCheckBox);
            this.groupBox2.Controls.Add(this.setmarkeduserCheckBox);
            this.groupBox2.Controls.Add(this.enablecallermenuCheckBox);
            this.groupBox2.Controls.Add(this.quietmodeCheckBox);
            this.groupBox2.Controls.Add(this.musicforfirstuserCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(376, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conference Room Options";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(166, 379);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 379);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(537, 379);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(417, 379);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // ConferencingConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 414);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.conferenceRoomDataGridView);
            this.Controls.Add(this.conferenceRoomBindingNavigator);
            this.Name = "ConferencingConfigPage";
            this.TabText = "Conferencing";
            this.Text = "Conferencing";
            this.Load += new System.EventHandler(this.ConferencingConfigPage_Load);
            this.Controls.SetChildIndex(this.conferenceRoomBindingNavigator, 0);
            this.Controls.SetChildIndex(this.conferenceRoomDataGridView, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingNavigator)).EndInit();
            this.conferenceRoomBindingNavigator.ResumeLayout(false);
            this.conferenceRoomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource conferenceRoomBindingSource;
        private System.Windows.Forms.BindingNavigator conferenceRoomBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView conferenceRoomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox adminPinTextBox;
        private System.Windows.Forms.CheckBox announcecallersCheckBox;
        private System.Windows.Forms.CheckBox enablecallermenuCheckBox;
        private System.Windows.Forms.CheckBox musicforfirstuserCheckBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.CheckBox quietmodeCheckBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.CheckBox setmarkeduserCheckBox;
        private System.Windows.Forms.CheckBox waitformarkeduserCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}