using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using VisualAsterisk.Test;
using VisualAsterisk.Core.Management.SystemInfo;
using NUnit.Framework;

namespace VisualAsterisk.Test.Simulator
{
    public class SystemInfoSim : SimulatorBase, ISystemInfoProvider
    {
        private OS m_OS;

        private void createRandomOsInstance()
        {
            string[] mountPoint = { "/","/usr", "/opt", "/boot"};
            Random random = new Random();

            m_OS = new OS();
            m_OS.Cpu.UsagePercent = random.NextDouble();
            m_OS.Cpu.Info = "haha";

            m_OS.Memory.Capacity = random.Next(100, 1000);
            m_OS.Memory.UsagePercent = random.NextDouble();

            m_OS.Swap.Capacity = random.Next(100, 1000);
            m_OS.Swap.UsagePercent = random.NextDouble();

            m_OS.Uptime = new DateTime(random.Next(2001, 2009), random.Next(1, 12), random.Next(1, 20), random.Next(0, 23), random.Next(0, 59), random.Next(0, 59));
            
            m_OS.Version = "2.2.1";
            
            for (int i = 0; i < 3; i++)
            {
                HardDriver hd = new HardDriver();
                hd.MountPoint = mountPoint[random.Next(0, 3)];
                hd.Capacity = random.Next(100, 1000);
                hd.UsagePercent = random.NextDouble();
                hd.PartitonName = string.Format("hda{0}", random.Next(1, 10));
                m_OS.HardDrivers.Add(hd);
            }      
        }

        public OS Os
        {
            get { return m_OS; }
            set { m_OS = value; }
        }

        #region SimulatorBase member
        protected override void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            EventHandler<OperatingSystemInfoChangedEventArgs> eh = OperatingSystemInfoChanged;
            if (eh != null)
            {
                createRandomOsInstance();
                eh(this, new OperatingSystemInfoChangedEventArgs(m_OS));
            }
        }

        public override void Start()
        {
            m_Timer.Start();
        }

        public override void Stop()
        {
            m_Timer.Stop();
        }
        #endregion

        #region ISystemInfoProvider member

        public event EventHandler<OperatingSystemInfoChangedEventArgs> OperatingSystemInfoChanged;

        #endregion
    }

    [TestFixture]
    public class SystemInfoSimTest
    {
        [Test]
        public void Test()
        {
            SystemInfoSim sim = new SystemInfoSim();
            sim.OperatingSystemInfoChanged += new EventHandler<OperatingSystemInfoChangedEventArgs>(sim_OperatingSystemInfoChanged);
            sim.Start();
            Thread.Sleep(10000);
            sim.Stop();
        }

        void sim_OperatingSystemInfoChanged(object sender, OperatingSystemInfoChangedEventArgs e)
        {
            Console.WriteLine(string.Format("CPU usage: {0}", e.OS.Cpu.Usage));
            Console.WriteLine(string.Format("CPU Info: {0}", e.OS.Cpu.Info));
            Console.WriteLine(string.Format("Memory usage: {0} of {1}", e.OS.Memory.Usage, e.OS.Memory.CapacityString));
            Console.WriteLine(string.Format("Swap usage: {0} of {1}", e.OS.Swap.Usage, e.OS.Swap.CapacityString));
            Console.WriteLine(e.OS.Uptime.ToString());
            Console.WriteLine(string.Format("Version: {0}", e.OS.Version));
            foreach (HardDriver var in e.OS.HardDrivers)
            {
                Console.WriteLine(string.Format("HardDirver: {0} Usage: {1} of {2}", var.MountPoint, var.Usage, var.CapacityString));
            }
        }
    }
}
