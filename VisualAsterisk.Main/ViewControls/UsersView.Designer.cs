namespace VisualAsterisk.Main.ViewControls
{
    partial class UsersView
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
            System.Windows.Forms.Label allowLabel;
            System.Windows.Forms.Label cidNumberLabel;
            System.Windows.Forms.Label contextLabel;
            System.Windows.Forms.Label disallowLabel;
            System.Windows.Forms.Label dtmfmodeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label insecureLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label vmsecretLabel;
            System.Windows.Forms.Label zapchanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersView));
            this.userExtensionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.userExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userExtensionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowTextBox = new System.Windows.Forms.TextBox();
            this.callWaitingCheckBox = new System.Windows.Forms.CheckBox();
            this.canreinviteCheckBox = new System.Windows.Forms.CheckBox();
            this.cidNumberTextBox = new System.Windows.Forms.TextBox();
            this.disallowTextBox = new System.Windows.Forms.TextBox();
            this.dtmfmodeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.hasagentCheckBox = new System.Windows.Forms.CheckBox();
            this.hasdirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.hasiaxCheckBox = new System.Windows.Forms.CheckBox();
            this.hasSipCheckBox = new System.Windows.Forms.CheckBox();
            this.hasVoicemailCheckBox = new System.Windows.Forms.CheckBox();
            this.insecureTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.threeWayCallingCheckBox = new System.Windows.Forms.CheckBox();
            this.vmsecretTextBox = new System.Windows.Forms.TextBox();
            this.zapchanTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dialplanComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.natCheckBox = new System.Windows.Forms.CheckBox();
            this.hasCTICheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editCodecButton = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            allowLabel = new System.Windows.Forms.Label();
            cidNumberLabel = new System.Windows.Forms.Label();
            contextLabel = new System.Windows.Forms.Label();
            disallowLabel = new System.Windows.Forms.Label();
            dtmfmodeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            insecureLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            vmsecretLabel = new System.Windows.Forms.Label();
            zapchanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingNavigator)).BeginInit();
            this.userExtensionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // allowLabel
            // 
            allowLabel.AutoSize = true;
            allowLabel.Location = new System.Drawing.Point(34, 28);
            allowLabel.Name = "allowLabel";
            allowLabel.Size = new System.Drawing.Size(41, 12);
            allowLabel.TabIndex = 2;
            allowLabel.Text = "Allow:";
            // 
            // cidNumberLabel
            // 
            cidNumberLabel.AutoSize = true;
            cidNumberLabel.Location = new System.Drawing.Point(17, 155);
            cidNumberLabel.Name = "cidNumberLabel";
            cidNumberLabel.Size = new System.Drawing.Size(65, 12);
            cidNumberLabel.TabIndex = 10;
            cidNumberLabel.Text = "Caller ID:";
            // 
            // contextLabel
            // 
            contextLabel.AutoSize = true;
            contextLabel.Location = new System.Drawing.Point(16, 211);
            contextLabel.Name = "contextLabel";
            contextLabel.Size = new System.Drawing.Size(65, 12);
            contextLabel.TabIndex = 12;
            contextLabel.Text = "Dial Plan:";
            // 
            // disallowLabel
            // 
            disallowLabel.AutoSize = true;
            disallowLabel.Location = new System.Drawing.Point(16, 61);
            disallowLabel.Name = "disallowLabel";
            disallowLabel.Size = new System.Drawing.Size(59, 12);
            disallowLabel.TabIndex = 16;
            disallowLabel.Text = "Disallow:";
            // 
            // dtmfmodeLabel
            // 
            dtmfmodeLabel.AutoSize = true;
            dtmfmodeLabel.Location = new System.Drawing.Point(16, 182);
            dtmfmodeLabel.Name = "dtmfmodeLabel";
            dtmfmodeLabel.Size = new System.Drawing.Size(59, 12);
            dtmfmodeLabel.TabIndex = 18;
            dtmfmodeLabel.Text = "Dtmfmode:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(17, 128);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 12);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email:";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Location = new System.Drawing.Point(16, 19);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(65, 12);
            extensionLabel.TabIndex = 22;
            extensionLabel.Text = "Extension:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(16, 46);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(65, 12);
            fullNameLabel.TabIndex = 24;
            fullNameLabel.Text = "Full Name:";
            // 
            // insecureLabel
            // 
            insecureLabel.AutoSize = true;
            insecureLabel.Location = new System.Drawing.Point(16, 204);
            insecureLabel.Name = "insecureLabel";
            insecureLabel.Size = new System.Drawing.Size(59, 12);
            insecureLabel.TabIndex = 36;
            insecureLabel.Text = "Insecure:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(17, 74);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(59, 12);
            passwordLabel.TabIndex = 38;
            passwordLabel.Text = "Password:";
            // 
            // vmsecretLabel
            // 
            vmsecretLabel.AutoSize = true;
            vmsecretLabel.Location = new System.Drawing.Point(16, 101);
            vmsecretLabel.Name = "vmsecretLabel";
            vmsecretLabel.Size = new System.Drawing.Size(77, 12);
            vmsecretLabel.TabIndex = 42;
            vmsecretLabel.Text = "VM password:";
            // 
            // zapchanLabel
            // 
            zapchanLabel.AutoSize = true;
            zapchanLabel.Location = new System.Drawing.Point(17, 183);
            zapchanLabel.Name = "zapchanLabel";
            zapchanLabel.Size = new System.Drawing.Size(83, 12);
            zapchanLabel.TabIndex = 44;
            zapchanLabel.Text = "Analog Phone:";
            // 
            // userExtensionBindingNavigator
            // 
            this.userExtensionBindingNavigator.AddNewItem = this.bindingNavigatorCountItem;
            this.userExtensionBindingNavigator.BindingSource = this.userExtensionBindingSource;
            this.userExtensionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userExtensionBindingNavigator.DeleteItem = null;
            this.userExtensionBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.userExtensionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.userExtensionBindingNavigator.Location = new System.Drawing.Point(14, 596);
            this.userExtensionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userExtensionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userExtensionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userExtensionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userExtensionBindingNavigator.Name = "userExtensionBindingNavigator";
            this.userExtensionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userExtensionBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.userExtensionBindingNavigator.TabIndex = 0;
            this.userExtensionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // userExtensionBindingSource
            // 
            this.userExtensionBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.UserExtension);
            this.userExtensionBindingSource.CurrentChanged += new System.EventHandler(this.userExtensionBindingSource_CurrentChanged);
            this.userExtensionBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.userExtensionBindingSource_AddingNew);
            this.userExtensionBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.userExtensionBindingSource_ListChanged);
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
            // userExtensionDataGridView
            // 
            this.userExtensionDataGridView.AllowUserToAddRows = false;
            this.userExtensionDataGridView.AllowUserToDeleteRows = false;
            this.userExtensionDataGridView.AutoGenerateColumns = false;
            this.userExtensionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userExtensionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn14});
            this.userExtensionDataGridView.DataSource = this.userExtensionBindingSource;
            this.userExtensionDataGridView.Location = new System.Drawing.Point(14, 50);
            this.userExtensionDataGridView.Name = "userExtensionDataGridView";
            this.userExtensionDataGridView.ReadOnly = true;
            this.userExtensionDataGridView.RowTemplate.Height = 23;
            this.userExtensionDataGridView.Size = new System.Drawing.Size(337, 544);
            this.userExtensionDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Extension";
            this.dataGridViewTextBoxColumn13.HeaderText = "Extension";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CidNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "CidNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Descripton";
            this.dataGridViewTextBoxColumn14.HeaderText = "Descripton";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // allowTextBox
            // 
            this.allowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Allow", true));
            this.allowTextBox.Enabled = false;
            this.allowTextBox.Location = new System.Drawing.Point(89, 25);
            this.allowTextBox.Name = "allowTextBox";
            this.allowTextBox.Size = new System.Drawing.Size(118, 21);
            this.allowTextBox.TabIndex = 1;
            // 
            // callWaitingCheckBox
            // 
            this.callWaitingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "CallWaiting", true));
            this.callWaitingCheckBox.Location = new System.Drawing.Point(10, 114);
            this.callWaitingCheckBox.Name = "callWaitingCheckBox";
            this.callWaitingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.callWaitingCheckBox.TabIndex = 6;
            this.callWaitingCheckBox.Text = "Call Waiting";
            this.callWaitingCheckBox.UseVisualStyleBackColor = true;
            // 
            // canreinviteCheckBox
            // 
            this.canreinviteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Canreinvite", true));
            this.canreinviteCheckBox.Location = new System.Drawing.Point(10, 144);
            this.canreinviteCheckBox.Name = "canreinviteCheckBox";
            this.canreinviteCheckBox.Size = new System.Drawing.Size(104, 24);
            this.canreinviteCheckBox.TabIndex = 8;
            this.canreinviteCheckBox.Text = "Can Reinvite";
            this.canreinviteCheckBox.UseVisualStyleBackColor = true;
            // 
            // cidNumberTextBox
            // 
            this.cidNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "CidNumber", true));
            this.cidNumberTextBox.Location = new System.Drawing.Point(129, 151);
            this.cidNumberTextBox.Name = "cidNumberTextBox";
            this.cidNumberTextBox.Size = new System.Drawing.Size(144, 21);
            this.cidNumberTextBox.TabIndex = 5;
            // 
            // disallowTextBox
            // 
            this.disallowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Disallow", true));
            this.disallowTextBox.Enabled = false;
            this.disallowTextBox.Location = new System.Drawing.Point(90, 58);
            this.disallowTextBox.Name = "disallowTextBox";
            this.disallowTextBox.Size = new System.Drawing.Size(117, 21);
            this.disallowTextBox.TabIndex = 2;
            // 
            // dtmfmodeTextBox
            // 
            this.dtmfmodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Dtmfmode", true));
            this.dtmfmodeTextBox.Location = new System.Drawing.Point(106, 179);
            this.dtmfmodeTextBox.Name = "dtmfmodeTextBox";
            this.dtmfmodeTextBox.Size = new System.Drawing.Size(144, 21);
            this.dtmfmodeTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(129, 124);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(144, 21);
            this.emailTextBox.TabIndex = 4;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Extension", true));
            this.errorProvider.SetIconPadding(this.extensionTextBox, 2);
            this.infoProvider.SetIconPadding(this.extensionTextBox, 2);
            this.extensionTextBox.Location = new System.Drawing.Point(128, 16);
            this.extensionTextBox.Name = "extensionTextBox";
            this.helpProvider.SetShowHelp(this.extensionTextBox, true);
            this.extensionTextBox.Size = new System.Drawing.Size(144, 21);
            this.extensionTextBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.extensionTextBox, "The numbered extension, i.e. 1234, that will be associated with this particular U" +
                    "ser / Phone.");
            this.extensionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.extensionTextBox_Validating);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(128, 43);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(144, 21);
            this.fullNameTextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.fullNameTextBox, "A character-based name for this user, i.e. \"Bob Jones\" ");
            this.fullNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fullNameTextBox_Validating);
            // 
            // hasagentCheckBox
            // 
            this.hasagentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Hasagent", true));
            this.hasagentCheckBox.Location = new System.Drawing.Point(159, 80);
            this.hasagentCheckBox.Name = "hasagentCheckBox";
            this.hasagentCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hasagentCheckBox.TabIndex = 5;
            this.hasagentCheckBox.Text = "Is Agent";
            this.hasagentCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasdirectoryCheckBox
            // 
            this.hasdirectoryCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Hasdirectory", true));
            this.hasdirectoryCheckBox.Location = new System.Drawing.Point(159, 20);
            this.hasdirectoryCheckBox.Name = "hasdirectoryCheckBox";
            this.hasdirectoryCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hasdirectoryCheckBox.TabIndex = 1;
            this.hasdirectoryCheckBox.Text = "In Directory";
            this.hasdirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasiaxCheckBox
            // 
            this.hasiaxCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Hasiax", true));
            this.hasiaxCheckBox.Location = new System.Drawing.Point(159, 50);
            this.hasiaxCheckBox.Name = "hasiaxCheckBox";
            this.hasiaxCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hasiaxCheckBox.TabIndex = 3;
            this.hasiaxCheckBox.Text = "IAX";
            this.hasiaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasSipCheckBox
            // 
            this.hasSipCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "HasSip", true));
            this.hasSipCheckBox.Location = new System.Drawing.Point(10, 50);
            this.hasSipCheckBox.Name = "hasSipCheckBox";
            this.hasSipCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hasSipCheckBox.TabIndex = 2;
            this.hasSipCheckBox.Text = "SIP";
            this.hasSipCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasVoicemailCheckBox
            // 
            this.hasVoicemailCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "HasVoicemail", true));
            this.hasVoicemailCheckBox.Location = new System.Drawing.Point(11, 20);
            this.hasVoicemailCheckBox.Name = "hasVoicemailCheckBox";
            this.hasVoicemailCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hasVoicemailCheckBox.TabIndex = 0;
            this.hasVoicemailCheckBox.Text = "Voicemail";
            this.hasVoicemailCheckBox.UseVisualStyleBackColor = true;
            // 
            // insecureTextBox
            // 
            this.insecureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Insecure", true));
            this.insecureTextBox.Location = new System.Drawing.Point(106, 201);
            this.insecureTextBox.Name = "insecureTextBox";
            this.insecureTextBox.Size = new System.Drawing.Size(144, 21);
            this.insecureTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(129, 70);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(144, 21);
            this.passwordTextBox.TabIndex = 2;
            // 
            // threeWayCallingCheckBox
            // 
            this.threeWayCallingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "ThreeWayCalling", true));
            this.threeWayCallingCheckBox.Location = new System.Drawing.Point(159, 114);
            this.threeWayCallingCheckBox.Name = "threeWayCallingCheckBox";
            this.threeWayCallingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.threeWayCallingCheckBox.TabIndex = 7;
            this.threeWayCallingCheckBox.Text = "3-Way Calling";
            this.threeWayCallingCheckBox.UseVisualStyleBackColor = true;
            // 
            // vmsecretTextBox
            // 
            this.vmsecretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Vmsecret", true));
            this.vmsecretTextBox.Location = new System.Drawing.Point(129, 97);
            this.vmsecretTextBox.Name = "vmsecretTextBox";
            this.vmsecretTextBox.Size = new System.Drawing.Size(144, 21);
            this.vmsecretTextBox.TabIndex = 3;
            // 
            // zapchanTextBox
            // 
            this.zapchanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userExtensionBindingSource, "Zapchan", true));
            this.zapchanTextBox.Location = new System.Drawing.Point(129, 178);
            this.zapchanTextBox.Name = "zapchanTextBox";
            this.zapchanTextBox.Size = new System.Drawing.Size(144, 21);
            this.zapchanTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dialplanComboBox);
            this.groupBox1.Controls.Add(extensionLabel);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(fullNameLabel);
            this.groupBox1.Controls.Add(this.extensionTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.vmsecretTextBox);
            this.groupBox1.Controls.Add(contextLabel);
            this.groupBox1.Controls.Add(vmsecretLabel);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(cidNumberLabel);
            this.groupBox1.Controls.Add(this.cidNumberTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(zapchanLabel);
            this.groupBox1.Controls.Add(this.zapchanTextBox);
            this.groupBox1.Location = new System.Drawing.Point(357, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Extension";
            // 
            // dialplanComboBox
            // 
            this.dialplanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dialplanComboBox.FormattingEnabled = true;
            this.dialplanComboBox.Location = new System.Drawing.Point(129, 205);
            this.dialplanComboBox.Name = "dialplanComboBox";
            this.dialplanComboBox.Size = new System.Drawing.Size(144, 20);
            this.dialplanComboBox.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.natCheckBox);
            this.groupBox2.Controls.Add(this.hasCTICheckBox);
            this.groupBox2.Controls.Add(this.hasVoicemailCheckBox);
            this.groupBox2.Controls.Add(this.hasdirectoryCheckBox);
            this.groupBox2.Controls.Add(this.hasSipCheckBox);
            this.groupBox2.Controls.Add(this.hasiaxCheckBox);
            this.groupBox2.Controls.Add(this.hasagentCheckBox);
            this.groupBox2.Controls.Add(this.callWaitingCheckBox);
            this.groupBox2.Controls.Add(this.canreinviteCheckBox);
            this.groupBox2.Controls.Add(this.threeWayCallingCheckBox);
            this.groupBox2.Controls.Add(insecureLabel);
            this.groupBox2.Controls.Add(this.insecureTextBox);
            this.groupBox2.Controls.Add(dtmfmodeLabel);
            this.groupBox2.Controls.Add(this.dtmfmodeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(357, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 229);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extension Options";
            // 
            // natCheckBox
            // 
            this.natCheckBox.AutoSize = true;
            this.natCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "Nat", true));
            this.natCheckBox.Location = new System.Drawing.Point(159, 144);
            this.natCheckBox.Name = "natCheckBox";
            this.natCheckBox.Size = new System.Drawing.Size(42, 16);
            this.natCheckBox.TabIndex = 9;
            this.natCheckBox.Text = "NAT";
            this.natCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasCTICheckBox
            // 
            this.hasCTICheckBox.AutoSize = true;
            this.hasCTICheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userExtensionBindingSource, "HasCTI", true));
            this.hasCTICheckBox.Location = new System.Drawing.Point(11, 84);
            this.hasCTICheckBox.Name = "hasCTICheckBox";
            this.hasCTICheckBox.Size = new System.Drawing.Size(42, 16);
            this.hasCTICheckBox.TabIndex = 4;
            this.hasCTICheckBox.Text = "CTI";
            this.hasCTICheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editCodecButton);
            this.groupBox3.Controls.Add(this.disallowTextBox);
            this.groupBox3.Controls.Add(disallowLabel);
            this.groupBox3.Controls.Add(this.allowTextBox);
            this.groupBox3.Controls.Add(allowLabel);
            this.groupBox3.Location = new System.Drawing.Point(357, 537);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Codec";
            // 
            // editCodecButton
            // 
            this.editCodecButton.Location = new System.Drawing.Point(220, 28);
            this.editCodecButton.Name = "editCodecButton";
            this.editCodecButton.Size = new System.Drawing.Size(71, 51);
            this.editCodecButton.TabIndex = 0;
            this.editCodecButton.Text = "&Edit Codec";
            this.editCodecButton.UseVisualStyleBackColor = true;
            this.editCodecButton.Click += new System.EventHandler(this.editCodecButton_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(446, 643);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(566, 643);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(46, 643);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(180, 643);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userExtensionDataGridView);
            this.Controls.Add(this.userExtensionBindingNavigator);
            this.HeaderCaption = "Configure users for asterisk server.";
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.user1_telephone_48_shadow;
            this.HeaderTitle = "Extensions";
            this.Name = "UsersView";
            this.Size = new System.Drawing.Size(680, 678);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingNavigator)).EndInit();
            this.userExtensionBindingNavigator.ResumeLayout(false);
            this.userExtensionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExtensionDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userExtensionBindingSource;
        private System.Windows.Forms.BindingNavigator userExtensionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView userExtensionDataGridView;
        private System.Windows.Forms.TextBox allowTextBox;
        private System.Windows.Forms.CheckBox callWaitingCheckBox;
        private System.Windows.Forms.CheckBox canreinviteCheckBox;
        private System.Windows.Forms.TextBox cidNumberTextBox;
        private System.Windows.Forms.TextBox disallowTextBox;
        private System.Windows.Forms.TextBox dtmfmodeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.CheckBox hasagentCheckBox;
        private System.Windows.Forms.CheckBox hasdirectoryCheckBox;
        private System.Windows.Forms.CheckBox hasiaxCheckBox;
        private System.Windows.Forms.CheckBox hasSipCheckBox;
        private System.Windows.Forms.CheckBox hasVoicemailCheckBox;
        private System.Windows.Forms.TextBox insecureTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox threeWayCallingCheckBox;
        private System.Windows.Forms.TextBox vmsecretTextBox;
        private System.Windows.Forms.TextBox zapchanTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox hasCTICheckBox;
        private System.Windows.Forms.CheckBox natCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button editCodecButton;
        private System.Windows.Forms.ComboBox dialplanComboBox;
    }
}