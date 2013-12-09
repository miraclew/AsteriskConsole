using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Management
{
    [global::System.Serializable]
    public class InvalidSystemInfoException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public InvalidSystemInfoException() { }
        public InvalidSystemInfoException(string message) : base(message) { }
        public InvalidSystemInfoException(string message, Exception inner) : base(message, inner) { }
        protected InvalidSystemInfoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
