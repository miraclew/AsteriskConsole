using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Dialplan.Application
{
    public class AppendCDRUserField : ApplicationBase
    {
        public AppendCDRUserField(string value)
        {
            m_Value = value;
        }
        string m_Value;
    }
}
