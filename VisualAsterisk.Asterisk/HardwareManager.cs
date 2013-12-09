using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Configuration;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk
{
    class HardwareManager : IAsteriskServerComponent
    {
        //private  Log logger = LogFactory.getLog(this.getClass());
        private DefaultAsteriskServer server;
        private IAsteriskConfigManager configManager;

        public HardwareManager(DefaultAsteriskServer asteriskServer, IAsteriskConfigManager configManager)
        {
            this.server = asteriskServer;
            this.configManager = configManager;
        }

        #region IAsteriskServerComponent 成员

        public void Disconnected()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            // 1. get gui_confighw.conf
            // 2. execute ztscan
            server.ExecuteSystemCommand("ztscan > /etc/asterisk/ztscan.conf; touch /etc/asterisk/applyzap.conf");
            // 3. get ztscan.conf
            configManager.GetAllZapDevices(true);
            //// 5. touch /etc/asterisk/zaptel_guiRead.conf
            //server.ExecuteSystemCommand("touch /etc/asterisk/zaptel_guiRead.conf");
            //// 6. updateconfig　zaptel_guiRead.conf
            //Dictionary<string, List<ConfigurationChange>> fileChanges = new Dictionary<string, List<ConfigurationChange>>();
            //List<ConfigurationChange> changes = new List<ConfigurationChange>();
            //changes.Add(new ConfigurationChange("zaptel_guiRead.conf", UpdateConfigAction.ACTION_DELCAT,"general",null,null));
            //changes.Add(new ConfigurationChange("zaptel_guiRead.conf", UpdateConfigAction.ACTION_NEWCAT, "general", null, null));
            //changes.Add(new ConfigurationChange("zaptel_guiRead.conf", UpdateConfigAction.ACTION_UPDATE, "general", "#include \"../zaptel.conf\"", null));
            //fileChanges.Add("zaptel_guiRead.conf", changes);
            //configManager.SubmitConfigFileChanges(fileChanges);
        }

        #endregion
    }
}
