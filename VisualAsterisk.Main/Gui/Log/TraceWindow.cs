using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;
using System.Diagnostics;

namespace VisualAsterisk.Main.Gui.Log
{
    public partial class TraceWindow : DockContent
    {
        delegate void WriteMessageDelegate(string message);
        private TraceWindowTraceListener traceListener;
        private bool enabled = false;
        public TraceWindow()
        {
            InitializeComponent();
            traceListener = new TraceWindowTraceListener(this);
            if (enabled)
            {
                Trace.Listeners.Add(traceListener);                
            }
        }

        internal void WriteMessage(string message)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.Invoke(new WriteMessageDelegate(delegate(string msg)
                {
                    this.textBox1.Text = string.Concat(this.textBox1.Text, msg);
                }), new string[] { message });
            }
        }

        internal void WriteMessageLine(string message)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.Invoke(new WriteMessageDelegate(delegate(string msg)
                    {
                        this.textBox1.Text = string.Concat(this.textBox1.Text, msg + "\r\n");
                    }), new string[] { message });
            }
        }

        private void TraceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trace.Listeners.Remove(traceListener);
        }
    }
}
