using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;
using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Main.UI.Forms;
using VisualAsterisk.Main.Controller;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class VoiceMenusView : DataViewControl
    {
        public VoiceMenusView()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            base.OnLoadData();
            if (AsteriskManager.Default.IsCurrentControllerOK())
            {
                this.voiceMenuBindingSource.DataSource = configManager.VoiceMenus;
            }
        }

        private void voiceMenuBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            VoiceMenu m = this.voiceMenuBindingSource.Current as VoiceMenu;
        }

        private void addNewVoiceMenuButton_Click(object sender, EventArgs e)
        {
            VoiceMenu menu = new VoiceMenu();
            menu.Name = "voicemenu" + configManager.VoiceMenus.Count + 1;
            menu.AddingNew = true;
            
            VoiceMenuEditorForm editor = new VoiceMenuEditorForm(menu, server);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                configManager.UpdateVoiceMenu(menu);
                this.voiceMenuBindingSource.Add(menu);
            }
        }

        private void voiceMenuVisualAsteriskEditDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            VoiceMenu menu = this.voiceMenuBindingSource.Current as VoiceMenu;
            if (menu != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete VoiceMenu {0}", menu.Name),
    "Delete VoiceMenu Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.voiceMenuBindingSource.Remove(menu);
                    if (!menu.AddingNew)
                    {
                        configManager.RemoveVoiceMenu(menu);
                    }
                }
            }

        }

        private void voiceMenuVisualAsteriskEditDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            VoiceMenu menu = e.DataRow.DataBoundItem as VoiceMenu;
            if (menu == null)
            {
                return;
            }

            VoiceMenuEditorForm2 editor = new VoiceMenuEditorForm2(menu, server);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                configManager.UpdateVoiceMenu(menu);
            }
            else
            {
                menu.CancelEdit();
            }
        }
    }
}
