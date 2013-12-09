using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public class CallerId
    {
        private readonly string name;

        public string Name
        {
            get { return name; }
        }

        private readonly string number;

        public string Number
        {
            get { return number; }
        }

        /// <summary>
        /// Creates a new CallerId.
        /// </summary>
        /// <param Name="Name">the Caller*ID Name.</param>
        /// <param Name="Number">the Caller*ID Number.</param>
        public CallerId(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

    }
}
