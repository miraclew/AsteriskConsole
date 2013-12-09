using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Remote;

namespace VisualAsterisk.Asterisk.Config.Dialplan
{
    public class ExtensionsConfigFileReader : ConfigFileReader
    {
        public ExtensionsConfigFileReader()
        {
        }

        public ExtensionsConfigFileReader(string dir)
            : base(dir)
        {

        }

        /// <summary>
        /// This method corresponds to an iteration of the loop at line 2212 Notes:
        ///      1. [General] and [globals] are allowed to be a Context here if they contain only configvariables
        ///      2. switch and ignorepat are treated like regular ConfigVariable.
        ///      
        /// throws ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="Lineno"></param>
        /// <param Name="line"></param>
        /// <returns></returns>
        protected override ConfigElement processTextLine(string configfile, int lineno, string line)
        {
            ConfigElement configElement;

            if (
                    (line.Trim().StartsWith("exten") || line.Trim().StartsWith("include")) &&
                    currentCategory != null &&
                    (currentCategory.Name.Equals("general") || currentCategory.Name.Equals("globals"))
            )
                throw new ConfigParseException(configfile, lineno, "cannot have 'exten' or 'include' in global or general sections");


            /*
             * Goal here is to break out anything unique that we might want to
             * look at and parse separately. For now, only Exten and include fit
             * that criteria. Eventually, I could see parsing sections for things
             * from macros, contexts to differentiate them from Categories, switch
             * for realtime, and More. 
             */
            if (line.Trim().StartsWith("exten"))
            {
                configElement = parseExtension(configfile, lineno, line);
                currentCategory.addElement(configElement);
                return configElement;
            }
            else if (line.Trim().StartsWith("include"))
            {
                // use parseVariable since we have access to it
                ConfigVariable configvar = parseVariable(configfile, lineno, line);
                configElement = new ConfigInclude(configfile, lineno, configvar.Value);
                currentCategory.addElement(configElement);
                return configElement;
            }

            // leave everything else the same
            configElement = base.processTextLine(configfile, lineno, line);

            return configElement;
        }

        /* Roughly corresponds to pbx_config.c:2222 */
        /// <summary>
        /// throws ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="Lineno"></param>
        /// <param Name="line"></param>
        /// <returns></returns>
        protected ConfigExtension parseExtension(string configfile, int lineno, string line)
        {
            ConfigVariable initialVariable = parseVariable(configfile, lineno, line);

            if (!initialVariable.Name.Equals("exten"))
                throw new ConfigParseException(configfile, lineno, "missing 'exten' near " + line);
            line = initialVariable.Value.Trim();

            int nameIndex = line.IndexOf(",", 0);
            if (nameIndex == -1)
                throw new ConfigParseException(configfile, lineno, "missing extension name near " + line);
            string name = line.Substring(0, nameIndex);
            line = line.Substring(name.Length + 1, line.Length - name.Length - 1).Trim();

            int priorityDelimiter = line.IndexOf(",", 0);
            if (priorityDelimiter == -1)
                throw new ConfigParseException(configfile, lineno, "missing extension priority near " + line);
            string priority = line.Substring(0, priorityDelimiter);
            line = line.Substring(priority.Length + 1, line.Length - priority.Length - 1).Trim();

            string[] application = harvestApplicationWithArguments(line);

            return new ConfigExtension(configfile, lineno, name, priority, application);
        }

        /* Roughly corresponds to pbx_config.c:2276 */
        private static string[] harvestApplicationWithArguments(string arg)
        {
            List<string> args = new List<string>();

            if (args != null && arg.Trim().Length >= 0)
            {
                string appl = "", data = "";

                /* Find the First occurrence of either '(' or ',' */
                int firstc = arg.IndexOf(',');
                int firstp = arg.IndexOf('(');

                if (firstc != -1 && (firstp == -1 || firstc < firstp))
                {
                    /* comma found, no parenthesis */
                    /* or both found, but comma found First */
                    string[] split = arg.Split(new char[] { ',' });
                    appl = split[0];
                    for (int i = 1; i < split.Length; i++)
                        data += split[i] + (i + 1 < split.Length ? "," : "");
                }
                else if (firstc == -1 && firstp == -1)
                {
                    /* Neither found */
                    data = "";
                    appl = arg; // BUGFIX:
                }
                else
                {
                    /* Final remaining case is parenthesis found First */
                    string[] split = arg.Split(new string[] { "(" }, StringSplitOptions.None);
                    appl = split[0];
                    for (int i = 1; i < split.Length; i++)
                        data += split[i] + (i + 1 < split.Length ? "(" : "");
                    int end = data.LastIndexOf(')');
                    if (end == -1)
                    {
                        //ast_log(LOG_WARNING, "No closing parenthesis found? '%s(%s'\n", appl, data);
                    }
                    else if (end == data.Length - 1)
                    {
                        data = data.Substring(0, end);
                    }
                    data = processQuotesAndSlashes(data, ',', '|');
                }

                if (!appl.Trim().Equals(""))
                {
                    args.Add(appl.Trim());
                    if (!data.Trim().Equals(""))
                    {
                        string[] dataSplit = data.Split(new string[] { "|" }, StringSplitOptions.None);
                        foreach (string aDataSplit in dataSplit)
                        {
                            args.Add(aDataSplit.Trim());
                        }
                    }
                }
            }

            return args.ToArray();
        }
        /// <summary>
        /// throws IOException, ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <returns></returns>
        public ExtensionsConfigFile ReadExtensionsFile(string configfile)
        {
            base.ReadFile(configfile);
            /* at some point, we may want to resolve back references */
            /* that include or goto from one Context to another */
            return new ExtensionsConfigFile(configfile, categories);
        }

        public ExtensionsConfigFile ReadRemoteExtensionFile(string configfile, DefaultAsteriskServer server)
        {
            RemoteConfigFileReader remoteReader = new RemoteConfigFileReader(server);
            remoteReader.Timeout = 5000;
            ConfigFile file = remoteReader.ReadFile(configfile);
            foreach (string catName in file.Categories.Keys)
            {
                processTextLine(configfile, -1, string.Format("[{0}]",catName));
                foreach (string  line in file.Categories[catName])
                {
                    processTextLine(configfile, -1, line);
                }
            }
            return new ExtensionsConfigFile(configfile, categories);
        }

        /* ast_process_quotes_and_slashes rewritten to be java friendly */
        private static string processQuotesAndSlashes(string start, char find, char replace_with)
        {
            string dataPut = "";
            int inEscape = 0;
            int inQuotes = 0;

            char[] startChars = start.ToCharArray();
            foreach (char startChar in startChars)
            {
                if (inEscape != 0)
                {
                    dataPut += startChar;       /* Always goes verbatim */
                    inEscape = 0;
                }
                else
                {
                    if (startChar == '\\')
                    {
                        inEscape = 1;      /* Do not copy \ into the data */
                    }
                    else if (startChar == '\'')
                    {
                        inQuotes = 1 - inQuotes;   /* Do not copy ' into the data */
                    }
                    else
                    {
                        /* Replace , with |, unless in quotes */
                        dataPut += inQuotes != 0 ? startChar : ((startChar == find) ? replace_with : startChar);
                    }
                }
            }
            return dataPut;
        }
    }
}
