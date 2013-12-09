using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk;

namespace AstFileEditor
{
    public class FileLoader
    {
        private static FileLoader instance = new FileLoader();
        private FileLoader()
        {
            
        }

        public static FileLoader Default
        {
            get { return instance; }
        }

        IAsteriskServer server;
        List<string> allConfigFiles = new List<string>();

        public List<string> AllConfigFiles
        {
            get { return allConfigFiles; }
            set { allConfigFiles = value; }
        }

        public IAsteriskServer Server
        {
            get { return server; }
            set { server = value; }
        }

        public string Load(string file)
        {
            string path = server.GetConfigFile(file);
            return path;
        }

        public void Save(string file)
        {
            server.UpdateConfigFile(file);
        }
    }
}
