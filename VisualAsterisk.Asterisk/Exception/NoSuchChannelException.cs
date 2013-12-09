using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Exception
{
    public class NoSuchChannelException : AsteriskException
    {
        public NoSuchChannelException(string message)
            : base(message)
        {
        }

        public NoSuchChannelException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }


    }
}
