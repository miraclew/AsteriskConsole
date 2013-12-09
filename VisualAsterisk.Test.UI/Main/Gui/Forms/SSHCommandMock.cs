using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Core.SSH;
using System.Diagnostics;
using System.Reflection;

namespace VisualAsterisk.Test.UI.Main.Gui.Forms
{
    class SSHCommandMock : ISSHCommand
    {
        private bool closed;

        public bool Closed
        {
            get { return closed; }
            set { closed = value; }
        }

        #region ISSHCommand 成员

        public void Close()
        {
            closed = true;
            Trace.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        public void Connect(string host, string user, string password)
        {
            Trace.WriteLine(string.Format("{0}({1}{2}{3})", MethodBase.GetCurrentMethod().Name, host, user, password));
        }

        public void Execute(string cmd)
        {
            Trace.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        #endregion
    }
}
