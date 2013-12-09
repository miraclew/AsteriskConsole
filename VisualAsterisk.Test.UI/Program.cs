using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VisualAsterisk.Test.Simulator;
using Asterisk.NET.Manager;
using VisualAsterisk.Test.Asterisk;
using System.Diagnostics;
using VisualAsterisk.Main;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Test.UI.Temp;

namespace VisualAsterisk.Test.UI
{
    static class Program
    {
        private static FormTestRuner testRunner;
        /// <summary>
        /// The main entry point for the Application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.Listeners.Add(new TextWriterTraceListener("visual_asterisk_test.log"));
            Trace.AutoFlush = true;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            Application.Run(new Form1());
            //runVisuaAsteriskTest();
        }

        private static void runVisuaAsteriskTest()
        {
            //AsteriskManager.Default.Initial();
            AsteriskManager.Default.AsteriskControllers = createControllers();
            //AsteriskManager.Default.CurrentAsteriskController = AsteriskManager.Default.AsteriskControllers[0];
            testRunner = new FormTestRuner();
            Application.Run(testRunner);
            //AsteriskManager.Default.Shutdown();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ErrorReporter box = new ErrorReporter();
            box.ErrorMessage = e.Exception.ToString();
            box.ShowDialog();
        }
        
        public static List<AsteriskController> createControllers()
        {
            List<AsteriskController> contorllers = new List<AsteriskController>();
            for (int i = 0; i < 10; i++)
            {
                AsteriskController c = new AsteriskController();
                c.Connected = true;
                c.ToolInstalled = true;
                c.ManagerConnectionInfo = new ManagerConnectionInfo("111.111.1." + (i + 1).ToString(), "user_" + i.ToString(), "");
                c.Server = TestData.Instace().Server;
                contorllers.Add(c);
            }
            return contorllers;
        }

        #region GUI debug - VisualAsterisk.Main.Gui.Configuration

        private static void Debug_Main_Gui_Configuration()
        {
            DefaultAsteriskServer server = new DefaultAsteriskServer("192.168.88.129", "admin", "abc123");
            server.Initialize();

            //debugUserConfigPage(Server);
            //debugQueueConfigPage(Server);
            //debugConfRoomConfigPage(Server);
        }

        #endregion
    }
}