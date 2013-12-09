using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class MissingEqualSignException : ConfigParseException
    {
    private const long serialVersionUID = 2694490330074765342L;
    public MissingEqualSignException(string filename, int lineno, string format, params object[] args)
        : base(filename, lineno, format, args)
    {
    }
    }
}
