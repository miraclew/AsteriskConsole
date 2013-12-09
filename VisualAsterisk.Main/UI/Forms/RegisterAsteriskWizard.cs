using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IC.Controls;
using VisualAsterisk.Core.SSH;
using VisualAsterisk.Main;
using VisualAsterisk.Main.UI.Forms;
using VisualAsterisk.Core.Deploy;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Main.Controller;

namespace VisualAsterisk.Main.Gui.Forms
{
    enum RegisterStep { Connect, CheckPreInstallCondition, Install, RestartAsterisk };
    enum Mode { CreateNewConfiguration, UsingExistConfiguration, InstallToolOnly };
    /// <summary>
    /// 
    /// </summary>
    public partial class RegisterAsteriskWizard : Form
    {
        private IConfigInstaller installer;
        private ManagerConnectionInfo managerConnectionInfo;
        private AsteriskController asteriskController;
        private Mode mode;

        //  welcomePage,connectPage, checkingPage, completedPage
        private const int WelcomePageIndex = 0;
        private const int FillConnectionInfoPageIndex = 1;
        private const int InstallPageIndex = 2;
        private const int CompletedPageIndex = 3;

        public AsteriskController AsteriskController
        {
            get { return asteriskController; }
            set { asteriskController = value; }
        }

        public ManagerConnectionInfo ManagerConnectionInfo
        {
            get { return managerConnectionInfo; }
            set { managerConnectionInfo = value; }
        }

        public IConfigInstaller Installer
        {
            get { return installer; }
            set { installer = value; }
        }

        public RegisterAsteriskWizard()
            : this(null, false)
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialConfigSetup"/> class.
        /// </summary>
        public RegisterAsteriskWizard(AsteriskController asteriskController, bool installToolOnly)
        {
            InitializeComponent();

            if (installToolOnly)
            {
                if (asteriskController == null)
                {
                    throw new ArgumentNullException("asteriskController should not be null when installToolOnly is true");
                }
                this.asteriskController = asteriskController;
                mode = Mode.InstallToolOnly;
                wizard1.PageIndex = 1;
                if (asteriskController.ManagerConnectionInfo != null)
                {
                    this.hostTextBox.Text = asteriskController.ManagerConnectionInfo.Host;
                    this.userTextBox.Text = "root";
                    this.passwordTextBox.Text = "";
                }
            }
            else
            {
                this.asteriskController = new AsteriskController();
                this.asteriskController.ToolInstalled = false;

                wizard1.PageIndex = 0;
            }
            
            wizard1.BackEnabled = false;
            wizard1.PageChanged += new EventHandler(wizard1_PageChanged);
            wizard1.BeforePageChanged += new EventHandler<IC.Controls.Wizard.PageChangedEventArgs>(wizard1_BeforePageChanged);
        }

        void wizard1_BeforePageChanged(object sender, IC.Controls.Wizard.PageChangedEventArgs e)
        {
            if (wizard1.PageIndex == FillConnectionInfoPageIndex) // before move to connection info filling
            {
                if (mode == Mode.UsingExistConfiguration)
                {
                    asteriskController.ManagerConnectionInfo = new ManagerConnectionInfo(hostTextBox.Text, userTextBox.Text, passwordTextBox.Text);
                    //wizard1.PageIndex = CompletedPageIndex;
                    //wizard1.NextTo(completedPage);
                }
                else if (mode == Mode.CreateNewConfiguration || mode == Mode.InstallToolOnly)
                {
                    asteriskController.SshConnectionInfo = new SSHConnectionInfo2();
                    asteriskController.SshConnectionInfo.Host = hostTextBox.Text;
                    asteriskController.SshConnectionInfo.User = userTextBox.Text;
                    asteriskController.SshConnectionInfo.Password = passwordTextBox.Text;
                }
            }
        }

        void wizard1_PageChanged(object sender, EventArgs e)
        {
            if (wizard1.PageIndex == WelcomePageIndex) // welcome
            {
                wizard1.BackEnabled = false;
                wizard1.NextEnabled = false;
            }
            else if (wizard1.PageIndex == FillConnectionInfoPageIndex) // enter Server connection info
            {
                if (mode == Mode.UsingExistConfiguration)
                {
                    connectServerLabel.Text = "Please enter the host and user/password configured in mananger.conf";
                }

                wizard1.BackEnabled = false;
                wizard1.NextEnabled = true;
            }
            else if (wizard1.PageIndex == InstallPageIndex) // connect to Server, detect environment
            {
                if (mode == Mode.UsingExistConfiguration)
                {
                    wizard1.NextTo(completedPage);
                    return;
                }

                if (installer == null)
                {
                    string toolsPath = Application.StartupPath + @"\Resources\visualasterisk-tools.tar.gz";
                    installer = new FirstTimeConfigInstaller(toolsPath);
                }
                try
                {
                    gotoStep(RegisterStep.Connect);
                    installer.Connect(asteriskController.SshConnectionInfo);
                    gotoStep(RegisterStep.CheckPreInstallCondition);
                    installer.CheckPreInstallCondition();
                    gotoStep(RegisterStep.Install);
                    installer.Install();
                    gotoStep(RegisterStep.RestartAsterisk);
                    installer.RestartAsterisk();
                    asteriskController.ToolInstalled = true;
                }
                catch (System.Exception ex)
                {
                    connectionFailedInfoLabel.Text = ex.Message;
                    connectionFailedInfoLabel.Visible = true;
                    return;
                }
            }
        }

        private void gotoStep(RegisterStep currentStep)
        {
            sshConnectLabel.Enabled = false;
            checkPreInstallConditionLabel.Enabled = false;
            transmitFIleLabel.Enabled = false;
            installLabel1.Enabled = false;

            switch (currentStep)
            {
                case RegisterStep.Connect:
                    sshConnectLabel.Enabled = true;
                    break;
                case RegisterStep.CheckPreInstallCondition:
                    checkPreInstallConditionLabel.Enabled = true;
                    break;
                case RegisterStep.Install:
                    installLabel1.Enabled = true;
                    break;
                case RegisterStep.RestartAsterisk:
                    break;
                default:
                    break;
            }
        }

        private void newConfigurationButton_Click(object sender, EventArgs e)
        {
            mode = Mode.CreateNewConfiguration;
            wizard1.Next();
        }

        private void useExistConfigurationButton_Click(object sender, EventArgs e)
        {
            mode = Mode.UsingExistConfiguration;
            wizard1.Next();
        }

        public static void CheckToolInstall()
        {
            if (!AsteriskManager.Default.CurrentAsteriskController.ToolInstalled)
            {
                if (MessageBox.Show("VisualAsterisk tool is not installed on this Asterisk, would you like to install now?", "VisualAsterisk Tool need to install to open this view", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RegisterAsteriskWizard wizard = new RegisterAsteriskWizard(AsteriskManager.Default.CurrentAsteriskController, true);
                    wizard.ShowDialog();
                }
            }
        }
    }
}
