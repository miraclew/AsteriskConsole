using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.Controller;
using WeifenLuo.WinFormsUI.Docking;
using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Main.Gui.PbxPanel;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Main.Gui.Log;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui
{
    public partial class AsteriskAdminUI : AsteriskUIBase
    {
        private const string PbxSettingsView = "Pbx Settings";
        private const string SystemPanelsView = "System Panels";
        private const string AsteriskOptionsView = "Asterisk Options";
        private const string ExtensionsView = "Extensions";
        private const string ToolsView = "ToolsView";
        private string activeView;
        private List<DockPage> activeViewPages;
        private InventoryControl inventoryWindow = new InventoryControl();
        private TraceWindow traceWindow = new TraceWindow();
        private AsteriskOptions asteriskOptions = new AsteriskOptions();

        private List<DockPage> configPages = new List<DockPage>();
        private List<DockPage> systemPanels = new List<DockPage>();
        private List<DockPage> extensionPages = new List<DockPage>();
        private List<DockPage> toolsPages = new List<DockPage>();
        private List<DockPage> allPages = new List<DockPage>();

        public AsteriskAdminUI()
        {
            InitializeComponent();
            this.dockPanel.SuspendLayout(true);

            inventoryWindow.AsteriskSelectChanged += new EventHandler<AsteriskSelectChangedEventArg>(inventoryWindow_AsteriskSelectChanged);
            inventoryWindow.Show(dockPanel, DockState.DockLeft);
            configPages.AddRange(new DockPage[] {
                new CallingRulesConfigPage(),
                new IncomingCallRulesConfigPage(),new VoiceMenusConfigPage(),
                new RingGroupsConfigPage(), new TrunkConfigPage()
                });

            extensionPages.AddRange(new DockPage[] {
                new UsersConfigPage(), new CallQueuesConfigPage(),
                new ConferencingConfigPage()
                });

            systemPanels.AddRange(new DockPage[] {
                new OperatorPanel(), new ChannelPanel(), new SystemInfo2()
            });

            toolsPages.AddRange(new DockPage[] {
                new ManagerCommandLine(),new RecordVoiceMenu(), new Hardware(),
                new BackupForm(), new AsteriskLogs()
            });

            allPages.AddRange(configPages);
            allPages.AddRange(extensionPages);
            allPages.AddRange(systemPanels);
            allPages.AddRange(toolsPages);
            allPages.Add(asteriskOptions);

            foreach (DockPage item in allPages)
            {
                item.HideOnClose = true;
            }
            dockPanel.ResumeLayout(true, true);

            changeView(SystemPanelsView);
        }

        void inventoryWindow_AsteriskSelectChanged(object sender, AsteriskSelectChangedEventArg e)
        {
            if (e.AsteriskController.Server.IsConnected())
            {
                foreach (DockPage page in allPages)
                {
                    page.Server = e.AsteriskController.Server;
                }
            }
        }

        protected override void initAsteriskControllers()
        {
            inventoryWindow.AsteriskControllers = asteriskControllers;
        }

        private void AsteriskAdminUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (AsteriskController c in asteriskControllers)
            {
                c.Disconnect();
            }
        }

        private void changeView(string view)
        {            
            if (activeView == view)
            {
                return;
            }
            this.dockPanel.SuspendLayout(true);

            if (activeViewPages != null)
            {
                foreach (DockPage page in activeViewPages)
                {
                    page.Hide();
                }
            }


            if (view == SystemPanelsView)
            {
                activeViewPages = systemPanels;
                this.systemPanelToolStripMenuItem.Checked = true;
                this.systemPanelsToolStripButton.Checked = true;
                this.configurationToolStripMenuItem.Checked = false;
                this.pbxSettingsToolStripButton.Checked = false;
            }
            else if (view == PbxSettingsView)
            {
                activeViewPages = configPages;
                this.configurationToolStripMenuItem.Checked = true;
                this.pbxSettingsToolStripButton.Checked = true;
                this.systemPanelToolStripMenuItem.Checked = false;
                this.systemPanelsToolStripButton.Checked = false;
            }
            else if (view == AsteriskOptionsView)
            {
                activeViewPages = new List<DockPage>();
                activeViewPages.Add(asteriskOptions);
                this.configurationToolStripMenuItem.Checked = false;
                this.pbxSettingsToolStripButton.Checked = false;
                this.systemPanelToolStripMenuItem.Checked = false;
                this.systemPanelsToolStripButton.Checked = false;

            }
            else if (view == ExtensionsView)
            {
                activeViewPages = extensionPages;
            }
            else if (view == ToolsView)
            {
                activeViewPages = toolsPages;
            }

            foreach (DockPage page in activeViewPages)
            {
                page.Show(dockPanel,  DockState.Document);
            }
            dockPanel.ResumeLayout(true, true);
            activeView = view;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #region Menu Admin
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void addAsteriskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryWindow.AddAsterisk();
        }

        private void deleteAsteriskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryWindow.DeleteAsterisk();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Menu View

        private void systemPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeView(SystemPanelsView);
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeView(PbxSettingsView);
        }

        private void inventoryWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryWindow.Show(dockPanel);
        }

        private void dialplanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void traceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            traceWindow.Show(dockPanel, DockState.DockBottomAutoHide);
        }
        #endregion

        #region Menu Help
        private void contentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "VisualAsterisk.chm");
        }
        #endregion

        private void systemPanelsToolStripButton_Click(object sender, EventArgs e)
        {
            changeView(SystemPanelsView);
        }

        private void pbxSettingsToolStripButton_Click(object sender, EventArgs e)
        {
            changeView(PbxSettingsView);
        }

        #region debug only
        private void uITestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "VisualAsterisk.Test.exe";
            process.Start();
        }
        #endregion

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyCultureInfo("zh-CHS");
            englishToolStripMenuItem.Checked = false;
            chineseToolStripMenuItem.Checked = !englishToolStripMenuItem.Checked;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyCultureInfo("");
            englishToolStripMenuItem.Checked = true;
            chineseToolStripMenuItem.Checked = !englishToolStripMenuItem.Checked;
        }

        private void applyCultureInfo(string cluture)
        {
            this.WindowState = FormWindowState.Minimized;
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(cluture);
            ComponentResourceManager res = new ComponentResourceManager(typeof(AsteriskAdminUI));
            foreach (Control ctl in Controls)
            {
                res.ApplyResources(ctl, ctl.Name);
            }
            foreach (ToolStripMenuItem item in this.mainMenu.Items)
            {
                res.ApplyResources(item, item.Name);
                applyResourceToMenuDropDownItem(res, item);
            }
            res.ApplyResources(this, "$this");
            Thread.Sleep(500);
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.Activate();
        }

        private void applyResourceToMenuDropDownItem(ComponentResourceManager res, ToolStripMenuItem menuItem)
        {
            foreach (ToolStripItem dropDownitem in menuItem.DropDownItems)
            {
                if (dropDownitem is ToolStripMenuItem)
                {
                    applyResourceToMenuDropDownItem(res, dropDownitem as ToolStripMenuItem);
                }
                res.ApplyResources(dropDownitem, dropDownitem.Name);
            }
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUpdatesDlg dlg = new CheckUpdatesDlg();
            dlg.ShowDialog();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preference dlg = new Preference();
            dlg.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.Activate();

        }

        private void AsteriskAdminUI_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (Properties.Settings.Default.HideWhenMinimized)
                {
                    this.Hide();
                    this.notifyIcon.Visible = true;
                }
            }
        }

        private void asteriskOptionsToolStripButton_Click(object sender, EventArgs e)
        {
            changeView(AsteriskOptionsView);
        }

        private void extensionsToolStripButton_Click(object sender, EventArgs e)
        {
            changeView(ExtensionsView);
        }

        private void toolsToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button != null)
            {
                button.Checked = true;
            }

            changeView(ToolsView);
        }
    }
}
