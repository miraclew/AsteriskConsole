using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class MissingDirectiveParameterException : ConfigParseException
    {
    private const long serialVersionUID = -3802754628756681515L;
    public MissingDirectiveParameterException(string filename, int lineno, string format, params object[] args)
        : base(filename, lineno, format, args)
    {
    }
    }
}
