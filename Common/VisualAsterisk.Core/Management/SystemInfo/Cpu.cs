using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Management.SystemInfo
{
    public class CPU : SystemResourceBase
    {
        string m_Info;

        public string Info
        {
            get { return m_Info; }
            set { m_Info = value; }
        }

    }
}
