using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Exception
{
    public  class ManagerCommunicationException : AsteriskException
    {
        public ManagerCommunicationException(string message)
            : base(message)
        {
        }

        public ManagerCommunicationException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }


    }
}
