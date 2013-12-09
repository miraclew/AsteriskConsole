using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui.Forms;

namespace VisualAsterisk.Test.UI.Main.Gui.Forms
{
    class InitialConfigSetupTest : AbstractUITestCase
    {
        RegisterAsteriskWizard pannel = new RegisterAsteriskWizard();
        public InitialConfigSetupTest()
        {
            target = pannel;
        }

        public override void Run()
        {
            pannel.Enabled = true;
            //pannel.Server = TestData.Instace().Server;
            pannel.Installer = new InitialConfigInstaller();
            pannel.Show();
        }
    }
}
