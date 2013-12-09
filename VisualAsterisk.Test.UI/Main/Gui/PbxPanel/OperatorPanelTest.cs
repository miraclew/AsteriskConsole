using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui.PbxPanel;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Test.UI;

namespace VisualAsterisk.Test.Main.Gui.PbxPanel
{
    class OperatorPanelTest : AbstractUITestCase
    {
        OperatorPanel panel = new OperatorPanel();
        public OperatorPanelTest()
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
