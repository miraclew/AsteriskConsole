using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Internal
{
    public class AstContext
    {
        public AstContext()
        {
            extens = new List<AstExten>();
            includes = new List<AstInclude>();
            ignorepats = new List<AstIgnorepat>();

        }
        List<AstExten> extens;

        public List<AstExten> Extens
        {
            get { return extens; }
            set { extens = value; }
        }
        List<AstInclude> includes;

        public List<AstInclude> Includes
        {
            get { return includes; }
            set { includes = value; }
        }
        List<AstIgnorepat> ignorepats;

        public List<AstIgnorepat> Ignorepats
        {
            get { return ignorepats; }
            set { ignorepats = value; }
        }
        string registrar;

        public string Registrar
        {
            get { return registrar; }
            set { registrar = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[{0}]\n", name);
            foreach (AstInclude var in includes)
            {
                sb.Append(var.ToString());
            }
            foreach (AstExten var in extens)
            {
                sb.Append(var.ToString());
            }
            foreach (AstIgnorepat var in ignorepats)
            {
                if (var.Name !=null && var.Name.Length > 0)
                {
                    sb.AppendFormat("ignorepat => {0}\n", var.Name);
                }                
            }
            return sb.ToString();
        }
    }

    public class AstMacro
    {
        public AstMacro()
        {
            extens = new List<AstExten>();
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        List<AstExten> extens;

        public List<AstExten> Extens
        {
            get { return extens; }
            set { extens = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[macro-{0}]\n", name);
            foreach (AstExten var in extens)
            {
                sb.Append(var.ToString());
            }
            return sb.ToString();
        }
    }

    public class AstIgnorepat
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
