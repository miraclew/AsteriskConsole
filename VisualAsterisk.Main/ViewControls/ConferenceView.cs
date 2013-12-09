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
    public partial class ConferenceView : DataViewControl
    {
        public ConferenceView()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (AsteriskManager.Default.IsCurrentControllerOK())
            {
                this.conferenceRoomBindingSource.DataSource = this.configManager.ConferenceRooms;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = this.conferenceRoomBindingSource.Current as ConferenceRoom;
            if (room != null)
            {
                configManager.UpdateConfRoom(room);
                //this.buttonSubmit.Enabled = false;
                //this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = this.conferenceRoomBindingSource.Current as ConferenceRoom;
            if (room != null)
            {
                room.CancelEdit();
                //this.buttonSubmit.Enabled = true;
                //this.buttonCancel.Enabled = false;
            }
        }

        private void roomNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }

        private void conferenceRoomVisualAsteriskEditDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            ConferenceRoom room = e.DataRow.DataBoundItem as ConferenceRoom;
            if (room != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete Conference Room {0}", room.RoomNumber),
                    "Delete Conference Room Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.conferenceRoomBindingSource.RemoveCurrent();
                    if (!room.AddingNew)
                    {
                        configManager.RemoveConfRoom(room);
                    }
                }
            }

        }

        private void conferenceRoomVisualAsteriskEditDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            ConferenceRoom room = e.DataRow.DataBoundItem as ConferenceRoom;
            if (room == null)
            {
                return;
            }

            ConferenceEditorForm editor = new ConferenceEditorForm(room, configManager);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                configManager.UpdateConfRoom(room);
            }
        }

        private void addNewConferenceButton_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = new ConferenceRoom();
            room.AddingNew = true;

            ConferenceEditorForm editor = new ConferenceEditorForm(room, configManager);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                this.conferenceRoomBindingSource.Add(room);
                configManager.UpdateConfRoom(room);
            }
        }
    }
}
