using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Configuration;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Response;
using VisualAsterisk.Asterisk.Exception;
using VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep;
using VisualAsterisk.Asterisk.Config.Remote;
using VisualAsterisk.Asterisk.Config.Dialplan;
using System.ComponentModel;
using System.Diagnostics;
using VisualAsterisk.Asterisk.Config.ConfigFiles;

namespace VisualAsterisk.Asterisk.Config
{
    public class AsteriskConfigManager : IAsteriskServerComponent, IAsteriskConfigManager
    {
        #region fields and property
        private DefaultAsteriskServer server;
        private string configFilesDir;
        private BindingList<UserExtension> users;
        private BindingList<ConferenceRoom> confRooms;
        private BindingList<QueueExtension> queues;
        private BindingList<Trunk> trunks;
        private IList<CallingRuleDialPlan> dialplans;
        private IList<CallingRule> callingRules;
        private IList<IncomingCallRule> incomingCallRules;
        private BindingList<VoiceMenu> voiceMenus;
        private BindingList<RingGroup> ringGroups;
        private VoiceMailSetting voiceMailSetting;
        private CallParkSetting callParkSetting;
        private Options options;

        // General or Default configuration
        private UserExtension generalUser;

        public UserExtension GeneralUser
        {
            get { return generalUser; }
        }

        public Options Options
        {
            get { return options; }
        }

        public System.ComponentModel.BindingList<RingGroup> RingGroups
        {
            get { return ringGroups; }
        }

        public VoiceMailSetting VoiceMailSetting
        {
            get { return voiceMailSetting; }
        }

        public CallParkSetting CallParkSetting
        {
            get { return callParkSetting; }
        }

        public BindingList<VoiceMenu> VoiceMenus
        {
            get { return voiceMenus; }
        }

        public IList<CallingRuleDialPlan> Dialplans
        {
            get { return dialplans; }
        }

        public IList<CallingRule> CallingRules
        {
            get { return callingRules; }
        }

        public BindingList<Trunk> Trunks
        {
            get { return trunks; }
        }

        public System.ComponentModel.BindingList<QueueExtension> Queues
        {
            get { return queues; }
        }

        public System.ComponentModel.BindingList<ConferenceRoom> ConferenceRooms
        {
            get { return confRooms; }
        }

        public BindingList<UserExtension> Users
        {
            get { return users; }
        }

        public IList<IncomingCallRule> IncomingCallRules
        {
            get { return incomingCallRules; }
        }

        #endregion

        /// <summary>
        /// Manage config files from remote server
        /// </summary>
        /// <param Name="server"></param>
        public AsteriskConfigManager(DefaultAsteriskServer server)
        {
            this.server = server;
        }

        /// <summary>
        /// Manage config files in local path
        /// </summary>
        /// <param Name="dir"></param>
        public AsteriskConfigManager(string dir)
        {
            configFilesDir = dir;
        }

        private void reset()
        {
            users = new BindingList<UserExtension>();
            users.AddingNew += new AddingNewEventHandler(users_AddingNew);
            confRooms = new BindingList<ConferenceRoom>();
            queues = new BindingList<QueueExtension>();
            trunks = new BindingList<Trunk>();
            dialplans = new List<CallingRuleDialPlan>();
            incomingCallRules = new List<IncomingCallRule>();
            callingRules = new List<CallingRule>();
            voiceMenus = new BindingList<VoiceMenu>();
            ringGroups = new BindingList<RingGroup>();
            callParkSetting = new CallParkSetting();
            voiceMailSetting = new VoiceMailSetting();
            options = new Options(this);
        }

        void users_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new UserExtension(generalUser);
        }

