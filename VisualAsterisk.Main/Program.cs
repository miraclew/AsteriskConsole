using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VisualAsterisk.Main.Gui.SystemPanel;
using VisualAsterisk.Main.Controller;
using System.Diagnostics;
using VisualAsterisk.Main.Gui;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Core;
using System.IO;
using System.Xml.Serialization;
using VisualAsterisk.Main.UI;
using VisualAsterisk.ExceptionManagement;

namespace VisualAsterisk.Main
{
    static class Program
    {
        public static bool DemoMode = false;
        public static bool AdminMode = false;
        public static bool RemoteMode = false;
        public static bool CreatVersionFileMode = false;
        public static bool MinimizeMode = false;
        public static bool VSDebugMode = false;
        /// <summary>
        /// The main entry point for the Application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.StartsWith("-d", true, System.Globalization.CultureInfo.InvariantCulture) || arg.StartsWith("/d", true, System.Globalization.CultureInfo.InvariantCulture))
                    DemoMode = true;

                if (arg.StartsWith("-cv", true, System.Globalization.CultureInfo.InvariantCulture) || arg.StartsWith("/cv", true, System.Globalization.CultureInfo.InvariantCulture))
                    CreatVersionFileMode = true;

                if (arg.StartsWith("-hide", true, System.Globalization.CultureInfo.InvariantCulture) || arg.StartsWith("/hide", true, System.Globalization.CultureInfo.InvariantCulture))
                    MinimizeMode = true;

                if (arg.StartsWith("-admin", true, System.Globalization.CultureInfo.InvariantCulture) || arg.StartsWith("/admin", true, System.Globalization.CultureInfo.InvariantCulture))
                    AdminMode = true;

                if (arg.StartsWith("-r", true, System.Globalization.CultureInfo.InvariantCulture) || arg.StartsWith("/r", true, System.Globalization.CultureInfo.InvariantCulture))
                    RemoteMode = true;

                if (arg.StartsWith("-vsdebug", true, System.Globalization.CultureInfo.InvariantCulture) || arg.StartsWith("/vsdebug", true, System.Globalization.CultureInfo.InvariantCulture))
                    VSDebugMode = true;
            }

            if (CreatVersionFileMode)
            {
                dumpVersion();
                return;
            }

            if (Properties.Settings.Default.UICulture == null || Properties.Settings.Default.UICulture.Length == 0)
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            else
            {
                try
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.UICulture);

                }
                catch (ArgumentException)
                {
                }
            }
            if (!VSDebugMode)
            {
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();

            Trace.TraceInformation("Main() Begin");
            AsteriskManager.Default.AsteriskControllersXmlFileFullName =  Application.StartupPath + "\\asterisk_controllers.xml";
            AsteriskManager.Default.Initial();

            MainForm adminUI = new MainForm();
            if (MinimizeMode)
            {
                adminUI.WindowState = FormWindowState.Minimized;
            }
            Application.Run(adminUI);
            AsteriskManager.Default.Shutdown();
            Trace.TraceInformation("Main() End");
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception is System.Threading.ThreadAbortException)
                System.Threading.Thread.ResetAbort();
            else
                ErrorCaptureUtils.SendError(e.Exception, "", "", Application.ProductVersion, Properties.Settings.Default.ErrorReportURL, true);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is System.Threading.ThreadAbortException)
                System.Threading.Thread.ResetAbort();
            else
                ErrorCaptureUtils.SendError((Exception)e.ExceptionObject, "", "", Application.ProductVersion, Properties.Settings.Default.ErrorReportURL, true);
        }

        private static void dumpVersion()
        {
            VisualAsteriskVersion version = new VisualAsteriskVersion(
                typeof(MainForm).Assembly.GetName().Version.ToString(4));
            version.Bugfixes = VisualAsteriskChanges.Default.Bugfixes;
            version.Features = VisualAsteriskChanges.Default.Features;
            try
            {
                FileStream fs = new FileStream("version.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(typeof(VisualAsteriskVersion));
                xs.Serialize(fs, version);
                fs.Close();
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}