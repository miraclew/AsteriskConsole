using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;
using System.Diagnostics;
using Asterisk.NET.Manager.Event;
using WeifenLuo.WinFormsUI.Docking;
using VisualAsterisk.Asterisk.Config.Configuration;
using System.Collections;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class OperatorPanel : DockPage
    {
        public delegate void ListViewUpdateDelegate(object sender, string itemText, int subItemIndex, string text);
        public delegate void AddRemoveParkedCallDelegate(object sender, ParkedCall call);
        public delegate void AddRemoveMeetMeUserDelegate(object sender, MeetMeUser user);
        public delegate void TrunkListViewDelegate(object sender, RegistryEvent registryEvent);
        public delegate void AddRemoveQueueEntryDelegate(object sender, AsteriskQueueEntry entry);
        public delegate void AddRemoveQueueMemberDelegate(object sender, AsteriskQueueMember member);

        // Determine whether Windows XP or a later
        // operating System is present.
        private bool isRunningXPOrLater =
            OSFeature.Feature.IsPresent(OSFeature.Themes);

        // Declare a Hashtable array in which to store the groups.
        private Hashtable[] groupTables;

        // Declare a variable to store the current grouping column.
        int groupColumn = 0;

        private const int extensionListViewColumnStatusIndex = 3;
        private const int extensionLIstViewColumnChannelStateIndex = 4;
        private const int offlineImageIndex = 3;
        private const int onlineImageIndex = 10;
        private const int ringImageIndex = 0;
        private const int talkingImageIndex = 5;
        private const int multipleUsersImageIndex = 9;

        public OperatorPanel()
        {
            InitializeComponent();
            // Extension ListView colums : Extension(Extension number), User(User Name), Type(tech), Status, Channel State 

            this.listViewExtensions.Columns.Add("Extension", -2);
            this.listViewExtensions.Columns.Add("User", -2);
            this.listViewExtensions.Columns.Add("Type", -2);
            this.listViewExtensions.Columns.Add("Status", -2);
            this.listViewExtensions.Columns.Add("ChannelStatus");
            this.listViewExtensions.ColumnClick += new ColumnClickEventHandler(listViewExtensions_ColumnClick);

            this.listViewQueues.Columns.Add("Queue", -2);
            this.listViewQueues.Columns.Add("Agents", -2);
            this.listViewQueues.Columns.Add("WaitingEntries", -2);
            this.listViewQueues.Columns.Add("Strategy");

            this.listViewConferences.Columns.Add("Room", -2);
            this.listViewConferences.Columns.Add("Attendee");

            this.listViewPackinglots.Columns.Add("ParkedAt", -2);
            this.listViewPackinglots.Columns.Add("Channel", -2);
            this.listViewPackinglots.Columns.Add("From", -2);
            this.listViewPackinglots.Columns.Add("Timeout", -2);
            this.listViewPackinglots.Columns.Add("State");

            this.listViewTrunks.Columns.Add("Name", -2);
            this.listViewTrunks.Columns.Add("Type", -2);
            this.listViewTrunks.Columns.Add("Domain", -2);
            this.listViewTrunks.Columns.Add("Username", -2);
            this.listViewTrunks.Columns.Add("Status", -2);
            this.listViewTrunks.Columns.Add("Cause");
        }

        void listViewExtensions_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the sort order to ascending when changing
            // column groups; otherwise, reverse the sort order.
            if (listViewExtensions.Sorting == SortOrder.Descending ||
                (isRunningXPOrLater && (e.Column != groupColumn)))
            {
                listViewExtensions.Sorting = SortOrder.Ascending;
            }
            else
            {
                listViewExtensions.Sorting = SortOrder.Descending;
            }
            groupColumn = e.Column;

            // Set the groups to those created for the clicked column.
            if (isRunningXPOrLater)
            {
                SetGroups(e.Column);
            }
        }

        public override IAsteriskServer Server
        {
            get
            {
                return base.Server;
            }
            set
            {
                base.Server = value;
                initListViewExtension();
                initListViewQueues();
                initListViewConferences();
                initListViewPackinglots();
                initListViewTrunks();
                server.NewParkedCall += new NewParkedCallEventHandler(server_NewParkedCall);
                server.ParkedCallRemoved += new ParkedCallRemovedEventHandler(server_ParkedCallRemoved);
                server.NewMeetMeUser += new NewMeetMeUserEventHandler(server_NewMeetMeUser);
                server.MeetMeUserRemoved += new MeetMeUserRemovedEventHandler(server_MeetMeUserRemoved);
                server.TrunkStateChanged += new TrunkEventHandler(server_TrunkStateChanged);
            }
        }

        #region event handler in the form
        void server_ParkedCallRemoved(object sender, ParkedCall call)
        {
            this.Invoke(new AddRemoveParkedCallDelegate(removeParkedCallFromListView), new object[] { sender, call });
        }

        void server_NewParkedCall(object sender, ParkedCall call)
        {
            this.Invoke(new AddRemoveParkedCallDelegate(addParkedCallToListView), new object[] { sender, call });
        }

        void server_MeetMeUserRemoved(object sender, MeetMeUser user)
        {
            this.Invoke(new AddRemoveMeetMeUserDelegate(removeMeetMeUser), new object[] { sender, user });
        }

        void server_NewMeetMeUser(object sender, MeetMeUser user)
        {
            this.Invoke(new AddRemoveMeetMeUserDelegate(addMeetMeUser), new object[] { sender, user });
        }

        void server_TrunkStateChanged(object sender, RegistryEvent registryEvent)
        {
            this.Invoke(new TrunkListViewDelegate(updateTrunkListView), new object[] { sender, registryEvent });
        }

        void queue_NewEntry(object sender, AsteriskQueueEntry entry)
        {
            this.Invoke(new AddRemoveQueueEntryDelegate(addQueueEntry), new object[] { sender, entry });
        }

        void queue_EntryServiceLevelExceeded(object sender, AsteriskQueueEntry entry)
        {
            //this.Invoke(new QueueListViewDelegate(updateQueueListView), new object[] { sender, entry });
        }

        void queue_MemberRemoved(object sender, AsteriskQueueMember member)
        {
            this.Invoke(new AddRemoveQueueMemberDelegate(removeQueueMember), new object[] { sender, member });
        }

        void queue_MemberAdded(object sender, AsteriskQueueMember member)
        {
            this.Invoke(new AddRemoveQueueMemberDelegate(addQueueMember), new object[] { sender, member });
        }

        void queue_EntryLeave(object sender, AsteriskQueueEntry entry)
        {
            this.Invoke(new AddRemoveQueueEntryDelegate(removeQueueEntry), new object[] { sender, entry });
        }

        void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is AsteriskPeer) // list items in Extension
            {
                AsteriskPeer peer = sender as AsteriskPeer;
                string itemText = peer.ObjectName;
                int subItemIndex;
                string text;
                if (e.PropertyName == AsteriskPeer.PROPERTY_STATUS)
                {
                    subItemIndex = extensionListViewColumnStatusIndex;
                    text = peer.Status;
                }
                else if (e.PropertyName == AsteriskPeer.PROPERTY_CHANNEL)
                {
                    subItemIndex = extensionLIstViewColumnChannelStateIndex;
                    text = peer.Channel.State.ToString();
                    // Channel proptery set for the firest time, Register event listener
                    peer.Channel.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
                }
                else
                    return;

                this.Invoke(new ListViewUpdateDelegate(updateListViewItem), new object[] { sender, itemText, subItemIndex, text });
            }
            else if (sender is AsteriskChannel) // list items in Extension
            {
                AsteriskChannel channel = sender as AsteriskChannel;
                if (channel.Peer == null)
                {
                    Debug.Fail("OnPropertyChanged");
                    return;
                }

                AsteriskPeer peer = channel.Peer;
                string itemText = peer.ObjectName;
                int subItemIndex = extensionLIstViewColumnChannelStateIndex;
                string text = channel.State.ToString();

                this.Invoke(new ListViewUpdateDelegate(updateListViewItem), new object[] { sender, itemText, subItemIndex, text });
            }
            else if (sender is AsteriskQueue) // list items in Queue
            {
                AsteriskQueue queue = sender as AsteriskQueue;
            }
            else if (sender is AsteriskMeetMeRoom) // list items in Conference
            {
                AsteriskMeetMeRoom room = sender as AsteriskMeetMeRoom;
            }
            else if (sender is ParkedCall) // list items in Parked slots
            {
                ParkedCall call = sender as ParkedCall;
                string itemText = call.Exten;
                int subItemIndex = 4;
                string text = call.State.ToString();
                if (call.State == ParkedCallState.WAITING)
                {
                    this.Invoke(new ListViewUpdateDelegate(updateListViewItem), new object[] { sender, itemText, subItemIndex, text });
                }
                else if (call.State == ParkedCallState.TIMEOUT || call.State == ParkedCallState.GIVEUP)
                {
                    this.Invoke(new AddRemoveParkedCallDelegate(removeParkedCallFromListView), new object[] { sender, call });
                }
            }

        }
        #endregion

        #region init list view
        void initListViewExtension()
        {
            // Extension ListView colums : Extension(Extension number), User(User Name), Type(tech), Status, Channel State
            string extension, username, type, status, channelState;
            this.listViewExtensions.Items.Clear();
            foreach (AsteriskPeer peer in server.GetPeerEntriesEx())
            {
                extension = peer.ObjectName;
                username = string.Empty;
                if (server.ConfigManager.FindUser(extension) != null)
                {
                    username = server.ConfigManager.FindUser(extension).FullName;
                }
                type = "Sip";
                status = peer.Status;
                channelState = "N/A";
                if (peer.Channel != null)
                {
                    channelState = peer.Channel.State.ToString();
                }
                ListViewItem item = new ListViewItem(new string[] { extension, username, type, status, channelState });
                item.Tag = peer;
                item.ImageIndex = getImageIndex(status, channelState); 
                this.listViewExtensions.Items.Add(item);
                peer.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
            }
            this.listViewExtensions.Items.Add(new ListViewItem(new string[] { "6011", "a", "Zap", "aa", "aaab" }));

            if (isRunningXPOrLater)
            {
                // Create the groupsTable array and populate it with one 
                // hash table for each column.
                groupTables = new Hashtable[listViewExtensions.Columns.Count];
                for (int column = 0; column < listViewExtensions.Columns.Count; column++)
                {
                    // Create a hash table containing all the groups 
                    // needed for a single column.
                    groupTables[column] = CreateGroupsTable(column);
                }

                // Start with the groups created for the Title column.
                SetGroups(2);
            }
            this.listViewExtensions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private int getImageIndex(string status, string channelState)
        {
            if (channelState.ToLower() == "up")
            {
                return talkingImageIndex;
            }
            else if (channelState.ToLower() == "ring" || channelState.ToLower() == "ringing")
            {
                return ringImageIndex;
            }

            if (status.ToLower() == "registered")
            {
                return onlineImageIndex;
            }
            return offlineImageIndex;
        }

        void initListViewQueues()
        {
            this.listViewQueues.Items.Clear();
            foreach (AsteriskQueue queue in server.Queues)
            {
                ListViewItem item = new ListViewItem(new string[] { queue.Name, queue.Members.Count.ToString(), 
                    queue.Entries.Count.ToString(), queue.Strategy }, multipleUsersImageIndex);
                item.Tag = queue;
                this.listViewQueues.Items.Add(item);
                queue.NewEntry += new EntryEventHandler(queue_NewEntry);
                queue.EntryLeave += new EntryEventHandler(queue_EntryLeave);
                queue.MemberAdded += new MemberEventHandler(queue_MemberAdded);
                queue.MemberRemoved += new MemberEventHandler(queue_MemberRemoved);
                queue.EntryServiceLevelExceeded += new EntryEventHandler(queue_EntryServiceLevelExceeded);
                queue.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
            }
            this.listViewQueues.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void initListViewConferences()
        {
            this.listViewConferences.Items.Clear();
            foreach (AsteriskMeetMeRoom room in server.MeetmeRooms)
            {
                ListViewItem item = new ListViewItem(new string[] { room.RoomNumber, room.GetUsers().Count.ToString() },
                    multipleUsersImageIndex);
                item.Tag = room;
                this.listViewConferences.Items.Add(item);
                room.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
            }
            this.listViewConferences.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void initListViewPackinglots()
        {
            this.listViewPackinglots.Items.Clear();
            if (string.IsNullOrEmpty(configManager.CallParkSetting.First) || 
                string.IsNullOrEmpty(configManager.CallParkSetting.Last))
            {
                return;
            }
            int first = int.Parse(server.ConfigManager.CallParkSetting.First);
            int last = int.Parse(server.ConfigManager.CallParkSetting.Last);
            for (int i = first; i <= last; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString(), 1);
                this.listViewPackinglots.Items.Add(item);
            }
            this.listViewPackinglots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        void initListViewTrunks()
        {
            this.listViewTrunks.Items.Clear();
            foreach (Trunk trunk in configManager.Trunks)
            {
                ListViewItem item = new ListViewItem(new string[] { trunk.Trunkname , 
                    trunk.TrunkTech.ToString(), trunk.Fromdomain, trunk.Fromuser }, 6);
                this.listViewTrunks.Items.Add(item);
            }
            this.listViewTrunks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        void addQueueEntry(object sender, AsteriskQueueEntry entry)
        {
            ListViewItem item = this.listViewQueues.FindItemWithText(entry.Queue.Name);
            if (item != null)
            {
                item.SubItems[2].Text = entry.Queue.Entries.Count.ToString();
            }
        }

        void removeQueueEntry(object sender, AsteriskQueueEntry entry)
        {
            ListViewItem item = this.listViewQueues.FindItemWithText(entry.Queue.Name);
            if (item != null)
            {
                item.SubItems[2].Text = entry.Queue.Entries.Count.ToString();
            }
        }

        void addQueueMember(object sender, AsteriskQueueMember member)
        {
            ListViewItem item = this.listViewQueues.FindItemWithText(member.Queue.Name);
            if (item != null)
            {
                item.SubItems[2].Text = member.Queue.Members.Count.ToString();
            }
        }

        void removeQueueMember(object sender, AsteriskQueueMember member)
        {
            ListViewItem item = this.listViewQueues.FindItemWithText(member.Queue.Name);
            if (item != null)
            {
                item.SubItems[2].Text = member.Queue.Members.Count.ToString();
            }
        }

        void addMeetMeUser(object sender, MeetMeUser user)
        {
            ListViewItem item = this.listViewConferences.FindItemWithText(user.Room.RoomNumber);
            if (item == null)
            {
                item = new ListViewItem(new string[] { user.Room.RoomNumber, user.Room.GetUsers().Count.ToString() });
                item.Tag = user.Room;
                this.listViewConferences.Items.Add(item);
            }
            else
            {
                item.SubItems[1].Text = user.Room.GetUsers().Count.ToString();
            }
        }

        void removeMeetMeUser(object sender, MeetMeUser user)
        {
            ListViewItem item = this.listViewConferences.FindItemWithText(user.Room.RoomNumber);
            if (item != null)
            {
                item.SubItems[1].Text = user.Room.GetUsers().Count.ToString();
            }
        }

        void addParkedCallToListView(object sender, ParkedCall call)
        {
            ListViewItem item = new ListViewItem(new string[] { call.Exten, call.Channel.Name, call.From.Name, call.Timeout.ToString(), call.State.ToString() });
            item.Tag = call;
            this.listViewPackinglots.Items.Add(item);
            call.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
        }

        void removeParkedCallFromListView(object sender, ParkedCall call)
        {
            ListViewItem item = this.listViewPackinglots.FindItemWithText(call.Exten);
            this.listViewPackinglots.Items.Remove(item);
        }

        void updateTrunkListView(object sender, RegistryEvent registryEvent)
        {
            ListViewItem item = null;
            foreach (ListViewItem var in listViewTrunks.Items)
            {
                RegistryEvent e = var.Tag as RegistryEvent;
                if (e.UniqueId == registryEvent.UniqueId)
                {
                    item = var;
                }
            }
            //ListViewItem item = this.listViewTrunks.FindItemWithText(User.Room.RoomNumber);
            if (item == null)
            {
                item = new ListViewItem(new string[] { registryEvent.ChannelType , registryEvent.Domain,
                    registryEvent.Username, registryEvent.Status, registryEvent.Cause });
                item.Tag = registryEvent;
                this.listViewTrunks.Items.Add(item);
            }
            else
            {
                item.SubItems[3].Text = registryEvent.Status;
                item.SubItems[4].Text = registryEvent.Cause;
            }

        }

        void updateListViewItem(object sender, string itemText, int subItemIndex, string text)
        {
            ListView listView;
            if (sender is AsteriskPeer || sender is AsteriskChannel)
            {
                listView = this.listViewExtensions;
            }
            else if (sender is AsteriskQueue)
            {
                listView = this.listViewQueues;
            }
            else if (sender is AsteriskMeetMeRoom)
            {
                listView = this.listViewConferences;
            }
            else if (sender is ParkedCall)
            {
                listView = this.listViewPackinglots;
            }
            else
            {
                Debug.Fail("updateListViewItem");
                return;
            }

            if (subItemIndex <= 0 || subItemIndex > listView.Columns.Count)
            {
                Debug.Fail("updateListViewItem");
                return;
            }

            ListViewItem item = listView.FindItemWithText(itemText);
            if (item != null)
            {
                item.SubItems[subItemIndex].Text = text;
                if (sender is AsteriskPeer || sender is AsteriskChannel)
                {
                    item.ImageIndex  = getImageIndex(
                        item.SubItems[extensionListViewColumnStatusIndex].Text,
                        item.SubItems[extensionLIstViewColumnChannelStateIndex].Text);
                }
            }
            else
            {
                Debug.Fail("updateListViewItem");
            }
        }

        private void listViewExtensions_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewExtensions.SelectedItems[0].Tag == null || !(this.listViewExtensions.SelectedItems[0].Tag is AsteriskPeer))
            {
                return;
            }

            AsteriskPeer peer = this.listViewExtensions.SelectedItems[0].Tag as AsteriskPeer;

            PeerDetailInfoDlg dlg = new PeerDetailInfoDlg();
            dlg.Text = "Peer  " + peer.Name;
            dlg.Peer = peer;
            dlg.PeerAttributes = server.GetSipPeerDetailInfo(peer.ObjectName);
            dlg.ShowDialog();
        }

        private void listViewQueues_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewQueues.SelectedItems[0].Tag == null || !(this.listViewQueues.SelectedItems[0].Tag is AsteriskQueue))
            {
                return;
            }
            AsteriskQueue queue = this.listViewQueues.SelectedItems[0].Tag as AsteriskQueue;

            QueueDetailInfoDlg dlg = new QueueDetailInfoDlg();
            dlg.Text = "Queue " + queue.Name;
            dlg.Queue = queue;
            dlg.ShowDialog();
        }

        private void listViewConferences_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewConferences.SelectedItems[0].Tag == null || !(this.listViewConferences.SelectedItems[0].Tag is AsteriskMeetMeRoom))
            {
                return;
            }
            AsteriskMeetMeRoom room = this.listViewConferences.SelectedItems[0].Tag as AsteriskMeetMeRoom;

            MeetMeRoomDetailInfoDlg dlg = new MeetMeRoomDetailInfoDlg();
            dlg.Text = "MeetMeRoom " + room.RoomNumber;
            dlg.MeetMeRoom = room;
            dlg.ShowDialog();
        }

        private void listViewPackinglots_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listViewTrunks_DoubleClick(object sender, EventArgs e)
        {

        }


        #region ListView Item Grouping
        // Sets listViewExtensions to the groups created for the specified column.
        private void SetGroups(int column)
        {
            // Remove the current groups.
            listViewExtensions.Groups.Clear();

            // Retrieve the hash table corresponding to the column.
            Hashtable groups = (Hashtable)groupTables[column];

            // Copy the groups for the column to an array.
            ListViewGroup[] groupsArray = new ListViewGroup[groups.Count];
            groups.Values.CopyTo(groupsArray, 0);

            // Sort the groups and add them to listViewExtensions.
            Array.Sort(groupsArray, new ListViewGroupSorter(listViewExtensions.Sorting));
            listViewExtensions.Groups.AddRange(groupsArray);

            // Iterate through the items in listViewExtensions, assigning each 
            // one to the appropriate group.
            foreach (ListViewItem item in listViewExtensions.Items)
            {
                // Retrieve the subitem text corresponding to the column.
                string subItemText = item.SubItems[column].Text;

                // For the Title column, use only the first letter.
                if (column == 0)
                {
                    subItemText = subItemText.Substring(0, 1);
                }

                // Assign the item to the matching group.
                item.Group = (ListViewGroup)groups[subItemText];
            }
        }

        // Creates a Hashtable object with one entry for each unique
        // subitem value (or initial letter for the parent item)
        // in the specified column.
        private Hashtable CreateGroupsTable(int column)
        {
            // Create a Hashtable object.
            Hashtable groups = new Hashtable();

            // Iterate through the items in listViewExtensions.
            foreach (ListViewItem item in listViewExtensions.Items)
            {
                // Retrieve the text value for the column.
                string subItemText = item.SubItems[column].Text;

                // Use the initial letter instead if it is the first column.
                //if (column == 0)
                //{
                //    subItemText = subItemText.Substring(0, 1);
                //}

                // If the groups table does not already contain a group
                // for the subItemText value, add a new group using the 
                // subItemText value for the group header and Hashtable Key.
                if (!groups.Contains(subItemText))
                {
                    groups.Add(subItemText, new ListViewGroup(subItemText,
                        HorizontalAlignment.Left));
                }
            }

            // Return the Hashtable object.
            return groups;
        }

        // Sorts ListViewGroup objects by header value.
        private class ListViewGroupSorter : IComparer
        {
            private SortOrder order;

            // Stores the sort order.
            public ListViewGroupSorter(SortOrder theOrder)
            {
                order = theOrder;
            }

            // Compares the groups by header value, using the saved sort
            // order to return the correct value.
            public int Compare(object x, object y)
            {
                int result = String.Compare(
                    ((ListViewGroup)x).Header,
                    ((ListViewGroup)y).Header
                );
                if (order == SortOrder.Ascending)
                {
                    return result;
                }
                else
                {
                    return -result;
                }
            }
        }

        #endregion

    }
}
