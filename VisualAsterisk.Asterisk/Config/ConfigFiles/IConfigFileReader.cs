using System;
namespace VisualAsterisk.Asterisk.Config.ConfigFiles
{
    interface IConfigFileReader
    {
        VisualAsterisk.Asterisk.Config.ConfigFile ReadFile(string configfile);
        VisualAsterisk.Asterisk.Config.ConfigFile ReadString(string configFileName, string fileContent);
    }
}
