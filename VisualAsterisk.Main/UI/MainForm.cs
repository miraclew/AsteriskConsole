using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.ViewControls;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Main.Gui;
using System.Threading;
using SipPhone;
using VisualAsterisk.Asterisk.Config.Configuration;
using Sipek.Common;
using AstFileEditor;

namespace VisualAsterisk.Main.UI
{
    public partial class MainForm : Form
    {        
        private ViewControl currentViewControl = null;
        private List<AsteriskController> asteriskControllers;

        public List<AsteriskController> AsteriskControllers
        {
            get { return asteriskControllers; }
            set { asteriskControllers = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            loadData();
            initializeUI();
            this.BringToFront();
        }

        private void loadData()
        {
            this.asteriskControllers = AsteriskManager.Default.AsteriskControllers;
            AsteriskManager.Default.CurrentAsteriskControllerChanged += new EventHandler<CurrentAsteriskControllerChangedEventArg>(Default_CurrentAsteriskControllerChanged);
            AsteriskManager.Default.CurrentAsteriskControllerItemChanged += new EventHandler<CurrentAsteriskControllerItemChangedEventArg>(Default_CurrentAsteriskControllerItemChanged);
        }

        void Default_CurrentAsteriskControllerItemChanged(object sender, CurrentAsteriskControllerItemChangedEventArg e)
        {
            if (currentViewControl != null)
            {
                currentViewControl.LoadData();
            }
        }

        void Default_CurrentAsteriskControllerChanged(object sender, CurrentAsteriskControllerChangedEventArg e)
        {
            if (currentViewControl != null && AsteriskManager.Default.IsCurrentControllerOK())
            {
                currentViewControl.LoadData();
            }
        }

        private void initializeUI()
        {
            showManagmentTasks(Properties.Settings.Default.ShowManageTask, false);
            showInventory(Properties.Settings.Default.ShowInventory);
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "zh-CN")
            {
                chineseToolStripMenuItem.Checked = true;
            }
            else
            {
                englishToolStripMenuItem.Checked = true;
            }
            inventoryControl1.AsteriskControllers = asteriskControllers;
            inventoryControl1.AsteriskSelectChanged += new EventHandler<AsteriskSelectChangedEventArg>(inventory_AsteriskSelectChanged);
            LoadViewControl(new SummaryView());
        }

        void inventory_AsteriskSelectChanged(object sender, AsteriskSelectChangedEventArg e)
        {
            AsteriskManager.Default.CurrentAsteriskController = e.AsteriskController;
        }

        private void closeCommonTasksButton_Click(object sender, EventArgs e)
        {
            showManagmentTasks(false, true);
        }

        private void showManagmentTasks(bool show, bool saveState)
        {
            rightPanel.Visible = show;
            showCommonTasksToolStripMenuItem.Checked = show;
        }

        private void showCommonTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showManagmentTasks(showCommonTasksToolStripMenuItem.Checked, true);
        }

