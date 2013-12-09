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
    public partial class AddCallingRuleDlg : DialogBase
    {
        public AddCallingRuleDlg()
        {
            InitializeComponent();
        }

        private CallingRule rule;

        public CallingRule Rule
        {
            get { return rule; }
        }

    }
}
