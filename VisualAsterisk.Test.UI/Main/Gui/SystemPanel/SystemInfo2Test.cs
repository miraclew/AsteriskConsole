using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui.SystemPanel;

namespace VisualAsterisk.Test.UI.Main.Gui.SystemPanel
{
    class SystemInfo2Test : AbstractUITestCase
    {
        SystemInfo2 panel = new SystemInfo2();

        public SystemInfo2Test()
        {
            target = panel;
        }
        
        public override void Run()
        {
            panel.Enabled = true;
            if (TestData.Instace().Server != null && TestData.Instace().Server.IsConnected())
            {
                panel.Server = TestData.Instace().Server;
            }
            panel.Show();
        }
    }
}
