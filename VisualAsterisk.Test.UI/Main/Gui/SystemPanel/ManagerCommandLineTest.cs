using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Test.UI;

namespace VisualAsterisk.Test.Main.Gui.SystemPanel
{
    class ManagerCommandLineTest : AbstractUITestCase
    {
        ManagerCommandLine panel = new ManagerCommandLine();
        public ManagerCommandLineTest()
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
