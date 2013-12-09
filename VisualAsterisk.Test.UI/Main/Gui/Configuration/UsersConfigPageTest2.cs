using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Test.UI;

namespace VisualAsterisk.Test.Main.Gui.Configuration
{
    class UsersConfigPageTest2 : AbstractUITestCase
    {
        UsersConfigPage panel = new UsersConfigPage();
        public UsersConfigPageTest2()
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
