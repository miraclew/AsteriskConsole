using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class ConfigVariable : ConfigElement 
    {
        private string name;

        private string value;

    public ConfigVariable(string name, string value)
    {
        this.Name = name;
        this.Value = value;
    }

    public ConfigVariable(string filename, int lineno, string name, string value)
        : base(filename, lineno)
    {
        this.Name = name;
        this.Value = value;
    }

    public string Name
    {
        get { return name; }
        set {
            if (value == null)
            {
                throw new ArgumentNullException("Variable name must not be null");
            }
            name = value; 
        }
    }

    public string Value
    {
        get { return this.value; }
        set { this.value = value; }
    }

    protected override StringBuilder rawFormat(StringBuilder sb)
    {
        sb.Append(name).Append(" = ");
        if (value != null)
        {
            sb.Append(value);
        }
        return sb;
    }
    
    public override string ToString()
    {
        return name+"="+value;
    }

    }
}
