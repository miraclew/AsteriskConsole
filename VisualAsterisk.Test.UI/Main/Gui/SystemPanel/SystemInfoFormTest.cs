using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Test.Simulator;
using VisualAsterisk.Test.UI;

namespace VisualAsterisk.Test.Main.Gui.SystemPanel
{
    class SystemInfoFormTest : AbstractUITestCase
    {
        SystemInfoForm f = new SystemInfoForm();

        public SystemInfoFormTest()
        {            
            target = f;
        }
        
        public override void Run()
        {            
            f.Enabled = true;
            SystemInfoSim sim = new SystemInfoSim();
            f.SystemInfo = sim;
            f.Show();
        }
    }
}
