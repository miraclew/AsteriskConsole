using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Dialplan;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    /// <summary>
    /// A dialplan is a conext in extensions.conf
    /// </summary>
    public class CallingRuleDialPlan : ConfigurationItemBase, IConfiguration
    {
        // TODO: ConfigurationItemBase member override, addchanges
        private static int maxSerialNo = 0;
        private bool allowParkedCalls;
        private IDictionary<int, CallingRule> rules = new Dictionary<int, CallingRule>();
        private List<string> includeContexts = new List<string>();
        private string name; // plancomment
        private string context; // the Context which this dialplan represented
        private int ruleSerialNoCount;
        private int serialNo;

        public CallingRuleDialPlan(int serialNo)
        {
            this.serialNo = serialNo;
            if (serialNo > CallingRuleDialPlan.maxSerialNo)
            {
                CallingRuleDialPlan.maxSerialNo = serialNo;
            }
        }

        public string Context
        {
            get { return context; }
        }

        public List<string> IncludeContexts
        {
            get { return includeContexts; }
        }

        public static int MaxSerialNo
        {
            get { return CallingRuleDialPlan.maxSerialNo; }
        }

        public int RuleSerialNoCount
        {
            get { return ruleSerialNoCount; }
        }

        public int SerialNo
        {
            get { return serialNo; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// SerialNo to CallingRule map
        /// </summary>
        public IDictionary<int, CallingRule> Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        public bool AllowParkedCalls
        {
            get { return allowParkedCalls; }
            set { allowParkedCalls = value; }
        }

        public void AddRule(CallingRule rule)
        {
            rules.Add(rule.SerialNo, rule);
            this.ruleSerialNoCount++;
        }

        public void RemoveRule(CallingRule rule)
        {
            rules.Remove(rule.SerialNo);
        }

        public CallingRule FindRule(string name)
        {
            throw new NotImplementedException();
        }

        public string AllRules
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in includeContexts)
                {
                    sb.Append(item + ",");
                }
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                return sb.ToString();
            }
        }

        #region IConfiguration 成员

        public void LoadUsersConfig(ConfigFile file, string cat)
        {
            throw new NotImplementedException();
        }

        public void LoadExtensionsConfig(ExtensionsConfigFile file, Category cat)
        {
            context = cat.Name;
            CallingRule lastRule = null;
            foreach (ConfigElement e in cat.Elements)
            {
                if (e is ConfigExtension)
                {
                    ConfigExtension exten = e as ConfigExtension;
                    if (!string.IsNullOrEmpty(exten.Name))
                    {
                        CallingRule rule = new CallingRule(ruleSerialNoCount++);
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
                        rule.ExtenConfigString = sb.ToString();
                        rules.Add(rule.SerialNo, rule);
                        lastRule = rule;
                    }
                }
                else if (e is ConfigInclude)
                {
                    ConfigInclude include = e as ConfigInclude;
                    if (!string.IsNullOrEmpty(include.Name))
                    {
                        if (include.Name.Equals("default"))
                        {
                        }
                        else if (include.Name.Equals("parkedcalls"))
                        {
                            allowParkedCalls = true;
                        }

                        includeContexts.Add(include.Name);
                    }
                }
                else if (e is ConfigVariable)
                {
                    ConfigVariable var = e as ConfigVariable;
                    if (var.Name == "plancomment")
                    {
                        this.name = var.Value;
                    }
                    if (var.Name == "comment" && lastRule != null)
                    {
                        lastRule.CommentConfigString = var.Value;
                    }
                }
            }
            if (context.StartsWith(Constants.CallingPlanPrefix))
            {
                name = context.Substring(Constants.CallingPlanPrefix.Length);
            }

        }

        #endregion
    }
}
