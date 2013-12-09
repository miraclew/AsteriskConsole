using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;
using VisualAsterisk.Main.Gui;

namespace VisualAsterisk.Main.UI.Forms
{
    public partial class ChooseKeyPressAction : DialogBase
    {
        private VoiceMenuActionItem action;

        public VoiceMenuActionItem Action
        {
            get 
            {
                return action;
            }
            set { action = value; }
        }
        private List<VoiceMenuActionItem> choices;

        public List<VoiceMenuActionItem> Choices
        {
            get { return choices; }
            set { choices = value;
            comboBox1.DisplayMember = "OptionsColumnDisplay";
            comboBox1.DataSource = choices;
            }
        }
        public ChooseKeyPressAction()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            action = comboBox1.SelectedValue as VoiceMenuActionItem;
        }
    }
}
