using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Dialplan.Application
{
    public class ADSIProg : ApplicationBase
    {
        public ADSIProg(string script)
        {
            m_Script = script;
        }
        string m_Script;
    }
}
