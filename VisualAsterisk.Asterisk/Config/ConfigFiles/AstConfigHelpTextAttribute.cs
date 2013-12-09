using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    [AttributeUsage(AttributeTargets.All)]
    class AstConfigHelpTextAttribute : System.Attribute
    {
        public AstConfigHelpTextAttribute(string helpText)
        {
            this.helpText = helpText;
        }
        string helpText;

        public string HelpText
        {
            get { return helpText; }
            set { helpText = value; }
        }
    }
}
