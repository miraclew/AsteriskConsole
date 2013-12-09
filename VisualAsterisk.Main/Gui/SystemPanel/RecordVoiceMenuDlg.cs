using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class RecordVoiceMenuDlg : DialogBase
    {
        private Mode dialogMode;
        private List<string> extensions;

        public List<string> Extensions
        {
            get { return extensions; }
        }

        public string SelectedExtension
        {
            get { return this.extensionComboBox.SelectedItem as string; }
        }

        public string FileName
        {
            get { return fileNameTextBox.Text; }
        }

        public Mode DialogMode
        {
            get { return dialogMode; }
            set { dialogMode = value; }
        }

        public RecordVoiceMenuDlg(Mode dialogMode, List<string> extensions)
        {
            this.dialogMode = dialogMode;
            this.extensions = extensions;
            InitializeComponent();
            this.fileNameLabel.Visible = false;
            this.fileNameTextBox.Visible = false;
            foreach (string item in extensions)
            {
                this.extensionComboBox.Items.Add(item);
            }

            switch (dialogMode)
            {
                case Mode.RecordNew:
                    this.Text = "Record a new voicemenu";
                    this.informationLabel.Text = "Please select a extension used for recording and enter a file name:";
                    this.fileNameLabel.Visible = true;
                    this.fileNameTextBox.Visible = true;
                    break;
                case Mode.RecordAgain:
                    this.Text = "Record again";
                    this.informationLabel.Text = "Please enter an Extension to call";
                    break;
                case Mode.Play:
                    this.Text = "Play a voicemenu";
                    this.informationLabel.Text = "Please select an Extension on which you want to listen to the file";
                    break;
                default:
                    break;
            }
        }

        public enum Mode
        {
            RecordNew, RecordAgain, Play
        }

        private void RecordNewVoiceMenuDlg_Load(object sender, EventArgs e)
        {

        }
    }
}
