using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Exception;
using VisualAsterisk.Asterisk.Config.Dialplan;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class CallingRule
    {
        public CallingRule(int no)
        {
            this.serialNo = no;
        }
        #region internal class member
        private int priority;
        private int serialNo;

        /// <summary>
        /// The serial number of this rule, which is the Priority of the extensions.conf
        /// </summary>
        public int SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

        #endregion

        private string name; // Rule Name
        private string trunkContext; // Trunk(Context) to place this call through
        private string trunkName;
        // Dialing Rules Pattern
        private string pattern; // dialing Rule string
        private string begin; // string Begin with
        private int follow; // how many Digits followed
        private bool more; // has More Digits
        // preoperate before dialing
        private int strip; // how many Digits to Strip
        private string prepend; // Digits Prepend before dialing

        /// <summary>
        /// The Rule Name
        /// For example in config line: comment = _9XXXX!,1,callingrule1,standard
        /// callingrule1 is the Name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string TrunkName
        {
            get { return trunkName; }
            set { trunkName = value; }
        }

        public string TrunkContext
        {
            get { return trunkContext; }
        }

        public string Begin
        {
            get { return begin; }
            set { begin = value; }
        }

        public int Follow
        {
            get { return follow; }
            set { follow = value; }
        }

        public bool More
        {
            get { return more; }
            set { more = value; }
        }

        public int Strip
        {
            get { return strip; }
            set { strip = value; }
        }

        public string Prepend
        {
            get { return prepend; }
            set { prepend = value; }
        }

        #region config line in extensions.conf
        /// <summary>
        /// get: Return a exten config line that this class represent in [numberplan-custom-xxx] in extensions.conf
        /// set: Parse exten config line
        /// For example in config line : exten = _9XXXX!,1,Macro(trunkdial,${trunk_1}/+2${EXTEN:1},${trunk_1_cid})
        /// ExtenConfigString is _9XXXX!,1,Macro(trunkdial,${trunk_1}/+2${EXTEN:1},${trunk_1_cid})
        /// </summary>
        public string ExtenConfigString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.Pattern);
                sb.Append(",");
                sb.Append(priority.ToString());
                sb.Append(",");
                sb.Append("Macro(trunkdial,${");
                sb.Append(trunkContext);
                sb.Append("}/+");
                sb.Append(prepend);
                sb.Append("${EXTEN:");
                sb.Append(strip.ToString());
                sb.Append("},${");
                sb.Append(trunkContext);
                sb.Append("_cid})");
                return sb.ToString();
            }
            set
            {
                string[] values = value.Split(new char[] { ',' });
                if (values.Length < 4)
                {
                    throw new ConfigFileParseErrorException("CallingRule.LoadConfigString failed");
                }
                this.Pattern = values[0];

                priority = int.Parse(values[1]);

                string toParse = values[3];
                int index1 = toParse.IndexOf('{');
                int index2 = toParse.IndexOf('}');
                trunkContext = toParse.Substring(index1 + 1, index2 - index1 - 1);
                if (toParse.IndexOf("/+") != -1)
                {
                    toParse = toParse.Substring(toParse.IndexOf("/+"));
                    index1 = toParse.IndexOf("${");
                    prepend = toParse.Substring(2, index1 - 2);
                }
                else
                {
                    toParse = toParse.Substring(toParse.IndexOf("/"));
                }
                index1 = toParse.IndexOf(':');
                index2 = toParse.IndexOf('}');
                strip = int.Parse(toParse.Substring(index1 + 1, index2 - index1 - 1));
            }
        }
        public string CommentConfigString
        {
            get
            {
                return string.Format("{0},{1},{2},standard", Pattern, "1", Name);
            }
            set
            {
                Name = value.Split(new char[] { ',' })[2];
            }
        }
        #endregion

        /// <summary>
        /// The exten Name of the config line in extensions.conf
        /// For example: _9XXXX!
        /// </summary>
        public string Pattern
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("_" + begin);
                sb.Append('X', follow);
                sb.Append('!', more ? 1 : 0);
                pattern = sb.ToString();
                return pattern;
            }
            set 
            { 
                pattern = value;

                if (pattern.StartsWith("_"))
                {
                    follow = 0;
                    if (pattern.IndexOf('X') > 0)
                    {
                        begin = pattern.Substring(1, pattern.IndexOf('X') - 1);
                        foreach (char c in pattern.ToCharArray())
                        {
                            if (c == 'X')
                            {
                                follow++;
                            }
                        }
                    }
                }

                if (pattern.LastIndexOf('!') != -1)
                {
                    more = true;
                }
            }
        }


        public void LoadExtensionsConfig(ExtensionsConfigFile extensFile, Category cat)
        {
            if (cat.Name.StartsWith(Constants.CallingRulePrefix))
            {
                name = cat.Name.Substring(Constants.CallingRulePrefix.Length);
            }
            foreach (ConfigElement e in cat.Elements)
            {
                if (e is ConfigExtension)
                {
                    ConfigExtension exten = e as ConfigExtension;
                    if (!string.IsNullOrEmpty(exten.Name))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(exten.Name + "," + exten.Priority + "," + exten.Application[0] + "(");
                        for (int i = 1; i < exten.Application.Length; i++)
                        {
                            sb.Append(exten.Application[i]);
                            if (i < exten.Application.Length - 1)
                            {
                                sb.Append(",");
                            }
                        }
                        sb.Append(")");
                        this.ExtenConfigString = sb.ToString();
                    }
                    break;
                }
            }
       }
    }
}
