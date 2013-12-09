using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Main.Gui.AutoCompletion
{
    public enum CompletionDataCategory
    {
        Application, Macro, Function, Variable, Data, Unknown
    }

    public class SimpleCompletionData : ICompletionData
    {
        private string m_DisplayName = "";

        public string DisplayName
        {
            get { return m_DisplayName; }
            set { m_DisplayName = value; }
        }
        private string m_InsertName = "";

        public string InsertName
        {
            get { return m_InsertName; }
            set { m_InsertName = value; }
        }
        //private string m_Type = "";
        private CompletionDataCategory m_Category = CompletionDataCategory.Unknown;

        public CompletionDataCategory Category
        {
            get { return m_Category; }
            set { m_Category = value; }
        }
        //internal int Overloads = 0;
        //internal StringCollection AllMethodArgs = null;

    }
}
