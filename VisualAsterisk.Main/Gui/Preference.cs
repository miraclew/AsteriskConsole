using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VisualAsterisk.Main.Gui
{
    public partial class Preference : Form
    {
        public Preference()
        {
            InitializeComponent();
            this.startWithWindowsCheckBox.Checked = Properties.Settings.Default.StartWithWindows;
            this.hideToTrayCheckBox.Checked = Properties.Settings.Default.HideWhenMinimized;
            this.languageComboBox.Items.Add("en");
            this.languageComboBox.Items.Add("zh-CN");
            if (Properties.Settings.Default.UICulture == string.Empty)
            {
                this.languageComboBox.Text = "en";
            }
            else
            {
                this.languageComboBox.Text = Properties.Settings.Default.UICulture;
            }
            this.checkForUpdatesCheckBox.Checked = Properties.Settings.Default.CheckForUpdates;
            this.checkUpdatesURLTextBox.Text = Properties.Settings.Default.UpdatesURL;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyPreferencChange();
        }

        private void applyPreferencChange()
        {
            Properties.Settings.Default.StartWithWindows = this.startWithWindowsCheckBox.Checked;
            Properties.Settings.Default.HideWhenMinimized = this.hideToTrayCheckBox.Checked;
            Properties.Settings.Default.UICulture = this.languageComboBox.Text;
            Properties.Settings.Default.CheckForUpdates = this.checkForUpdatesCheckBox.Checked;
            Properties.Settings.Default.UpdatesURL = this.checkUpdatesURLTextBox.Text;
            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.StartWithWindows)
            {
                RegistryKey run = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                run.SetValue("VisualAsterisk", Application.ExecutablePath.ToString() + " -hide");
            }
            else
            {
                RegistryKey run = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                run.SetValue("VisualAsterisk", "");
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            applyPreferencChange();
        }
    }
}
