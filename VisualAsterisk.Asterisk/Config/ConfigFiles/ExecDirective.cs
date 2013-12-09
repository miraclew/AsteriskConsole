using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class ExecDirective : ConfigDirective
    {
        /// <summary>
        /// file Name of the executable.
        /// </summary>
        private readonly string execFile;

        public ExecDirective(string execFile)
        {
            this.execFile = execFile;
        }

        public ExecDirective(string filename, int lineno, string execFile)
            : base(filename, lineno)
        {
            this.execFile = execFile;
        }

        public string getExecFile()
        {
            return execFile;
        }


        protected override StringBuilder rawFormat(StringBuilder sb)
        {
            sb.Append("#exec \"").Append(execFile).Append("\"");
            return sb;
        }
    }
}
