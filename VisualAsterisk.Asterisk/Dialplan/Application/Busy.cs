using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Dialplan.Application
{
    public class Busy : ApplicationBase
    {
        public Busy()
        {
        }
        public Busy(int timeout)
        {
            m_Timeout = timeout;
        }
        int m_Timeout;
    }
}
