using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using VisualAsterisk.Asterisk.Config;

namespace VisualAsterisk.Asterisk.Dialplan.Application
{
    public class ApplicationBase
    {
        static ApplicationBase()
        {
            m_Applications = new Dictionary<string, Type>();
            Type[] appTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in appTypes)
            {
                if (type.IsSubclassOf(typeof(ApplicationBase)))
                {
                    m_Applications[type.Name] = type;
                }
            } 
        }

        public ApplicationBase()
        {
            m_AutoCompletionDataDictionary = new Dictionary<string, List<string>>();
        }

        static IDictionary<string, Type> m_Applications;
        /// <summary>
        /// Return a Type Name to Type map
        /// </summary>
        public static IDictionary<string, Type> Applications
        {
            get { return ApplicationBase.m_Applications; }
        }

        public List<string> GetAutoCompleteDataById(int index)
        {
            if (AutoCompleteDataList != null && AutoCompleteDataList.Length > index &&
                AutoCompletionDataDictionary != null && AutoCompletionDataDictionary.ContainsKey(AutoCompleteDataList[index]))
            {
                return AutoCompletionDataDictionary[AutoCompleteDataList[index]];
            }
            else
                return null;
            
        }

        public List<string> GetAutoCompleteDataByName(string name)
        {
            if (AutoCompletionDataDictionary.ContainsKey(name))
            {
                return AutoCompletionDataDictionary[name];
            }
            else
                return null;
        }

        //protected string[] m_AutoCompleteDataList;
        // parameters array
        public virtual string[] AutoCompleteDataList
        {
            get { return null; }
        }

        public virtual void SetParameterValueByIndex(int index, string value)
        {            
        }

        protected Dictionary<string, List<string>> m_AutoCompletionDataDictionary;
        public virtual Dictionary<string, List<string>> AutoCompletionDataDictionary
        {
            get { return m_AutoCompletionDataDictionary; }
            set { m_AutoCompletionDataDictionary = value; }
        }

        protected IConfig m_Config;

        public virtual IConfig ConfigManager
        {
            get { return m_Config; }
            set { m_Config = value; }
        }
    }
}
