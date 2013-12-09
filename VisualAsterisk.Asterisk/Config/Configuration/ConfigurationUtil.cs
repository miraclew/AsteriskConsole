using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Collections;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    class ConfigurationUtil
    {
        public static IList<KeyValuePair<string, string>> GetConfigObjectKeyValuePairs(object obj)
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            foreach (PropertyInfo pi in obj.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(ConfigurationPropertyAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    ConfigurationPropertyAttribute pro = pros[0] as ConfigurationPropertyAttribute;
                    if (pro.Exclude || pi.GetValue(obj, null) == null)
                    {
                        continue;
                    }

                    if (pro.PropertyType == ConfigurationPropertyType.Object)
                    {
                        list.AddRange(ConfigurationUtil.PropertyToConfigKeyValuePairs(pi, obj));
                    }
                }
            }
            return list;
        }

        // Get all the Key/Value pairs for ConfigurationPropertyType.Var properties (except which equals to default)
        public static IList<KeyValuePair<string, string>> GetConfigVarKeyValuePairs(object obj, object defaultObj)
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            foreach (PropertyInfo pi in obj.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(ConfigurationPropertyAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    ConfigurationPropertyAttribute pro = pros[0] as ConfigurationPropertyAttribute;
                    if (pro.Exclude || pi.GetValue(obj, null) == null)
                    {
                        continue;
                    }

                    if (pro.PropertyType == ConfigurationPropertyType.Var)
                    {
                        if (defaultObj !=null && pi.GetValue(obj, null) == pi.GetValue(defaultObj, null))
                        {
                            continue; // equals to default Value, skip to wirte to string
                        }
                        list.AddRange(ConfigurationUtil.PropertyToConfigKeyValuePairs(pi, obj));
                    }
                }
            }
            return list;
        }

        public static string GetPrimitivePropertyValueString(PropertyInfo pi, object obj)
        {
            return ToConfigValueString(pi.GetValue(obj, null));
        }

        public static string ToConfigValueString(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }
            string result = "";
            switch (obj.GetType().Name)
            {
                case "Boolean":
                    bool b = (bool)obj;
                    result = b ? "yes" : "no";
                    break;
                case "string":
                    result = obj as string;
                    break;
                default:
                    result = obj.ToString();
                    break;
            }
            return result;
        }

        public static string GetConfigVariable(PropertyInfo pi)
        {
            object[] atts = pi.GetCustomAttributes(typeof(ConfigurationPropertyAttribute), false);
            if (atts == null || atts.Length <= 0)
            {
                return string.Empty;
            }
            ConfigurationPropertyAttribute pro = atts[0] as ConfigurationPropertyAttribute;
            return pro.Name;
        }

        public static IList<KeyValuePair<string,string>> PropertyToConfigKeyValuePairs(PropertyInfo pi, object obj)
        {
            if (pi.GetValue(obj, null) == null) return null;

            IList<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            object[] atts = pi.GetCustomAttributes(typeof(ConfigurationPropertyAttribute), false);
            if (atts != null && atts.Length > 0)
            {
                ConfigurationPropertyAttribute pro = atts[0] as ConfigurationPropertyAttribute;
                switch (pro.PropertyType)
                {
                    case ConfigurationPropertyType.Var:
                        list.Add(new KeyValuePair<string, string>(pro.Name, GetPrimitivePropertyValueString(pi, obj)));
                        break;
                    case ConfigurationPropertyType.Object:
                        foreach (object var in pi.GetValue(obj, null) as IEnumerable)
                        {
                            list.Add(new KeyValuePair<string, string>(pro.Name, ToConfigValueString(var)));
                        }
                        break;
                    case ConfigurationPropertyType.Category:
                    case ConfigurationPropertyType.CategoryCollection:
                    default:
                        Trace.TraceWarning(string.Format("PropertyToConfigKeyValue: unknow property type {0}", pro.ToString()));
                        break;
                }
            }
            else
            {
                // no attribute, we treat it as AstConfigPropertyClass.Var
                Trace.TraceWarning(string.Format("The property have no attribute", pi.Name));
            }
            return list;
        }

        public static void LoadCoinfigStringsToObject(object obj, string category, Dictionary<int, string> lines)
        {
            foreach (string line in lines.Values)
            {

            }
        }

        internal static void LoadConfigToObject(object obj, ConfigFile file, string cat)
        {
            foreach (PropertyInfo pi in obj.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(ConfigurationPropertyAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    ConfigurationPropertyAttribute pro = pros[0] as ConfigurationPropertyAttribute;
                    if (pro.Exclude)
                    {
                        continue;
                    }

                    if (pro.PropertyType == ConfigurationPropertyType.Var)
                    {
                        string value = file.GetValue(cat, pro.Name);
                        SetPropertyValueFromString(pi, obj, value);
                    }
                    else if (pro.PropertyType == ConfigurationPropertyType.Object)
                    {
                        // Support IList<string> only
                        IList<string> list = file.GetValues(cat, pro.Name);
                        pi.SetValue(obj, list, null);
                    }
                }
            }
        }

        private static void SetPropertyValueFromString(PropertyInfo pi, object obj, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            if (pi.PropertyType.Name.Equals("Int32"))
            {
                pi.SetValue(obj, int.Parse(value), null);
            }
            else if (pi.PropertyType.Name.Equals("String"))
            {
                pi.SetValue(obj, value, null);
            }
            else if (pi.PropertyType.Name.Equals("Boolean"))
            {
                pi.SetValue(obj, IsTrue(value)? true:false, null);
            }
            else
            {
                Trace.TraceError(string.Format("Type of property can't be handle - {0}", pi.PropertyType.Name)); 
            }

        }

        #region IsTrue(string)
        /// <summary>
        /// Checks if a String represents <code>true</code> or <code>false</code> according to Asterisk's logic.<br/>
        /// The original implementation is <code>util.c</code> is as follows:
        /// </summary>
        /// <param Name="s">the String to check for <code>true</code>.</param>
        /// <returns>
        /// <code>true</code> if s represents <code>true</code>,
        /// <code>false</code> otherwise.
        /// </returns>
        public static bool IsTrue(string s)
        {
            if (s == null || s.Length == 0)
                return false;
            string sx = s.ToLower();
            if (sx == "yes" || sx == "true" || sx == "y" || sx == "t" || sx == "1" || sx == "on")
                return true;
            return false;
        }
        #endregion
    }
}
