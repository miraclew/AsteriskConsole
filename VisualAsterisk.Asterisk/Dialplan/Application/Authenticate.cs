using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Dialplan.Application
{
    public class Authenticate : ApplicationBase
    {
        public Authenticate(string password)
        {
            m_Password = password;
        }
        string m_Password;
        string m_Options;
        int m_MaxDigits;
    }
}
