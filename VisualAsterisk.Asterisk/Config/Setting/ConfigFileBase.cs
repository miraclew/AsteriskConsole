using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using VisualAsterisk.Asterisk.Config.Internal;
using VisualAsterisk.Asterisk.Exception;

namespace VisualAsterisk.Asterisk.Config
{
    public class ConfigFileBase
    {
        /// <summary>
        /// Creates an instance of ConfigClassBase From AstConfig.
        /// </summary>
        /// <param Name="cfg"></param>
        /// <returns>Instace of ConfigClassBase</returns>
        public static ConfigFileBase Parse(AstConfig cfg)
        {
            //m_Logger.Debug(MethodBase.GetCurrentMethod().Name);
            if (m_ConfigFileTypes[cfg.FileName] == null)
            {
                //m_Logger.Error("{0}.{1} - could not find a ConfigFile class for {2}", typeof(ConfigFileBase).Name, MethodBase.GetCurrentMethod().Name, cfg.FileName);
                throw new ConfigFileBaseException("Unknown config file: " + cfg.FileName);
            }

            Type type = m_ConfigFileTypes[cfg.FileName] as Type;
            ConfigFileBase configFile = (ConfigFileBase)type.GetConstructor(Type.EmptyTypes).Invoke(null);
            configFile.Clear();

            for (int i = 0; i < cfg.Categories.Count; i++)
            {
                if (cfg.Categories[i].Name.Equals("general") && configFile.SetGeneralProperties)
                {
                    configFile.setProperties(configFile, cfg.Categories[i]);
                }
                else
                {
                    configFile.LoadCategory(cfg.Categories[i]);
                }
            }
            return configFile;
            
        }

        protected virtual void LoadCategory(AstCategory cat) { }

        protected virtual void Clear() { }

