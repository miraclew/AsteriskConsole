using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VisualAsterisk.Test.Simulator;
using Asterisk.NET.Manager;
using VisualAsterisk.Test.Asterisk;
using System.Diagnostics;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Test.Asterisk.Config;
using VisualAsterisk.Core.SSH;
using VisualAsterisk.Test.Core.SSH;
using VisualAsterisk.Test.Core.Deploy;
using System.Globalization;
using VisualAsterisk.Test.Data;

namespace VisualAsterisk.Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the Application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AsteriskConfigManagerTest test = new AsteriskConfigManagerTest();
            //test.TestInitialize();
            //SSHCommandTest test = new SSHCommandTest();
            //test.TestCopyFileNotExsit();
            //TestFirstTimeConfigInstaller();
            //test1();
            //test.TestExecute();
            //AutoResetEventTest test = new AutoResetEventTest();
            //test.TestWaitOne();
            DefaultAsteriskServerDebug debug = new DefaultAsteriskServerDebug();
            debug.RandomCallTest();
        }

        private static void test1()
        {
            VisualAsteriskCsvDataProviderTest test = new VisualAsteriskCsvDataProviderTest();
            test.TestConnect();
        }

        private static void TestFirstTimeConfigInstaller()
        {
            FirstTimeConfigInstallerTest test = new FirstTimeConfigInstallerTest();
            DateTime.Now.ToString("yyyyMMMddHHmmss", CultureInfo.CreateSpecificCulture("en-US"));
            test.Test();
        }
    }
}