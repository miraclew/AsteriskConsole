using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Management.SystemInfo
{
    public class StorageBase : SystemResourceBase
    {
        double m_Capacity;

        public double Capacity
        {
            //get { return m_Capacity; }
            set { m_Capacity = value; }
        }

        string m_Unit = "GB";

        public string Unit
        {
            get { return m_Unit; }
            set { m_Unit = value; }
        }

        public string CapacityString
        {
            get { return string.Format("{0} {1}",m_Capacity,m_Unit); }
        }
    }
}
