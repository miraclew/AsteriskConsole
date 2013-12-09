using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.Configuration
{
    public partial class AddDialPlanDlg : DialogBase
    {
        public AddDialPlanDlg()
        {
            InitializeComponent();
        }

        private string dialPlanName;

        public string DialPlanName
        {
            get { return dialPlanName; }
            set { dialPlanName = value; }
        }
    }
}
