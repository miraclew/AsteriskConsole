using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;
using System.Diagnostics;
using VisualAsterisk.Asterisk.Exception;
using WeifenLuo.WinFormsUI.Docking;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class ChannelPanel : DockPage
    {
        public ChannelPanel()
        {
            InitializeComponent();
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
                foreach (AsteriskChannel c in server.Channels)
                {
                    OnNewChannel(this, c);
                }
                server.NewAsteriskChannel += new NewChannelEventHandler(server_NewAsteriskChannel);
                server.AsteriskChannelRemoved += new ChannelRemovedEventHandler(server_RemoveAsteriskChannel);
            }
        }

        void server_RemoveAsteriskChannel(object sender, AsteriskChannel channel)
        {
            this.Invoke(new ChannelRemovedEventHandler(OnRemoveChannel), new object[] { sender, channel });
        }

        void server_NewAsteriskChannel(object sender, AsteriskChannel channel)
        {
            this.Invoke(new NewChannelEventHandler(OnNewChannel), new object[] { sender, channel });
        }

        void OnNewChannel(object sender, AsteriskChannel channel)
        {
            lock (this.asteriskChannelBindingSource.SyncRoot)
            {
                try
                {
                    this.asteriskChannelBindingSource.Add(channel);
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }

        void OnRemoveChannel(object sender, AsteriskChannel channel)
        {
            lock (this.asteriskChannelBindingSource.SyncRoot)
            {
                try
                {
                    if (this.asteriskChannelBindingSource.Contains(channel))
                    {
                        this.asteriskChannelBindingSource.Remove(channel);
                    }
                    else
                    {
                        // may be we Delete the reference From the gridview before
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }

            }
        }

        private void asteriskChannelDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this.asteriskChannelBindingSource.Current;
        }

        #region Channel Actions
        private void hangupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lock (this.asteriskChannelBindingSource.SyncRoot)
            {
                if (this.asteriskChannelDataGridView.SelectedCells.Count > 0 && this.asteriskChannelBindingSource.Current != null)
                {
                    AsteriskChannel channel = this.asteriskChannelBindingSource.Current as AsteriskChannel;
                    if (channel != null)
                    {
                        try
                        {
                            channel.Hangup();
                        }
                        catch (NoSuchChannelException exception)
                        {
                            Trace.TraceWarning(exception.Message);
                            MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Hangup", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void timeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int timeout = 10;

            EditTimeout dlg = new EditTimeout();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                timeout = dlg.Timeout;
                lock (this.asteriskChannelBindingSource.SyncRoot)
                {
                    if (this.asteriskChannelDataGridView.SelectedCells.Count > 0 && this.asteriskChannelBindingSource.Current != null)
                    {
                        AsteriskChannel channel = this.asteriskChannelBindingSource.Current as AsteriskChannel;
                        if (channel != null)
                        {
                            try
                            {
                                channel.SetAbsoluteTimeout(timeout);
                            }
                            catch (NoSuchChannelException exception)
                            {
                                Trace.TraceWarning(exception.Message);
                                MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Set Timeout", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditChannelMonitor dlg = new EditChannelMonitor();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lock (this.asteriskChannelBindingSource.SyncRoot)
                {
                    if (this.asteriskChannelDataGridView.SelectedCells.Count > 0 && this.asteriskChannelBindingSource.Current != null)
                    {
                        AsteriskChannel channel = this.asteriskChannelBindingSource.Current as AsteriskChannel;
                        if (channel != null)
                        {
                            try
                            {
                                channel.StartMonitoring(dlg.File, dlg.Format, dlg.Mix);
                            }
                            catch (NoSuchChannelException exception)
                            {
                                Trace.TraceWarning(exception.Message);
                                MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Monitor", MessageBoxButtons.OK);
                            }
                        }
                    }
                }

            }
        }

        private void stopMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lock (this.asteriskChannelBindingSource.SyncRoot)
            {
                if (this.asteriskChannelDataGridView.SelectedCells.Count > 0 && this.asteriskChannelBindingSource.Current != null)
                {
                    AsteriskChannel channel = this.asteriskChannelBindingSource.Current as AsteriskChannel;
                    if (channel != null)
                    {
                        try
                        {
                            channel.StopMonitoring();
                        }
                        catch (NoSuchChannelException exception)
                        {
                            Trace.TraceWarning(exception.Message);
                            MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Stop Monitor", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void redirectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditChannelRedirect dlg = new EditChannelRedirect();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lock (this.asteriskChannelBindingSource.SyncRoot)
                {
                    if (this.asteriskChannelDataGridView.SelectedCells.Count > 0 && this.asteriskChannelBindingSource.Current != null)
                    {
                        AsteriskChannel channel = this.asteriskChannelBindingSource.Current as AsteriskChannel;
                        if (channel != null)
                        {
                            try
                            {
                                channel.Redirect(dlg.Context, dlg.Exten, dlg.Priority);
                            }
                            catch (NoSuchChannelException exception)
                            {
                                Trace.TraceWarning(exception.Message);
                                MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Redirect", MessageBoxButtons.OK);
                            }
                        }
                    }
                }

            }
        }

        private void setVarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditChannelSetVar dlg = new EditChannelSetVar();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lock (this.asteriskChannelBindingSource.SyncRoot)
                {
                    if (this.asteriskChannelDataGridView.SelectedCells.Count > 0 && this.asteriskChannelBindingSource.Current != null)
                    {
                        AsteriskChannel channel = this.asteriskChannelBindingSource.Current as AsteriskChannel;
                        if (channel != null)
                        {
                            try
                            {
                                channel.SetVariable(dlg.Variable, dlg.Value);
                            }
                            catch (NoSuchChannelException exception)
                            {
                                Trace.TraceWarning(exception.Message);
                                MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Set Var", MessageBoxButtons.OK);
                            }
                        }
                    }
                }

            }
        }

        private void getVarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditChannelGetVar dlg = new EditChannelGetVar();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lock (this.asteriskChannelBindingSource.SyncRoot)
                {
                    if (this.asteriskChannelDataGridView.SelectedCells.Count > 0 && this.asteriskChannelBindingSource.Current != null)
                    {
                        AsteriskChannel channel = this.asteriskChannelBindingSource.Current as AsteriskChannel;
                        if (channel != null)
                        {
                            try
                            {
                                string value = channel.GetVariable(dlg.Variable);
                                MessageBox.Show(string.Format("{0}={1}", dlg.Variable, value), "GetVar Result");
                            }
                            catch (NoSuchChannelException exception)
                            {
                                Trace.TraceWarning(exception.Message);
                                MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Get Var", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        private void getInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Get Info", MessageBoxButtons.OK);
        }

        private void orignateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditChannelOriginate dlg = new EditChannelOriginate();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CallerId callerId = dlg.CallerId;
                Dictionary<string, string> variables = new Dictionary<string, string>();
                foreach (VariableBinding vb in dlg.Variables)
                {
                    if (!variables.ContainsKey(vb.Variable))
                    {
                        variables.Add(vb.Variable, vb.Value);
                    }
                }

                try
                {
                    if (!string.IsNullOrEmpty(dlg.Context) && !string.IsNullOrEmpty(dlg.Exten) && dlg.Priority != null)
                    {
                        if (callerId != null && variables != null)
                        {
                            server.OriginateToExtension(dlg.Channel, dlg.Context, dlg.Exten, dlg.Priority, dlg.Timeout, callerId, variables);
                        }
                        else
                        {
                            server.OriginateToExtension(dlg.Channel, dlg.Context, dlg.Exten, dlg.Priority, dlg.Timeout);
                        }

                    }
                    else if (!string.IsNullOrEmpty(dlg.Application) && !string.IsNullOrEmpty(dlg.Data))
                    {
                        if (callerId != null && variables != null)
                        {
                            server.originateToApplication(dlg.Channel, dlg.Application, dlg.Data, dlg.Timeout, callerId, variables);
                        }
                        else
                        {
                            server.originateToApplication(dlg.Channel, dlg.Application, dlg.Data, dlg.Timeout);
                        }
                    }
                    else
                    {
                        server.originateToApplication(dlg.Channel, "noop", null, dlg.Timeout, callerId, variables);
                        Trace.TraceWarning("EditChannelOriginate: invalid input");
                        MessageBox.Show("Invalid input");
                    }
                }
                catch (NoSuchChannelException exception)
                {
                    Trace.TraceWarning(exception.Message);
                    MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Originate", MessageBoxButtons.OK);
                }
                catch (ArgumentException exception)
                {
                    Trace.TraceWarning(exception.Message);
                    MessageBox.Show(string.Format("Failed: {0}", exception.Message), "Originate", MessageBoxButtons.OK);
                }
            }
        }
        #endregion

        private void asteriskChannelDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }


        }
    }
}
