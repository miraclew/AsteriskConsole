namespace VisualAsterisk.Main.Gui
{
    partial class AsteriskAdminUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsteriskAdminUI));
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAsteriskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAsteriskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.debugOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uITestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.systemPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.asteriskLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMIEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.traceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPermisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dialplanDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSHDiagnosticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configFileEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.systemPanelsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pbxSettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.asteriskOptionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.extensionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            resources.ApplyResources(this.dockPanel, "dockPanel");
            this.dockPanel.Name = "dockPanel";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.MdiWindowListItem = this.windowToolStripMenuItem;
            this.mainMenu.Name = "mainMenu";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAsteriskToolStripMenuItem,
            this.deleteAsteriskToolStripMenuItem,
            this.importSettingsToolStripMenuItem,
            this.exportSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            resources.ApplyResources(this.adminToolStripMenuItem, "adminToolStripMenuItem");
            // 
            // addAsteriskToolStripMenuItem
            // 
            this.addAsteriskToolStripMenuItem.Name = "addAsteriskToolStripMenuItem";
            resources.ApplyResources(this.addAsteriskToolStripMenuItem, "addAsteriskToolStripMenuItem");
            this.addAsteriskToolStripMenuItem.Click += new System.EventHandler(this.addAsteriskToolStripMenuItem_Click);
            // 
            // deleteAsteriskToolStripMenuItem
            // 
            this.deleteAsteriskToolStripMenuItem.Name = "deleteAsteriskToolStripMenuItem";
            resources.ApplyResources(this.deleteAsteriskToolStripMenuItem, "deleteAsteriskToolStripMenuItem");
            this.deleteAsteriskToolStripMenuItem.Click += new System.EventHandler(this.deleteAsteriskToolStripMenuItem_Click);
            // 
            // importSettingsToolStripMenuItem
            // 
            this.importSettingsToolStripMenuItem.Name = "importSettingsToolStripMenuItem";
            resources.ApplyResources(this.importSettingsToolStripMenuItem, "importSettingsToolStripMenuItem");
            // 
            // exportSettingsToolStripMenuItem
            // 
            this.exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            resources.ApplyResources(this.exportSettingsToolStripMenuItem, "exportSettingsToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redoToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator5,
            this.debugOnlyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            // 
            // undoToolStripMenuItem
            // 
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            // 
            // pasteToolStripMenuItem
            // 
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // debugOnlyToolStripMenuItem
            // 
            this.debugOnlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uITestToolStripMenuItem});
            this.debugOnlyToolStripMenuItem.Name = "debugOnlyToolStripMenuItem";
            resources.ApplyResources(this.debugOnlyToolStripMenuItem, "debugOnlyToolStripMenuItem");
            // 
            // uITestToolStripMenuItem
            // 
            this.uITestToolStripMenuItem.Name = "uITestToolStripMenuItem";
            resources.ApplyResources(this.uITestToolStripMenuItem, "uITestToolStripMenuItem");
            this.uITestToolStripMenuItem.Click += new System.EventHandler(this.uITestToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryWindowToolStripMenuItem,
            this.toolStripSeparator1,
            this.systemPanelToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.dialplanToolStripMenuItem,
            this.toolStripSeparator2,
            this.asteriskLogToolStripMenuItem,
            this.cDRToolStripMenuItem,
            this.clusterToolStripMenuItem,
            this.aMIEventToolStripMenuItem,
            this.toolStripSeparator3,
            this.traceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // inventoryWindowToolStripMenuItem
            // 
            this.inventoryWindowToolStripMenuItem.Name = "inventoryWindowToolStripMenuItem";
            resources.ApplyResources(this.inventoryWindowToolStripMenuItem, "inventoryWindowToolStripMenuItem");
            this.inventoryWindowToolStripMenuItem.Click += new System.EventHandler(this.inventoryWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // systemPanelToolStripMenuItem
            // 
            this.systemPanelToolStripMenuItem.Name = "systemPanelToolStripMenuItem";
            resources.ApplyResources(this.systemPanelToolStripMenuItem, "systemPanelToolStripMenuItem");
            this.systemPanelToolStripMenuItem.Click += new System.EventHandler(this.systemPanelToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            resources.ApplyResources(this.configurationToolStripMenuItem, "configurationToolStripMenuItem");
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // dialplanToolStripMenuItem
            // 
            this.dialplanToolStripMenuItem.Name = "dialplanToolStripMenuItem";
            resources.ApplyResources(this.dialplanToolStripMenuItem, "dialplanToolStripMenuItem");
            this.dialplanToolStripMenuItem.Click += new System.EventHandler(this.dialplanToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // asteriskLogToolStripMenuItem
            // 
            this.asteriskLogToolStripMenuItem.Name = "asteriskLogToolStripMenuItem";
            resources.ApplyResources(this.asteriskLogToolStripMenuItem, "asteriskLogToolStripMenuItem");
            // 
            // cDRToolStripMenuItem
            // 
            this.cDRToolStripMenuItem.Name = "cDRToolStripMenuItem";
            resources.ApplyResources(this.cDRToolStripMenuItem, "cDRToolStripMenuItem");
            // 
            // clusterToolStripMenuItem
            // 
            this.clusterToolStripMenuItem.Name = "clusterToolStripMenuItem";
            resources.ApplyResources(this.clusterToolStripMenuItem, "clusterToolStripMenuItem");
            // 
            // aMIEventToolStripMenuItem
            // 
            this.aMIEventToolStripMenuItem.Name = "aMIEventToolStripMenuItem";
            resources.ApplyResources(this.aMIEventToolStripMenuItem, "aMIEventToolStripMenuItem");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // traceToolStripMenuItem
            // 
            this.traceToolStripMenuItem.Name = "traceToolStripMenuItem";
            resources.ApplyResources(this.traceToolStripMenuItem, "traceToolStripMenuItem");
            this.traceToolStripMenuItem.Click += new System.EventHandler(this.traceToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.userPermisionToolStripMenuItem,
            this.toolStripSeparator4,
            this.dialplanDesignerToolStripMenuItem,
            this.sSHDiagnosticToolStripMenuItem,
            this.hardwareDetectorToolStripMenuItem,
            this.configFileEditorToolStripMenuItem,
            this.manageCommandToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            resources.ApplyResources(this.optionToolStripMenuItem, "optionToolStripMenuItem");
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chineseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            resources.ApplyResources(this.chineseToolStripMenuItem, "chineseToolStripMenuItem");
            this.chineseToolStripMenuItem.Click += new System.EventHandler(this.chineseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // userPermisionToolStripMenuItem
            // 
            this.userPermisionToolStripMenuItem.Name = "userPermisionToolStripMenuItem";
            resources.ApplyResources(this.userPermisionToolStripMenuItem, "userPermisionToolStripMenuItem");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // dialplanDesignerToolStripMenuItem
            // 
            this.dialplanDesignerToolStripMenuItem.Name = "dialplanDesignerToolStripMenuItem";
            resources.ApplyResources(this.dialplanDesignerToolStripMenuItem, "dialplanDesignerToolStripMenuItem");
            // 
            // sSHDiagnosticToolStripMenuItem
            // 
            this.sSHDiagnosticToolStripMenuItem.Name = "sSHDiagnosticToolStripMenuItem";
            resources.ApplyResources(this.sSHDiagnosticToolStripMenuItem, "sSHDiagnosticToolStripMenuItem");
            // 
            // hardwareDetectorToolStripMenuItem
            // 
            this.hardwareDetectorToolStripMenuItem.Name = "hardwareDetectorToolStripMenuItem";
            resources.ApplyResources(this.hardwareDetectorToolStripMenuItem, "hardwareDetectorToolStripMenuItem");
            // 
            // configFileEditorToolStripMenuItem
            // 
            this.configFileEditorToolStripMenuItem.Name = "configFileEditorToolStripMenuItem";
            resources.ApplyResources(this.configFileEditorToolStripMenuItem, "configFileEditorToolStripMenuItem");
            // 
            // manageCommandToolStripMenuItem
            // 
            this.manageCommandToolStripMenuItem.Name = "manageCommandToolStripMenuItem";
            resources.ApplyResources(this.manageCommandToolStripMenuItem, "manageCommandToolStripMenuItem");
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            resources.ApplyResources(this.contentToolStripMenuItem, "contentToolStripMenuItem");
            this.contentToolStripMenuItem.Click += new System.EventHandler(this.contentToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdateToolStripMenuItem, "checkForUpdateToolStripMenuItem");
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemPanelsToolStripButton,
            this.pbxSettingsToolStripButton,
            this.asteriskOptionsToolStripButton,
            this.extensionsToolStripButton,
            this.toolsToolStripButton});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // systemPanelsToolStripButton
            // 
            this.systemPanelsToolStripButton.Image = global::VisualAsterisk.Main.Properties.Resources.Graph;
            resources.ApplyResources(this.systemPanelsToolStripButton, "systemPanelsToolStripButton");
            this.systemPanelsToolStripButton.Name = "systemPanelsToolStripButton";
            this.systemPanelsToolStripButton.Click += new System.EventHandler(this.systemPanelsToolStripButton_Click);
            // 
            // pbxSettingsToolStripButton
            // 
            this.pbxSettingsToolStripButton.Image = global::VisualAsterisk.Main.Properties.Resources.Dial;
            resources.ApplyResources(this.pbxSettingsToolStripButton, "pbxSettingsToolStripButton");
            this.pbxSettingsToolStripButton.Name = "pbxSettingsToolStripButton";
            this.pbxSettingsToolStripButton.Click += new System.EventHandler(this.pbxSettingsToolStripButton_Click);
            // 
            // asteriskOptionsToolStripButton
            // 
            resources.ApplyResources(this.asteriskOptionsToolStripButton, "asteriskOptionsToolStripButton");
            this.asteriskOptionsToolStripButton.Name = "asteriskOptionsToolStripButton";
            this.asteriskOptionsToolStripButton.Click += new System.EventHandler(this.asteriskOptionsToolStripButton_Click);
            // 
            // extensionsToolStripButton
            // 
            resources.ApplyResources(this.extensionsToolStripButton, "extensionsToolStripButton");
            this.extensionsToolStripButton.Name = "extensionsToolStripButton";
            this.extensionsToolStripButton.Click += new System.EventHandler(this.extensionsToolStripButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenuStrip;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.DoubleClick += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.abouToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.notifyIconContextMenuStrip.Name = "contextMenuStrip1";
            resources.ApplyResources(this.notifyIconContextMenuStrip, "notifyIconContextMenuStrip");
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.contentToolStripMenuItem_Click);
            // 
            // abouToolStripMenuItem
            // 
            this.abouToolStripMenuItem.Name = "abouToolStripMenuItem";
            resources.ApplyResources(this.abouToolStripMenuItem, "abouToolStripMenuItem");
            this.abouToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripButton
            // 
            resources.ApplyResources(this.toolsToolStripButton, "toolsToolStripButton");
            this.toolsToolStripButton.Name = "toolsToolStripButton";
            this.toolsToolStripButton.Click += new System.EventHandler(this.toolsToolStripButton_Click);
            // 
            // AsteriskAdminUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "AsteriskAdminUI";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.AsteriskAdminUI_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsteriskAdminUI_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPermisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem systemPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem asteriskLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMIEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addAsteriskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAsteriskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialplanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem dialplanDesignerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSHDiagnosticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardwareDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configFileEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traceToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton systemPanelsToolStripButton;
        private System.Windows.Forms.ToolStripButton pbxSettingsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem debugOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uITestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton asteriskOptionsToolStripButton;
        private System.Windows.Forms.ToolStripButton extensionsToolStripButton;
        private System.Windows.Forms.ToolStripButton toolsToolStripButton;
    }
}