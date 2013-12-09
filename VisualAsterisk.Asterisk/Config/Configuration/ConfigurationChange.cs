using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class ConfigurationChange
    {
        private static int IdCount = 0;

        public ConfigurationChange()
        {
            this.id = (IdCount++).ToString();
        }

        public ConfigurationChange(string filename, string action, string category, string variable, string value, 
            string match)
            : this()
        {
            this.filename = filename;
            this.action = action;
            this.category = category;
            this.variable = variable;
            this.value = value;
            this.match = match;
        }

        public ConfigurationChange(string filename, string action, string category, string variable, string value)
            : this(filename,action,category,variable, value,null)
        {
        }


        private string id;
        private string filename;
        private string action;
        private string category;
        private string variable;
        private string value;
        private string match;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }

        // 
        /// <summary>
        /// Action string should be one of 
        /// UpdateConfigAction.ACTION_NEWCAT,
        /// UpdateConfigAction.ACTION_RENAMECAT
        /// UpdateConfigAction.ACTION_DELCAT
        /// UpdateConfigAction.ACTION_UPDATE
        /// UpdateConfigAction.ACTION_DELETE
        /// UpdateConfigAction.ACTION_APPEND
        /// </summary>
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Variable
        {
            get { return variable; }
            set { variable = value; }
        }

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public string Match
        {
            get { return match; }
            set { match = value; }
        }
    }
}
