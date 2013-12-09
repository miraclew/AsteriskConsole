using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using VisualAsterisk.Asterisk.Config.Internal;


namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("agents.conf", "Agent configuration")]
    public class Agents : ConfigFileBase
    {
        public Agents()
        {
            categories.Add("General", new List<PropertyInfo>());
            categories.Add("Agents", new List<PropertyInfo>());

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(AstConfigPropertyAttribute), false);
                object[] cats = pi.GetCustomAttributes(typeof(CategoryAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    AstConfigPropertyAttribute pro = pros[0] as AstConfigPropertyAttribute;
                    if (pro.Exclude)
                    {
                        continue;
                    }
                }

                if (cats != null && cats.Length > 0)
                {
                    CategoryAttribute c = cats[0] as CategoryAttribute;
                    categories[c.Category].Add(pi);
                }
            }

            this.agentList = new List<Agent>();
        }
        #region General
        bool persistentagents;

        [CategoryAttribute("General"), DescriptionAttribute("Define whether callbacklogins should be stored in astdb for persistence.Persistent logins will be reloaded after Asterisk restarts.")]
        public bool Persistentagents
        {
            get { return persistentagents; }
            set { persistentagents = value; }
        }
        #endregion

        #region agents

        int maxlogintries;
        int autologoff;
        bool autologoffunavail;
        bool ackcall;
        bool endcall;
        int wrapuptime;
        string musiconhold;//TODO asterisk object
        string agentgoodbye;// TODO: asterisk object       
        int group;
        bool updatecdr;
        bool recordagentcalls;/* This section is devoted to recording agent's calls The keywords are global to the chan_agent Channel driver */
        string recordformat;
        string urlprefix;
        string savecallsin;
        string custom_beep;
        List<Agent> agentList;

        [CategoryAttribute("Agents"), DescriptionAttribute("Define maxlogintries to allow agent to try max logins before failed.default to 3")]
        public int Maxlogintries
        {
            get { return maxlogintries; }
            set { maxlogintries = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define autologoff times if appropriate.  This is how long the phone has to ring with no answer before the agent is automatically logged off (in seconds)")]
        public int Autologoff
        {
            get { return autologoff; }
            set { autologoff = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define autologoffunavail to have agents automatically logged out when the extension that they are at returns a CHANUNAVAIL status when a call is attempted to be sent there.Default is \"no\".")]
        public bool Autologoffunavail
        {
            get { return autologoffunavail; }
            set { autologoffunavail = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define ackcall to require an acknowledgement by '#' when an agent logs in using agentcallbacklogin.Default is \"no\".")]
        public bool Ackcall
        {
            get { return ackcall; }
            set { ackcall = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define endcall to allow an agent to hangup a call by '*'.Default is \"yes\".Set this to \"no\" to ignore '*'.")]
        public bool Endcall
        {
            get { return endcall; }
            set { endcall = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define wrapuptime.  This is the minimum amount of time when after disconnecting before the caller can receive a new call note this is in milliseconds.")]
        public int Wrapuptime
        {
            get { return wrapuptime; }
            set { wrapuptime = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define the default musiconhold for agents musiconhold => music_class")]
        public string Musiconhold
        {
            get { return musiconhold; }
            set { musiconhold = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define the default good bye sound file for agents default to vm-goodbye")]
        public string Agentgoodbye
        {
            get { return agentgoodbye; }
            set { agentgoodbye = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Define updatecdr. This is whether or not to change the source channel in the CDR record for this call to agent/agent_id so that we know which agent generates the call")]
        public bool Updatecdr
        {
            get { return updatecdr; }
            set { updatecdr = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Group memberships for agents (may change in mid-file)")]
        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("Enable recording calls addressed to agents. It's turned off by default.")]
        public bool Recordagentcalls
        {
            get { return recordagentcalls; }
            set { recordagentcalls = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("The format to be used to record the calls: wav, gsm, wav49.By default its \"wav\".")]
        public string Recordformat
        {
            get { return recordformat; }
            set { recordformat = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("The text to be added to the name of the recording. Allows forming a url link.")]
        public string Urlprefix
        {
            get { return urlprefix; }
            set { urlprefix = value; }
        }

        [CategoryAttribute("Agents"), DescriptionAttribute("The optional directory to save the conversations in. The default is /var/spool/asterisk/monitor")]
        public string Savecallsin
        {
            get { return savecallsin; }
            set { savecallsin = value; }
        }

        //[CategoryAttribute("Agents"), DescriptionAttribute("An optional custom beep sound file to play to always-connected agents.")]

        /* This section contains the agent definitions, in the form: agent => agentid,agentpassword,Name */
        [CategoryAttribute("Agents"), Browsable(false), DescriptionAttribute("This section contains the agent definitions, in the form: agent => agentid,agentpassword,name")]
        [AstConfigProperty(AstConfigPropertyClass.Object, Name = "agent")]
        public List<Agent> AgentList
        {
            get { return agentList; }
            set { agentList = value; }
        }

        #endregion

        protected override void LoadCategory(AstCategory cat)
        {
            if (cat.Name.Equals("agents"))
            {
                setProperties(this, cat); // set others property

                // set agents
                foreach (AstVariable var in cat.Variables)
                {
                    if (var.Name == "agent" && var.IsObject == 1)
                    {
                        Agent agent = new Agent();
                        int index1 = var.Value.IndexOf(',');
                        int index2 = var.Value.IndexOf(',', index1 + 1);
                        if (index1 > 0)
                        {
                            agent.Agentid = var.Value.Substring(0, index1).Trim();
                            if (index2 > 0)
                            {
                                agent.Agentpassword = var.Value.Substring(index1 + 1, index2 - index1 - 1).Trim();
                                agent.Name = var.Value.Substring(index2 + 1).Trim();
                            }
                            else
                                agent.Agentpassword = var.Value.Substring(index1 + 1).Trim();

                        }
                        else
                            agent.Agentid = var.Value.Trim();

                        agentList.Add(agent);
                    }
                }
            }
        }
    }

    [UILabel("Agents:")]
    [UIDisplayMemeberAttribute("Name")]
    [Description("")]
    public class Agent
    {
        private string agentid;
        private string agentpassword;
        private string name;

        [UIItem("Agent ID:", UIItemType.DETAIL, 0, "")]
        [Description("")]
        public string Agentid
        {
            get { return agentid; }
            set { agentid = value; }
        }

        [UIItem("Agent password:", UIItemType.DETAIL, 1, "")]
        public string Agentpassword
        {
            get { return agentpassword; }
            set { agentpassword = value; }
        }

        [UIItem("Name:", UIItemType.DETAIL, 2, "")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (agentid != null && agentid.Length > 0)
            {
                sb.AppendFormat("agent => {0},{1},{2}\n", agentid, agentpassword, name);
            }
            return sb.ToString();
        }
    }
}
