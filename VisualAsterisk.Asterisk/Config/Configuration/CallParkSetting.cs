using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class CallParkSetting : IExtension
    {
        private string extension;
        private int timeout = 45;
        private string first;
        private string last;
        private int count;
        /// <summary>
        /// What extensions to park calls on
        /// </summary>
        public string First
        {
            get { return first; }
            set { first = value; }
        }

        public string Last
        {
            get { return last; }
            set { last = value; }
        }
        /// <summary>
        /// Number of seconds a call can be parked for
        /// (default is 45 seconds)
        /// </summary>
        public int Timeout
        {
            get { return timeout; }
            set { timeout = value; }
        }
        #region IExtension 成员
        /// <summary>
        /// Extension to Dial for Parking Calls
        /// </summary>
        public string Extension
        {
            get
            {
                return extension;
            }
            set
            {
                extension = value;
            }
        }

        public string Descripton
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
