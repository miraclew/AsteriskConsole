using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Dialplan
{
    public class ConfigExtension : ConfigElement
    {
        string name, priority;
        /// <summary>
        /// Holds the Application in the First element, and Arguments1 in all subsequent elements. Similar to command line Arguments1 array. 
        /// </summary>
        string[] application;

        public ConfigExtension(string filename, int lineno, string name, string priority, string[] application)
            : base(filename, lineno)
        {
            this.name = name;
            this.priority = priority;
            this.application = application;
        }


        protected override StringBuilder rawFormat(StringBuilder sb)
        {
            return sb.Append(ToString());
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in application)
            {
                sb.Append(s);
            }
            return "exten => " + name + "," + priority + "," + sb.ToString();
        }


        public string Priority
        {
            get { return priority; }
        }

        public string Name
        {
            get { return name; }
        }
        
        public string[] Application
        {
            get { return application; }
            set { application = value; }
        }
    }
}
