using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Diagnostics;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("extensions.conf", "Extensions config file")]
    public class Extension : ConfigFileBase
    {
        public Extension()
        {
            categories.Add("General", new List<PropertyInfo>());
            categories.Add("Globals", new List<PropertyInfo>());

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(AstConfigPropertyAttribute), false);
                object[] cats = pi.GetCustomAttributes(typeof(CategoryAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    AstConfigPropertyAttribute pro = pros[0] as AstConfigPropertyAttribute;
                    if (pro.Exclude)
                    {
                        continue;
                    }
                }

                if (cats != null && cats.Length > 0)
                {
                    CategoryAttribute c = cats[0] as CategoryAttribute;
                    categories[c.Category].Add(pi);
                }
            }

            globals = new List<AstVariable>();
            contexts = new List<AstContext>();
            macros = new List<AstMacro>();
        }

        // [General]
        bool _static = false;

        [CategoryAttribute("General"), DescriptionAttribute("")]
        public bool Static
        {
            get { return _static; }
            set { _static = value; }
        }

        bool writeProtect = true;

        [CategoryAttribute("General"), DescriptionAttribute("")]
        public bool WriteProtect
        {
            get { return writeProtect; }
            set { writeProtect = value; }
        }

        bool autoFallthrough = true;

        [CategoryAttribute("General"), DescriptionAttribute("")]
        public bool AutoFallthrough
        {
            get { return autoFallthrough; }
            set { autoFallthrough = value; }
        }

        bool clearGlobalvars = false;

        [CategoryAttribute("General"), DescriptionAttribute("")]
        public bool ClearGlobalvars
        {
            get { return clearGlobalvars; }
            set { clearGlobalvars = value; }
        }

        bool priorityJumping = false;

        [CategoryAttribute("General"), DescriptionAttribute("")]
        public bool PriorityJumping
        {
            get { return priorityJumping; }
            set { priorityJumping = value; }
        }

        // [globals]
        List<AstVariable> globals;

        [CategoryAttribute("Globals"),Browsable(false), DescriptionAttribute("")]
        [AstConfigProperty(AstConfigPropertyClass.Category, Name = "globals")]
        public List<AstVariable> Globals
        {
            get { return globals; }
            set { globals = value; }
        }

        List<AstContext> contexts;

        [Browsable(false)]
        [AstConfigProperty(AstConfigPropertyClass.CategoryCollection)]
        public List<AstContext> Contexts
        {
            get { return contexts; }
            set { contexts = value; }
        }

        List<AstMacro> macros;

        [Browsable(false)]
        [AstConfigProperty(AstConfigPropertyClass.CategoryCollection)]
        public List<AstMacro> Macros
        {
            get { return macros; }
            set { macros = value; }
        }

        string userscontext = "default";

        protected override void Clear()
        {
            base.Clear();
            globals.Clear();
            contexts.Clear();
            macros.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            foreach (AstContext ctx in contexts)
            {
                sb.Append("\n");
                sb.Append(ctx.ToString());
                Trace.TraceInformation(ctx.ToString());
                Trace.TraceInformation("----------------");
            }
            foreach (AstMacro m in macros)
            {
                sb.Append("\n");
                sb.Append(m.ToString());
            }
            return sb.ToString();
        }

        protected override void LoadCategory(AstCategory cat)
        {
            if (cat.Name.Equals("globals"))
            {
                foreach (AstVariable var in cat.Variables)
                {
                    globals.Add(var);
                }
            }
            else if (cat.Name.StartsWith("macro-"))
            {
                AstMacro macro = new AstMacro();
                macro.Name = cat.Name.Substring(("macro-").Length);
                int lastpri = 0;
                foreach (AstVariable var in cat.Variables)
                {
                    try
                    {
                        if (var.Name == "exten")
                        {
                            macro.Extens.Add(parseExten(macro.Name, var, ref lastpri));
                        }
                        else
                        {
                            Trace.TraceError("var name is not exten in marco");
                        }
                    }
                    catch (System.Exception e)
                    {
                        //Trace.TraceError("error Priority {0}", pri);
                        throw;
                    }
                }
                macros.Add(macro);
            }
            else
            {
                AstContext context = new AstContext();
                context.Name = cat.Name;
                int lastpri = 0;
                foreach (AstVariable var in cat.Variables)
                {
                    try
                    {
                        if (var.Name == "exten")
                        {
                            context.Extens.Add(parseExten(context.Name, var,ref lastpri));
                        } /* if (var.Name == "Exten") */
                        else if (var.Name == "include")
                        {
                            AstInclude include = new AstInclude();
                            include.Name = var.Value;
                            include.Rname = var.Value;
                            context.Includes.Add(include);
                        }
                        else if (var.Name == "ignorepat")
                        {
                            AstIgnorepat ip = new AstIgnorepat();
                            ip.Name = var.Value;
                            context.Ignorepats.Add(ip);
                        }
                    }
                    catch (System.Exception e)
                    {
                        //Trace.TraceError("error Priority {0}", pri);
                        throw;
                    }
                }

                contexts.Add(context);

            }
        }

        private AstExten parseExten(string context, AstVariable var, ref int lastpri)
        {
            string exten = null, application = null, label = null;
            int priority;
            object appData = null;

            int index1 = var.Value.IndexOf(",");
            int index2 = var.Value.IndexOf(",", index1 + 1);
            int index3 = var.Value.IndexOf("(", index2 + 1);
            int index4 = var.Value.LastIndexOf(")");

            exten = var.Value.Substring(0, index1);
            string pri = var.Value.Substring(index1 + 1, index2 - index1 - 1);
            if (pri != "hint")
            {
                if (pri == "n" || pri == "next")
                {
                    priority = ++lastpri;
                }
                else
                {
                    int index5 = pri.IndexOf("(");
                    int index6 = pri.IndexOf(")", index5 + 1);

                    if (index5 > -1 && index6 > -1)
                    {
                        priority = int.Parse(pri.Substring(0, index5));
                        label = pri.Substring(index5 + 1, index6 - index5 - 1);
                    }
                    else
                    {
                        priority = int.Parse(pri);
                    }

                    lastpri = priority;
                }
                application = var.Value.Substring(index2 + 1, index3 - index2 - 1);
                appData = var.Value.Substring(index3 + 1, index4 - index3 - 1);
            }
            else
                priority = -1;
            return new AstExten(context, exten, priority, application, appData);
        }
    }
}
