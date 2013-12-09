using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Main.Gui.AutoCompletion
{
    public class SimpleCompletionDataCollection
    {
        public SimpleCompletionDataCollection()
        {
            m_CompletionDataCollection = new List<SimpleCompletionData>();
        }
        List<SimpleCompletionData> m_CompletionDataCollection;

        public List<SimpleCompletionData> CompletionDataCollection
        {
            get { return m_CompletionDataCollection; }
            set { m_CompletionDataCollection = value; }
        }
    }
}
