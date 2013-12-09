using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using System.Diagnostics;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("asterisk.conf","")]
    public class AsteriskConf : ConfigFileBase
    {
        public AsteriskConf()
        {
            categories.Add("Directories", new List<PropertyInfo>());
            categories.Add("Options", new List<PropertyInfo>());
            categories.Add("Files", new List<PropertyInfo>());

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                CategoryAttribute c = pi.GetCustomAttributes(typeof(CategoryAttribute), false)[0] as CategoryAttribute;
                categories[c.Category].Add(pi);
            }
        }
#region directories
        string astetcdir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astetcdir
        {
            get { return astetcdir; }
            set { astetcdir = value; }
        }
        string astmoddir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astmoddir
        {
            get { return astmoddir; }
            set { astmoddir = value; }
        }
        string astvarlibdir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astvarlibdir
        {
            get { return astvarlibdir; }
            set { astvarlibdir = value; }
        }
        string astdatadir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astdatadir
        {
            get { return astdatadir; }
            set { astdatadir = value; }
        }
        string astagidir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astagidir
        {
            get { return astagidir; }
            set { astagidir = value; }
        }
        string astspooldir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astspooldir
        {
            get { return astspooldir; }
            set { astspooldir = value; }
        }
        string astrundir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astrundir
        {
            get { return astrundir; }
            set { astrundir = value; }
        }
        string astlogdir;

        [Category("Directories")]
        [Description("")]
        [AstConfigVariable(true)]
        public string Astlogdir
        {
            get { return astlogdir; }
            set { astlogdir = value; }
        }
#endregion

#region Options
        int verbose;

        [Category("Options")]
        [Description("")]
        public int Verbose
        {
            get { return verbose; }
            set { verbose = value; }
        }
        int debug;

        [Category("Options")]
        [Description("")]
        public int Debug
        {
            get { return debug; }
            set { debug = value; }
        }

        bool alwaysfork; //

        [Category("Options")]
        [Description("same as -F at startup")]
        public bool Alwaysfork
        {
            get { return alwaysfork; }
            set { alwaysfork = value; }
        }
        
        bool nofork;

        [Category("Options")]
        [Description("same as -f at startup")]
        public bool Nofork
        {
            get { return nofork; }
            set { nofork = value; }
        } 

        bool quiet;

        [Category("Options")]
        [Description("same as -q at startup")]
        public bool Quiet
        {
            get { return quiet; }
            set { quiet = value; }
        }

        bool timestamp;

        [Category("Options")]
        [Description("same as -T at startup")]
        public bool Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        bool execincludes;

        [Category("Options")]
        [Description("support #exec in config files")]
        public bool Execincludes
        {
            get { return execincludes; }
            set { execincludes = value; }
        }

        bool console;

        [Category("Options")]
        [Description("Run as console (same as -c at startup)")]
        public bool Console
        {
            get { return console; }
            set { console = value; }
        }
        

        bool highpriority;

        [Category("Options")]
        [Description("Run realtime priority (same as -p at startup)")]
        public bool Highpriority
        {
            get { return highpriority; }
            set { highpriority = value; }
        }
      
        bool initcrypto;

        [Category("Options")]
        [Description("Initialize crypto keys (same as -i at startup)")]
        public bool Initcrypto
        {
            get { return initcrypto; }
            set { initcrypto = value; }
        }
        
        bool nocolor;

        [Category("Options")]
        [Description("Disable console colors")]
        public bool Nocolor
        {
            get { return nocolor; }
            set { nocolor = value; }
        } 

        bool dontwarn;

        [Category("Options")]
        [Description("Disable some warnings")]
        public bool Dontwarn
        {
            get { return dontwarn; }
            set { dontwarn = value; }
        }

        bool dumpcore;

        [Category("Options")]
        [Description("Dump core on crash (same as -g at startup)")]
        public bool Dumpcore
        {
            get { return dumpcore; }
            set { dumpcore = value; }
        }

        bool languageprefix;

        [Category("Options")]
        [Description("Use the new sound prefix path syntax")]
        public bool Languageprefix
        {
            get { return languageprefix; }
            set { languageprefix = value; }
        }
        [AstConfigHelpText("")]
        bool internal_timing;

        [Category("Options")]
        [Description("")]
        public bool Internal_timing
        {
            get { return internal_timing; }
            set { internal_timing = value; }
        }

        string systemname;

        [Category("Options")]
        [Description("prefix uniqueid with a system name for global uniqueness issues")]
        public string Systemname
        {
            get { return systemname; }
            set { systemname = value; }
        }
        
        int maxcalls;

        [Category("Options")]
        [Description("Maximum amount of calls allowed")]
        public int Maxcalls
        {
            get { return maxcalls; }
            set { maxcalls = value; }
        }
        
        float maxload;

        [Category("Options")]
        [Description("Asterisk stops accepting new calls if the load average exceed this limit")]
        public float Maxload
        {
            get { return maxload; }
            set { maxload = value; }
        }
        
        bool cache_record_files;

        [Category("Options")]
        [Description("Cache recorded sound files to another directory during recording")]
        public bool Cache_record_files
        {
            get { return cache_record_files; }
            set { cache_record_files = value; }
        }

        string record_cache_dir;

        [Category("Options")]
        [Description("Specify cache directory (used in cnjunction with cache_record_files)")]
        public string Record_cache_dir
        {
            get { return record_cache_dir; }
            set { record_cache_dir = value; }
        }


        bool transmit_silence_during_record;

        [Category("Options")]
        [Description("Transmit SLINEAR silence while a channel is being recorded")]
        public bool Transmit_silence_during_record
        {
            get { return transmit_silence_during_record; }
            set { transmit_silence_during_record = value; }
        }

        bool transcode_via_sln;

        [Category("Options")]
        [Description("Build transcode paths via SLINEAR, instead of directly")]
        public bool Transcode_via_sln
        {
            get { return transcode_via_sln; }
            set { transcode_via_sln = value; }
        } 

        string runuser;

        [Category("Options")]
        [Description("The user to run as")]
        public string Runuser
        {
            get { return runuser; }
            set { runuser = value; }
        } 

        string rungroup;

        [Category("Options")]
        [Description("The group to run as")]
        public string Rungroup
        {
            get { return rungroup; }
            set { rungroup = value; }
        }
#endregion

#region files

        string astctlpermissions;

        [Category("Files")]
        [Description("The group to run as")]
        public string Astctlpermissions
        {
            get { return astctlpermissions; }
            set { astctlpermissions = value; }
        }
        string astctlowner;

        [Category("Files")]
        [Description("")]
        public string Astctlowner
        {
            get { return astctlowner; }
            set { astctlowner = value; }
        }
        string astctlgroup;

        [Category("Files")]
        [Description("")]
        public string Astctlgroup
        {
            get { return astctlgroup; }
            set { astctlgroup = value; }
        }
        string astctl;

        [Category("Files")]
        [Description("")]
        public string Astctl
        {
            get { return astctl; }
            set { astctl = value; }
        }
#endregion
        protected override void LoadCategory(AstCategory cat)
        {
            if (cat.Name.Equals("directories") || cat.Name.Equals("options") || cat.Name.Equals("files"))
            {
                setProperties(this, cat); // set others property
            }
            else
                Trace.TraceWarning("{0} unknown category {1}", MethodBase.GetCurrentMethod().Name, cat.Name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string cat in categories.Keys)
            {
                sb.AppendLine("Category="+cat);
                foreach (PropertyInfo pi in categories[cat])
                {
                    sb.AppendFormat("{0}={1} ",pi.Name, pi.GetValue(this,null).ToString());
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

}
