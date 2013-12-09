using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Dialplan;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public interface IConfiguration
    {
        //IList<KeyValuePair<string, string>> GetConfigKeyValuePairs();

        /// <summary>
        /// Create a IConfiguration instance from parsing Category and lines 
        /// </summary>
        /// <param Name="Category"></param>
        /// <param Name="lines"></param>
        /// <returns></returns>
        //static IConfiguration Parse(string Category, Dictionary<int, string> lines);  
         void LoadUsersConfig(ConfigFile file, string cat);
         void LoadExtensionsConfig(ExtensionsConfigFile file, Category cat);
    }
}
