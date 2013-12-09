using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Test.UI;

namespace VisualAsterisk.Test.Main.Gui.Configuration
{
    class ConferencingConfigPageTest : AbstractUITestCase
    {
        ConferencingConfigPage panel = new ConferencingConfigPage();
        public ConferencingConfigPageTest()
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
