using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui;

namespace VisualAsterisk.Test.UI.Main.Gui
{
    class AsteriskOptionsTest : AbstractUITestCase
    {
        private AsteriskOptions panel = new AsteriskOptions();
        public AsteriskOptionsTest()
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
