using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Main.Controller
{
    public class ChannelController
    {
        public enum Operation
        {
            Originate = 0, GetInfo = 1, GetVar = 2, SetVar = 3, Timeout = 4, Monitor = 5, ChangeMonitor = 6, StopMonitor = 7, Redirect = 8, Hangup = 9
        }

        public void Originate() { }
        public void GetInfo() { }
        public void GetVar() { }
        public void SetVar() { }
        public void Timeout() { }
        public void Monitor() { }
        public void ChangeMonitor() { }
        public void StopMonitor() { }
        public void Redirect() { }
        public void Hangup() { }

    }

}
