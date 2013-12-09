using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Main.ViewControls;
using VisualAsterisk.Main.UI.Forms;
using VisualAsterisk.Main.Controller;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class TrunksView : DataViewControl
    {
        public TrunksView()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (AsteriskManager.Default.IsCurrentControllerOK())
            {
                this.trunkBindingSource.DataSource = configManager.Trunks;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Trunk trunk = this.trunkBindingSource.AddNew() as Trunk;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Trunk trunk = this.trunkBindingSource.Current as Trunk;
            if (trunk != null)
            {
                configManager.UpdateTrunk(trunk);
                //this.buttonSubmit.Enabled = false;
                //this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Trunk trunk = this.trunkBindingSource.Current as Trunk;
            if (trunk != null)
            {
                trunk.CancelEdit();
                //this.buttonSubmit.Enabled = true;
                //this.buttonCancel.Enabled = false;
            }
        }

        private void trunkBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            Trunk trunk = new Trunk(trunkBindingSource.Count + 1);
            trunk.AddingNew = true;
            e.NewObject = trunk;
        }

        private void trunkBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemChanged:
                case ListChangedType.ItemDeleted:
                    //this.buttonSubmit.Enabled = true;
                    //this.buttonCancel.Enabled = true;
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

        private void addNewTrunkButton_Click(object sender, EventArgs e)
        {
            Trunk trunk = new Trunk(trunkBindingSource.Count + 1);
            trunk.AddingNew = true;

            TrunkEditorForm editor = new TrunkEditorForm(trunk, configManager);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                this.trunkBindingSource.Add(trunk);
                configManager.UpdateTrunk(trunk);
            }
        }

        private void trunkVisualAsteriskEditDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            Trunk trunk = e.DataRow.DataBoundItem as Trunk;
            if (trunk == null)
            {
                return;
            }

            TrunkEditorForm editor = new TrunkEditorForm(trunk, configManager);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                configManager.UpdateTrunk(trunk);
            }
        }

        private void trunkVisualAsteriskEditDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            Trunk trunk = this.trunkBindingSource.Current as Trunk;
            if (trunk != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete Trunk {0}", trunk.Trunkname),
                    "Delete Trunk Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.trunkBindingSource.RemoveCurrent();
                    if (!trunk.AddingNew)
                    {
                        configManager.RemoveTrunk(trunk);
                    }
                }
            }
        }
    }
}