        private void invetoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showInventory(invetoryToolStripMenuItem.Checked);
        }

        private void showInventory(bool show)
        {
            leftPanel.Visible = show;
            invetoryToolStripMenuItem.Checked = show;
        }

        private void pbxButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new PBXView());
        }

        internal void LoadViewControl(ViewControl viewControl)
        {
            if (!viewControl.LoadData())
                return;

            currentViewControl = viewControl;

            // Remove the view from the screen
            contentPanel.Controls.Clear();
            // Load the new control
            this.viewTitleLabel.Text = viewControl.HeaderTitle;
            this.headerCaptionLabel.Text = viewControl.HeaderCaption;
            this.headerIconPictureBox.Image = viewControl.HeaderIcon;

            //lblLoadStatus.Visible = false;

            viewControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(viewControl);
            viewControl.Show();

            //if (viewControl is SummaryView)
            //    backToSummaryLinkButton.Visible = false;
            //else
            //    backToSummaryLinkButton.Visible = true;
        }

        private void systemButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new SystemInfoView());
        }

        private void trunksButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new TrunksView());
        }

        private void extensionsButton_Click(object sender, EventArgs e)
        {
            //LoadViewControl(new UsersView());
            LoadViewControl(new UsersView2());
        }

        private void queueButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new QueuesView());
        }

        private void conferenceButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new ConferenceView());
        }

        private void dialPlanButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new DialPlanView());
        }

        private void ringGroupsButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new RingGroupsView());
        }

        private void voiceMenusButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new VoiceMenusView());
        }

        private void recordVoicePromptButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new RecordVoicePrompt());
        }

        private void hardwareDetectButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new HardwareView());
        }

        private void managerCLIButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new ManagerCLIView());
        }

        private void backupRestoreButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new BackupRestoreView());
        }

        private void asteriskLogsButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new AsteriskLogsView());
        }

        private void monitorButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new CallMonitor());
        }

        private void backToSummaryLinkButton_Click(object sender, EventArgs e)
        {
            LoadViewControl(new SummaryView());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (AsteriskController item in AsteriskManager.Default.AsteriskControllers)
            {
                item.Disconnect();
            }
        }

        private void addAsteriskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryControl1.AddAsterisk();
        }

        private void deleteAsteriskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryControl1.DeleteAsterisk();
        }

        private void importSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openControllersFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in openControllersFileDialog.FileNames)
                {
                    AsteriskManager.Default.ImportControllers(item);
                }

                inventoryControl1.AsteriskControllers = AsteriskManager.Default.AsteriskControllers;
            }
        }

        private void exportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveControllersFileDialog.ShowDialog() == DialogResult.OK)
            {
                AsteriskManager.Default.ExportControllers(saveControllersFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preference dlg = new Preference();
            dlg.ShowDialog();
        }

        private void contentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUpdatesDlg dlg = new CheckUpdatesDlg();
            dlg.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void cDRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadViewControl(new CallDetailRecordView());
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(((ToolStripMenuItem)sender).Tag.ToString(), true);
        }

        private void ChangeLanguage(string languageID, bool reloadForm)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(languageID);

            //Properties.Settings.Default.UICulture = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            Properties.Settings.Default.UICulture = languageID;
            Properties.Settings.Default.Save();

            if (reloadForm)
            {
                this.WindowState = FormWindowState.Minimized;
                this.SuspendLayout();

                foreach (Control control in this.Controls)
                {
                    control.Dispose();
                }

                this.Controls.Clear();

                InitializeComponent();

                this.initializeUI();
                //ConfigureUI();

                Thread.Sleep(500);
                this.WindowState = FormWindowState.Normal;
                this.ResumeLayout(true);
            }

            foreach (ToolStripMenuItem menu in this.languageToolStripMenuItem.DropDownItems)
            {
                if (menu.Tag is string && (string)menu.Tag == languageID)
                    menu.Checked = true;
                else
                    menu.Checked = false;
            }

        }

        private void headerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            headerPanel.Visible = headerToolStripMenuItem.Checked;
        }

        private void sipPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AsteriskManager.Default.IsCurrentControllerOK())
            {
                MessageBox.Show("Please connect to Asterisk Server first");
                return;
            }

            List<IAccount> accouts = new List<IAccount>();
            foreach (UserExtension item in AsteriskManager.Default.CurrentAsteriskController.Server.ConfigManager.Users)
            {
                if (!item.HasSip)
                {
                    continue;
                }
                SipAccountConfig ac = new SipAccountConfig();
                ac.HostName = AsteriskManager.Default.CurrentAsteriskController.ManagerConnectionInfo.Host;
                ac.UserName = item.Extension;
                ac.Password = item.Password;
                ac.DisplayName = item.FullName;
                accouts.Add(ac);
            }
            PhoneForm phone = new PhoneForm(accouts);
            phone.Show();
        }

        private void fileEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileEditorForm editor = new FileEditorForm();
            editor.Show();
        }
    }
}
