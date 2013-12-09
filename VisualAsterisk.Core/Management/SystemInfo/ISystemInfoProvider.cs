using System;
using VisualAsterisk.Core.Management;

namespace VisualAsterisk.Core.Management.SystemInfo
{
    public interface ISystemInfoProvider
    {
        event EventHandler<OperatingSystemInfoChangedEventArgs> OperatingSystemInfoChanged;
        OS Os { get; set; }
        void Start();
        void Stop();
    }

    public class OperatingSystemInfoChangedEventArgs : EventArgs
    {
        public OperatingSystemInfoChangedEventArgs(OS os)
        {
            m_OS = os;
        }
        private OS m_OS;

        public OS OS
        {
            get { return m_OS; }
        }
    }
}
