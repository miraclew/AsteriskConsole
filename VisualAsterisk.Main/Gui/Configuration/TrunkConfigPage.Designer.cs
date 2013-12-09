namespace VisualAsterisk.Main.Gui.Configuration
{
    partial class TrunkConfigPage
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
            System.Windows.Forms.Label canreinviteLabel;
            System.Windows.Forms.Label cidLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label fromdomainLabel;
            System.Windows.Forms.Label fromuserLabel;
            System.Windows.Forms.Label hostLabel;
            System.Windows.Forms.Label insecureLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label portLabel;
            System.Windows.Forms.Label registerLabel;
            System.Windows.Forms.Label trunknameLabel;
            System.Windows.Forms.Label trunkTechLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label allowLabel;
            System.Windows.Forms.Label disallowLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrunkConfigPage));
            this.trunkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.trunkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trunkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canreinviteCheckBox = new System.Windows.Forms.CheckBox();
            this.cidTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.fromdomainTextBox = new System.Windows.Forms.TextBox();
            this.fromuserTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.insecureTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.registerCheckBox = new System.Windows.Forms.CheckBox();
            this.trunknameTextBox = new System.Windows.Forms.TextBox();
            this.trunkTechTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.disallowTextBox = new System.Windows.Forms.TextBox();
            this.allowTextBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            canreinviteLabel = new System.Windows.Forms.Label();
            cidLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            fromdomainLabel = new System.Windows.Forms.Label();
            fromuserLabel = new System.Windows.Forms.Label();
            hostLabel = new System.Windows.Forms.Label();
            insecureLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            portLabel = new System.Windows.Forms.Label();
            registerLabel = new System.Windows.Forms.Label();
            trunknameLabel = new System.Windows.Forms.Label();
            trunkTechLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            allowLabel = new System.Windows.Forms.Label();
            disallowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingNavigator)).BeginInit();
            this.trunkBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Size = new System.Drawing.Size(531, 32);
            this.descriptionLabel.Text = "Trunks are outbound lines used to allow the system to make calls to the real worl" +
                "d. \r\nTrunks can be VoIP lines or traditional telephony lines.";
            // 
            // canreinviteLabel
            // 
            canreinviteLabel.AutoSize = true;
            canreinviteLabel.Location = new System.Drawing.Point(28, 224);
            canreinviteLabel.Name = "canreinviteLabel";
            canreinviteLabel.Size = new System.Drawing.Size(77, 12);
            canreinviteLabel.TabIndex = 2;
            canreinviteLabel.Text = "Canreinvite:";
            // 
            // cidLabel
            // 
            cidLabel.AutoSize = true;
            cidLabel.Location = new System.Drawing.Point(28, 112);
            cidLabel.Name = "cidLabel";
            cidLabel.Size = new System.Drawing.Size(29, 12);
            cidLabel.TabIndex = 4;
            cidLabel.Text = "Cid:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(20, 25);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(53, 12);
            commentLabel.TabIndex = 8;
            commentLabel.Text = "Comment:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(28, 195);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(53, 12);
            contactLabel.TabIndex = 10;
            contactLabel.Text = "Contact:";
            // 
            // fromdomainLabel
            // 
            fromdomainLabel.AutoSize = true;
            fromdomainLabel.Location = new System.Drawing.Point(28, 141);
            fromdomainLabel.Name = "fromdomainLabel";
            fromdomainLabel.Size = new System.Drawing.Size(71, 12);
            fromdomainLabel.TabIndex = 12;
            fromdomainLabel.Text = "Fromdomain:";
            // 
            // fromuserLabel
            // 
            fromuserLabel.AutoSize = true;
            fromuserLabel.Location = new System.Drawing.Point(28, 168);
            fromuserLabel.Name = "fromuserLabel";
            fromuserLabel.Size = new System.Drawing.Size(59, 12);
            fromuserLabel.TabIndex = 14;
            fromuserLabel.Text = "Fromuser:";
            // 
            // hostLabel
            // 
            hostLabel.AutoSize = true;
            hostLabel.Location = new System.Drawing.Point(20, 107);
            hostLabel.Name = "hostLabel";
            hostLabel.Size = new System.Drawing.Size(35, 12);
            hostLabel.TabIndex = 16;
            hostLabel.Text = "Host:";
            // 
            // insecureLabel
            // 
            insecureLabel.AutoSize = true;
            insecureLabel.Location = new System.Drawing.Point(28, 58);
            insecureLabel.Name = "insecureLabel";
            insecureLabel.Size = new System.Drawing.Size(59, 12);
            insecureLabel.TabIndex = 18;
            insecureLabel.Text = "Insecure:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(20, 164);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(59, 12);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Password:";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new System.Drawing.Point(28, 85);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(35, 12);
            portLabel.TabIndex = 22;
            portLabel.Text = "Port:";
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Location = new System.Drawing.Point(20, 79);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new System.Drawing.Size(59, 12);
            registerLabel.TabIndex = 24;
            registerLabel.Text = "Register:";
            // 
            // trunknameLabel
            // 
            trunknameLabel.AutoSize = true;
            trunknameLabel.Location = new System.Drawing.Point(28, 31);
            trunknameLabel.Name = "trunknameLabel";
            trunknameLabel.Size = new System.Drawing.Size(65, 12);
            trunknameLabel.TabIndex = 26;
            trunknameLabel.Text = "Trunkname:";
            // 
            // trunkTechLabel
            // 
            trunkTechLabel.AutoSize = true;
            trunkTechLabel.Location = new System.Drawing.Point(20, 54);
            trunkTechLabel.Name = "trunkTechLabel";
            trunkTechLabel.Size = new System.Drawing.Size(71, 12);
            trunkTechLabel.TabIndex = 28;
            trunkTechLabel.Text = "Trunk Tech:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(20, 134);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(59, 12);
            usernameLabel.TabIndex = 30;
            usernameLabel.Text = "Username:";
            // 
            // allowLabel
            // 
            allowLabel.AutoSize = true;
            allowLabel.Location = new System.Drawing.Point(47, 81);
            allowLabel.Name = "allowLabel";
            allowLabel.Size = new System.Drawing.Size(41, 12);
            allowLabel.TabIndex = 7;
            allowLabel.Text = "Allow:";
            // 
            // disallowLabel
            // 
            disallowLabel.AutoSize = true;
            disallowLabel.Location = new System.Drawing.Point(29, 35);
            disallowLabel.Name = "disallowLabel";
            disallowLabel.Size = new System.Drawing.Size(59, 12);
            disallowLabel.TabIndex = 8;
            disallowLabel.Text = "Disallow:";
            // 
            // trunkBindingNavigator
            // 
            this.trunkBindingNavigator.AddNewItem = null;
            this.trunkBindingNavigator.BindingSource = this.trunkBindingSource;
            this.trunkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trunkBindingNavigator.DeleteItem = null;
            this.trunkBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.trunkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.trunkBindingNavigator.Location = new System.Drawing.Point(9, 51);
            this.trunkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trunkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trunkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trunkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trunkBindingNavigator.Name = "trunkBindingNavigator";
            this.trunkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trunkBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.trunkBindingNavigator.TabIndex = 0;
            this.trunkBindingNavigator.Text = "bindingNavigator1";
            // 
            // trunkBindingSource
            // 
            this.trunkBindingSource.AllowNew = true;
            this.trunkBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.Trunk);
            this.trunkBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.trunkBindingSource_AddingNew);
            this.trunkBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.trunkBindingSource_ListChanged);
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
            // trunkDataGridView
            // 
            this.trunkDataGridView.AllowUserToAddRows = false;
            this.trunkDataGridView.AllowUserToDeleteRows = false;
            this.trunkDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.trunkDataGridView.AutoGenerateColumns = false;
            this.trunkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trunkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Username,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.trunkDataGridView.DataSource = this.trunkBindingSource;
            this.trunkDataGridView.Location = new System.Drawing.Point(9, 80);
            this.trunkDataGridView.Name = "trunkDataGridView";
            this.trunkDataGridView.ReadOnly = true;
            this.trunkDataGridView.RowTemplate.Height = 23;
            this.trunkDataGridView.Size = new System.Drawing.Size(517, 303);
            this.trunkDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TrunkTech";
            this.dataGridViewTextBoxColumn1.HeaderText = "Trunk Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Host";
            this.dataGridViewTextBoxColumn3.HeaderText = "Host";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn2.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Register";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Register";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // canreinviteCheckBox
            // 
            this.canreinviteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.trunkBindingSource, "Canreinvite", true));
            this.canreinviteCheckBox.Location = new System.Drawing.Point(111, 219);
            this.canreinviteCheckBox.Name = "canreinviteCheckBox";
            this.canreinviteCheckBox.Size = new System.Drawing.Size(104, 24);
            this.canreinviteCheckBox.TabIndex = 7;
            this.canreinviteCheckBox.UseVisualStyleBackColor = true;
            // 
            // cidTextBox
            // 
            this.cidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Cid", true));
            this.cidTextBox.Location = new System.Drawing.Point(111, 109);
            this.cidTextBox.Name = "cidTextBox";
            this.cidTextBox.Size = new System.Drawing.Size(156, 21);
            this.cidTextBox.TabIndex = 3;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(103, 22);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(153, 21);
            this.commentTextBox.TabIndex = 0;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(111, 192);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(156, 21);
            this.contactTextBox.TabIndex = 6;
            // 
            // fromdomainTextBox
            // 
            this.fromdomainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Fromdomain", true));
            this.fromdomainTextBox.Location = new System.Drawing.Point(111, 138);
            this.fromdomainTextBox.Name = "fromdomainTextBox";
            this.fromdomainTextBox.Size = new System.Drawing.Size(156, 21);
            this.fromdomainTextBox.TabIndex = 4;
            // 
            // fromuserTextBox
            // 
            this.fromuserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Fromuser", true));
            this.fromuserTextBox.Location = new System.Drawing.Point(111, 165);
            this.fromuserTextBox.Name = "fromuserTextBox";
            this.fromuserTextBox.Size = new System.Drawing.Size(156, 21);
            this.fromuserTextBox.TabIndex = 5;
            // 
            // hostTextBox
            // 
            this.hostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Host", true));
            this.hostTextBox.Location = new System.Drawing.Point(103, 104);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(153, 21);
            this.hostTextBox.TabIndex = 3;
            // 
            // insecureTextBox
            // 
            this.insecureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Insecure", true));
            this.insecureTextBox.Location = new System.Drawing.Point(111, 55);
            this.insecureTextBox.Name = "insecureTextBox";
            this.insecureTextBox.Size = new System.Drawing.Size(156, 21);
            this.insecureTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(103, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(153, 21);
            this.passwordTextBox.TabIndex = 5;
            // 
            // portTextBox
            // 
            this.portTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Port", true));
            this.portTextBox.Location = new System.Drawing.Point(111, 82);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(156, 21);
            this.portTextBox.TabIndex = 2;
            // 
            // registerCheckBox
            // 
            this.registerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.trunkBindingSource, "Register", true));
            this.registerCheckBox.Location = new System.Drawing.Point(103, 74);
            this.registerCheckBox.Name = "registerCheckBox";
            this.registerCheckBox.Size = new System.Drawing.Size(153, 24);
            this.registerCheckBox.TabIndex = 2;
            this.registerCheckBox.UseVisualStyleBackColor = true;
            // 
            // trunknameTextBox
            // 
            this.trunknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Trunkname", true));
            this.trunknameTextBox.Location = new System.Drawing.Point(111, 28);
            this.trunknameTextBox.Name = "trunknameTextBox";
            this.trunknameTextBox.Size = new System.Drawing.Size(156, 21);
            this.trunknameTextBox.TabIndex = 0;
            // 
            // trunkTechTextBox
            // 
            this.trunkTechTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "TrunkTech", true));
            this.trunkTechTextBox.Location = new System.Drawing.Point(103, 51);
            this.trunkTechTextBox.Name = "trunkTechTextBox";
            this.trunkTechTextBox.Size = new System.Drawing.Size(153, 21);
            this.trunkTechTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(103, 131);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(153, 21);
            this.usernameTextBox.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(539, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 343);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commentTextBox);
            this.tabPage1.Controls.Add(commentLabel);
            this.tabPage1.Controls.Add(this.trunkTechTextBox);
            this.tabPage1.Controls.Add(passwordLabel);
            this.tabPage1.Controls.Add(trunkTechLabel);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(registerLabel);
            this.tabPage1.Controls.Add(usernameLabel);
            this.tabPage1.Controls.Add(this.registerCheckBox);
            this.tabPage1.Controls.Add(this.usernameTextBox);
            this.tabPage1.Controls.Add(this.hostTextBox);
            this.tabPage1.Controls.Add(hostLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trunk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(trunknameLabel);
            this.tabPage2.Controls.Add(this.trunknameTextBox);
            this.tabPage2.Controls.Add(this.insecureTextBox);
            this.tabPage2.Controls.Add(fromuserLabel);
            this.tabPage2.Controls.Add(canreinviteLabel);
            this.tabPage2.Controls.Add(this.fromdomainTextBox);
            this.tabPage2.Controls.Add(insecureLabel);
            this.tabPage2.Controls.Add(this.fromuserTextBox);
            this.tabPage2.Controls.Add(this.canreinviteCheckBox);
            this.tabPage2.Controls.Add(fromdomainLabel);
            this.tabPage2.Controls.Add(this.portTextBox);
            this.tabPage2.Controls.Add(this.contactTextBox);
            this.tabPage2.Controls.Add(cidLabel);
            this.tabPage2.Controls.Add(this.cidTextBox);
            this.tabPage2.Controls.Add(portLabel);
            this.tabPage2.Controls.Add(contactLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(disallowLabel);
            this.tabPage3.Controls.Add(this.disallowTextBox);
            this.tabPage3.Controls.Add(allowLabel);
            this.tabPage3.Controls.Add(this.allowTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(323, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Codec";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // disallowTextBox
            // 
            this.disallowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Disallow", true));
            this.disallowTextBox.Location = new System.Drawing.Point(94, 32);
            this.disallowTextBox.Name = "disallowTextBox";
            this.disallowTextBox.Size = new System.Drawing.Size(171, 21);
            this.disallowTextBox.TabIndex = 0;
            // 
            // allowTextBox
            // 
            this.allowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trunkBindingSource, "Allow", true));
            this.allowTextBox.Location = new System.Drawing.Point(94, 78);
            this.allowTextBox.Name = "allowTextBox";
            this.allowTextBox.Size = new System.Drawing.Size(171, 21);
            this.allowTextBox.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(183, 408);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(49, 408);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(711, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(591, 408);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // TrunkConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 457);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.trunkDataGridView);
            this.Controls.Add(this.trunkBindingNavigator);
            this.Name = "TrunkConfigPage";
            this.TabText = "Trunks";
            this.Text = "Trunks";
            this.Controls.SetChildIndex(this.trunkBindingNavigator, 0);
            this.Controls.SetChildIndex(this.trunkDataGridView, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingNavigator)).EndInit();
            this.trunkBindingNavigator.ResumeLayout(false);
            this.trunkBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource trunkBindingSource;
        private System.Windows.Forms.BindingNavigator trunkBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView trunkDataGridView;
        private System.Windows.Forms.CheckBox canreinviteCheckBox;
        private System.Windows.Forms.TextBox cidTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox fromdomainTextBox;
        private System.Windows.Forms.TextBox fromuserTextBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox insecureTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.CheckBox registerCheckBox;
        private System.Windows.Forms.TextBox trunknameTextBox;
        private System.Windows.Forms.TextBox trunkTechTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox disallowTextBox;
        private System.Windows.Forms.TextBox allowTextBox;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;

    }
}