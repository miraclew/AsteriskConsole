using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Response;
using Asterisk.NET.Manager.Action;
using System.Diagnostics;
using VisualAsterisk.Asterisk.Exception;
using VisualAsterisk.Asterisk.Config.ConfigFiles;

namespace VisualAsterisk.Asterisk.Config.Remote
{
    class RemoteConfigFileReader : IConfigFileReader
    {
        protected readonly Dictionary<string, Category> categories;
        private DefaultAsteriskServer server;
        private int timeout = 3000; // 3 seconds

        public int Timeout
        {
            get { return timeout; }
            set { timeout = value; }
        }

        public RemoteConfigFileReader(DefaultAsteriskServer server)
        {
            this.server = server;
            this.categories = new Dictionary<string, Category>();
        }

        public ConfigFile ReadFile(string configfile)
        {
            RemoteConfigFile result;

            categories.Clear();

            ManagerResponse response = server.SendAction(new GetConfigAction(configfile), timeout);
            if (response.IsSuccess())
            {
                GetConfigResponse responseConfig = (GetConfigResponse)response;
                foreach (int key in responseConfig.Categories.Keys)
                {
                    Trace.TraceInformation(string.Format("{0}:{1}", key, responseConfig.Categories[key]));
                    Category cat = new Category(configfile, key, responseConfig.Categories[key]);
                    foreach (int keyLine in responseConfig.Lines(key).Keys)
                    {
                        Trace.TraceInformation(string.Format("\t{0}:{1}", keyLine, responseConfig.Lines(key)[keyLine]));
                        processTextLine(cat, keyLine, responseConfig.Lines(key)[keyLine]);
                    }
                    if (!categories.ContainsKey(cat.Name))
                    {
                        categories.Add(cat.Name, cat); 
                    }
                    else
                    {
                        Trace.TraceError("More then one category with same name {0} in file {1}",cat.Name, configfile);
                    }
                }
            }
            else
            {
                Trace.TraceError(response.ToString());
                throw new ManagerOperationException(string.Format("Read remote file {0} failed, {1}",configfile,response.Message));
            }

            result = new RemoteConfigFile(server, configfile, new Dictionary<string, Category>(categories));

            return result;
        }

        protected virtual ConfigElement processTextLine(Category cat, int lineno, string line)
        {
            int pos;
            string name;
            string value;

            pos = line.IndexOf('=');
            if (pos == -1)
            {
                throw new MissingEqualSignException(cat.FileName, lineno,
                        "No '=' (equal sign) in line %d of %s", lineno, cat.FileName);
            }

            name = line.Substring(0, pos).Trim();

            // Ignore > in =>
            if (line.Length > pos + 1 && line[pos + 1] == '>')
            {
                pos++;
            }

            value = (line.Length > pos + 1) ? line.Substring(pos + 1).Trim() : "";
            ConfigVariable configElement = new ConfigVariable(cat.FileName, lineno, name, value);
            cat.addElement(configElement);
            return configElement;
        }

        #region IConfigFileReader 成员


        public ConfigFile ReadString(string configFileName, string fileContent)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
