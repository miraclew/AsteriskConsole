using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui.PbxPanel;
using VisualAsterisk.Test.UI;

namespace VisualAsterisk.Test.Main.Gui.PbxPanel
{
    class ChannelPanelTest : AbstractUITestCase
    {
        ChannelPanel pannel = new ChannelPanel();
        public ChannelPanelTest()
        {
            target = pannel;
        }

        public override void Run()
        {
            pannel.Enabled = true;
            pannel.Server = TestData.Instace().Server;
            pannel.Show();
        }
    }
}
