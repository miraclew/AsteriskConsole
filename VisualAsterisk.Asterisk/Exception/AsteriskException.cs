using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Exception
{
    /// <summary>
    /// Base class for exceptions thrown by the asterisk assembly.
    /// </summary>
    public class AsteriskException : System.Exception
    {
        public AsteriskException()
        {

        }
        public AsteriskException(string message)
            : base(message)
        {
        }

        public AsteriskException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }
    }
}
