using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.ExceptionManagement.Dialogs
{
    public partial class ErrorCaptureDialog : Form
    {
        private ErrorPacket _ePack;

        public ErrorPacket ErrorPacket
        {
            get { return _ePack; }
            set { _ePack = value; }
        }

        public ErrorCaptureDialog()
        {
            InitializeComponent();
        }

        public ErrorCaptureDialog(ErrorPacket ePack)
        {
            InitializeComponent();
            ErrorPacket = ePack;
            string fmt = lblHeader.Text;
            lblHeader.Text = String.Format(fmt, ePack.ApplicationName);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnDontSend_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void lnkShowErrorContent_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowErrorDialog dlg = new ShowErrorDialog(ErrorPacket);
            dlg.ShowDialog(this);
        }
    }
}
