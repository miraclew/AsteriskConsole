using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui.Configuration
{
    public partial class EditCodecDlg : DialogBase
    {
        private string allow;
        private string disallow;
        
        public string Allow
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (object item in allowedCodeListBox.Items)
                {
                    sb.Append(Codecs.NameToCodec[item.ToString()] + ",");
                }
                allow = sb.ToString().TrimEnd(',');
                return allow;
            }
            set
            {
                allow = value;
            }
        }

        public string Disallow
        {
            get
            {
                disallow = "all";
                return disallow;
            }
            set
            {
                disallow = value;
            }
        }

        public EditCodecDlg(IEnumerable<string> codecs)
        {
            InitializeComponent();

            foreach (string item in codecs)
            {
                disallowedCodeListBox.Items.Add(Codecs.CodecToName[item]);                
            }
        }

        private void disallowSelectedCodecButton_Click(object sender, EventArgs e)
        {
            if (allowedCodeListBox.SelectedItem != null)
            {
                disallowedCodeListBox.Items.Add(allowedCodeListBox.SelectedItem);
                allowedCodeListBox.Items.Remove(allowedCodeListBox.SelectedItem);
            }
        }

        private void allowSelectedCodecButton_Click(object sender, EventArgs e)
        {
            if (disallowedCodeListBox.SelectedItem != null)
            {
                allowedCodeListBox.Items.Add(disallowedCodeListBox.SelectedItem);
                disallowedCodeListBox.Items.Remove(disallowedCodeListBox.SelectedItem);
            }
        }

        private void disallowAllCodeButton_Click(object sender, EventArgs e)
        {
            foreach (object item in allowedCodeListBox.Items)
            {
                disallowedCodeListBox.Items.Add(item);
            }
            allowedCodeListBox.Items.Clear();
        }
    }
}
