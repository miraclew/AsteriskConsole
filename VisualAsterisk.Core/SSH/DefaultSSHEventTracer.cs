using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Granados;

namespace VisualAsterisk.Core.SSH
{
    class DefaultSSHEventTracer : ISSHEventTracer
    {
        public void OnTranmission(string type, string detail)
        {
            Debug.WriteLine("T:" + type + ":" + detail);
        }
        public void OnReception(string type, string detail)
        {
            Debug.WriteLine("R:" + type + ":" + detail);
        }
    }
}
