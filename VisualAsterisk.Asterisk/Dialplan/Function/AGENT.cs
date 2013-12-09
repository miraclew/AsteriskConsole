using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Dialplan.Functions
{
    public class AGENT : FunctionBase
    {
        enum ItemType
        {
            status, password, name, mohclass, exten, channel
        }
        string m_AgentId;
        ItemType item;
    }
}
