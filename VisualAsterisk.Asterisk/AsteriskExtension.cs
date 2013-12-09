using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public enum ExtensionTech
    {
        SIP, IAX2, ZAP, Unknown
    }

    public enum ExtensionStatus
    {
        // sip
        Register, UnRegister,
        // zap
        OnHook, OffHook,
        // General
        Ring, Busy
    }

    public class AsteriskExtension
    {
        public AsteriskExtension(string number, ExtensionTech extensionTech, ExtensionStatus status)
        {
            m_Number = number;
            m_ExtensionTech = extensionTech;
            m_Status = status;
        }

        string m_Number;

        public string Number
        {
            get { return m_Number; }
            set { m_Number = value; }
        }
        ExtensionTech m_ExtensionTech;

        public ExtensionTech ExtensionTech
        {
            get { return m_ExtensionTech; }
            set { m_ExtensionTech = value; }
        }
        ExtensionStatus m_Status;

        public ExtensionStatus Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }
    }
}

