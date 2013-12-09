using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class IncludeDirective : ConfigDirective
    {
        /**
         * file Name included.
         */
        private readonly string includeFile;

        public IncludeDirective(string includeFile)
        {
            this.includeFile = includeFile;
        }

        public IncludeDirective(string filename, int lineno, string includeFile)
            : base(filename, lineno)
        {
            this.includeFile = includeFile;
        }

        public string getIncludeFile()
        {
            return includeFile;
        }


        protected override StringBuilder rawFormat(StringBuilder sb)
        {
            sb.Append("#include \"").Append(includeFile).Append("\"");
            return sb;
        }
    }
}
