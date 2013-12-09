using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Exception
{
    class NoSuchInterfaceException : AsteriskException
    {
        public NoSuchInterfaceException(string message)
            : base(message)
        {
        }

        public NoSuchInterfaceException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }
    }
}
