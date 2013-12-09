using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public abstract class ConfigElement
    {
        /// <summary>
        /// Name of the file the Category was Read from.
        /// </summary>
        private string fileName;

        /// <summary>
        /// Line Number.
        /// </summary>
        private int lineno;
        private string preComment;
        private string samelineComment;

        public int LineNumber
        {
            get { return lineno; }
            set { lineno = value; }
        }

        public string PreComment
        {
            get { return preComment; }
            set { preComment = value; }
        }

        public string Comment
        {
            get { return samelineComment; }
            set { samelineComment = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        protected ConfigElement()
        {
        }

        protected ConfigElement(string filename, int lineno)
        {
            this.fileName = filename;
            this.lineno = lineno;
        }

        internal StringBuilder format(StringBuilder sb)
        {
            if (preComment != null && preComment.Length != 0)
            {
                sb.Append(preComment);
            }

            rawFormat(sb);

            if (samelineComment != null && samelineComment.Length != 0)
            {
                sb.Append(" ; ").Append(samelineComment);
            }

            return sb;
        }

        protected abstract StringBuilder rawFormat(StringBuilder sb);
    }
}
