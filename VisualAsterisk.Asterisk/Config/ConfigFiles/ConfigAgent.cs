using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.ConfigFiles
{
    /// <summary>
    /// ConfigAgent is a ConfigElement in Agents.conf
    /// </summary>
    public class ConfigAgent : ConfigElement
    {
        private string agentid;
        private string agentpassword;
        private string name;

        public string Agentid
        {
            get { return agentid; }
        }

        public string Agentpassword
        {
            get { return agentpassword; }
        }

        public string Name
        {
            get { return name; }
        }

        public ConfigAgent(string filename, int lineno, string agentid, string agentpassword, string name)
            : base(filename, lineno)
        {
            this.agentid = agentid;
            this.agentpassword = agentpassword;
            this.name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (agentid != null && agentid.Length > 0)
            {
                sb.AppendFormat("agent => {0},{1},{2}\n", agentid, agentpassword, name);
            }
            return sb.ToString();
        }

        protected override StringBuilder rawFormat(StringBuilder sb)
        {
            throw new NotImplementedException();
        }
    }
}
