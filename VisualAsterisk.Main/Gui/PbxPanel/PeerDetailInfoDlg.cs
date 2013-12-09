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
    public partial class PeerDetailInfoDlg : DialogBase
    {
        public PeerDetailInfoDlg()
        {
            InitializeComponent();
        }

        AsteriskPeer peer;

        public AsteriskPeer Peer
        {
            get { return peer; }
            set { 
                peer = value;
                this.propertyGridBasicInfo.SelectedObject = peer;
            }
        }

        Dictionary<string, string> peerAttributes;

        public Dictionary<string, string> PeerAttributes
        {
            get { return peerAttributes; }
            set { 
                peerAttributes = value;
                BindingList<VariableBinding> variables = new BindingList<VariableBinding>();
                foreach (string var in peerAttributes.Keys)
                {
                    variables.Add(new VariableBinding(var, peerAttributes[var]));
                }
                this.variableBindingBindingSource.DataSource = variables;
            }
        }
    }
}
