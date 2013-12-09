using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui;

namespace VisualAsterisk.Test.UI.Main.Gui
{
    class CheckUpdatesDlgTest : AbstractUITestCase
    {
        private CheckUpdatesDlg dlg = new CheckUpdatesDlg();
        public CheckUpdatesDlgTest()
        {
            target = dlg;
        }
        public override void Run()
        {
            dlg.Show();
        }
    }
}