        public void AddUser(UserExtension user)
        {
            if (generalUser == null)
            {
                throw new InvalidOperationException("UserExtension.General not set");
            }

            UpdateConfigAction config = new UpdateConfigAction("users.conf", "users.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, user.Category);
            foreach (KeyValuePair<string, string> item in ConfigurationUtil.GetConfigVarKeyValuePairs(user, generalUser))
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, user.Category, item.Key, item.Value);
            }
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddUser failed, {0}", response.Message));
            }

            //users.Add(User);
            // TODO: notify server new User added
        }

        public void RemoveUser(UserExtension user)
        {
            UpdateConfigAction config = new UpdateConfigAction("users.conf", "users.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, user.Category);
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveUser failed, {0}", response.Message));
            }

            //users.Remove(User);
            // TODO: notify server new User removed
        }

        public void UpdateUser(UserExtension user)
        {
            if (user.AddingNew || FindUser(user.Extension) == null)
            {
                AddUser(user);
                user.AddingNew = false;
                return;
            }

            if (server != null)
            {
                UpdateConfigAction config = new UpdateConfigAction("users.conf", "users.conf");
                foreach (string key in user.Changes.Keys)
                {
                    config.AddCommand(UpdateConfigAction.ACTION_UPDATE, user.Category, user.Changes[key].Variable, user.Changes[key].Value);
                }
                ManagerResponse response = server.SendAction(config);
                if (!response.IsSuccess())
                {
                    throw new ManagerOperationException(string.Format("UpdateUser failed, {0}", response.Message));
                }
            }
            user.PendingChangesCommitted();
        }

        public UserExtension FindUser(string extension)
        {
            UserExtension user = null;
            foreach (UserExtension u in users)
            {
                if (u.Extension == extension)
                {
                    user = u;
                    break;
                }
            }
            return user;
        }

        public void AddCallingRule(CallingRule rule)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, rule.Name); //TODO:
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, rule.Name , "exten", rule.ExtenConfigString);
                
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddCallingRule failed, {0}", response.Message));
            }
        }

        public void RemoveCallingRule(CallingRule rule)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, rule.Name); //TODO:
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveCallingRule failed, {0}", response.Message));
            }
        }

        public void AddConfRoom(ConferenceRoom room)
        {
            // add to meetme.conf
            UpdateConfigAction config = new UpdateConfigAction("meetme.conf", "meetme.conf");
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, "rooms", "conf", room.ConfConfigString);

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddConfRoom failed when update meetme.conf, {0}", response.Message));
            }

            // add to extensions.conf
            config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, "default", "exten", room.ExtenConfigString);
            response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddConfRoom failed when update extensions.conf {0}", response.Message));
            }

            //confRooms.Add(room);
            // TODO: notify server new User added
        }

        public void UpdateConfRoom(ConferenceRoom room)
        {
            if (room.AddingNew || FindConfRoom(room.RoomNumber) == null)
            {
                AddConfRoom(room);
                room.AddingNew = false;
                return;
            }

            SubmitConfigFileChanges(room.FileChanges);
            room.PendingChangesCommitted();
        }

        public void SubmitConfigFileChanges(Dictionary<string, List<ConfigurationChange>> changes)
        {
            foreach (string file in changes.Keys)
            {
                UpdateConfigAction config = new UpdateConfigAction(file, file);
                foreach (ConfigurationChange c in changes[file])
                {
                    config.AddCommand(c.Action, c.Category, c.Variable, c.Value, c.Match);
                }
                ManagerResponse response = server.SendAction(config);
                if (!response.IsSuccess())
                {
                    throw new ManagerOperationException(string.Format("Update file {0} failed, {1}", file, response.Message));
                }
            }
        }

        public void RemoveConfRoom(ConferenceRoom room)
        {
            // remove from meetme.conf
            UpdateConfigAction config = new UpdateConfigAction("meetme.conf", "meetme.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELETE, "rooms", "conf", null, room.ConfConfigString);

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveConfRoom failed when update meetme.conf, {0}", response.Message));
            }

            // remove from Extension.conf
            config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELETE, "default", "exten", null, room.ExtenConfigString);
            response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveConfRoom failed when update extensions.conf, {0}", response.Message));
            }

            // TODO: some other place (e.g. voice menu)may refer to this conference room, need to be removed also 

            //confRooms.Remove(room);
            // TODO: notify server new User added
        }

        public ConferenceRoom FindConfRoom(string roomNumber)
        {
            ConferenceRoom room = null;
            foreach (ConferenceRoom r in confRooms)
            {
                if (r.RoomNumber == roomNumber)
                {
                    room = r;
                    break;
                }
            }
            return room;
        }

        public void AddQueue(QueueExtension queue)
        {
            UpdateConfigAction config = new UpdateConfigAction("queues.conf", "queues.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, queue.Extension);

            foreach (KeyValuePair<string, string> item in ConfigurationUtil.GetConfigVarKeyValuePairs(queue, null))
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, queue.Extension, item.Key, item.Value);
            }

            foreach (string item in queue.Members)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, queue.Extension, "member", item);
            }

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddQueue failed when update queues.conf, {0}", response.Message));
            }

            // add to Extension.conf
            config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, "default", "exten", queue.ExtenConfigString);
            response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddQueue failed when update extensions.conf, {0}", response.Message));
            }

            //queues.Add(queue);
            // TODO: notify server new User added
        }

        public void RemoveQueue(QueueExtension queue)
        {
            UpdateConfigAction config = new UpdateConfigAction("queues.conf", "queues.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, queue.Extension);

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveQueue failed when update queues.conf, {0}", response.Message));
            }

            // remove from Extension.conf
            config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELETE, "default", "exten", null, queue.ExtenConfigString);
            response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveQueue failed when update extensions.conf, {0}", response.Message));
            }
            //queues.Remove(queue);
            // TODO: notify server new User added
        }

        public void UpdateQueue(QueueExtension queue)
        {
            if (queue.AddingNew || FindQueue(queue.Extension) == null)
            {
                AddQueue(queue);
                queue.AddingNew = false;
                return;
            }
            SubmitConfigFileChanges(queue.FileChanges);
            queue.PendingChangesCommitted();
        }

        /// <summary>
        /// Find Queue with Extension
        /// </summary>
        /// <param Name="queueExtension"></param>
        /// <returns></returns>
        public QueueExtension FindQueue(string extension)
        {
            QueueExtension queue = null;
            foreach (QueueExtension q in this.queues)
            {
                if (q.Extension == extension)
                {
                    queue = q;
                    break;
                }
            }
            return queue;
        }

        public void AddTrunk(Trunk trunk)
        {
            #region update users.conf
            UpdateConfigAction config = new UpdateConfigAction("users.conf", "users.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, trunk.TrunkUserCategory);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "disallow", trunk.Disallow);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "allow", trunk.Allow);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "context", trunk.Context);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "dialformat", "${EXTEN:1}");
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "canreinvite", trunk.Canreinvite ? "yes" : "no");
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "hasexten", "no"); // TODO: no member to map
            if (trunk.TrunkTech == Tech.IAX)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "hasaix", "yes");
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "hassip", "no");
                if (trunk.Register)
                {
                    config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "registeriax", "yes");
                    config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "registersip", "no");
                }
            }
            else if (trunk.TrunkTech == Tech.SIP)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "hassip", "yes");
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "hasaix", "no");
                if (trunk.Register)
                {
                    config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "registersip", "yes");
                    config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "registeraix", "no");
                }
            }
            else
            {
                // TODO: Zap
            }

            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "secret", trunk.Password);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "trunkname", "Custom " + trunk.Comment);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "trunkstyle", "customvoip");
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.TrunkUserCategory, "username", trunk.Username);

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddTrunk failed, {0}", response.Message));
            }
            #endregion

            #region update extensions.conf
            config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, trunk.Context);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, trunk.Context, "include", "default");
            response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddTrunk failed, {0}", response.Message));
            }

            #endregion
            //trunks.Add(trunk);
            // TODO: notify server new trunk added
        }

        public void UpdateTrunk(Trunk trunk)
        {
            if (trunk.AddingNew || FindTrunkByUserCategory(trunk.TrunkUserCategory) == null)
            {
                AddTrunk(trunk);
                trunk.AddingNew = false;
                return;
            }
            UpdateConfigAction config = new UpdateConfigAction("users.conf", "users.conf");
            foreach (ConfigurationChange c in trunk.Changes.Values)
            {
                config.AddCommand(c.Action, c.Category, c.Variable, c.Value, c.Match);
            }

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("UpdateTrunk failed, {0}", response.Message));
            }
            trunk.PendingChangesCommitted();
            // TODO: update extensions.conf ?
        }

        public void RemoveTrunk(Trunk trunk)
        {
            UpdateConfigAction config = new UpdateConfigAction("users.conf", "users.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, trunk.TrunkUserCategory);
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveTrunk failed, {0}", response.Message));
            }

            // remove from Extension.conf
            config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, trunk.Context);
            response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveTrunk failed, {0}", response.Message));
            }

            //trunks.Remove(trunk);
            // TODO: notify server trunk removed
        }

        public Trunk FindTrunkByName(string name)
        {
            Trunk trunk = null;
            foreach (Trunk t in this.trunks)
            {
                if (t.Trunkname == name)
                {
                    trunk = t;
                    break;
                }
            }
            return trunk;
        }

        public Trunk FindTrunkByUserCategory(string category)
        {
            Trunk trunk = null;
            foreach (Trunk t in this.trunks)
            {
                if (t.TrunkUserCategory == category)
                {
                    trunk = t;
                    break;
                }
            }
            return trunk;
        }

        public void AddDailPlan(CallingRuleDialPlan dialplan)
        {
            // TODO: UPDATE TO 2.0
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, dialplan.Name);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, dialplan.Name, "include", "default");
            if (dialplan.AllowParkedCalls)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, dialplan.Name, "include", "parkedcalls");
            }
            else
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, dialplan.Name, "parked", "no");
            }
            foreach (int no in dialplan.Rules.Keys)
            {
                CallingRule rule = dialplan.Rules[no];
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, dialplan.Name, "exten", rule.ExtenConfigString);
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, dialplan.Name, "comment", rule.CommentConfigString);
            }

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddDailPlan failed, {0}", response.Message));
            }

            dialplans.Add(dialplan);
            // TODO: notify server dialplan added
        }

        public void ReomveDialPlan(CallingRuleDialPlan dialplan)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, dialplan.Name);
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("ReomveDialPlan failed, {0}", response.Message));
            }

            dialplans.Remove(dialplan);
            // TODO: notify server dialplan added
        }

        public CallingRuleDialPlan FindDailPlan(string name)
        {
            CallingRuleDialPlan plan = null;
            foreach (CallingRuleDialPlan p in dialplans)
            {
                if (p.Name == name)
                {
                    plan = p;
                    break;
                }
            }
            return plan;
        }

        public void AddIncomingCallRule(IncomingCallRule rule)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, rule.Trunk.Context, "exten", rule.GetGotoExtenString());
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddIncomingCallRule failed, {0}", response.Message));
            }
            //incomingCallRules.Add(rule);
            // TODO: notify server rule added
        }

        public IncomingCallRule FindIncomingCallRule(string name)
        {
            IncomingCallRule rule = null;
            foreach (IncomingCallRule r in incomingCallRules)
            {
                if (r.Name == name)
                {
                    rule = r;
                    break;
                }
            }
            return rule;
        }

        public void UpdateIncomingCallRule(IncomingCallRule incomingCallRule)
        {
            if (incomingCallRule.AddingNew || FindIncomingCallRule(incomingCallRule.Name) == null)
            {
                AddIncomingCallRule(incomingCallRule);
                incomingCallRule.AddingNew = false;
                return;
            }
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            foreach (ConfigurationChange c in incomingCallRule.Changes.Values)
            {
                config.AddCommand(c.Action, c.Category, c.Variable, c.Value, c.Match);
            }

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("UpdateIncomingCallRule failed, {0}", response.Message));
            }
            incomingCallRule.PendingChangesCommitted();
        }

        public void RemoveIncomingCallRule(IncomingCallRule rule)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELETE, rule.Trunk.Context, "exten", string.Format("{0},{1},Goto(default|{2}|1)", rule.Pattern, rule.SerialNo.ToString(), rule.Extension));
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveIncomingCallRule failed, {0}", response.Message));
            }
            incomingCallRules.Remove(rule);
            // TODO: notify server rule removed
        }

        public void AddVoiceMenu(VoiceMenu menu)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, menu.Context);
            if (menu.DialOtherAllowed)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, menu.Context, "include", "default");
            }
            foreach (VoiceMenuAction step in menu.Actions.Values)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, menu.Context, "exten", string.Format("s,{0},{1}", step.Priority, step.ToString()));
            }
            foreach (string keyPressed in menu.KeyPressActions.Keys)
            {
                VocieMenuKeyPressEvent action = menu.KeyPressActions[keyPressed];
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, menu.Context, "exten", string.Format("{0},{1},{2}", keyPressed, action.Action.Priority, action.Action.ToString()));
            }
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddVoiceMenu failed, {0}", response.Message));
            }
            voiceMenus.Add(menu);
            // TODO: notify server
        }

        public void UpdateVoiceMenu(VoiceMenu menu)
        {
            // TODO:
        }

        public void RemoveVoiceMenu(VoiceMenu menu)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, menu.Context);
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("RemoveVoiceMenu failed, {0}", response.Message));
            }
            voiceMenus.Remove(menu);
            // TODO: notify server
        }

        public VoiceMenu FindVoiceMenu(string name)
        {
            VoiceMenu menu = null;
            foreach (VoiceMenu m in this.voiceMenus)
            {
                if (m.Name.Equals(name))
                {
                    menu = m;
                    break;
                }
            }
            return menu;
        }

        public void AddRingGroup(RingGroup group)
        {
            // TODO: Check input 
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_NEWCAT, group.Context);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, group.Context, "gui_ring_groupname", group.Name);
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, group.Context, "exten", string.Format("s,1,NoOp(RINGGROUP)"));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < group.Members.Count; i++)
            {
                sb.Append(group.Members[i]);
                if (i < group.Members.Count - 1)
                {
                    sb.Append("&");
                }
            }
            config.AddCommand(UpdateConfigAction.ACTION_APPEND, group.Context, "exten", string.Format("s,n,Dial({0},{1})", sb.ToString(), group.HowLong));
            if (group.Action == NotAnsweredActionOption.GotoIvrMenu)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, group.Context, "exten", string.Format("s,n,Goto({0}|s|1)", group.IvrMenu));
            }
            else if (group.Action == NotAnsweredActionOption.GotoVoicemail)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, group.Context, "exten", string.Format("s,n,Voicemail({0},b)", group.Extension.Extension));
            }
            else if (group.Action == NotAnsweredActionOption.Hangup)
            {
                config.AddCommand(UpdateConfigAction.ACTION_APPEND, group.Context, "exten", "s,n,Hangup");
            }

            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddRingGroup failed, {0}", response.Message));
            }
            //this.ringGroups.Add(group);
            // TODO: notify server
        }

        public void UpdateRingGroup(RingGroup g)
        {
            if (g.AddingNew || FindRingGroup(g.Name) == null)
            {
                AddRingGroup(g);
                g.AddingNew = false;
                return;
            }
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            foreach (ConfigurationChange c in g.Changes.Values)
            {
                config.AddCommand(c.Action, c.Category, c.Variable, c.Value, c.Match);
            }
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("UpdateRingGroup failed, {0}", response.Message));
            }
            g.PendingChangesCommitted();
        }

        public void RemoveRingGroup(RingGroup group)
        {
            UpdateConfigAction config = new UpdateConfigAction("extensions.conf", "extensions.conf");
            config.AddCommand(UpdateConfigAction.ACTION_DELCAT, group.Context);
            ManagerResponse response = server.SendAction(config);
            if (!response.IsSuccess())
            {
                throw new ManagerOperationException(string.Format("AddIncomingCallRule failed, {0}", response.Message));
            }
            //ringGroups.Remove(group);
            // TODO: notify server
        }

        public RingGroup FindRingGroup(string name)
        {
            throw new NotImplementedException();
        }

        public bool IsExtensionExist(string extension)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllExtensions()
        {
            List<string> extens = new List<string>();
            foreach (UserExtension ex in users)
            {
                extens.Add(ex.Extension);
            }
            return extens;
        }

        public void Initialize()
        {
            reset();

            IConfigFileReader reader = createConfigFileReader();
            ConfigFile file;

            #region load users.conf
            Trace.TraceInformation("Loading users.conf");
            reportInitializingProgress(40, "Loading users.conf");

            file = reader.ReadFile("users.conf");
            foreach (string cat in file.Categories.Keys)
            {
                if (cat == "general")
                {
                    generalUser = new UserExtension();
                    generalUser.Category = cat;
                    ConfigurationUtil.LoadConfigToObject(generalUser, file, cat);
                    break;
                }
            }
            foreach (string cat in file.Categories.Keys)
            {
                if (cat == "general")
                {
                    continue;
                }
                else if (cat.StartsWith("trunk_"))
                {
                    int no = int.Parse(cat.Substring(6));
                    Trunk trunk = new Trunk(no);
                    trunk.LoadUserConfig(file, cat);
                    trunks.Add(trunk);
                }
                else
                {
                    UserExtension user = new UserExtension(generalUser);
                    user.Category = cat;
                    ConfigurationUtil.LoadConfigToObject(user, file, cat);
                    users.Add(user);
                }
            }
            #endregion

            #region load meetme.conf
            Trace.TraceInformation("Loading meetme.conf");
            reportInitializingProgress(52, "Loading meetme.conf");

            file = reader.ReadFile("meetme.conf");
            foreach (string cat in file.Categories.Keys)
            {
                if (cat == "rooms")
                {
                    foreach (string r in file.GetValues(cat, "conf"))
                    {
                        ConferenceRoom room = new ConferenceRoom();
                        room.ConfConfigString = r;
                        confRooms.Add(room);
                    }
                }
                // room options loaded when parse extensions.conf 
            }
            #endregion

            #region load queues.conf
            Trace.TraceInformation("Loading queues.conf");
            reportInitializingProgress(55, "Loading queues.conf");

            file = reader.ReadFile("queues.conf");
            foreach (string cat in file.Categories.Keys)
            {
                if (cat != "general")
                {
                    QueueExtension queue = new QueueExtension();
                    queue.Extension = cat;
                    ConfigurationUtil.LoadConfigToObject(queue, file, cat);
                    this.queues.Add(queue);
                }
            }
            #endregion

            #region load extensions.conf
            Trace.TraceInformation("Loading extensions.conf");
            reportInitializingProgress(60, "Loading extensions.conf");

            ExtensionsConfigFileReader extensReader = new ExtensionsConfigFileReader(configFilesDir);
            ExtensionsConfigFile extensFile;
            if (server != null)
            {
                extensFile = extensReader.ReadRemoteExtensionFile("extensions.conf", server);
            }
            else
            {
                extensFile = extensReader.ReadExtensionsFile("extensions.conf");
            }

            foreach (Category cat in extensFile.Contexts)
            {
                if (cat.Name == "general")
                {
                }
                else if (cat.Name == "globals")
                {

                }
                else if (cat.Name == "default")
                {
                    foreach (ConfigElement e in cat.Elements)
                    {
                        if (e is ConfigExtension)
                        {
                            ConfigExtension exten = e as ConfigExtension;
                            if (exten.Application[0] == "MeetMe")
                            {
                                // Load MeetMe options
                                string opts = exten.Application[2];
                                ConferenceRoom room = FindConfRoom(exten.Name);
                                if (room != null)
                                {
                                    room.OptionString = opts;
                                }
                                else
                                {
                                    Trace.TraceError("Parse extensions.conf error, Meetme Room: {0} not found", exten.Name);
                                    //throw new ConfigFileParseErrorException(string.Format("Parse extensions.conf error, Meetme Room: {0} not found", exten.Name));
                                }
                            }
                            else if (exten.Application[0] == "VoiceMailMain")
                            {
                                this.voiceMailSetting.Extension = exten.Name;
                            }
                            else if (exten.Application[0] == "Queue")
                            {

                            }
                            else if (exten.Application[0] == "Goto")
                            {

                            }
                            else
                            {
                                Trace.TraceWarning(string.Format("Unhandled application {0} of [default] in extension.conf", exten.Application[0]));
                            }
                        }
                    }

                }
                else if (cat.Name.StartsWith(Constants.VoiceMenuPrefix))
                {
                    VoiceMenu menu = new VoiceMenu();
                    menu.LoadExtensionsConfig(extensFile, cat);
                    voiceMenus.Add(menu);
                }
                else if (cat.Name.StartsWith(Constants.DIALPLAN_CONTEXT_PREFIX) || cat.Name.StartsWith(Constants.CallingPlanPrefix))
                {
                    //int no = int.Parse(cat.Name.Substring(DIALPLAN_CONTEXT_PREFIX.Length));
                    CallingRuleDialPlan plan = new CallingRuleDialPlan(1);
                    plan.LoadExtensionsConfig(extensFile, cat);
                    dialplans.Add(plan);
                }
                else if (cat.Name.StartsWith(Constants.CallingRulePrefix))
                {
                    CallingRule rule = new CallingRule(1);
                    rule.LoadExtensionsConfig(extensFile, cat);
                    rule.TrunkName = FindTrunkByUserCategory(rule.TrunkContext).Trunkname;
                    callingRules.Add(rule);
                }
                else if (cat.Name.StartsWith(Constants.RINGGOUP_CONTEXT_PREFIX))
                {
                    RingGroup group = new RingGroup();
                    group.LoadExtensionsConfig(extensFile, cat);
                    ringGroups.Add(group);
                }
                else if (cat.Name.StartsWith(Constants.TrunkDIDPrefix))
                {
                    foreach (ConfigElement e in cat.Elements)
                    {
                        if (e is ConfigExtension)
                        {
                            IncomingCallRule rule = new IncomingCallRule();

                            ConfigExtension exten = e as ConfigExtension;
                            rule.Pattern = exten.Name;
                            rule.Extension = exten.Application[2];

                            if (exten.Name == "_X.")
                            {
                                rule.Pattern = IncomingCallRule.AllUnmatchedIncomingCallPattern;
                            }


                            rule.Trunk = FindTrunkByUserCategory(cat.Name.Substring(4, cat.Name.Length - 4));
                            //rule.LoadExtensionsConfig(extensFile, cat);
                            incomingCallRules.Add(rule);
                        }
                    }

                }
                else if (cat.Name.StartsWith("macro-"))
                {
                    // TODO: ADD macros
                }
            }
            #endregion

            #region load Features.conf
            Trace.TraceInformation("Loading features.conf");
            reportInitializingProgress(80, "Loading features.conf");
            file = reader.ReadFile("features.conf");
            foreach (string cat in file.Categories.Keys)
            {
                if (cat == "general")
                {
                    this.callParkSetting.Extension = file.GetValue(cat, "parkext");
                    string parkpos = file.GetValue(cat, "parkpos");
                    string parkingtime = file.GetValue(cat, "parkingtime");
                    if (!string.IsNullOrEmpty(parkpos) && parkpos.IndexOf('-') > 0)
                    {
                        this.callParkSetting.First = parkpos.Substring(0, parkpos.IndexOf('-'));
                        this.callParkSetting.Last = parkpos.Substring(parkpos.IndexOf('-') + 1, parkpos.Length - parkpos.IndexOf('-') - 1);
                    }
                    if (!string.IsNullOrEmpty(parkingtime))
                    {
                        this.callParkSetting.Timeout = int.Parse(parkingtime);
                    }
                }
            }
            #endregion

            #region load voicemail.conf
            Trace.TraceInformation("Loading voicemail.conf");
            reportInitializingProgress(85, "Loading voicemail.conf");

            file = reader.ReadFile("voicemail.conf");
            foreach (string cat in file.Categories.Keys)
            {
                if (cat == "general")
                {
                    ConfigurationUtil.LoadConfigToObject(this.voiceMailSetting, file, cat);
                }
            }
            #endregion

            #region load agents.conf
            Trace.TraceInformation("Loading agents.conf");
            reportInitializingProgress(95, "Loading agents.conf");
            // TODO:
            #endregion

        }

        private IConfigFileReader createConfigFileReader()
        {
            IConfigFileReader reader;
            if (server != null)
            {
                reader = new RemoteConfigFileReader(server);
            }
            else
            {
                reader = new ConfigFileReader(configFilesDir);
            }
            return reader;
        }

        private void reportInitializingProgress(int percent, string text)
        {
            if (server != null)
            {
                server.OnConnectingProgressChanged(new ConnectingProgressEventArg(percent, text));
            }
        }

        public void Disconnected()
        {
            users.Clear();
            confRooms.Clear();
            queues.Clear();
            trunks.Clear();
            dialplans.Clear();
            incomingCallRules.Clear();
            voiceMenus.Clear();
            ringGroups.Clear();
        }

        public void fireConfigChanged()
        {
            // TODO:
        }

        public List<string> GetAllVoiceMenus()
        {
            List<string> menus = new List<string>();
            foreach (VoiceMenu m in voiceMenus)
            {
                menus.Add(m.Name);
            }
            return menus;

        }

        public List<string> GetAllMacros()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllRingGroups()
        {
            List<string> groups = new List<string>();
            foreach (RingGroup g in ringGroups)
            {
                groups.Add(g.Name);
            }
            return groups;
        }

        public List<string> GetAllDialplanNames()
        {
            List<string> plans = new List<string>();
            foreach (CallingRuleDialPlan p in dialplans)
            {
                plans.Add(p.Name);
            }
            return plans;
        }

        public List<string> GetAllDialplanContexts()
        {
            List<string> plans = new List<string>();
            foreach (CallingRuleDialPlan p in dialplans)
            {
                plans.Add(p.Context);
            }
            return plans;
        }


        public CallingRuleDialPlan FindDailPlanByContext(string context)
        {
            CallingRuleDialPlan plan = null;
            foreach (CallingRuleDialPlan p in dialplans)
            {
                if (p.Context == context)
                {
                    plan = p;
                    break;
                }
            }
            return plan;
        }

        #region IAsteriskConfigManager 成员

        private IList<ZapDevice> zapDevices;
        public IList<ZapDevice> GetAllZapDevices(bool refresh)
        {
            if (zapDevices == null || refresh)
            {
                zapDevices = new List<ZapDevice>();
                IConfigFileReader reader = createConfigFileReader();
                ConfigFile file = reader.ReadFile("ztscan.conf");
                if (file != null)
                {
                    foreach (string cat in file.Categories.Keys)
                    {
                        ZapDevice device = new ZapDevice();
                        ConfigurationUtil.LoadConfigToObject(device, file, cat);
                        zapDevices.Add(device);
                    }
                }
            }
            return zapDevices;
        }

        #endregion

    }
}
