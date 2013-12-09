using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Main.Gui.Forms;
using System.Threading;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class RecordVoicePrompt : DataViewControl
    {
        public RecordVoicePrompt()
        {
            InitializeComponent();
            playColumn.Text = Properties.LocalizedStrings.RecordVoicePrompt_Play;
            recordAgainColumn.Text = Properties.LocalizedStrings.RecordVoicePrompt_RecordAgain;
            deleteColumn.Text = Properties.LocalizedStrings.RecordVoicePrompt_Delete;
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (!AsteriskManager.Default.IsCurrentControllerOK())
            {
                return;
            }

            RegisterAsteriskWizard.CheckToolInstall();
            if (!AsteriskManager.Default.CurrentAsteriskController.ToolInstalled)
            {
                this.Enabled = false;
            }
            else
            {
                this.recordVoicePromptBindingSource.Clear();
                foreach (string item in server.GetAllRecordedVoicePrompt())
                {
                    VoicePrompt vp = new VoicePrompt();
                    vp.FileName = item;
                    this.recordVoicePromptBindingSource.Add(vp);
                }

                this.Enabled = true;
            }
        }

        private void addNewVoicePromptButton_Click(object sender, EventArgs e)
        {
            RecordVoiceMenuDlg dlg = new RecordVoiceMenuDlg(
                    RecordVoiceMenuDlg.Mode.RecordNew, configManager.GetAllExtensions());

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                if (!fileName.EndsWith(".gsm"))
                {
                    fileName = fileName + ".gsm";
                }
                extension = dlg.SelectedExtension;
                new Thread(new ThreadStart(recordVoicePrompt)).Start();
            }
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            this.recordVoicePromptBindingSource.Clear();
            foreach (string item in server.GetAllRecordedVoicePrompt())
            {
                VoicePrompt vp = new VoicePrompt();
                vp.FileName = item;
                this.recordVoicePromptBindingSource.Add(vp);
            }
        }

        private string fileName;
        private string extension;

        private void visualAsteriskDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VoicePrompt vp = this.visualAsteriskDataGrid1.Rows[e.RowIndex].DataBoundItem as VoicePrompt;
            if (vp == null)
            {
                return;
            }

            if (e.ColumnIndex == playColumn.Index)
            {
                RecordVoiceMenuDlg dlg = new RecordVoiceMenuDlg(
                        RecordVoiceMenuDlg.Mode.Play, configManager.GetAllExtensions());
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = vp.FileName;
                    extension = dlg.SelectedExtension;
                    new Thread(new ThreadStart(playVoicePrompt)).Start();
                }
            }
            else if (e.ColumnIndex == recordAgainColumn.Index)
            {
                if (MessageBox.Show("Are you sure you want to Record over an existing Voice Prompt?",
                    "Record again", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                RecordVoiceMenuDlg dlg = new RecordVoiceMenuDlg(
                        RecordVoiceMenuDlg.Mode.RecordAgain, configManager.GetAllExtensions());
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = vp.FileName;
                    extension = dlg.SelectedExtension;
                    new Thread(new ThreadStart(recordVoicePrompt)).Start();
                }
            }
            else if (e.ColumnIndex == deleteColumn.Index)
            {
                if (MessageBox.Show("Delete selected file ?",
                    "Delete Voice Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.server.DeleteRecordedVoicePrompt(vp.FileName);
                    this.recordVoicePromptBindingSource.Remove(vp);
                }
            }
        }

        void playVoicePrompt()
        {
            this.server.PlayVoicePrompt(fileName, extension);
        }

        void recordVoicePrompt()
        {
            this.server.RecordVoicePrompt(fileName, extension);
        }
    }

    public class VoicePrompt
    {
        string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
    }

}
