using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Main.Gui.Inventory;
using VisualAsterisk.Asterisk;
using System.Diagnostics;
using VisualAsterisk.Main.Gui.Forms;

namespace VisualAsterisk.Main.Gui
{
    // TODO: Refactor needed, move connecting logic to ConnectAsteriskServerProgress.cs
    public partial class InventoryControl : DockContent
    {
        delegate void ServerConnetionStateChangedDelegate(TreeNode node, ServerTreeNodeConnectionState state);

        protected List<AsteriskController> asteriskControllers;
        private TreeNode asteriskServerTreeNodeRoot;
        public event EventHandler<AsteriskSelectChangedEventArg> AsteriskSelectChanged;
        private ConnectAsteriskServerProgress progressWindow;

        public List<AsteriskController> AsteriskControllers
        {
            get { return asteriskControllers; }
            set
            {
                asteriskControllers = value;
                initAsteriskControllers();
            }
        }

        protected virtual void initAsteriskControllers()
        {
            asteriskServerTreeNodeRoot = new TreeNode("Asterisk Servers");
            asteriskServerTreeNodeRoot.ImageKey = asteriskServerTreeNodeRoot.SelectedImageKey = "group.ico";
            //asteriskServerTreeNodeRoot.ImageIndex = 0;
            //asteriskServerTreeNodeRoot.SelectedImageIndex = 0;
            this.treeViewInventory.Nodes.Add(asteriskServerTreeNodeRoot);

            foreach (AsteriskController c in asteriskControllers)
            {
                createControllerTreeNode(c);
            }

            asteriskServerTreeNodeRoot.Expand();
        }

        private void createControllerTreeNode(AsteriskController c)
        {
            TreeNode host = new TreeNode(c.ManagerConnectionInfo.Name);
            host.ImageKey = host.SelectedImageKey = "disconnected.ico";
            //Host.SelectedImageIndex = 1;
            host.Tag = c;
            asteriskServerTreeNodeRoot.Nodes.Add(host);
        }

        public InventoryControl()
        {
            InitializeComponent();
        }

        private void treeViewInventory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;

            if (e.Node.Tag is AsteriskController)
            {
                AsteriskController c = e.Node.Tag as AsteriskController;
                if (c.Connected)
                {
                    OnAsteriskSelectChanged(c);
                }                
            }
        }

        void Server_ConnectingProgressChanged(object sender, ConnectingProgressEventArg e)
        {
            if (this.backgroundWorker1.IsBusy)
            {
                backgroundWorker1.ReportProgress(e.Percent, e.ProgressText);
            }
        }

        private void OnAsteriskSelectChanged(AsteriskController asteriskController)
        {
            EventHandler<AsteriskSelectChangedEventArg> eh = AsteriskSelectChanged;
            if (eh != null)
            {
                eh(this, new AsteriskSelectChangedEventArg(asteriskController));
            }
        }

