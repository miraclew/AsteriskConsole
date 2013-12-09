using System;
using VisualAsterisk.Asterisk.Config.Configuration;
using System.Collections.Generic;
namespace VisualAsterisk.Asterisk.Config
{
    public interface IAsteriskConfigManager
    {
        void AddConfRoom(ConferenceRoom room);
        void AddDailPlan(CallingRuleDialPlan dialplan);
        void AddIncomingCallRule(IncomingCallRule rule);
        void AddQueue(QueueExtension queue);
        void AddRingGroup(RingGroup group);
        void AddTrunk(Trunk trunk);
        void AddUser(UserExtension user);
        void AddVoiceMenu(VoiceMenu menu);
        CallParkSetting CallParkSetting { get; }
        System.ComponentModel.BindingList<ConferenceRoom> ConferenceRooms { get; }
        IList<CallingRuleDialPlan> Dialplans { get; }
        void Disconnected();
        ConferenceRoom FindConfRoom(string roomNumber);
        CallingRuleDialPlan FindDailPlan(string name);
        CallingRuleDialPlan FindDailPlanByContext(string context);
        IncomingCallRule FindIncomingCallRule(string name);
        QueueExtension FindQueue(string extension);
        RingGroup FindRingGroup(string name);
        Trunk FindTrunkByName(string name);
        Trunk FindTrunkByUserCategory(string category);
        UserExtension FindUser(string extension);
        VoiceMenu FindVoiceMenu(string name);
        void fireConfigChanged();
        UserExtension GeneralUser { get; }
        List<string> GetAllDialplanContexts();
        List<string> GetAllDialplanNames();
        List<string> GetAllExtensions();
        List<string> GetAllRingGroups();
        List<string> GetAllVoiceMenus();
        List<string> GetAllMacros();
        IList<ZapDevice> GetAllZapDevices(bool rescan);
        IList<IncomingCallRule> IncomingCallRules { get; }
        IList<CallingRule> CallingRules { get; }
        void Initialize();
        bool IsExtensionExist(string extension);
        Options Options { get; }
        System.ComponentModel.BindingList<QueueExtension> Queues { get; }
        void RemoveConfRoom(ConferenceRoom room);
        void RemoveIncomingCallRule(IncomingCallRule rule);
        void RemoveQueue(QueueExtension queue);
        void RemoveRingGroup(RingGroup group);
        void RemoveTrunk(Trunk trunk);
        void RemoveUser(UserExtension user);
        void RemoveVoiceMenu(VoiceMenu menu);
        void ReomveDialPlan(CallingRuleDialPlan dialplan);
        System.ComponentModel.BindingList<RingGroup> RingGroups { get; }
        System.ComponentModel.BindingList<Trunk> Trunks { get; }
        void UpdateConfRoom(ConferenceRoom room);
        void UpdateIncomingCallRule(IncomingCallRule incomingCallRule);
        void UpdateQueue(QueueExtension queue);
        void UpdateRingGroup(RingGroup g);
        void UpdateTrunk(Trunk trunk);
        void UpdateUser(UserExtension user);
        void UpdateVoiceMenu(VoiceMenu menu);
        void SubmitConfigFileChanges(Dictionary<string, List<ConfigurationChange>> changes);
        System.ComponentModel.BindingList<UserExtension> Users { get; }
        VoiceMailSetting VoiceMailSetting { get; }
        System.ComponentModel.BindingList<VoiceMenu> VoiceMenus { get; }

        void AddCallingRule(CallingRule rule);

        void RemoveCallingRule(CallingRule rule);
    }
}
