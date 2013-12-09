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
    public partial class TrunkConfigPage : DockPage
    {
        public TrunkConfigPage()
        {
            InitializeComponent();
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
                this.trunkBindingSource.DataSource = configManager.Trunks;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Trunk trunk = this.trunkBindingSource.AddNew() as Trunk;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Trunk trunk = this.trunkBindingSource.Current as Trunk;
            if (trunk != null)
            {
                configManager.UpdateTrunk(trunk);
                this.buttonSubmit.Enabled = false;
                this.buttonCancel.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Trunk trunk = this.trunkBindingSource.Current as Trunk;
            if (trunk != null)
            {
                trunk.CancelEdit();
                this.buttonSubmit.Enabled = true;
                this.buttonCancel.Enabled = false;
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
    }
}
