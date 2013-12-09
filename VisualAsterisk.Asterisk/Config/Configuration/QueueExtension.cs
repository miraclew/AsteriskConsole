using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Action;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class QueueExtension : ConfigurationItemBase, IExtension
    {
        public QueueExtension()
        {
        }

        public QueueExtension(QueueExtension queue)
        {
            copy(queue);
        }

        #region config line in extensions.conf
        /// <summary>
        /// get: Return a exten config line in [default] in extensions.conf
        /// 
        /// For example in config line : exten => 8000,1,MeetMe(${EXTEN}|MI)
        /// ExtenConfigString return 8000,1,MeetMe(${EXTEN}|MI)
        /// </summary>
        public string ExtenConfigString
        {
            get
            {
                return string.Format("{0},1,{1})", queue, "Queue(${EXTEN})");
            }
        }
        #endregion

        #region config lines queues.conf
        #endregion

        #region Queue define
        private string queue;
        private string name;
        private string strategy;
        private IList<string> members = new List<string>();

        [ConfigurationProperty(ConfigurationPropertyType.Var, "fullname")]
        public string Name
        {
            get { return name; }
            set
            {
                firePropertyChange("fullname", name, value);
                name = value;
            }
        }

        /// <summary>
        /// A Strategy may be specified.  Valid strategies include:
        /// ringall - ring all available channels until one answers (default)
        /// roundrobin - take turns ringing each available interface 
        /// leastrecent - ring interface which was least recently called by this queue
        /// fewestcalls - ring the one with fewest completed calls From this queue
        /// random - ring random interface
        /// rrmemory - round robin with memory, remember where we left off Last ring pass
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyType.Var, "strategy")]
        public string Strategy
        {
            get { return strategy; }
            set
            {
                firePropertyChange("strategy", strategy, value);
                strategy = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Object, "member")]
        public IList<string> Members
        {
            get { return members; }
            set { members = value; }
        }
        #endregion

        #region Queue Options
        private int timeout; // How long do we let the phone ring before we consider this a Timeout1...
        /// <summary>
        /// After a successful call, how long to wait before sending a potentially
        /// free member another call (default is 0, or no delay)
        /// </summary>
        private int wrapuptime;
        /// <summary>
        /// Maximum Number of people waiting in the queue (0 for unlimited)
        /// </summary>
        private int maxlen;
        /// <summary>
        /// Musicclass sets which music applies for this particular call queue.
        /// The only class which can override this one is if the MOH class is set
        /// directly on the Channel using Set(CHANNEL(musicclass)=whatever) in the
        /// dialplan.
        /// </summary>
        private string musicclass;

        /// <summary>
        /// Autofill will Follow queue Strategy but push multiple calls through
        /// at same time until there are no More waiting callers or no More
        /// available Members. The per-queue setting of autofill allows you
        /// to override the default setting on an individual queue level.
        /// </summary>
        private bool autofill;
        /// <summary>
        /// Autopause will pause a queue member if they fail to answer a call
        /// </summary>
        private bool autopause;

        /// <summary>
        /// This setting controls whether callers can join a queue with no Members. There
        /// are three choices:
        /// yes    - callers can join a queue with no Members or only unavailable Members
        /// no     - callers cannot join a queue with no Members
        /// strict - callers cannot join a queue with no Members or only unavailable Members
        /// </summary>
        private string joinempty;

        /// <summary>
        /// If you wish to remove callers From the queue when new callers cannot join,
        /// set this setting to one of the same choices for 'joinempty'
        /// </summary>
        private bool leavewhenempty;

        /// <summary>
        /// If you wish to report the caller's hold time to the member before they are
        /// connected to the caller, set this to yes.
        /// </summary>
        bool reportholdtime;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "reportholdtime")]
        public bool Reportholdtime
        {
            get { return reportholdtime; }
            set
            {
                firePropertyChange("reportholdtime", reportholdtime, value);
                reportholdtime = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "leavewhenempty")]
        public bool Leavewhenempty
        {
            get { return leavewhenempty; }
            set
            {
                firePropertyChange("leavewhenempty", leavewhenempty, value);
                leavewhenempty = value;
            }
        }


        [ConfigurationProperty(ConfigurationPropertyType.Var, "joinempty")]
        public string Joinempty
        {
            get { return joinempty; }
            set
            {
                firePropertyChange("joinempty", joinempty, value);
                joinempty = value;
            }
        }


        [ConfigurationProperty(ConfigurationPropertyType.Var, "autofill")]
        public bool Autofill
        {
            get { return autofill; }
            set
            {
                firePropertyChange("autofill", autofill, value);
                autofill = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "autopause")]
        public bool Autopause
        {
            get { return autopause; }
            set
            {
                firePropertyChange("autopause", autopause, value);
                autopause = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "musicclass")]
        public string Musicclass
        {
            get { return musicclass; }
            set
            {
                firePropertyChange("musicclass", musicclass, value);
                musicclass = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "maxlen")]
        public int Maxlen
        {
            get { return maxlen; }
            set
            {
                firePropertyChange("maxlen", maxlen, value);
                maxlen = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "wrapuptime")]
        public int Wrapuptime
        {
            get { return wrapuptime; }
            set
            {
                firePropertyChange("wrapuptime", wrapuptime, value);
                wrapuptime = value;
            }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "timeout")]
        public int Timeout
        {
            get { return timeout; }
            set
            {
                firePropertyChange("timeout", timeout, value);
                timeout = value;
            }
        }

        #endregion

        #region IExtension members

        public string Extension
        {
            get
            {
                return queue;
            }
            set
            {
                queue = value;
            }
        }

        public string Descripton
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region IEditableObject members
        public override ConfigurationItemBase Copy()
        {
            return new QueueExtension(this);
        }

        protected override void copy(ConfigurationItemBase obj)
        {
            QueueExtension queue = obj as QueueExtension;
            this.Autofill = queue.autofill;
            this.Autopause = queue.autopause;
            this.Joinempty = queue.joinempty;
            this.Leavewhenempty = queue.leavewhenempty;
            this.Maxlen = queue.maxlen;
            // TODO: NEED to do something for members
            this.members.Clear();
            foreach (string item in queue.Members)
            {
                this.members.Add(string.Copy(item));
            }
            this.Musicclass = queue.musicclass;
            this.Name = queue.name;
            this.queue = queue.queue;
            this.Reportholdtime = queue.reportholdtime;
            this.Strategy = queue.strategy;
            this.Timeout = queue.timeout;
            this.Wrapuptime = queue.wrapuptime;
        }
        #endregion

        public void AddMember(string member)
        {
            if (!members.Contains(member))
            {
                members.Add(member);
                addChange(new ConfigurationChange("queues.conf", UpdateConfigAction.ACTION_APPEND, queue, "member", member, null));
            }
        }

        public void RemoveMember(string member)
        {
            if (members.Contains(member))
            {
                members.Remove(member);
                addChange(new ConfigurationChange("queues.conf", UpdateConfigAction.ACTION_DELETE, queue, "member", member,null));
            }
        }

        protected override void firePropertyChange(string propertyName, object oldValue, object newValue)
        {
            if (editing)
            {
                addChange(new ConfigurationChange("queues.conf", UpdateConfigAction.ACTION_UPDATE, queue, propertyName,
            ConfigurationUtil.ToConfigValueString(newValue), null));
                
            }
        }
    }
}
