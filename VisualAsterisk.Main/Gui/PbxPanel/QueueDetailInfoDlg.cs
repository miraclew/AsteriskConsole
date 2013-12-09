using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class QueueDetailInfoDlg : DialogBase
    {
        public QueueDetailInfoDlg()
        {
            InitializeComponent();
        }

        AsteriskQueue queue;

        public AsteriskQueue Queue
        {
            get { return queue; }
            set { 
                queue = value;
                this.asteriskQueueEntryBindingSource.DataSource = queue.Entries;
                this.asteriskQueueMemberBindingSource.DataSource = queue.Members.Values;
            }
        }

        private void asteriskQueueEntryDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void asteriskQueueMemberDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
