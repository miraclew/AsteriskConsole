using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Configuration;

namespace AstFileEditor
{
    class ConfigFileVariablesDataBase
    {
        private static ConfigFileVariablesDataBase db = new ConfigFileVariablesDataBase();
        public static ConfigFileVariablesDataBase Default
        {
            get
            {
                return db;
            }
        }

        private Dictionary<string, List<string>> fileVariables = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> FileVariables
        {
            get { return fileVariables; }
        }

        public void Build()
        {
            Type[] configFileTypes = Assembly.GetAssembly(typeof(VisualAsterisk.Asterisk.Config.ConfigFileBase)).GetTypes();
            foreach (Type type in configFileTypes)
            {
                if (type.IsSubclassOf(typeof(VisualAsterisk.Asterisk.Config.ConfigFileBase)))
                {
                    AstConfigFileAttribute[] typeAttributes = (AstConfigFileAttribute[])type.GetCustomAttributes(typeof(AstConfigFileAttribute), false);
                    if (typeAttributes != null && typeAttributes.Length > 0)
                    {
                        AstConfigFileAttribute attribute = typeAttributes[0];
                        List<string> variables = new List<string>();

                        foreach (var pi in type.GetProperties())
                        {
                            object[] atts = pi.GetCustomAttributes(typeof(ConfigurationPropertyAttribute), false);
                            if (atts != null && atts.Length > 0)
                            {
                                ConfigurationPropertyAttribute pro = atts[0] as ConfigurationPropertyAttribute;
                                variables.Add(pro.Name);
                            }
                        }
                        fileVariables.Add(attribute.File, variables);
                    }
                }
            } 

        }
    }
}
