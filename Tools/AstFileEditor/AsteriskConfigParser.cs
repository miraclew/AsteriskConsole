using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config;

namespace AstFileEditor
{
    class AsteriskConfigParser
    {
        public static ConfigFile Parse(string fileName, string text)
        {
            ConfigFileReader reader = new ConfigFileReader();
            return reader.ReadString(fileName, text);
        }
    }
}
