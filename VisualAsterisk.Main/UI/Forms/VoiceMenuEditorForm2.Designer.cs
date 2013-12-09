namespace VisualAsterisk.Main.UI.Forms
{
    partial class VoiceMenuEditorForm2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actionsDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid();
            this.voiceMenuActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new IC.Controls.SmoothLabel();
            this.label2 = new IC.Controls.SmoothLabel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.voiceMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new IC.Controls.SmoothLabel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.smoothLabel1 = new IC.Controls.SmoothLabel();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.addNewActionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectedActionLabel = new IC.Controls.SmoothLabel();
            this.argTextBox1 = new System.Windows.Forms.TextBox();
            this.arg2Label = new System.Windows.Forms.Label();
            this.argTextBox2 = new System.Windows.Forms.TextBox();
            this.argComboBox1 = new System.Windows.Forms.ComboBox();
            this.argComboBox2 = new System.Windows.Forms.ComboBox();
            this.addNewActionButton = new System.Windows.Forms.Button();
            this.cancelNewActionButton = new System.Windows.Forms.Button();
            this.stepHelpTextLabel = new System.Windows.Forms.Label();
            this.chooseStepPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.smoothLabel2 = new IC.Controls.SmoothLabel();
            this.allowKeyPressEventsCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.keyPressEventsDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyPressEventEditColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.keyPressEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.actionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveDownColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.moveUpColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceMenuActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceMenuBindingSource)).BeginInit();
            this.addNewActionPanel.SuspendLayout();
            this.chooseStepPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyPressEventsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPressEventBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.actionsDataGrid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.smoothLabel1);
            this.panel1.Controls.Add(this.textBoxExtension);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 236);
            this.panel1.TabIndex = 0;
            // 
            // actionsDataGrid
            // 
            this.actionsDataGrid.AllowUserToAddRows = false;
            this.actionsDataGrid.AllowUserToDeleteRows = false;
            this.actionsDataGrid.AllowUserToResizeRows = false;
            this.actionsDataGrid.AutoGenerateColumns = false;
            this.actionsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.actionsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actionsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.actionsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actionsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.actionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.moveDownColumn,
            this.moveUpColumn,
            this.deleteColumn});
            this.actionsDataGrid.DataSource = this.voiceMenuActionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.actionsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.actionsDataGrid.Location = new System.Drawing.Point(62, 68);
            this.actionsDataGrid.Name = "actionsDataGrid";
            this.actionsDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actionsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.actionsDataGrid.RowHeadersVisible = false;
            this.actionsDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.actionsDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.actionsDataGrid.RowTemplate.Height = 32;
            this.actionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actionsDataGrid.Size = new System.Drawing.Size(509, 162);
            this.actionsDataGrid.TabIndex = 42;
            this.actionsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.actionsDataGrid_CellContentClick);
            // 
            // voiceMenuActionBindingSource
            // 
            this.voiceMenuActionBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep.VoiceMenuAction);
            // 
            // label4
            // 
            this.label4.AntiAliasText = false;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.EnableHelp = true;
            this.label4.HelpText = "A sequence of actions performed when a call enters the menu.";
            this.label4.HelpTitle = "Actions:\r\n";
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Actions:";
            // 
            // label2
            // 
            this.label2.AntiAliasText = false;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.EnableHelp = true;
            this.label2.HelpText = "A name for the Voice Menu";
            this.label2.HelpTitle = "Name:";
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name:";
            // 
            // checkBox3
            // 
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.voiceMenuBindingSource, "DialOtherAllowed", true));
            this.checkBox3.Location = new System.Drawing.Point(62, 36);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(17, 26);
            this.checkBox3.TabIndex = 33;
            this.checkBox3.Text = "Allow Dialing other Extensions? ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // voiceMenuBindingSource
            // 
            this.voiceMenuBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.VoiceMenu);
            // 
            // label3
            // 
            this.label3.AntiAliasText = false;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.EnableHelp = true;
            this.label3.HelpText = "If you want this Voicemenu to be accessible by dialing an extension, then enter t" +
                "hat extension number\r\n";
            this.label3.HelpTitle = "Extension(optional):";
            this.label3.Location = new System.Drawing.Point(233, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Extension:";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMenuBindingSource, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(62, 11);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(114, 21);
            this.textBoxName.TabIndex = 31;
            // 
            // smoothLabel1
            // 
            this.smoothLabel1.AntiAliasText = false;
            this.smoothLabel1.AutoSize = true;
            this.smoothLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smoothLabel1.EnableHelp = true;
            this.smoothLabel1.HelpText = "Is the caller allowed to dial extensions other than the ones explicitly defined\r\n" +
                "";
            this.smoothLabel1.HelpTitle = "Dial other Extensions:";
            this.smoothLabel1.Location = new System.Drawing.Point(85, 42);
            this.smoothLabel1.Name = "smoothLabel1";
            this.smoothLabel1.Size = new System.Drawing.Size(210, 13);
            this.smoothLabel1.TabIndex = 34;
            this.smoothLabel1.Text = "Allow Dialing other Extensions? ";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voiceMenuBindingSource, "Extension", true));
            this.textBoxExtension.Location = new System.Drawing.Point(310, 11);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(123, 21);
            this.textBoxExtension.TabIndex = 35;
            // 
            // addNewActionPanel
            // 
            this.addNewActionPanel.Controls.Add(this.selectedActionLabel);
            this.addNewActionPanel.Controls.Add(this.argTextBox1);
            this.addNewActionPanel.Controls.Add(this.arg2Label);
            this.addNewActionPanel.Controls.Add(this.argTextBox2);
            this.addNewActionPanel.Controls.Add(this.argComboBox1);
            this.addNewActionPanel.Controls.Add(this.argComboBox2);
            this.addNewActionPanel.Controls.Add(this.addNewActionButton);
            this.addNewActionPanel.Controls.Add(this.cancelNewActionButton);
            this.addNewActionPanel.Controls.Add(this.stepHelpTextLabel);
            this.addNewActionPanel.Location = new System.Drawing.Point(3, 294);
            this.addNewActionPanel.Name = "addNewActionPanel";
            this.addNewActionPanel.Size = new System.Drawing.Size(561, 72);
            this.addNewActionPanel.TabIndex = 43;
            this.addNewActionPanel.Visible = false;
            // 
            // selectedActionLabel
            // 
            this.selectedActionLabel.AntiAliasText = false;
            this.selectedActionLabel.AutoSize = true;
            this.selectedActionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectedActionLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectedActionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.selectedActionLabel.Location = new System.Drawing.Point(3, 0);
            this.selectedActionLabel.Name = "selectedActionLabel";
            this.selectedActionLabel.Size = new System.Drawing.Size(127, 14);
            this.selectedActionLabel.TabIndex = 31;
            this.selectedActionLabel.Text = "selected action";
            this.selectedActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // argTextBox1
            // 
            this.argTextBox1.Location = new System.Drawing.Point(136, 3);
            this.argTextBox1.Name = "argTextBox1";
            this.argTextBox1.Size = new System.Drawing.Size(100, 21);
            this.argTextBox1.TabIndex = 35;
            // 
            // arg2Label
            // 
            this.arg2Label.AutoSize = true;
            this.arg2Label.Location = new System.Drawing.Point(242, 0);
            this.arg2Label.Name = "arg2Label";
            this.arg2Label.Size = new System.Drawing.Size(41, 12);
            this.arg2Label.TabIndex = 36;
            this.arg2Label.Text = "label1";
            // 
            // argTextBox2
            // 
            this.argTextBox2.Location = new System.Drawing.Point(289, 3);
            this.argTextBox2.Name = "argTextBox2";
            this.argTextBox2.Size = new System.Drawing.Size(100, 21);
            this.argTextBox2.TabIndex = 38;
            // 
            // argComboBox1
            // 
            this.argComboBox1.FormattingEnabled = true;
            this.argComboBox1.Location = new System.Drawing.Point(395, 3);
            this.argComboBox1.Name = "argComboBox1";
            this.argComboBox1.Size = new System.Drawing.Size(157, 20);
            this.argComboBox1.TabIndex = 37;
            // 
            // argComboBox2
            // 
            this.argComboBox2.FormattingEnabled = true;
            this.argComboBox2.Location = new System.Drawing.Point(3, 30);
            this.argComboBox2.Name = "argComboBox2";
            this.argComboBox2.Size = new System.Drawing.Size(233, 20);
            this.argComboBox2.TabIndex = 39;
            // 
            // addNewActionButton
            // 
            this.addNewActionButton.Location = new System.Drawing.Point(242, 30);
            this.addNewActionButton.Name = "addNewActionButton";
            this.addNewActionButton.Size = new System.Drawing.Size(75, 23);
            this.addNewActionButton.TabIndex = 32;
            this.addNewActionButton.Text = "&Add";
            this.addNewActionButton.UseVisualStyleBackColor = true;
            this.addNewActionButton.Click += new System.EventHandler(this.addNewActionButton_Click);
            // 
            // cancelNewActionButton
            // 
            this.cancelNewActionButton.Location = new System.Drawing.Point(323, 30);
            this.cancelNewActionButton.Name = "cancelNewActionButton";
            this.cancelNewActionButton.Size = new System.Drawing.Size(75, 23);
            this.cancelNewActionButton.TabIndex = 33;
            this.cancelNewActionButton.Text = "&Cancel";
            this.cancelNewActionButton.UseVisualStyleBackColor = true;
            this.cancelNewActionButton.Click += new System.EventHandler(this.cancelNewActionButton_Click);
            // 
            // stepHelpTextLabel
            // 
            this.stepHelpTextLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepHelpTextLabel.ForeColor = System.Drawing.Color.Gray;
            this.stepHelpTextLabel.Location = new System.Drawing.Point(3, 56);
            this.stepHelpTextLabel.Name = "stepHelpTextLabel";
            this.stepHelpTextLabel.Size = new System.Drawing.Size(549, 45);
            this.stepHelpTextLabel.TabIndex = 34;
            this.stepHelpTextLabel.Text = "label1";
            // 
            // chooseStepPanel
            // 
            this.chooseStepPanel.Controls.Add(this.label5);
            this.chooseStepPanel.Controls.Add(this.comboBox1);
            this.chooseStepPanel.Location = new System.Drawing.Point(3, 258);
            this.chooseStepPanel.Name = "chooseStepPanel";
            this.chooseStepPanel.Size = new System.Drawing.Size(561, 30);
            this.chooseStepPanel.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "Choose a step";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 20);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // smoothLabel2
            // 
            this.smoothLabel2.AntiAliasText = false;
            this.smoothLabel2.AutoSize = true;
            this.smoothLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smoothLabel2.EnableHelp = true;
            this.smoothLabel2.HelpText = "Add new action";
            this.smoothLabel2.HelpTitle = "New action:";
            this.smoothLabel2.Location = new System.Drawing.Point(3, 242);
            this.smoothLabel2.Name = "smoothLabel2";
            this.smoothLabel2.Size = new System.Drawing.Size(108, 13);
            this.smoothLabel2.TabIndex = 39;
            this.smoothLabel2.Text = "Add new action:";
            // 
            // allowKeyPressEventsCheckBox
            // 
            this.allowKeyPressEventsCheckBox.AutoSize = true;
            this.allowKeyPressEventsCheckBox.Location = new System.Drawing.Point(3, 372);
            this.allowKeyPressEventsCheckBox.Name = "allowKeyPressEventsCheckBox";
            this.allowKeyPressEventsCheckBox.Size = new System.Drawing.Size(144, 16);
            this.allowKeyPressEventsCheckBox.TabIndex = 37;
            this.allowKeyPressEventsCheckBox.Text = "Show KeyPress Events";
            this.allowKeyPressEventsCheckBox.UseVisualStyleBackColor = true;
            this.allowKeyPressEventsCheckBox.CheckedChanged += new System.EventHandler(this.allowKeyPressEventsCheckBox_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.smoothLabel2);
            this.flowLayoutPanel1.Controls.Add(this.chooseStepPanel);
            this.flowLayoutPanel1.Controls.Add(this.addNewActionPanel);
            this.flowLayoutPanel1.Controls.Add(this.allowKeyPressEventsCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(576, 547);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.keyPressEventsDataGrid);
            this.panel2.Location = new System.Drawing.Point(583, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 200);
            this.panel2.TabIndex = 1;
            // 
            // keyPressEventsDataGrid
            // 
            this.keyPressEventsDataGrid.AllowUserToAddRows = false;
            this.keyPressEventsDataGrid.AllowUserToDeleteRows = false;
            this.keyPressEventsDataGrid.AllowUserToResizeRows = false;
            this.keyPressEventsDataGrid.AutoGenerateColumns = false;
            this.keyPressEventsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.keyPressEventsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyPressEventsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.keyPressEventsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.keyPressEventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyPressEventsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.actionDataGridViewTextBoxColumn,
            this.keyPressEventEditColumn});
            this.keyPressEventsDataGrid.DataSource = this.keyPressEventBindingSource;
            this.keyPressEventsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyPressEventsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.keyPressEventsDataGrid.Name = "keyPressEventsDataGrid";
            this.keyPressEventsDataGrid.ReadOnly = true;
            this.keyPressEventsDataGrid.RowHeadersVisible = false;
            this.keyPressEventsDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.keyPressEventsDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.keyPressEventsDataGrid.RowTemplate.Height = 32;
            this.keyPressEventsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.keyPressEventsDataGrid.Size = new System.Drawing.Size(562, 200);
            this.keyPressEventsDataGrid.TabIndex = 0;
            this.keyPressEventsDataGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.keyPressEventsDataGrid_CellLeave);
            this.keyPressEventsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.keyPressEventsDataGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KeyPressEventColumnDisplay";
            this.dataGridViewTextBoxColumn2.HeaderText = "Event";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OptionsColumnDisplay";
            this.dataGridViewTextBoxColumn3.HeaderText = "OptionsColumnDisplay";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDataGridViewTextBoxColumn.Visible = false;
            // 
            // keyPressEventEditColumn
            // 
            this.keyPressEventEditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.keyPressEventEditColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.keyPressEventEditColumn.Name = "keyPressEventEditColumn";
            this.keyPressEventEditColumn.ReadOnly = true;
            this.keyPressEventEditColumn.Text = "Update";
            this.keyPressEventEditColumn.TrackVisitedState = false;
            this.keyPressEventEditColumn.UseColumnTextForLinkValue = true;
            this.keyPressEventEditColumn.Width = 5;
            // 
            // keyPressEventBindingSource
            // 
            this.keyPressEventBindingSource.DataSource = typeof(VisualAsterisk.Main.UI.Forms.VoiceMenuActionItem);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 48);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.cancelButton);
            this.panel5.Controls.Add(this.okButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 595);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(576, 51);
            this.panel5.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(480, 16);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(367, 16);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // actionColumn
            // 
            this.actionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actionColumn.DataPropertyName = "DisplayText";
            this.actionColumn.HeaderText = "Action";
            this.actionColumn.Name = "actionColumn";
            this.actionColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // moveDownColumn
            // 
            this.moveDownColumn.Image = global::VisualAsterisk.Main.Properties.Resources.downarrow;
            this.moveDownColumn.Name = "moveDownColumn";
            this.moveDownColumn.ReadOnly = true;
            this.moveDownColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.moveDownColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.moveDownColumn.ToolTipText = "Move down the action";
            this.moveDownColumn.Width = 20;
            // 
            // moveUpColumn
            // 
            this.moveUpColumn.Image = global::VisualAsterisk.Main.Properties.Resources.uparrow;
            this.moveUpColumn.Name = "moveUpColumn";
            this.moveUpColumn.ReadOnly = true;
            this.moveUpColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.moveUpColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.moveUpColumn.ToolTipText = "Move up the action";
            this.moveUpColumn.Width = 20;
            // 
            // deleteColumn
            // 
            this.deleteColumn.Image = global::VisualAsterisk.Main.Properties.Resources.delete_16;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.ToolTipText = "Remove the action";
            this.deleteColumn.Width = 20;
            // 
            // VoiceMenuEditorForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 646);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "VoiceMenuEditorForm2";
            this.Text = "VoiceMenuEditorForm2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceMenuActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceMenuBindingSource)).EndInit();
            this.addNewActionPanel.ResumeLayout(false);
            this.addNewActionPanel.PerformLayout();
            this.chooseStepPanel.ResumeLayout(false);
            this.chooseStepPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyPressEventsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPressEventBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private IC.Controls.SmoothLabel label2;
        private System.Windows.Forms.CheckBox allowKeyPressEventsCheckBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private IC.Controls.SmoothLabel label3;
        private System.Windows.Forms.TextBox textBoxName;
        private IC.Controls.SmoothLabel smoothLabel1;
        private System.Windows.Forms.TextBox textBoxExtension;
        private VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid actionsDataGrid;
        private System.Windows.Forms.Button cancelNewActionButton;
        private System.Windows.Forms.Button addNewActionButton;
        private IC.Controls.SmoothLabel selectedActionLabel;
        private System.Windows.Forms.Panel chooseStepPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private IC.Controls.SmoothLabel label4;
        private IC.Controls.SmoothLabel smoothLabel2;
        protected System.Windows.Forms.Button cancelButton;
        protected System.Windows.Forms.Button okButton;
        private System.Windows.Forms.BindingSource voiceMenuActionBindingSource;
        private System.Windows.Forms.BindingSource voiceMenuBindingSource;
        private System.Windows.Forms.BindingSource keyPressEventBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyPressEventColumnDisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionsColumnDisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendlyStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel addNewActionPanel;
        private System.Windows.Forms.Label stepHelpTextLabel;
        private System.Windows.Forms.Panel panel2;
        private VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid keyPressEventsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn keyPressEventEditColumn;
        private System.Windows.Forms.TextBox argTextBox1;
        private System.Windows.Forms.Label arg2Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox argComboBox1;
        private System.Windows.Forms.TextBox argTextBox2;
        private System.Windows.Forms.ComboBox argComboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn moveDownColumn;
        private System.Windows.Forms.DataGridViewImageColumn moveUpColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}