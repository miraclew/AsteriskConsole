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
    public partial class MeetMeRoomDetailInfoDlg : DialogBase
    {
        public MeetMeRoomDetailInfoDlg()
        {
            InitializeComponent();
        }

        AsteriskMeetMeRoom meetMeRoom;

        public AsteriskMeetMeRoom MeetMeRoom
        {
            get { return meetMeRoom; }
            set { 
                meetMeRoom = value;
                this.meetMeUserBindingSource.DataSource = meetMeRoom.GetUsers();
            }
        }
    }
}
