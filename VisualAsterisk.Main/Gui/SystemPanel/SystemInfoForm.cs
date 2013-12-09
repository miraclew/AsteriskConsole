using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ZedGraph;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Core.Management.SystemInfo;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class SystemInfoForm : DockPage
    {
        delegate void FormAsyncOperationDelegate(object data);
        private EventHandler<OperatingSystemInfoChangedEventArgs> systemInfoChangeEventHandler;
        private ISystemInfoProvider m_SystemInfo;

        public SystemInfoForm()
        {
            InitializeComponent();
            systemInfoChangeEventHandler = new EventHandler<OperatingSystemInfoChangedEventArgs>(sim_OperatingSystemInfoChanged);
        }

        public ISystemInfoProvider SystemInfo
        {
            get { return m_SystemInfo; }
            set
            {
                m_SystemInfo = value;
                if (m_SystemInfo != null)
                {
                    m_SystemInfo.OperatingSystemInfoChanged += systemInfoChangeEventHandler;
                    m_SystemInfo.Start();
                    dispalyCpuMemoryUsageHistory();
                    tickStart = Environment.TickCount;
                }
            }
        }

        private void SystemInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_SystemInfo != null)
            {
                m_SystemInfo.OperatingSystemInfoChanged -= systemInfoChangeEventHandler;
            }
        }

        private void SystemInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_SystemInfo != null)
            {
                m_SystemInfo.Stop();
            }
        }

        void sim_OperatingSystemInfoChanged(object sender, OperatingSystemInfoChangedEventArgs e)
        {
            if (this.Disposing)
            {
                return;
            }
            this.Invoke(new FormAsyncOperationDelegate(performAsyncOperation), e);
        }

        #region paint graph
        private void refrashCpuMemoryUsageHistory(double cpu, double memory)
        {
            if (zedGraphControlCPUMemoryUsageHistory.GraphPane.CurveList.Count != 2)
                return;
            LineItem curve = zedGraphControlCPUMemoryUsageHistory.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list1 = curve.Points as IPointListEdit;
            if (list1 == null)
                return;

            curve = zedGraphControlCPUMemoryUsageHistory.GraphPane.CurveList[1] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list2 = curve.Points as IPointListEdit;
            if (list2 == null)
                return;

            double time = (Environment.TickCount - tickStart) / 1000.0;

            list1.Add(time, cpu);
            list2.Add(time, memory);

            Scale xScale = zedGraphControlCPUMemoryUsageHistory.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30.0;
            }

            zedGraphControlCPUMemoryUsageHistory.AxisChange();
            zedGraphControlCPUMemoryUsageHistory.Invalidate();
        }

        private void dispalyCpuMemoryUsageHistory()
        {
            GraphPane myPane = this.zedGraphControlCPUMemoryUsageHistory.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "Cpu Memory Usage History";
            myPane.XAxis.Title.Text = "";
            myPane.YAxis.Title.Text = "";
            myPane.Fill = new Fill(Color.White, Color.Goldenrod, 45.0f);
            myPane.Chart.Fill = new Fill(Color.Black);

            RollingPointPairList list1 = new RollingPointPairList(1200);
            RollingPointPairList list2 = new RollingPointPairList(1200);
            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve = myPane.AddCurve("CPU", list1, Color.Red, SymbolType.None);

            // Generate a blue curve with circle
            // symbols, and "Piper" in the legend
            LineItem myCurve2 = myPane.AddCurve("Memory",
                list2, Color.Blue, SymbolType.None);
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;

            this.zedGraphControlCPUMemoryUsageHistory.AxisChange();
        }
        int tickStart = 0;

        private void listViewHardDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHardDrivers.SelectedItems.Count != 1) return;
            HardDriver hd = listViewHardDrivers.SelectedItems[0].Tag as HardDriver;
            if (hd == null) return;

            GraphPane myPane = this.zedGraphControlHardDrivers.GraphPane;
            myPane.Title.Text = "Disk Usage";
            myPane.Title.FontSpec.IsItalic = true;
            myPane.Title.FontSpec.Size = 24f;
            myPane.Title.FontSpec.Family = "Times New Roman";

            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.Goldenrod, 45.0f);
            // No fill for the axis background
            myPane.Chart.Fill.Type = FillType.None;

            // Set the legend to an arbitrary Location
            myPane.Legend.Position = LegendPos.Float;
            myPane.Legend.Location = new Location(0.95f, 0.15f, CoordType.PaneFraction,
                                AlignH.Right, AlignV.Top);
            myPane.Legend.FontSpec.Size = 15f;
            myPane.Legend.IsHStack = false;
            myPane.CurveList.Clear();
            PieItem segment1 = myPane.AddPieSlice(hd.UsagePercent * 100, Color.Navy, Color.White, 45f, 0, "Used space");
            PieItem segment2 = myPane.AddPieSlice((1 - hd.UsagePercent) * 100, Color.Purple, Color.White, 45f, .0, "Free space");
            this.zedGraphControlHardDrivers.AxisChange();
            this.zedGraphControlHardDrivers.Invalidate();
        }
        #endregion

        void performAsyncOperation(object data)
        {
            if (data is OperatingSystemInfoChangedEventArgs)
            {
                OperatingSystemInfoChangedEventArgs e = data as OperatingSystemInfoChangedEventArgs;
                Console.WriteLine(string.Format("CPU usage: {0}", e.OS.Cpu.Usage));
                this.labelCPUUsage.Text = e.OS.Cpu.Usage;
                Console.WriteLine(string.Format("CPU Info: {0}", e.OS.Cpu.Info));
                this.labelCPUInfo.Text = e.OS.Cpu.Info;
                Console.WriteLine(string.Format("Memory usage: {0} of {1}", e.OS.Memory.Usage, e.OS.Memory.CapacityString));
                this.labelMemoryUsage.Text = string.Format("{0} of {1}", e.OS.Memory.Usage, e.OS.Memory.CapacityString);
                Console.WriteLine(string.Format("Swap usage: {0} of {1}", e.OS.Swap.Usage, e.OS.Swap.CapacityString));
                this.labelSwapUsage.Text = string.Format("{0} of {1}", e.OS.Swap.Usage, e.OS.Swap.CapacityString);
                Console.WriteLine(e.OS.Uptime.ToString());
                this.labelUptime.Text = e.OS.Uptime.ToString();
                Console.WriteLine(string.Format("Version: {0}", e.OS.Version));

                this.listViewHardDrivers.Items.Clear();
                foreach (HardDriver var in e.OS.HardDrivers)
                {
                    ListViewItem item = new ListViewItem(var.PartitonName);
                    item.SubItems.Add(var.CapacityString);
                    item.SubItems.Add(var.Usage);
                    item.SubItems.Add(var.MountPoint);
                    item.Tag = var;
                    listViewHardDrivers.Items.Add(item);
                    Console.WriteLine(string.Format("HardDirver: {0} Usage: {1} of {2}", var.MountPoint, var.Usage, var.CapacityString));
                }
                refrashCpuMemoryUsageHistory(e.OS.Cpu.UsagePercent, e.OS.Memory.UsagePercent);
            }
        }
    }
}