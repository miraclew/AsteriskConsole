using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class EditChannelGetVar : DialogBase
    {
        private string variable;

        public string Variable
        {
            get
            {
                variable = this.textBoxVariable.Text;
                return variable;
            }
            set { variable = value; }
        }

        public EditChannelGetVar()
        {
            InitializeComponent();
        }
    }
}
