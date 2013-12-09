using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Dialplan
{
    public class ExtensionsConfigFile : ConfigFile
    {
        public ExtensionsConfigFile(string filename, Dictionary<string, Category> categories)
            : base(filename, categories)
        {
        }

        public ICollection<Category> Contexts
        {
            get
            {
                return categories.Values;
            }
        }
    }
}
