using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;
using System.Diagnostics;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class PeerPanel : Form
    {
        public delegate void PeerChangedEventHandler(object sender, AsteriskPeer peer, PropertyChangedEventArgs e);
        public delegate void ListViewUpdateEventHandler(string itemText, int subItemIndex, string text);
        public PeerPanel()
        {
            InitializeComponent();

            this.listViewPeers.Columns.Add("Peer");
            this.listViewPeers.Columns.Add("ChannelType", 100);
            this.listViewPeers.Columns.Add("Status", 100);
            this.listViewPeers.Columns.Add("ChannelStatus",100);
        }

        private IAsteriskServer server;

        public IAsteriskServer Server
        {
            get { return server; }
            set
            {
                server = value;
                this.listViewPeers.Items.Clear();
                foreach (AsteriskPeer peer in server.GetPeerEntriesEx())
                {
                    ListViewItem item = new ListViewItem(new string[] { peer.ObjectName, peer.ChannelType, peer.Status, "N/A" });
                    item.Tag = peer;
                    this.listViewPeers.Items.Add(item);
                    peer.PropertyChanged += new PropertyChangedEventHandler(peer_PropertyChanged);
                }
            }
        }

        void peer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is AsteriskPeer)
            {
                AsteriskPeer peer = sender as AsteriskPeer;
                //this.Invoke(new PeerChangedEventHandler(OnPeerChanged), new object[] { this, Peer, e });
                string itemText = peer.ObjectName;
                int subItemIndex;
                string text;
                if (e.PropertyName == AsteriskPeer.PROPERTY_STATUS)
                {
                    subItemIndex = 2;
                    text = peer.Status;
                }
                else if (e.PropertyName == AsteriskPeer.PROPERTY_CHANNEL)
                {
                    subItemIndex = 3;
                    text = peer.Channel.State.ToString();
                    // Channel proptery set for the firest time, Register event listener
                    peer.Channel.PropertyChanged += new PropertyChangedEventHandler(Channel_PropertyChanged);
                }
                else
                    return;

                this.Invoke(new ListViewUpdateEventHandler(updateListViewItem), new object[] { itemText, subItemIndex, text });
            }
        }

        void updateListViewItem(string itemText, int subItemIndex, string text)
        {
            if (subItemIndex <= 0 || subItemIndex > listViewPeers.Columns.Count)
            {
                Debug.Fail("updateListViewItem");
                return;
            }
            ListViewItem item = this.listViewPeers.FindItemWithText(itemText);
            if (item != null)
            {
                item.SubItems[subItemIndex].Text = text;
            }
            else
            {
                Debug.Fail("updateListViewItem");
                //this.listViewPeers.Items.Add(new ListViewItem(new string[] { Peer.ObjectName, Peer.ChannelType, Peer.Status, "N/A" }));
            }
        }

        void Channel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is AsteriskChannel)
            {
                AsteriskChannel channel = sender as AsteriskChannel;
                if (channel.Peer == null)
                {
                    Debug.Fail("updateListViewItem");
                    return;
                }

                AsteriskPeer peer = channel.Peer;
                string itemText = peer.ObjectName;
                int subItemIndex = 3;
                string text = channel.State.ToString() ;

                this.Invoke(new ListViewUpdateEventHandler(updateListViewItem), new object[] { itemText, subItemIndex, text });
            }
        }

        private void listViewPeers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewPeers_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewPeers.SelectedItems[0].Tag == null || !(this.listViewPeers.SelectedItems[0].Tag is AsteriskPeer))
            {
                return;
            }

            AsteriskPeer peer = this.listViewPeers.SelectedItems[0].Tag as AsteriskPeer;

            PeerDetailInfoDlg dlg = new PeerDetailInfoDlg();
            dlg.Peer = peer;
            dlg.PeerAttributes = server.GetSipPeerDetailInfo(peer.ObjectName);
            dlg.ShowDialog();
        }
    }
}
