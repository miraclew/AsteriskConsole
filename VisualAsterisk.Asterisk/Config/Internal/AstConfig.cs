using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Internal
{
    public class AstConfig
    {
        public AstConfig()
        {
            categories = new List<AstCategory>();
        }
        private List<AstCategory> categories;

        public List<AstCategory> Categories
        {
            get { return categories; }
            set { categories = value; }
        }
        int include_level;
        int max_include_level;
        string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
    }
}
