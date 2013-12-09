using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SipPhone
{
    public partial class IncommingCallForm : Form
    {
        System.Timers.Timer timer;
        public IncommingCallForm(string number, int timeout)
        {
            InitializeComponent();
            this.numberLabel.Text = number;
            timer = new System.Timers.Timer(timeout);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
            timer.Start();
        }

        void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Close();
        }

        private void IncommingCallForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
