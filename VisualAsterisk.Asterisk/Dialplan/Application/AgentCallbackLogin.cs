using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Dialplan.Application
{
    public class AgentCallbackLogin : ApplicationBase
    {
        string m_AgentNumber;
        string m_Options;
        string m_Exten;
        string m_Context;
        
//; silently log in as agent Number 42, and have Asterisk
//; call Extension1 123 in the internal Context
//; when a call comes in for this agent
//Exten => 123,1,AgentCallbackLogin(42,s,123@internal)
                 
    }
}
