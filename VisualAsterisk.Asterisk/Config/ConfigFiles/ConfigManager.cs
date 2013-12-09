using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using System.Text;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk
{
    public class ConfigManager : IConfig
    {
        public ConfigManager()
        {
            configFileDictionary = new Dictionary<ConfigFileEnum,ConfigFileBase>();
        }

        #region IConfig Members

        public void LoadAll()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            configFileDictionary.Clear();
            LoadAgents();
            LoadCdr();
            LoadExtensions2();
            LoadMeetme();
            LoadQueues();
            LoadSip();
            LoadUsers2();
            LoadVoicemail();
            LoadManager();
            LoadAsterisk();
        }

        public AstConfig LoadFile(string fileName)
        {
            AstConfig config = new AstConfig();
            config.FileName = fileName;
            configTextFileLoad(fileName, config);
            return config;
        }

        public void SaveConfig(ConfigFileEnum file)
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            ConfigFileBase config = configFileDictionary[file] as ConfigFileBase;
            if (config == null)
            {
                Trace.TraceError("Config for {0} not found", file.ToString());
                return;
            }
            string fullFileName = configFileDir + @"\" + file.ToString().ToLower() + ".conf";
            try
            {
                using (StreamWriter sw = new StreamWriter(fullFileName))
                {
                    sw.Write(config.ToString());
                }
            }
            catch (System.Exception e)
            {
                Trace.TraceError("The file could not be read: {0}", fullFileName);
                Trace.TraceError(e.Message);
            }

            ConfigChanged(this, new ConfigChangedEventArgs(this));
        }


        public ConfigFileBase this[ConfigFileEnum file]
        {
            get
            {
                if (configFileDictionary.ContainsKey(file))
                {
                    return configFileDictionary[file];
                }
                else
                    return null;
            }
        }

        public string ConfigFileDir
        {
            get { return configFileDir; }
            set
            {
                configFileDir = value;

            }
        }

        public event ConfigChangedEventHandler ConfigChanged;

        #endregion

        public Manager LoadManager()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("manager.conf");
            Manager m = ConfigFileBase.Parse(cfg) as Manager;
            configFileDictionary.Remove(ConfigFileEnum.Manager);
            configFileDictionary.Add(ConfigFileEnum.Manager, m);

            return m;
        }
        public AsteriskConf LoadAsterisk()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("asterisk.conf");
            AsteriskConf a = ConfigFileBase.Parse(cfg) as AsteriskConf;
            configFileDictionary.Remove(ConfigFileEnum.Asterisk);
            configFileDictionary.Add(ConfigFileEnum.Asterisk, a);
            return a;
        }

        public Users LoadUsers2()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("users.conf");
            Users user = (Users) ConfigFileBase.Parse(cfg);
            configFileDictionary.Remove(ConfigFileEnum.Users);
            configFileDictionary.Add(ConfigFileEnum.Users, user);
            return user;
        }

        public Extension LoadExtensions2()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            Extension exten = (Extension)ConfigFileBase.Parse(LoadFile("extensions.conf"));
            configFileDictionary.Remove(ConfigFileEnum.Extensions);
            configFileDictionary.Add(ConfigFileEnum.Extensions, exten);
            return exten;
        }

        public Meetme LoadMeetme()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("meetme.conf");
            Meetme cf = (Meetme)ConfigFileBase.Parse(cfg);
            configFileDictionary.Remove(ConfigFileEnum.Meetme);
            configFileDictionary.Add(ConfigFileEnum.Meetme, cf);
            return cf;

        }

        public Agents LoadAgents()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("agents.conf");
            Agents cf = (Agents)ConfigFileBase.Parse(cfg);
            configFileDictionary.Remove(ConfigFileEnum.Agents);
            configFileDictionary.Add(ConfigFileEnum.Agents, cf);
            return cf;
        }

        public Cdr LoadCdr()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("cdr.conf");
            Cdr cdr = ConfigFileBase.Parse(cfg) as Cdr;
            configFileDictionary.Remove(ConfigFileEnum.Cdr);
            configFileDictionary.Add(ConfigFileEnum.Cdr, cdr);
            return cdr;
        }

        public Queues LoadQueues()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("queues.conf");
            Queues q = ConfigFileBase.Parse(cfg) as Queues;
            configFileDictionary.Remove(ConfigFileEnum.Queues);
            configFileDictionary.Add(ConfigFileEnum.Queues, q);
            return q; 
        }

        public Sip LoadSip()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("sip.conf");
            Sip s = ConfigFileBase.Parse(cfg) as Sip;
            configFileDictionary.Remove(ConfigFileEnum.Sip);
            configFileDictionary.Add(ConfigFileEnum.Sip, s);
            return s;
        }

        public Voicemail LoadVoicemail()
        {
            Trace.TraceInformation(MethodBase.GetCurrentMethod().Name);
            AstConfig cfg = LoadFile("voicemail.conf");
            Voicemail v = ConfigFileBase.Parse(cfg) as Voicemail;
            configFileDictionary.Remove(ConfigFileEnum.Voicemail);
            configFileDictionary.Add(ConfigFileEnum.Voicemail, v);
            return v;
        }
        
        private void configTextFileLoad(string fileName, AstConfig cfg)
        {
            AstCategory cat = null;
            string fullFileName = configFileDir + @"\" + fileName;
            try
            {
                using (StreamReader sr = new StreamReader(fullFileName))
                {
                    string line;
                    int lineno = 1;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cat = processTextLine(line, cfg, cat, lineno);
                        lineno++;
                    }
                }
            }
            catch (System.Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }

        }

        private AstCategory processTextLine(string line, AstConfig cfg, AstCategory cat, int lineno)
        {
            //static AstCategory currentCategory = null;

            int commentindex = line.IndexOf(";");
            if (commentindex >= 0)
            {
                // trim Comment
                line = line.Substring(0, commentindex);
                line = line.Trim();
                //string c = "\t";
                //line.Trim(c.ToCharArray());
                //line.Trim(new char[] { '\t',' ' });
            }

            if (line.Length == 0)
            {
                if (commentindex < 0)
                {
                    //Trace.TraceInformation("Blank line {0}, ignored", Lineno);
                }
                else
                {
                    //Trace.TraceInformation("Comment line {0}, ignored", Lineno);
                }
            }
            else if (line.StartsWith("[") && line.EndsWith("]"))
            {
                cat = new AstCategory();
                cat.Name = line.Substring(1, line.Length - 2);
                cfg.Categories.Add(cat);
            }
            else
            {
                if (cat == null)
                {
                    Trace.TraceWarning("Line {0} is out of a category, ignored", lineno);
                    // this line is out of a Category, ignore it
                }
                else
                {
                    int index = line.IndexOf('=');
                    if (index > 0 && index < line.Length - 1)
                    {

                        AstVariable var = new AstVariable();
                        var.Name = line.Substring(0, index).Trim();
                        if (line.Substring(index).StartsWith("=>"))
                        {
                            var.Value = line.Substring(index + 2, line.Length - 1 - index - 1).Trim();
                            var.IsObject = 1;
                        }
                        else
                        {
                            var.Value = line.Substring(index + 1, line.Length - 1 - index).Trim();
                            var.IsObject = 0;
                        }


                        var.Lineno = lineno;
                        cat.Variables.Add(var);
                    }
                    else
                    {
                        Trace.TraceWarning("Line {0} is invalid variable in category {1}, ignore it", lineno, cat.Name);
                    }
                }

            }
            return cat;
        }
        
        private Dictionary<ConfigFileEnum, ConfigFileBase> configFileDictionary;

        private string configFileDir;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ConfigFileDir=" + configFileDir);

            sb.AppendLine("ConfigTable=");
            foreach (ConfigFileEnum var in configFileDictionary.Keys)
            {
                sb.AppendLine("Key=" + var);
                sb.Append("Value=" + configFileDictionary[var].ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}