using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AstFileEditor
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigFileVariablesDataBase.Default.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FileEditorForm());
        }
    }
}
