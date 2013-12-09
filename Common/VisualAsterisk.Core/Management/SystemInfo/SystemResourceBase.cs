using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Management.SystemInfo
{
    public class SystemResourceBase
    {
        string m_Usage;

        public string Usage
        {
            get { return string.Format("{0:##.##}%",m_UsagePercent*100); }
        }
        double m_UsagePercent;

        public double UsagePercent
        {
            get { return m_UsagePercent; }
            set { m_UsagePercent = value; }
        }
        
    }
}
