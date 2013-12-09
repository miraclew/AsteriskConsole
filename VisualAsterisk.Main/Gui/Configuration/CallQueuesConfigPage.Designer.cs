namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class CallQueuesConfigPage
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
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label maxlenLabel;
            System.Windows.Forms.Label musicclassLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label strategyLabel;
            System.Windows.Forms.Label timeoutLabel;
            System.Windows.Forms.Label wrapuptimeLabel;
            System.Windows.Forms.Label joinemptyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallQueuesConfigPage));
            this.queueExtensionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.queueExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.queueExtensionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autofillCheckBox = new System.Windows.Forms.CheckBox();
            this.autopauseCheckBox = new System.Windows.Forms.CheckBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.joinemptyTextBox = new System.Windows.Forms.TextBox();
            this.leavewhenemptyCheckBox = new System.Windows.Forms.CheckBox();
            this.maxlenTextBox = new System.Windows.Forms.TextBox();
            this.musicclassTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reportholdtimeCheckBox = new System.Windows.Forms.CheckBox();
            this.strategyTextBox = new System.Windows.Forms.TextBox();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.wrapuptimeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewAgents = new System.Windows.Forms.ListView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            extensionLabel = new System.Windows.Forms.Label();
            maxlenLabel = new System.Windows.Forms.Label();
            musicclassLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            strategyLabel = new System.Windows.Forms.Label();
            timeoutLabel = new System.Windows.Forms.Label();
            wrapuptimeLabel = new System.Windows.Forms.Label();
            joinemptyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingNavigator)).BeginInit();
            this.queueExtensionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(408, 16);
            this.descriptionLabel.Text = "Call queues allow calls to be sequenced to one or more agents.";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Location = new System.Drawing.Point(383, 40);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(65, 12);
            extensionLabel.TabIndex = 8;
            extensionLabel.Text = "Extension:";
            // 
            // maxlenLabel
            // 
            maxlenLabel.AutoSize = true;
            maxlenLabel.Location = new System.Drawing.Point(6, 86);
            maxlenLabel.Name = "maxlenLabel";
            maxlenLabel.Size = new System.Drawing.Size(47, 12);
            maxlenLabel.TabIndex = 10;
            maxlenLabel.Text = "Maxlen:";
            // 
            // musicclassLabel
            // 
            musicclassLabel.AutoSize = true;
            musicclassLabel.Location = new System.Drawing.Point(7, 118);
            musicclassLabel.Name = "musicclassLabel";
            musicclassLabel.Size = new System.Drawing.Size(71, 12);
            musicclassLabel.TabIndex = 11;
            musicclassLabel.Text = "Musicclass:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(383, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 12);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            // 
            // strategyLabel
            // 
            strategyLabel.AutoSize = true;
            strategyLabel.Location = new System.Drawing.Point(383, 100);
            strategyLabel.Name = "strategyLabel";
            strategyLabel.Size = new System.Drawing.Size(59, 12);
            strategyLabel.TabIndex = 22;
            strategyLabel.Text = "Strategy:";
            // 
            // timeoutLabel
            // 
            timeoutLabel.AutoSize = true;
            timeoutLabel.Location = new System.Drawing.Point(7, 30);
            timeoutLabel.Name = "timeoutLabel";
            timeoutLabel.Size = new System.Drawing.Size(53, 12);
            timeoutLabel.TabIndex = 6;
            timeoutLabel.Text = "Timeout:";
            // 
            // wrapuptimeLabel
            // 
            wrapuptimeLabel.AutoSize = true;
            wrapuptimeLabel.Location = new System.Drawing.Point(6, 60);
            wrapuptimeLabel.Name = "wrapuptimeLabel";
            wrapuptimeLabel.Size = new System.Drawing.Size(71, 12);
            wrapuptimeLabel.TabIndex = 7;
            wrapuptimeLabel.Text = "Wrapuptime:";
            // 
            // joinemptyLabel
            // 
            joinemptyLabel.AutoSize = true;
            joinemptyLabel.Location = new System.Drawing.Point(12, 210);
            joinemptyLabel.Name = "joinemptyLabel";
            joinemptyLabel.Size = new System.Drawing.Size(65, 12);
            joinemptyLabel.TabIndex = 10;
            joinemptyLabel.Text = "Joinempty:";
            // 
            // queueExtensionBindingNavigator
            // 
            this.queueExtensionBindingNavigator.AddNewItem = null;
            this.queueExtensionBindingNavigator.BindingSource = this.queueExtensionBindingSource;
            this.queueExtensionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.queueExtensionBindingNavigator.DeleteItem = null;
            this.queueExtensionBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.queueExtensionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.queueExtensionBindingNavigator.Location = new System.Drawing.Point(4, 40);
            this.queueExtensionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.queueExtensionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.queueExtensionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.queueExtensionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.queueExtensionBindingNavigator.Name = "queueExtensionBindingNavigator";
            this.queueExtensionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.queueExtensionBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.queueExtensionBindingNavigator.TabIndex = 0;
            this.queueExtensionBindingNavigator.Text = "bindingNavigator1";
            // 
            // queueExtensionBindingSource
            // 
            this.queueExtensionBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.QueueExtension);
            this.queueExtensionBindingSource.CurrentChanged += new System.EventHandler(this.queueExtensionBindingSource_CurrentChanged);
            this.queueExtensionBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.queueExtensionBindingSource_AddingNew);
            this.queueExtensionBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.queueExtensionBindingSource_ListChanged);
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
            // queueExtensionDataGridView
            // 
            this.queueExtensionDataGridView.AllowUserToAddRows = false;
            this.queueExtensionDataGridView.AllowUserToDeleteRows = false;
            this.queueExtensionDataGridView.AutoGenerateColumns = false;
            this.queueExtensionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queueExtensionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Extension,
            this.dataGridViewTextBoxColumn2});
            this.queueExtensionDataGridView.DataSource = this.queueExtensionBindingSource;
            this.queueExtensionDataGridView.Location = new System.Drawing.Point(4, 67);
            this.queueExtensionDataGridView.Name = "queueExtensionDataGridView";
            this.queueExtensionDataGridView.ReadOnly = true;
            this.queueExtensionDataGridView.RowTemplate.Height = 23;
            this.queueExtensionDataGridView.Size = new System.Drawing.Size(353, 371);
            this.queueExtensionDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Extension
            // 
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Strategy";
            this.dataGridViewTextBoxColumn2.HeaderText = "Strategy";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // autofillCheckBox
            // 
            this.autofillCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Autofill", true));
            this.autofillCheckBox.Location = new System.Drawing.Point(9, 150);
            this.autofillCheckBox.Name = "autofillCheckBox";
            this.autofillCheckBox.Size = new System.Drawing.Size(194, 24);
            this.autofillCheckBox.TabIndex = 4;
            this.autofillCheckBox.Text = "Auto Fill";
            this.autofillCheckBox.UseVisualStyleBackColor = true;
            // 
            // autopauseCheckBox
            // 
            this.autopauseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Autopause", true));
            this.autopauseCheckBox.Location = new System.Drawing.Point(9, 180);
            this.autopauseCheckBox.Name = "autopauseCheckBox";
            this.autopauseCheckBox.Size = new System.Drawing.Size(194, 24);
            this.autopauseCheckBox.TabIndex = 5;
            this.autopauseCheckBox.Text = "Auto Pause";
            this.autopauseCheckBox.UseVisualStyleBackColor = true;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Extension", true));
            this.extensionTextBox.Location = new System.Drawing.Point(484, 37);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(104, 21);
            this.extensionTextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.extensionTextBox, "This option defines the numbered extension that may be dialed to reach this Queue" +
                    ".");
            this.extensionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.extensionTextBox_Validating);
            // 
            // joinemptyTextBox
            // 
            this.joinemptyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Joinempty", true));
            this.joinemptyTextBox.Location = new System.Drawing.Point(99, 205);
            this.joinemptyTextBox.Name = "joinemptyTextBox";
            this.joinemptyTextBox.Size = new System.Drawing.Size(104, 21);
            this.joinemptyTextBox.TabIndex = 6;
            // 
            // leavewhenemptyCheckBox
            // 
            this.leavewhenemptyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Leavewhenempty", true));
            this.leavewhenemptyCheckBox.Location = new System.Drawing.Point(9, 236);
            this.leavewhenemptyCheckBox.Name = "leavewhenemptyCheckBox";
            this.leavewhenemptyCheckBox.Size = new System.Drawing.Size(194, 24);
            this.leavewhenemptyCheckBox.TabIndex = 7;
            this.leavewhenemptyCheckBox.Text = "LeaveWhenEmpty";
            this.leavewhenemptyCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxlenTextBox
            // 
            this.maxlenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Maxlen", true));
            this.maxlenTextBox.Location = new System.Drawing.Point(99, 83);
            this.maxlenTextBox.Name = "maxlenTextBox";
            this.maxlenTextBox.Size = new System.Drawing.Size(104, 21);
            this.maxlenTextBox.TabIndex = 2;
            // 
            // musicclassTextBox
            // 
            this.musicclassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Musicclass", true));
            this.musicclassTextBox.Location = new System.Drawing.Point(99, 115);
            this.musicclassTextBox.Name = "musicclassTextBox";
            this.musicclassTextBox.Size = new System.Drawing.Size(104, 21);
            this.musicclassTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(484, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(104, 21);
            this.nameTextBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.nameTextBox, "This option defines a name for this Queue, i.e. \"Sales\"");
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // reportholdtimeCheckBox
            // 
            this.reportholdtimeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.queueExtensionBindingSource, "Reportholdtime", true));
            this.reportholdtimeCheckBox.Location = new System.Drawing.Point(9, 266);
            this.reportholdtimeCheckBox.Name = "reportholdtimeCheckBox";
            this.reportholdtimeCheckBox.Size = new System.Drawing.Size(194, 24);
            this.reportholdtimeCheckBox.TabIndex = 8;
            this.reportholdtimeCheckBox.Text = "Report Hold Time";
            this.reportholdtimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // strategyTextBox
            // 
            this.strategyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Strategy", true));
            this.strategyTextBox.Location = new System.Drawing.Point(484, 97);
            this.strategyTextBox.Name = "strategyTextBox";
            this.strategyTextBox.Size = new System.Drawing.Size(104, 21);
            this.strategyTextBox.TabIndex = 3;
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Timeout", true));
            this.timeoutTextBox.Location = new System.Drawing.Point(99, 27);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(104, 21);
            this.timeoutTextBox.TabIndex = 0;
            // 
            // wrapuptimeTextBox
            // 
            this.wrapuptimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queueExtensionBindingSource, "Wrapuptime", true));
            this.wrapuptimeTextBox.Location = new System.Drawing.Point(99, 57);
            this.wrapuptimeTextBox.Name = "wrapuptimeTextBox";
            this.wrapuptimeTextBox.Size = new System.Drawing.Size(104, 21);
            this.wrapuptimeTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(timeoutLabel);
            this.groupBox1.Controls.Add(this.timeoutTextBox);
            this.groupBox1.Controls.Add(this.autofillCheckBox);
            this.groupBox1.Controls.Add(wrapuptimeLabel);
            this.groupBox1.Controls.Add(this.autopauseCheckBox);
            this.groupBox1.Controls.Add(joinemptyLabel);
            this.groupBox1.Controls.Add(this.joinemptyTextBox);
            this.groupBox1.Controls.Add(this.wrapuptimeTextBox);
            this.groupBox1.Controls.Add(this.reportholdtimeCheckBox);
            this.groupBox1.Controls.Add(maxlenLabel);
            this.groupBox1.Controls.Add(this.leavewhenemptyCheckBox);
            this.groupBox1.Controls.Add(this.maxlenTextBox);
            this.groupBox1.Controls.Add(musicclassLabel);
            this.groupBox1.Controls.Add(this.musicclassTextBox);
            this.groupBox1.Location = new System.Drawing.Point(385, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queue Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewAgents);
            this.groupBox2.Location = new System.Drawing.Point(613, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 393);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agents";
            // 
            // listViewAgents
            // 
            this.listViewAgents.CheckBoxes = true;
            this.listViewAgents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAgents.Location = new System.Drawing.Point(3, 17);
            this.listViewAgents.Name = "listViewAgents";
            this.listViewAgents.Size = new System.Drawing.Size(177, 373);
            this.listViewAgents.TabIndex = 0;
            this.listViewAgents.UseCompatibleStateImageBehavior = false;
            this.listViewAgents.View = System.Windows.Forms.View.List;
            this.listViewAgents.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewAgents_ItemChecked);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(204, 449);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(70, 449);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(575, 449);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(455, 449);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // CallQueuesConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(extensionLabel);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(strategyLabel);
            this.Controls.Add(this.strategyTextBox);
            this.Controls.Add(this.queueExtensionDataGridView);
            this.Controls.Add(this.queueExtensionBindingNavigator);
            this.Name = "CallQueuesConfigPage";
            this.TabText = "Queues";
            this.Text = "Queues";
            this.Controls.SetChildIndex(this.queueExtensionBindingNavigator, 0);
            this.Controls.SetChildIndex(this.queueExtensionDataGridView, 0);
            this.Controls.SetChildIndex(this.strategyTextBox, 0);
            this.Controls.SetChildIndex(strategyLabel, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(nameLabel, 0);
            this.Controls.SetChildIndex(this.extensionTextBox, 0);
            this.Controls.SetChildIndex(extensionLabel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingNavigator)).EndInit();
            this.queueExtensionBindingNavigator.ResumeLayout(false);
            this.queueExtensionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueExtensionDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource queueExtensionBindingSource;
        private System.Windows.Forms.BindingNavigator queueExtensionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView queueExtensionDataGridView;
        private System.Windows.Forms.CheckBox autofillCheckBox;
        private System.Windows.Forms.CheckBox autopauseCheckBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox joinemptyTextBox;
        private System.Windows.Forms.CheckBox leavewhenemptyCheckBox;
        private System.Windows.Forms.TextBox maxlenTextBox;
        private System.Windows.Forms.TextBox musicclassTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox reportholdtimeCheckBox;
        private System.Windows.Forms.TextBox strategyTextBox;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.TextBox wrapuptimeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewAgents;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}