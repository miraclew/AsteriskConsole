using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Management.SystemInfo
{
    public class OS
    {
        public OS()
        {
            m_Cpu = new CPU();
            m_Memory = new Memory();
            m_Swap = new HardDriver();
            m_HardDrivers = new List<HardDriver>();
        }
        CPU m_Cpu;

        public CPU Cpu
        {
            get { return m_Cpu; }
            set { m_Cpu = value; }
        }
        Memory m_Memory;

        public Memory Memory
        {
            get { return m_Memory; }
            set { m_Memory = value; }
        }

        List<HardDriver> m_HardDrivers;

        public List<HardDriver> HardDrivers
        {
            get { return m_HardDrivers; }
            set { m_HardDrivers = value; }
        }
        HardDriver m_Swap;

        public HardDriver Swap
        {
            get { return m_Swap; }
            set { m_Swap = value; }
        }

        DateTime m_Uptime;

        public DateTime Uptime
        {
            get { return m_Uptime; }
            set { m_Uptime = value; }
        }

        string m_Name;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        string m_Version;

        public string Version
        {
            get { return m_Version; }
            set { m_Version = value; }
        }
    }
}
