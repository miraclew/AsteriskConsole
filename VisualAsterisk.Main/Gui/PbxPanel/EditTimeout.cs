using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class EditTimeout : DialogBase
    {
        public EditTimeout()
        {
            InitializeComponent();
        }

        private int timeout = 0;

        public int Timeout
        {
            get
            {
                try
                {
                    int i = int.Parse(this.textBox1.Text);
                    if (i > 0)
                    {
                        timeout = i;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return timeout;
            }
            set
            {
                if (value > 0)
                {
                    timeout = value;
                }
            }
        }
    }
}
