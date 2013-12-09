using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class EditChannelSetVar : DialogBase
    {
        private string variable;

        public string Variable
        {
            get {
                variable = this.textBoxVariable.Text;
                return variable; 
            }
            set { variable = value; }
        }
        private string _value;

        public string Value
        {
            get {
                _value = this.textBoxValue.Text;
                return _value; 
            }
            set { _value = value; }
        }
        public EditChannelSetVar()
        {
            InitializeComponent();
        }
    }
}
