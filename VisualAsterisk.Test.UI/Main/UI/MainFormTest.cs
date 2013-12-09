using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.UI;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Test.UI.Main.UI
{
    class MainFormTest : AbstractUITestCase
    {
        private MainForm panel;
        public MainFormTest()
        {
            panel = new MainForm(createControllers());
            target = panel;
        }

        private static List<AsteriskController2> createControllers()
        {
            List<AsteriskController2> contorllers = new List<AsteriskController2>();
            for (int i = 0; i < 10; i++)
            {
                AsteriskController2 c = new AsteriskController2();
                c.Connected = true;
                c.ManagerConnectionInfo = new ManagerConnectionInfo("111.111.1." + (i + 1).ToString(), "user_" + i.ToString(), "");
                c.Server = TestData.Instace().Server;
                contorllers.Add(c);
            }
            return contorllers;
        }

        public override void Run()
        {
            panel.Enabled = true;
            //if (TestData.Instace().Server != null && TestData.Instace().Server.IsConnected())
            //{
            //    panel.Server = TestData.Instace().Server;
            //}
            panel.Show();
        }
    }
}
