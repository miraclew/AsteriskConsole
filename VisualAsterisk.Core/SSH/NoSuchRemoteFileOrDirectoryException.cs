using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.SSH
{
    public class NoSuchRemoteFileOrDirectoryException : System.Exception
    {
        public NoSuchRemoteFileOrDirectoryException()
        {

        }
        public NoSuchRemoteFileOrDirectoryException(string message)
            : base(message)
        {
        }

        public NoSuchRemoteFileOrDirectoryException(string message, System.Exception internalException)
            : base(message, internalException)
        {

        }
    }
}
