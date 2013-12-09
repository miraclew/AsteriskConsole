using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Remote
{
    public class RemoteConfigFile : ConfigFile
    {
        private DefaultAsteriskServer server;
        public RemoteConfigFile(DefaultAsteriskServer server, string filename, Dictionary<string, Category> categories)
            : base(filename, categories)
        {
            this.server = server;
        }
    }
}
