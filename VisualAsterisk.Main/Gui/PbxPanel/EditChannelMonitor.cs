using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class EditChannelMonitor : DialogBase
    {
        private string file;

        public string File
        {
            get {
                file = this.textBoxFile.Text;
                return file; 
            }
            set { file = value; }
        }
        private string format;

        public string Format
        {
            get {
                format = this.textBoxFormat.Text;
                return format; 
            }
            set { format = value; }
        }
        private bool mix;

        public bool Mix
        {
            get {
                mix = this.checkBoxMix.Checked;
                return mix; 
            }
            set { mix = value; }
        }

        public EditChannelMonitor()
        {
            InitializeComponent();
        }

    }
}
