using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class RecordVoiceMenu : DockPage
    {
        public RecordVoiceMenu()
        {
            InitializeComponent();
        }

        public override VisualAsterisk.Asterisk.IAsteriskServer Server
        {
            get
            {
                return base.Server;
            }
            set
            {
                base.Server = value;
                this.recordedVoiceListView.Items.Clear();
                foreach (string item in server.GetAllRecordedVoicePrompt())
                {
                    this.recordedVoiceListView.Items.Add(item);
                }

                if (this.recordedVoiceListView.Items.Count > 0)
                {
                    this.recordedVoiceListView.SelectedIndices.Add(0);
                }
            }
        }

        private void recordNewButton_Click(object sender, EventArgs e)
        {
            RecordVoiceMenuDlg dlg = new RecordVoiceMenuDlg(
                    RecordVoiceMenuDlg.Mode.RecordNew, configManager.GetAllExtensions());

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                if (!fileName.EndsWith(".gsm"))
                {
                    fileName = fileName + ".gsm";
                }

                this.server.RecordVoicePrompt(fileName, dlg.SelectedExtension);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (this.recordedVoiceListView.SelectedItems.Count <= 0)
            {
                return;
            }
            string fileName = this.recordedVoiceListView.SelectedItems[0].Text;

            RecordVoiceMenuDlg dlg = new RecordVoiceMenuDlg(
                    RecordVoiceMenuDlg.Mode.Play, configManager.GetAllExtensions());
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.server.PlayVoicePrompt(fileName, dlg.SelectedExtension);
            }
        }

        private void recordAgainButton_Click(object sender, EventArgs e)
        {
            if (this.recordedVoiceListView.SelectedItems.Count <= 0)
            {
                return;
            }
            string fileName = this.recordedVoiceListView.SelectedItems[0].Text;

            if (MessageBox.Show("Are you sure you want to Record over an existing Voicemenu?",
                "Record again",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            RecordVoiceMenuDlg dlg = new RecordVoiceMenuDlg(
                    RecordVoiceMenuDlg.Mode.RecordAgain, configManager.GetAllExtensions());
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.server.RecordVoicePrompt(fileName, dlg.SelectedExtension);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.recordedVoiceListView.SelectedItems.Count <= 0)
            {
                return;
            }
            string fileName = this.recordedVoiceListView.SelectedItems[0].Text;

            if (MessageBox.Show("Delete selected file ?",
                "Record again", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.server.DeleteRecordedVoicePrompt(fileName);
                this.recordedVoiceListView.Items.Remove(this.recordedVoiceListView.SelectedItems[0]);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.recordedVoiceListView.Items.Clear();
            foreach (string item in server.GetAllRecordedVoicePrompt())
            {
                this.recordedVoiceListView.Items.Add(item);
            }
        }
    }
}
