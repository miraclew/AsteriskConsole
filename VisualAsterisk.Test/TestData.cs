using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk;
using System.Windows.Forms;
using System.IO;

namespace VisualAsterisk.Test
{
    public class TestData
    {
        private IAsteriskServer server;
        private string csvDataDirectory = Path.Combine(Environment.CurrentDirectory,
            @"..\..\..\TestData\cdr");

        public string CsvDataDirectory
        {
            get { return csvDataDirectory; }
            set { csvDataDirectory = value; }
        }

        public IAsteriskServer Server
        {
            get { return server; }
            set { server = value; }
        }

        private static TestData instance;

        public void Initialize()
        {
            try
            {
                server.Initialize();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Connect server {0} failed : {1}", 
                    server.ConnectionInfo.Host, e.Message));
            }                
        }

        public void Dispose()
        {
            server.Shutdown();
        }

        public static TestData Instace()
        {
            if (instance == null)
            {
                instance = new TestData();
            }
            return instance; 
        }
    }
}
