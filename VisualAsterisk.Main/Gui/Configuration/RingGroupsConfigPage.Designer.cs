namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class RingGroupsConfigPage
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
            System.Windows.Forms.Label howLongLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label strategyLabel;
            System.Windows.Forms.Label extensionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RingGroupsConfigPage));
            this.ringGroupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ringGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ringGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howLongTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.strategyTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMenus = new System.Windows.Forms.ComboBox();
            this.radioButtonHangup = new System.Windows.Forms.RadioButton();
            this.radioButtonGotoIvrMenu = new System.Windows.Forms.RadioButton();
            this.radioButtonGotoVoicemail = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddSelected = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.listViewAvailiableChannels = new System.Windows.Forms.ListView();
            this.listViewRingGroupMembers = new System.Windows.Forms.ListView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            howLongLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            strategyLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingNavigator)).BeginInit();
            this.ringGroupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(329, 16);
            this.descriptionLabel.Text = "define RingGroups to dial more than one extension";
            // 
            // howLongLabel
            // 
            howLongLabel.AutoSize = true;
            howLongLabel.Location = new System.Drawing.Point(349, 118);
            howLongLabel.Name = "howLongLabel";
            howLongLabel.Size = new System.Drawing.Size(59, 12);
            howLongLabel.TabIndex = 4;
            howLongLabel.Text = "How Long:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(349, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 12);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // strategyLabel
            // 
            strategyLabel.AutoSize = true;
            strategyLabel.Location = new System.Drawing.Point(349, 58);
            strategyLabel.Name = "strategyLabel";
            strategyLabel.Size = new System.Drawing.Size(59, 12);
            strategyLabel.TabIndex = 8;
            strategyLabel.Text = "Strategy:";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Location = new System.Drawing.Point(349, 88);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(65, 12);
            extensionLabel.TabIndex = 12;
            extensionLabel.Text = "Extension:";
            // 
            // ringGroupBindingNavigator
            // 
            this.ringGroupBindingNavigator.AddNewItem = null;
            this.ringGroupBindingNavigator.BindingSource = this.ringGroupBindingSource;
            this.ringGroupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ringGroupBindingNavigator.DeleteItem = null;
            this.ringGroupBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.ringGroupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.ringGroupBindingNavigator.Location = new System.Drawing.Point(10, 32);
            this.ringGroupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ringGroupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ringGroupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ringGroupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ringGroupBindingNavigator.Name = "ringGroupBindingNavigator";
            this.ringGroupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ringGroupBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.ringGroupBindingNavigator.TabIndex = 0;
            this.ringGroupBindingNavigator.Text = "bindingNavigator1";
            // 
            // ringGroupBindingSource
            // 
            this.ringGroupBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.RingGroup);
            this.ringGroupBindingSource.CurrentChanged += new System.EventHandler(this.ringGroupBindingSource_CurrentChanged);
            this.ringGroupBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.ringGroupBindingSource_AddingNew);
            this.ringGroupBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.ringGroupBindingSource_ListChanged);
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
            // ringGroupDataGridView
            // 
            this.ringGroupDataGridView.AllowUserToAddRows = false;
            this.ringGroupDataGridView.AllowUserToDeleteRows = false;
            this.ringGroupDataGridView.AutoGenerateColumns = false;
            this.ringGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ringGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.ringGroupDataGridView.DataSource = this.ringGroupBindingSource;
            this.ringGroupDataGridView.Location = new System.Drawing.Point(6, 61);
            this.ringGroupDataGridView.Name = "ringGroupDataGridView";
            this.ringGroupDataGridView.ReadOnly = true;
            this.ringGroupDataGridView.RowTemplate.Height = 23;
            this.ringGroupDataGridView.Size = new System.Drawing.Size(325, 392);
            this.ringGroupDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Strategy";
            this.dataGridViewTextBoxColumn4.HeaderText = "Strategy";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HowLong";
            this.dataGridViewTextBoxColumn7.HeaderText = "HowLong";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // howLongTextBox
            // 
            this.howLongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "HowLong", true));
            this.howLongTextBox.Location = new System.Drawing.Point(420, 115);
            this.howLongTextBox.Name = "howLongTextBox";
            this.howLongTextBox.Size = new System.Drawing.Size(100, 21);
            this.howLongTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(420, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // strategyTextBox
            // 
            this.strategyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "Strategy", true));
            this.strategyTextBox.Location = new System.Drawing.Point(420, 55);
            this.strategyTextBox.Name = "strategyTextBox";
            this.strategyTextBox.Size = new System.Drawing.Size(100, 21);
            this.strategyTextBox.TabIndex = 2;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ringGroupBindingSource, "Extension", true));
            this.extensionTextBox.Location = new System.Drawing.Point(420, 81);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(100, 21);
            this.extensionTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMenus);
            this.groupBox1.Controls.Add(this.radioButtonHangup);
            this.groupBox1.Controls.Add(this.radioButtonGotoIvrMenu);
            this.groupBox1.Controls.Add(this.radioButtonGotoVoicemail);
            this.groupBox1.Location = new System.Drawing.Point(343, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "If not answered :";
            // 
            // comboBoxMenus
            // 
            this.comboBoxMenus.FormattingEnabled = true;
            this.comboBoxMenus.Location = new System.Drawing.Point(163, 61);
            this.comboBoxMenus.Name = "comboBoxMenus";
            this.comboBoxMenus.Size = new System.Drawing.Size(141, 20);
            this.comboBoxMenus.TabIndex = 2;
            // 
            // radioButtonHangup
            // 
            this.radioButtonHangup.AutoSize = true;
            this.radioButtonHangup.Location = new System.Drawing.Point(13, 97);
            this.radioButtonHangup.Name = "radioButtonHangup";
            this.radioButtonHangup.Size = new System.Drawing.Size(59, 16);
            this.radioButtonHangup.TabIndex = 3;
            this.radioButtonHangup.TabStop = true;
            this.radioButtonHangup.Text = "HangUp";
            this.radioButtonHangup.UseVisualStyleBackColor = true;
            // 
            // radioButtonGotoIvrMenu
            // 
            this.radioButtonGotoIvrMenu.AutoSize = true;
            this.radioButtonGotoIvrMenu.Location = new System.Drawing.Point(13, 62);
            this.radioButtonGotoIvrMenu.Name = "radioButtonGotoIvrMenu";
            this.radioButtonGotoIvrMenu.Size = new System.Drawing.Size(119, 16);
            this.radioButtonGotoIvrMenu.TabIndex = 1;
            this.radioButtonGotoIvrMenu.TabStop = true;
            this.radioButtonGotoIvrMenu.Text = "Goto an IVR menu";
            this.radioButtonGotoIvrMenu.UseVisualStyleBackColor = true;
            // 
            // radioButtonGotoVoicemail
            // 
            this.radioButtonGotoVoicemail.AutoSize = true;
            this.radioButtonGotoVoicemail.Location = new System.Drawing.Point(13, 30);
            this.radioButtonGotoVoicemail.Name = "radioButtonGotoVoicemail";
            this.radioButtonGotoVoicemail.Size = new System.Drawing.Size(185, 16);
            this.radioButtonGotoVoicemail.TabIndex = 0;
            this.radioButtonGotoVoicemail.TabStop = true;
            this.radioButtonGotoVoicemail.Text = "Goto Voicemail of this user";
            this.radioButtonGotoVoicemail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(524, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "Available Channels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(341, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ring Group Members";
            // 
            // buttonAddSelected
            // 
            this.buttonAddSelected.Location = new System.Drawing.Point(471, 322);
            this.buttonAddSelected.Name = "buttonAddSelected";
            this.buttonAddSelected.Size = new System.Drawing.Size(49, 23);
            this.buttonAddSelected.TabIndex = 6;
            this.buttonAddSelected.Text = "<-";
            this.buttonAddSelected.UseVisualStyleBackColor = true;
            this.buttonAddSelected.Click += new System.EventHandler(this.buttonAddSelected_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(471, 358);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(49, 23);
            this.buttonDeleteSelected.TabIndex = 7;
            this.buttonDeleteSelected.Text = "->";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(471, 387);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(49, 23);
            this.buttonDeleteAll.TabIndex = 8;
            this.buttonDeleteAll.Text = ">>>>";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // listViewAvailiableChannels
            // 
            this.listViewAvailiableChannels.Location = new System.Drawing.Point(534, 289);
            this.listViewAvailiableChannels.Name = "listViewAvailiableChannels";
            this.listViewAvailiableChannels.Size = new System.Drawing.Size(113, 148);
            this.listViewAvailiableChannels.TabIndex = 23;
            this.listViewAvailiableChannels.UseCompatibleStateImageBehavior = false;
            this.listViewAvailiableChannels.View = System.Windows.Forms.View.List;
            // 
            // listViewRingGroupMembers
            // 
            this.listViewRingGroupMembers.Location = new System.Drawing.Point(343, 289);
            this.listViewRingGroupMembers.Name = "listViewRingGroupMembers";
            this.listViewRingGroupMembers.Size = new System.Drawing.Size(121, 148);
            this.listViewRingGroupMembers.TabIndex = 24;
            this.listViewRingGroupMembers.UseCompatibleStateImageBehavior = false;
            this.listViewRingGroupMembers.View = System.Windows.Forms.View.List;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(190, 472);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(56, 472);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(523, 472);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(403, 472);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // RingGroupsConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 507);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.listViewRingGroupMembers);
            this.Controls.Add(this.listViewAvailiableChannels);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.buttonAddSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(extensionLabel);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(howLongLabel);
            this.Controls.Add(this.howLongTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(strategyLabel);
            this.Controls.Add(this.strategyTextBox);
            this.Controls.Add(this.ringGroupDataGridView);
            this.Controls.Add(this.ringGroupBindingNavigator);
            this.Name = "RingGroupsConfigPage";
            this.TabText = "RingGroups";
            this.Text = "RingGroups";
            this.Controls.SetChildIndex(this.ringGroupBindingNavigator, 0);
            this.Controls.SetChildIndex(this.ringGroupDataGridView, 0);
            this.Controls.SetChildIndex(this.strategyTextBox, 0);
            this.Controls.SetChildIndex(strategyLabel, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(nameLabel, 0);
            this.Controls.SetChildIndex(this.howLongTextBox, 0);
            this.Controls.SetChildIndex(howLongLabel, 0);
            this.Controls.SetChildIndex(this.extensionTextBox, 0);
            this.Controls.SetChildIndex(extensionLabel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buttonAddSelected, 0);
            this.Controls.SetChildIndex(this.buttonDeleteSelected, 0);
            this.Controls.SetChildIndex(this.buttonDeleteAll, 0);
            this.Controls.SetChildIndex(this.listViewAvailiableChannels, 0);
            this.Controls.SetChildIndex(this.listViewRingGroupMembers, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingNavigator)).EndInit();
            this.ringGroupBindingNavigator.ResumeLayout(false);
            this.ringGroupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringGroupDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ringGroupBindingSource;
        private System.Windows.Forms.BindingNavigator ringGroupBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView ringGroupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox howLongTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox strategyTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMenus;
        private System.Windows.Forms.RadioButton radioButtonHangup;
        private System.Windows.Forms.RadioButton radioButtonGotoIvrMenu;
        private System.Windows.Forms.RadioButton radioButtonGotoVoicemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddSelected;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.ListView listViewAvailiableChannels;
        private System.Windows.Forms.ListView listViewRingGroupMembers;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}