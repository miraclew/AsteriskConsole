using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class UnknownDirectiveException : ConfigParseException
    {
    private const long serialVersionUID = 4356355066633810196L;
    public UnknownDirectiveException(string filename, int lineno, string format, params object[] args)
        : base(filename, lineno, format, args)
    {
    }
    }
}
