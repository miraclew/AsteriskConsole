using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Deploy
{
    class PreInstallConditionNotSatisfiedException : System.Exception
    {
        public PreInstallConditionNotSatisfiedException()
        {
        }
        public PreInstallConditionNotSatisfiedException(string message)
            : base(message)
        {
        }

        public PreInstallConditionNotSatisfiedException(string message, System.Exception internalException)
            : base(message, internalException)
        {
        }
    }
}
