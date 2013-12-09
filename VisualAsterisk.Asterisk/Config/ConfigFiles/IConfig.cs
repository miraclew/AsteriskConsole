using System;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Internal;
namespace VisualAsterisk.Asterisk.Config
{
    public enum ConfigFileEnum
    {
        Agents, Cdr, Extensions, Meetme, Queues, Sip, Iax, Users, Voicemail, Asterisk, Manager
    }
    
    public delegate void ConfigChangedEventHandler(object sender, ConfigChangedEventArgs e);
    public class ConfigChangedEventArgs
    {
        public ConfigChangedEventArgs(IConfig config)
        {
            m_Config = config;
        }
        IConfig m_Config;

        public IConfig ConfigManager
        {
            get { return m_Config; }
            set { m_Config = value; }
        }
    }
    
    public interface IConfig
    {
        string ConfigFileDir { get; set; }
        void LoadAll();
        AstConfig LoadFile(string fileName);
        void SaveConfig(ConfigFileEnum file);
        ConfigFileBase this[ConfigFileEnum file] { get; }
        event ConfigChangedEventHandler ConfigChanged;
    }
}
