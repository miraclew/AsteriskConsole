using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace VisualAsterisk.Asterisk.Dialplan.Functions
{
    public class FunctionBase
    {
        static FunctionBase()
        {
            m_Functions = new Dictionary<string, Type>();
            Type[] appTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in appTypes)
            {
                if (type.IsSubclassOf(typeof(FunctionBase)))
                {
                    m_Functions[type.Name] = type;
                }
            } 
        }

        public FunctionBase()
        {
            //m_AutoCompletionDataDictionary = new Dictionary<string, List<string>>();
        }

        static IDictionary<string, Type> m_Functions;

        public static IDictionary<string, Type> Functions
        {
            get { return FunctionBase.m_Functions; }
        }
    }
}