        #region background worker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (true)
            //    return;
            ConnectAsteriskServerProgress progress = e.Argument as ConnectAsteriskServerProgress;
            try
            {
                if (progress.AsteriskController == null)
                {
                    return;
                }                

                progress.AsteriskController.Connect(new EventHandler<ConnectingProgressEventArg>(Server_ConnectingProgressChanged));

            }
            catch (Exception ex)
            {
                Trace.WriteLine(string.Format("Connect to {0} failed! {1}", progress.AsteriskController.ManagerConnectionInfo.Name, ex.Message));
                MessageBox.Show(
                    string.Format("Connect to {0} failed!", progress.AsteriskController.ManagerConnectionInfo.Name),
                    "Failed to connect to Asterisk Server",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            // Indicate cancelation
            if (this.backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }

            if (progress.AsteriskController.Connected)
            {
                this.Invoke(new ServerConnetionStateChangedDelegate(serverTreeNodeConnectionStateChanged),
                    progress.SelectedNode, ServerTreeNodeConnectionState.Connected);
            }
            else
            {
                this.Invoke(new ServerConnetionStateChangedDelegate(serverTreeNodeConnectionStateChanged),
                   progress.SelectedNode, ServerTreeNodeConnectionState.Disconnected);
            }
        }

        void serverTreeNodeConnectionStateChanged(TreeNode node, ServerTreeNodeConnectionState state)
        {
            switch (state)
            {
                case ServerTreeNodeConnectionState.Disconnected:
                    node.SelectedImageKey = node.ImageKey = "disconnected.ico";
                    break;
                case ServerTreeNodeConnectionState.Disconnecting:
                case ServerTreeNodeConnectionState.Connecting:
                    node.SelectedImageKey = node.ImageKey = "connecting.gif";
                    break;
                case ServerTreeNodeConnectionState.Connected:
                    node.SelectedImageKey = node.ImageKey = "connected.ico";
                    break;
                default:
                    node.SelectedImageKey = node.ImageKey = "disconnected.ico";
                    break;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string progressText = e.UserState as string;
            if (progressText == null)
            {
                return;
            }
            showProgress(e.ProgressPercentage, progressText);
        }

        private void showProgress(int percent, string progressText)
        {
            // Make sure we're on the UI thread
            Debug.Assert(this.InvokeRequired == false);

            if (progressWindow != null && progressWindow.Visible)
            {
                progressWindow.SetProgressPercent(percent);
                progressWindow.SetProgressText(progressText);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressWindow != null && progressWindow.Visible)
            {
                AsteriskController c = progressWindow.AsteriskController;
                progressWindow.AsteriskController = null;
                progressWindow.Close();

                try
                {
                    if (c != null && c.Connected && c.Server != null && c.Server.IsConnected())
                    {
                        OnAsteriskSelectChanged(c);
                    }

                }
                catch (NullReferenceException ex)
                {

                    throw;
                }
            }
        }

        #endregion 
        #region Context menu
        private void addAsteriskServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAsterisk();
        }

        internal void AddAsterisk()
        {
            //EditAsteriskServerHost dlg = new EditAsteriskServerHost();
            RegisterAsteriskWizard dlg = new RegisterAsteriskWizard();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                AsteriskController c = new AsteriskController();
                c.ManagerConnectionInfo = dlg.ManagerConnectionInfo;
                asteriskControllers.Add(c);
                createControllerTreeNode(c);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAsterisk();
        }

        internal void DeleteAsterisk()
        {
            if (this.treeViewInventory.SelectedNode != null &&
                this.treeViewInventory.SelectedNode.Tag as AsteriskController != null)
            {
                AsteriskController c = this.treeViewInventory.SelectedNode.Tag as AsteriskController;
                if (MessageBox.Show(string.Format("Do you want to delete AsteriskServer?", c.ManagerConnectionInfo.Name), "Delete AsteriskServer Confirm", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    asteriskControllers.Remove(c);
                    asteriskServerTreeNodeRoot.Nodes.Remove(this.treeViewInventory.SelectedNode);

                }
            };
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void connect()
        {
            if (this.treeViewInventory.SelectedNode != null &&
                this.treeViewInventory.SelectedNode.Tag as AsteriskController != null)
            {
                AsteriskController c = this.treeViewInventory.SelectedNode.Tag as AsteriskController;
                if (!c.Connected)
                {

                    serverTreeNodeConnectionStateChanged(treeViewInventory.SelectedNode, ServerTreeNodeConnectionState.Connecting);
                    // If worker thread currently executing, cancel it
                    if (this.backgroundWorker1.IsBusy)
                    {
                        return;
                    }
                    progressWindow = new ConnectAsteriskServerProgress();
                    this.backgroundWorker1.RunWorkerAsync(progressWindow);
                    progressWindow.AsteriskController = c;
                    progressWindow.SelectedNode = this.treeViewInventory.SelectedNode;
                    progressWindow.ShowDialog();
                    progressWindow = null;
                }
            };
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeViewInventory.SelectedNode != null &&
                this.treeViewInventory.SelectedNode.Tag as AsteriskController != null)
            {
                AsteriskController c = this.treeViewInventory.SelectedNode.Tag as AsteriskController;
                if (c.Connected)
                {
                    serverTreeNodeConnectionStateChanged(treeViewInventory.SelectedNode, ServerTreeNodeConnectionState.Disconnecting);
                    c.Disconnect();
                }
                serverTreeNodeConnectionStateChanged(treeViewInventory.SelectedNode, ServerTreeNodeConnectionState.Disconnected);
            };

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeViewInventory.SelectedNode != null &&
                this.treeViewInventory.SelectedNode.Tag as AsteriskController != null)
            {
                AsteriskController c = this.treeViewInventory.SelectedNode.Tag as AsteriskController;
                if (c.Connected)
                {
                    c.Reload();
                }
            };
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeViewInventory.SelectedNode != null &&
                this.treeViewInventory.SelectedNode.Tag as AsteriskController != null)
            {
                AsteriskController c = this.treeViewInventory.SelectedNode.Tag as AsteriskController;
                //ManagerConnectionInfo copy = new ManagerConnectionInfo(c.ManagerConnectionInfo.Host,
                //    c.ManagerConnectionInfo.User, c.ManagerConnectionInfo.Password);
                //copy.Name = c.ManagerConnectionInfo.Name;

                EditAsteriskServerHost dlg = new EditAsteriskServerHost();
                dlg.AsteriskConnectionInfo = c.ManagerConnectionInfo;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    c.ManagerConnectionInfo = dlg.AsteriskConnectionInfo;
                    //c.ManagerConnectionInfo = copy;
                }
            }
        }
        #endregion

        private void treeViewInventory_DoubleClick(object sender, EventArgs e)
        {
            connect();
        }
    }

    enum ServerTreeNodeConnectionState
    {
        Disconnected, Connecting, Connected, Disconnecting
    }

    public class AsteriskSelectChangedEventArg : EventArgs
    {
        private AsteriskController asteriskController;
        public AsteriskSelectChangedEventArg(AsteriskController asteriskController)
        {
            this.asteriskController = asteriskController;
        }

        public AsteriskController AsteriskController
        {
            get { return asteriskController; }
            set { asteriskController = value; }
        }
    }

}
