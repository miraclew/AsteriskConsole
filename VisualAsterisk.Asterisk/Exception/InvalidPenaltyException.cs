using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Exception
{
    public class InvalidPenaltyException : AsteriskException
    {
        public InvalidPenaltyException(string message)
            : base(message)
        {
        }

        public InvalidPenaltyException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }

    }
}
