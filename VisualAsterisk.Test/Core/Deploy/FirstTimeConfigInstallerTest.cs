using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VisualAsterisk.Core.Deploy;

namespace VisualAsterisk.Test.Core.Deploy
{
    [TestFixture]
    public class FirstTimeConfigInstallerTest
    {
        [Test]
        public void Test()
        {
            string toolsPath = @"D:\Project\VisualAsterisk\VisualAsterisk.Installer\VisualAsteriskTools\preinstall\visualasterisk-tools.tar.gz";
            FirstTimeConfigInstaller installer = new FirstTimeConfigInstaller(toolsPath);
            installer.Connect("192.168.88.129", "root", "Ideal12");
            installer.CheckPreInstallCondition();
            installer.Install();
            installer.RestartAsterisk();
        }
    }
}
