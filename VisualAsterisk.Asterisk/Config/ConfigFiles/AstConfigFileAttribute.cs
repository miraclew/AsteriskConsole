using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class AstConfigFileAttribute : System.Attribute
    {
        public AstConfigFileAttribute(string file, string description)
        {
            this.file = file;
            this.description = description;
        }
        string file;
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string File
        {
            get { return file; }
            set { file = value; }
        }
    }
}
