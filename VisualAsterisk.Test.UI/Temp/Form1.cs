using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SipCommunicator;

namespace VisualAsterisk.Test.UI.Temp
{
    public partial class Form1 : Form
    {
        IncommingCallForm incommingCall = new IncommingCallForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //incommingCall.ShowNotifier();
        }       
    }
}
