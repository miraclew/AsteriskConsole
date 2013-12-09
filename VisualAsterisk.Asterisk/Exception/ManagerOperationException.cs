using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Exception
{
    public class ManagerOperationException : AsteriskException
    {
        public ManagerOperationException(string message)
            : base(message)
        {
        }

        public ManagerOperationException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }
    }
}
