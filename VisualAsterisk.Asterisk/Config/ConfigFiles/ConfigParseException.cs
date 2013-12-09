using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Exception;

namespace VisualAsterisk.Asterisk.Config
{
    public class ConfigParseException : AsteriskException
    {
    private const long serialVersionUID = 4346366210261425734L;
    private string filename;
    private int lineno;

    public ConfigParseException(string filename, int lineno, string message)
        : base(message)
    {
        this.filename = filename;
        this.lineno = lineno;
    }

    public ConfigParseException(string filename, int lineno, string format, params object[] args)
        : base(string.Format(format, args))
    {
        this.filename = filename;
        this.lineno = lineno;
    }

    public string getFileName()
    {
        return filename;
    }

    public int getLineNumber()
    {
        return lineno;
    }
    }
}
