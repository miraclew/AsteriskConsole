using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Management.SystemInfo
{
    public enum HardDriverType
    {
        Ext2,Ext3,Swap
    }
    public class HardDriver : StorageBase
    {
        string m_MountPoint;

        public string MountPoint
        {
            get { return m_MountPoint; }
            set { m_MountPoint = value; }
        }

        string m_PartitonName;

        public string PartitonName
        {
            get { return m_PartitonName; }
            set { m_PartitonName = value; }
        }
    }
}
