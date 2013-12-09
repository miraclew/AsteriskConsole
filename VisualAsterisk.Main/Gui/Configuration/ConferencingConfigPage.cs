using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;

namespace VisualAsterisk.Main.Gui.Configuration
{
    public partial class ConferencingConfigPage : DockPage
    {
        public ConferencingConfigPage()
        {
            InitializeComponent();
        }

        private void ConferencingConfigPage_Load(object sender, EventArgs e)
        {

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
                this.conferenceRoomBindingSource.DataSource = this.configManager.ConferenceRooms;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = this.conferenceRoomBindingSource.Current as ConferenceRoom;

            if (MessageBox.Show(string.Format("Do you really want to delete {0} ?", room.RoomNumber), "Delete Conference Room confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                configManager.RemoveConfRoom(room);
            } 

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = this.conferenceRoomBindingSource.AddNew() as ConferenceRoom;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = this.conferenceRoomBindingSource.Current as ConferenceRoom;
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = this.conferenceRoomBindingSource.Current as ConferenceRoom;
            if (room != null)
            {
                configManager.UpdateConfRoom(room);
                this.buttonSubmit.Enabled = false;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ConferenceRoom room = this.conferenceRoomBindingSource.Current as ConferenceRoom;
            if (room != null)
            {
                room.CancelEdit();
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = false;
            }
        }

        private void conferenceRoomBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            ConferenceRoom room = new ConferenceRoom();
            room.AddingNew = true;
            e.NewObject = room;
        }

        private void conferenceRoomBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemChanged:
                case ListChangedType.ItemDeleted:
                    this.buttonSubmit.Enabled = true;
                    this.buttonCancel.Enabled = true;
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.Reset:
                    break;
                default:
                    break;
            }
        }

        private void roomNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            UpdateErrorStatus(((Control)sender).Text.Trim().Length != 0, (Control)sender, e);
        }
    }
}
