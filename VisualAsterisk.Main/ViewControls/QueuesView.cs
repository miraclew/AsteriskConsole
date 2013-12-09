using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Main.UI.Forms;
using VisualAsterisk.Main.Controller;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class QueuesView : DataViewControl
    {
        public QueuesView()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (AsteriskManager.Default.IsCurrentControllerOK())
            {
                this.queueExtensionBindingSource.DataSource = this.configManager.Queues;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //QueueExtension queue = this.queueExtensionBindingSource.Current as QueueExtension;
            //if (queue != null)
            //{
            //    queue.CancelEdit();
            //    //this.buttonSubmit.Enabled = true;
            //    //this.buttonCancel.Enabled = false;
            //}
        }

        private void extensionTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }

        private void addNewQueueButton_Click(object sender, EventArgs e)
        {
            QueueExtension queue = new QueueExtension();
            queue.AddingNew = true;

            QueueEditorForm editor = new QueueEditorForm(queue, configManager);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                queueExtensionBindingSource.Add(queue);
                configManager.UpdateQueue(queue);
            }
        }

        private void queueExtensionVisualAsteriskEditDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            QueueExtension queue = e.DataRow.DataBoundItem as QueueExtension;
            if (queue == null)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Do you want to delete Queue {0}", queue.Name),
                "Delete Queue Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.queueExtensionBindingSource.RemoveCurrent();
                if (!queue.AddingNew)
                {
                    configManager.RemoveQueue(queue);
                }
            }
        }

        private void queueExtensionVisualAsteriskEditDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            QueueExtension queue = e.DataRow.DataBoundItem as QueueExtension;
            if (queue == null)
            {
                return;
            }

            QueueEditorForm editor = new QueueEditorForm(queue, configManager);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                configManager.UpdateQueue(queue);
            }

            //this.buttonSubmit.Enabled = false;
            //this.buttonCancel.Enabled = false;
        }

        private void queueExtensionVisualAsteriskEditDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
