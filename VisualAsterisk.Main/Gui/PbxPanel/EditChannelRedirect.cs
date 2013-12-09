using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class EditChannelRedirect : DialogBase
    {
        private string context;

        public string Context
        {
            get {
                context = this.textBoxContext.Text;
                return context; 
            }
            set { context = value; }
        }
        private string exten;

        public string Exten
        {
            get {
                exten = this.textBoxExten.Text;
                return exten; 
            }
            set { exten = value; }
        }
        private int priority;

        public int Priority
        {
            get {
                priority = int.Parse(this.textBoxPriority.Text);
                return priority; 
            }
            set { priority = value; }
        }
        public EditChannelRedirect()
        {
            InitializeComponent();
        }
    }
}
