using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Dialplan
{
    public class ConfigInclude : ConfigElement
    {
        string category;

        public ConfigInclude(string filename, int lineno, string category)
            : base(filename, lineno)
        {
            this.category = category;
        }


        protected override StringBuilder rawFormat(StringBuilder sb)
        {
            return sb.Append(ToString());
        }


        public override string ToString()
        {
            return "include => " + category;
        }

        public string Name
        {
            get
            { return category; }
        }
    }
}