        protected void setProperties(object obj, AstCategory cat)
        {            
            for (int i = 0; i < cat.Variables.Count; i++)
            {
                AstVariable var = cat.Variables[i];
                PropertyInfo pi = obj.GetType().GetProperty(var.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (pi != null)
                {
                    if (pi.PropertyType.Name.Equals("Int32"))
                    {
                        pi.SetValue(obj, int.Parse(var.Value), null);
                    }
                    else if (pi.PropertyType.Name.Equals("string"))
                    {
                        pi.SetValue(obj, var.Value, null);
                    }
                    else if (pi.PropertyType.Name.Equals("Boolean"))
                    {
                        if (var.Value.ToLower().Equals("yes") || var.Value.ToLower().Equals("1"))
                            pi.SetValue(obj, true, null);
                        else if (var.Value.ToLower().Equals("no") || var.Value.ToLower().Equals("0"))
                            pi.SetValue(obj, false, null);
                        else
                        {
                            pi.SetValue(obj, false, null);
                            
                            Trace.TraceWarning("Unknown type - {0}", pi.GetType().ToString());
                        }
                    }
                    else if (pi.PropertyType.Name.Equals("UserHost"))
                    {
                        if (var.Value.ToLower().Equals("static"))
                        {
                            pi.SetValue(obj, UserHost.Static, null);
                        }
                        else if (var.Value.ToLower().Equals("dynamic"))
                        {
                            pi.SetValue(obj, UserHost.Dynamic, null);
                        }
                        else
                        {                            
                            Trace.TraceError("Unknown UserHost - {0}", var.Value);
                        }
                    }
                    else if (pi.PropertyType.Name.Equals("UserType"))
                    {
                        if (var.Value.ToLower().Equals("friend"))
                        {
                            pi.SetValue(obj, UserType.Friend, null);
                        }
                        else if (var.Value.ToLower().Equals("peer"))
                        {
                            pi.SetValue(obj, UserType.Peer, null);
                        }
                        else if (var.Value.ToLower().Equals("user"))
                        {
                            pi.SetValue(obj, UserType.User, null);
                        }
                        else
                        {
                            Trace.TraceError("Unknown UserHost - {0}", var.Value);
                        }
                    }
                    else if (pi.PropertyType.IsGenericType && var.IsObject == 1)
                    {
                        List<string> pv = new List<string>();

                    }
                    else
                    {
                        Trace.TraceError("Unknown type - {0}", pi.PropertyType.Name);
                    }

                }
                else
                {
                    Trace.TraceError("No such property - {0}", var.Name);
                }                
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string cat in categories.Keys)
            {
                sb.AppendFormat("[{0}]\n", cat.ToLower());
                foreach (PropertyInfo pi in categories[cat])
                {
                    if (pi.GetValue(this, null) == null) continue;

                    sb.Append(PropertyToString(pi, this));
                }
            }
            return sb.ToString();
        }

        static public string PropertyToString(PropertyInfo pi, object obj)
        {
            if (pi.GetValue(obj, null) == null) return "";

            StringBuilder sb = new StringBuilder();

            object[] atts = pi.GetCustomAttributes(typeof(AstConfigPropertyAttribute), false);
            if (atts != null && atts.Length > 0)
            {
                AstConfigPropertyAttribute pro = atts[0] as AstConfigPropertyAttribute;
                switch (pro.PropertyClass)
                {
                    case AstConfigPropertyClass.Var:
                        sb.AppendFormat("{0} = {1}\n", pi.Name.ToLower(), pi.GetValue(obj, null).ToString());
                        break;
                    case AstConfigPropertyClass.Object:
                        foreach (object var in pi.GetValue(obj, null) as IEnumerable)
                        {
                            if (var.GetType() == typeof(string))
                            {
                                sb.AppendFormat("{0} => {1}\n", pro.Name, var);
                            }
                            else
                            {
                                sb.AppendFormat("{0}\n", var.ToString());
                            }
                        }
                        break;
                    case AstConfigPropertyClass.Category:
                        foreach (object var in pi.GetValue(obj, null) as IEnumerable)
                        {
                            if (var.GetType() == typeof(string))
                            {
                                sb.AppendFormat("{0} = {1}\n", pro.Name, var);
                            }
                            else
                            {
                                sb.AppendFormat("{0}\n", var.ToString());
                            }
                        }
                        break;
                    case AstConfigPropertyClass.CategoryCollection:
                        foreach (object var in pi.GetValue(obj, null) as IEnumerable)
                        {
                            sb.AppendFormat("{0}", var.ToString());
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                // no attribute, we treat it as AstConfigPropertyClass.Var
                string str = SimplePropertyToString(pi, obj);
                sb.AppendFormat("{0} = {1}\n", pi.Name.ToLower(), str);
            }
            return sb.ToString();
        }

        protected void fillCategoryTable()
        {
            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(AstConfigPropertyAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    AstConfigPropertyAttribute pro = pros[0] as AstConfigPropertyAttribute;
                    if (pro.Exclude)
                    {
                        continue;
                    }
                    switch (pro.PropertyClass)
                    {
                        case AstConfigPropertyClass.Category:
                            break;
                        case AstConfigPropertyClass.CategoryCollection:
                            foreach (object var in pi.GetValue(this, null) as IEnumerable)
                            {
                                
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static string SimplePropertyToString(PropertyInfo pi, object obj)
        {
            string str = "";
            switch (pi.PropertyType.Name)
            {
                case "Boolean":
                    bool b = (bool)pi.GetValue(obj, null); // pi.GetValue(this, null) as Boolean;
                    if (b)
                    {
                        str = "yes";
                    }
                    else
                    {
                        str = "no";
                    }
                    break;
                case "string":
                    str = pi.GetValue(obj, null) as string;
                    break;
                default:
                    str = pi.GetValue(obj, null).ToString();
                    break;
            }
            return str;
        }
        /// <summary>
        /// Initializes static variables.
        /// </summary>
        static ConfigFileBase()
        {
            m_ConfigFileTypes = new Dictionary<string, Type>();
            Type[] configFileTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in configFileTypes)
            {
                if (type.IsSubclassOf(typeof(ConfigFileBase)))
                {
                    AstConfigFileAttribute[] attributes = (AstConfigFileAttribute[])type.GetCustomAttributes(typeof(AstConfigFileAttribute), false);
                    foreach (AstConfigFileAttribute attribute in attributes)
                    {
                        //m_Logger.Debug("Adding entry : m_CommandTypes[{0}] = {1}", attribute.ControllerCommandName, commandInfo.ToString());
                        //m_ConfigFileTypes[attribute.File] = (ConfigFileBase)Type.GetConstructor(Type.EmptyTypes).Invoke(null);
                        m_ConfigFileTypes[attribute.File] = type;
                    }
                }
            } 
        }

        protected ConfigFileBase()
        {
            categories = new Dictionary<string, List<PropertyInfo>>();
        }

        protected virtual void SetupVariables() { }
        protected virtual void SetupConfig() { }

        protected virtual bool SetGeneralProperties
        {
            get { return true; }
        }

        private static IDictionary<string, Type> m_ConfigFileTypes;
        protected IDictionary<string, List<PropertyInfo>> categories;
    }

    /// <summary>
    /// Exception thrown by ConfigFileBase
    /// </summary>
    public class ConfigFileBaseException : AsteriskException
    {
        /// <summary>
        /// Initializes the new instance of exception
        /// </summary>
        /// <param Name="message">exception message</param>
        public ConfigFileBaseException(string message)
            : base(message)
        { }

        /// <summary>
        /// Initializes the new instance of exception
        /// </summary>
        /// <param Name="message">exception message</param>
        /// <param Name="internalException">internal exception</param>
        public ConfigFileBaseException(string message, System.Exception internalException)
            : base(message, internalException)
        { }
    }
}
