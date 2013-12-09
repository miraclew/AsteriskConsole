using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace VisualAsterisk.Main.Gui.Log
{
    class TraceWindowTraceListener : TraceListener
    {
        private TraceWindow window;
        public TraceWindowTraceListener(TraceWindow window)
        {
            this.window = window;
        }

        public override void Write(string message)
        {
            window.WriteMessage(message);
        }

        public override void WriteLine(string message)
        {
            window.WriteMessageLine(message);
        }
    }
}
