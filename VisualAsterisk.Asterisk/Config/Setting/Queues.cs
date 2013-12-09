using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("queues.conf", "Queue configuration file")]
    public class Queues : ConfigFileBase
    {
        public Queues()
        {
            List<PropertyInfo> general = new List<PropertyInfo>();
            categories.Add("General", general);

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
            queues = new List<Queue>();
        }
        #region [General]
        /*
         * Global settings for call Queues
         */


        bool persistentmembers;

        [CategoryAttribute("General"), DescriptionAttribute("Store each dynamic member in each queue in the astdb so that when asterisk is restarted, each member will be automatically read into their recorded queues. Default is 'yes'.")]
        public bool Persistentmembers
        {
            get { return persistentmembers; }
            set { persistentmembers = value; }
        }

        /*; AutoFill Behavior
;    The old/current behavior of the queue has a serial Type behavior 
;    in that the queue will make all waiting callers wait in the queue
;    even if there is More than one available member ready to take
;    calls until the head caller is connected with the member they 
;    were trying to get to. The next waiting caller in line then
;    becomes the head caller, and they are then connected with the
;    next available member and all available Members and waiting callers
;    waits while this happens. The new behavior, enabled by setting
;    autofill=yes makes sure that when the waiting callers are connecting
;    with available Members in a parallel fashion until there are
;    no More available Members or no More waiting callers. This is
;    probably More along the lines of how a queue should work and 
;    in most cases, you will want to enable this behavior. If you 
;    do not specify or Comment out this option, it will default to no
;    to keep backward compatibility with the old behavior.*/
        bool autofill;

        [CategoryAttribute("General"), DescriptionAttribute("Store each dynamic member in each queue in the astdb so that when asterisk is restarted, each member will be automatically read into their recorded queues. Default is 'yes'.")]
        public bool Autofill
        {
            get { return autofill; }
            set { autofill = value; }
        }

        /*; Monitor Type
;    By setting monitor-Type = MixMonitor, when specifying monitor-format
;    to enable recording of queue member conversations, app_queue will
;    now use the new MixMonitor Application instead of Monitor so 
;    the concept of "joining/mixing" the in/out files now goes away
;    when this is enabled. You can set the default Type for all Queues
;    here, and then also change monitor-Type for individual Queues within
;    queue by using the same configuration parameter within a queue 
;    configuration block. If you do not specify or Comment out this option,
;    it will default to the old 'Monitor' behavior to keep backward
;    compatibility. 
         */
        string monitortype; // monitor-Type

        [CategoryAttribute("General"), DescriptionAttribute("")]
        public string Monitortype
        {
            get { return monitortype; }
            set { monitortype = value; }
        }
        #endregion

        List<Queue> queues;
        
        [Browsable(false)] 
        [AstConfigProperty(AstConfigPropertyClass.CategoryCollection)]
        public List<Queue> QueueList
        {
            get { return queues; }
            set { queues = value; }
        }

        protected override void LoadCategory(AstCategory cat)
        {
            Queue q = new Queue();
            q.Name = cat.Name;

            setProperties(q, cat);

            foreach (AstVariable var in cat.Variables)
            {
                if (var.Name == "member" && var.IsObject == 1)
                {
                    q.Members.Add(var.Value); 
                }
            }
            queues.Add(q);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", base.ToString());

            foreach (Queue var in queues)
            {
                sb.AppendFormat("{0}",var.ToString());
            }
            return sb.ToString();
        }
    }

    public class Queue
    {
        public Queue()
        {
            members = new List<string>();
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #region queue settings
        /*Musicclass sets which music applies for this particular call queue.
; The only class which can override this one is if the MOH class is set
; directly on the Channel using Set(CHANNEL(musicclass)=whatever) in the
; dialplan.*/
        string musicclass;

        public string Musicclass
        {
            get { return musicclass; }
            set { musicclass = value; }
        }

        /*An announcement may be specified which is played for the member as
; soon as they answer a call, typically to indicate to them which queue
; this call should be answered as, so that agents or Members who are
; listening to More than one queue can differentiated how they should
; engage the customer*/
        string announce;

        public string Announce
        {
            get { return announce; }
            set { announce = value; }
        }

        /*; A Strategy may be specified.  Valid strategies include:
;
; ringall - ring all available channels until one answers (default)
; roundrobin - take turns ringing each available interface 
; leastrecent - ring interface which was least recently called by this queue
; fewestcalls - ring the one with fewest completed calls From this queue
; random - ring random interface
; rrmemory - round robin with memory, remember where we left off Last ring pass
;*/
        string strategy;

        public string Strategy
        {
            get { return strategy; }
            set { strategy = value; }
        }

        /*; Second settings for service level (default 0)
; Used for service level statistics (calls answered within service level time
; frame)*/
        int servicelevel;

        public int Servicelevel
        {
            get { return servicelevel; }
            set { servicelevel = value; }
        }

        /*; A Context may be specified, in which if the User types a SINGLE
; digit Extension1 while they are in the queue, they will be taken out
; of the queue and sent to that Extension1 in this Context.
;*/
        string context;

        public string Context
        {
            get { return context; }
            set { context = value; }
        }
        /*; How long do we let the phone ring before we consider this a Timeout1...
;*/
        int timeout;

        public int Timeout
        {
            get { return timeout; }
            set { timeout = value; }
        }
        /*; How long do we wait before trying all the Members again?
*/
        int retry;

        public int Retry
        {
            get { return retry; }
            set { retry = value; }
        }

        /*; Weight of queue - when compared to other Queues, higher weights get 
; First shot at available channels when the same Channel is included in 
; More than one queue.
;*/
        int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        /*; After a successful call, how long to wait before sending a potentially
; free member another call (default is 0, or no delay)
;*/
        int wrapuptime;

        public int Wrapuptime
        {
            get { return wrapuptime; }
            set { wrapuptime = value; }
        }

        /*; Autofill will Follow queue Strategy but push multiple calls through
; at same time until there are no More waiting callers or no More
; available Members. The per-queue setting of autofill allows you
; to override the default setting on an individual queue level.
*/
        bool autofill;

        public bool Autofill
        {
            get { return autofill; }
            set { autofill = value; }
        }

        /*; Autopause will pause a queue member if they fail to answer a call
*/
        bool autopause;

        public bool Autopause
        {
            get { return autopause; }
            set { autopause = value; }
        }

        /*; Maximum Number of people waiting in the queue (0 for unlimited)
*/
        int maxlen;

        public int Maxlen
        {
            get { return maxlen; }
            set { maxlen = value; }
        }

        /*; If set to yes, just prior to the caller being bridged with a queue member 
; the MEMBERINTERFACE Variable will be set with the interface Name (eg. Agent/1234)
; of the queue member that was chosen and is now connected to be bridged with
; the caller
*/
        bool setinterfacevar;

        public bool Setinterfacevar
        {
            get { return setinterfacevar; }
            set { setinterfacevar = value; }
        }

        /*; How often to announce queue Position and/or estimated 
; holdtime to caller (0=off)
*/
        int announcefrequency; // announce-frequency

        public int Announcefrequency
        {
            get { return announcefrequency; }
            set { announcefrequency = value; }
        }

        /*; Should we include estimated hold time in Position announcements?
; Either yes, no, or only once.
; Hold time will be announced as the estimated time, 
; or "less than 2 minutes" when appropriate.
*/
        public enum AnnounceHoldtimeType
        {
            YES, NO, ONCE
        }
        AnnounceHoldtimeType announceholdtime;

        public AnnounceHoldtimeType Announceholdtime
        {
            get { return announceholdtime; }
            set { announceholdtime = value; }
        }

        /*; What's the rounding time for the seconds?
; If this is non-zero, then we announce the seconds as well as the minutes
; rounded to this Value.*/
        int announceroundseconds;

        public int Announceroundseconds
        {
            get { return announceroundseconds; }
            set { announceroundseconds = value; }
        }

        /*; This setting controls whether callers can join a queue with no Members. There
; are three choices:
;
; yes    - callers can join a queue with no Members or only unavailable Members
; no     - callers cannot join a queue with no Members
; strict - callers cannot join a queue with no Members or only unavailable
;          Members*/
        string joinempty;

        public string Joinempty
        {
            get { return joinempty; }
            set { joinempty = value; }
        }

        /*; If you wish to remove callers From the queue when new callers cannot join,
; set this setting to one of the same choices for 'joinempty'
*/
        bool leavewhenempty;

        public bool Leavewhenempty
        {
            get { return leavewhenempty; }
            set { leavewhenempty = value; }
        }
        /*; If this is set to yes, the following manager events will be generated:
; AgentCalled, AgentDump, AgentConnect, AgentComplete; setting this to
; vars also sends all Channel variables with the event.
; (may generate some extra manager events, but probably ones you want)
         * eventwhencalled = yes|no|var
*/
        string eventwhencalled;

        public string Eventwhencalled
        {
            get { return eventwhencalled; }
            set { eventwhencalled = value; }
        }

        /*; If this is set to yes, the following manager events will be generated:
; QueueMemberStatus
; (may generate a WHOLE LOT of extra manager events)
*/
        bool eventmemberstatus;

        public bool Eventmemberstatus
        {
            get { return eventmemberstatus; }
            set { eventmemberstatus = value; }
        }

        /*; If you wish to report the caller's hold time to the member before they are
; connected to the caller, set this to yes.
*/
        bool reportholdtime;

        public bool Reportholdtime
        {
            get { return reportholdtime; }
            set { reportholdtime = value; }
        }

        /*; If you want the queue to avoid sending calls to Members whose devices are
; known to be 'in use' (via the Channel driver supporting that device State)
; uncomment this option. (Note: only the SIP Channel driver currently is able
; to report 'in use'.)
*/
        bool ringinuse;

        public bool Ringinuse
        {
            get { return ringinuse; }
            set { ringinuse = value; }
        }

        /*; If you wish to have a delay before the member is connected to the caller (or
; before the member hears any announcement messages), set this to the Number of
; seconds to delay.
*/
        int memberdelay;

        public int Memberdelay
        {
            get { return memberdelay; }
            set { memberdelay = value; }
        }

        /*; If timeoutrestart is set to yes, then the Timeout1 for an agent to answer is
; reset if a BUSY or CONGESTION is received.  This can be useful if agents
; are able to cancel a call with reject or similar.
*/
        bool timeoutrestart;

        public bool Timeoutrestart
        {
            get { return timeoutrestart; }
            set { timeoutrestart = value; }
        }

        /*; Each member of this call queue is listed on a separate line in
; the form technology/dialstring.  "member" means a normal member of a
; queue.  An optional penalty may be specified after a comma, such that
; entries with higher penalties are considered Last.  An optional member
; Name may also be specified after a second comma, which is used in log
; messages as a "friendly Name".  Multiple interfaces may share a single
; member Name.
;
; It is important to ensure that Channel drivers used for Members are loaded
; before app_queue.so itself or they may be marked invalid until reload. This
; can be accomplished by explicitly listing them in modules.conf before app_queue.so
*/
        #endregion

        List<string> members;

        [AstConfigProperty(AstConfigPropertyClass.Object, Name = "member")]
        public List<string> Members
        {
            get { return members; }
            set { members = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[{0}]\n", name);

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(AstConfigPropertyAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    AstConfigPropertyAttribute pro = pros[0] as AstConfigPropertyAttribute;
                    if (pro.Exclude)
                    {
                        continue;
                    }
                    switch (pro.PropertyClass)
                    {
                        case AstConfigPropertyClass.Var:
                            sb.AppendFormat("{0} = {1}\n", pi.Name.ToLower(), pi.GetValue(this, null).ToString());
                            break;
                        case AstConfigPropertyClass.Object:
                            if (pi.GetValue(this, null) != null)
                            {
                                foreach (object var in pi.GetValue(this, null) as IEnumerable)
                                {
                                    if (var.GetType() == typeof(string))
                                    {
                                        sb.AppendFormat("{0} => {1}\n", pro.Name, var);
                                    }
                                    else
                                    {
                                        sb.AppendFormat("{0}\n", var.ToString());
                                    }
                                }
                                
                            } break;
                        case AstConfigPropertyClass.Category:
                            break;
                        case AstConfigPropertyClass.CategoryCollection:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    string str = ConfigFileBase.SimplePropertyToString(pi, this);
                    sb.AppendFormat("{0} = {1}\n", pi.Name.ToLower(), str);
                }
            }
            return sb.ToString();
        }

    }
}
