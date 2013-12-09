using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.SSH
{
    public class CommandNotFoundException : System.Exception
    {
        public CommandNotFoundException()
        {
        }
        public CommandNotFoundException(string message)
            : base(message)
        {
        }

        public CommandNotFoundException(string message, System.Exception internalException)
            : base(message, internalException)
        {
        }
    }
}
