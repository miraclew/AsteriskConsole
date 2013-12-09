using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Event;

namespace VisualAsterisk.Asterisk
{
    public delegate void NewChannelEventHandler(object sender, AsteriskChannel channel);
    public delegate void ChannelRemovedEventHandler(object sender, AsteriskChannel channel);
    public delegate void NewMeetMeUserEventHandler(object sender, MeetMeUser user);
    public delegate void MeetMeUserRemovedEventHandler(object sender, MeetMeUser user);
    public delegate void NewAgentEventHandler(object sender, AsteriskAgent agent);
    public delegate void AgentRemovedEventHandler(object sender, AsteriskAgent agent);
    public delegate void NewQueueEntryEventHandler(object sender, AsteriskQueueEntry entry);
    public delegate void QueueEntryRemovedEventHandler(object sender, AsteriskQueueEntry entry);
    public delegate void NewParkedCallEventHandler(object sender, ParkedCall entry);
    public delegate void ParkedCallRemovedEventHandler(object sender, ParkedCall entry);
    public delegate void TrunkEventHandler(object sender, RegistryEvent registryEvent);

    public interface INotifyAsteriskServerChanged
    {
        /// <summary>
        /// Called whenever a new Channel appears on the Asterisk server.
        /// </summary>
        event NewChannelEventHandler NewAsteriskChannel;
        event ChannelRemovedEventHandler AsteriskChannelRemoved;
        /// <summary>
        /// Called whenever a User joins a {@link MeetMeRoom}.
        /// </summary>
        event NewMeetMeUserEventHandler NewMeetMeUser;
        event MeetMeUserRemovedEventHandler MeetMeUserRemoved;
        /// <summary>
        /// Called whenever a new agent will be registered at Asterisk server.
        /// </summary>
        event NewAgentEventHandler NewAgent;
        event AgentRemovedEventHandler AgentRemoved;
        /// <summary>
        /// Called whenever a queue entry ( ~ wapper over Channel) joins a {@link AstriskQueue}.
        /// </summary>
        event NewQueueEntryEventHandler NewQueueEntry;
        event QueueEntryRemovedEventHandler QueueEntryRemoved;

        event NewParkedCallEventHandler NewParkedCall;
        event ParkedCallRemovedEventHandler ParkedCallRemoved;

        event TrunkEventHandler TrunkStateChanged;
    }
}
