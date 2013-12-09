using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Exception
{
    public class ConfigFileParseErrorException : AsteriskException
    {
        public ConfigFileParseErrorException(string message)
            : base(message)
        {
        }

        public ConfigFileParseErrorException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }
    }
}
