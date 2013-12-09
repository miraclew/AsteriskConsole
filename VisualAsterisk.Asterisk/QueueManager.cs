using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager;
using VisualAsterisk.Asterisk.Exception;
using Asterisk.NET.Manager.Event;
using Asterisk.NET.Manager.Action;
using System.Diagnostics;
using VisualAsterisk.Core.Util;

namespace VisualAsterisk.Asterisk
{
    public class QueueManager : IAsteriskServerComponent
    {
        private DefaultAsteriskServer server;
        private ChannelManager channelManager;

        /**
         * A map of ACD Queues by there Name.
         */
        private IDictionary<string, AsteriskQueue> queues;

        public QueueManager(DefaultAsteriskServer server, ChannelManager channelManager)
        {
            this.server = server;
            this.channelManager = channelManager;
            this.queues = new Dictionary<string, AsteriskQueue>();
        }

        public void Initialize()
        {
            ResponseEvents re;
            Disconnected();
            try
            {
                re = server.sendEventGeneratingAction(new QueueStatusAction());
            }
            catch (ManagerCommunicationException e)
            {
                System.Exception cause = e.InnerException;

                if (cause is EventTimeoutException)
                {
                    // this happens with Asterisk 1.0.x as it doesn't send a
                    // QueueStatusCompleteEvent
                    re = ((EventTimeoutException)cause).PartialResult;
                }
                else
                {
                    throw e;
                }
            }

            foreach (ManagerEvent e in re.Events)
            {
                if (e is QueueParamsEvent)
                {
                    handleQueueParamsEvent((QueueParamsEvent)e);
                }
                else if (e is QueueMemberEvent)
                {
                    handleQueueMemberEvent((QueueMemberEvent)e);
                }
                else if (e is QueueEntryEvent)
                {
                    handleQueueEntryEvent((QueueEntryEvent)e);
                }
            }
        }

        public void Disconnected()
        {
            lock (queues)
            {
                foreach (AsteriskQueue queue in queues.Values)
                {
                    queue.cancelServiceLevelTimer();
                }
                queues.Clear();
            }
        }

        /**
         * Gets (a copy of) the list of the Queues.
         *
         * @return a copy of the list of the Queues.
         */
        internal IList<AsteriskQueue> getQueues()
        {
            IList<AsteriskQueue> copy;

            lock (queues)
            {
                copy = new List<AsteriskQueue>(queues.Values);
            }
            return copy;
        }

        /**
         * Adds a queue to the internal map, keyed by Name.
         *
         * @param queue the AsteriskQueue to be added
         */
        private void addQueue(AsteriskQueue queue)
        {
            lock (queues)
            {
                queues[queue.Name] = queue;
            }
        }

        /**
         * Called during initialization to populate the list of Queues.
         *
         * @param e the e received
         */
        internal void handleQueueParamsEvent(QueueParamsEvent e)
        {
            AsteriskQueue queue;
            string name;
            int max;
            string strategy;
            int serviceLevel;
            int weight;

            name = e.Queue;
            max = e.Max;
            strategy = e.Strategy;
            serviceLevel = e.ServiceLevel;
            weight = e.Weight;

            if (name == null)
            {
                // ignore the event without queue Name
                return;
            }

            if (!queues.ContainsKey(name))
            {
                queue = new AsteriskQueue(server, name, max, strategy, serviceLevel, weight);
                Trace.TraceInformation("Adding new queue " + queue);
                addQueue(queue);
            }
            else
            {
                queue = queues[name];

                // We should never reach that code as this method is only called for initialization
                // So the queue should never be in the Queues list
                lock (queue)
                {
                    queue.Max = max;
                    queue.ServiceLevel = serviceLevel;
                    queue.Weight = weight;
                }
            }
        }

        /**
         * Called during initialization to populate the Members of the Queues.
         * 
         * @param e the QueueMemberEvent received
         */
        internal void handleQueueMemberEvent(QueueMemberEvent e)
        {
            AsteriskQueue queue = queues[e.Queue];
            if (queue == null)
            {
                Trace.TraceError("Ignored QueueEntryEvent for unknown queue " + e.Queue);
                return;
            }

            AsteriskQueueMember member = queue.getMemberByLocation(e.Location);
            if (member == null)
            {
                member = new AsteriskQueueMember(server, queue, e.Location,
                        (QueueMemberState)Enum.ToObject(typeof(QueueMemberState), e.Status), e.Paused,
                        e.Penalty, e.Membership);
                member.CallsTaken = e.CallsTaken;
                if (e.LastCall > 0)
                {
                    member.LastCall = DateTime2UnixTime.ConvertIntDateTime(e.LastCall);
                    
                } 
                member.MemberName = e.MemberName;
                member.Name = e.Name;
            }
            queue.addMember(member);
        }

        /**
         * Called during initialization to populate entries of the Queues.
         * Currently does the same as handleJoinEvent()
         *
         * @param e - the QueueEntryEvent received
         */
        internal void handleQueueEntryEvent(QueueEntryEvent e)
        {
            AsteriskQueue queue = getQueueByName(e.Queue);
            AsteriskChannel channel = channelManager
                    .getChannelByName(e.Channel);

            if (queue == null)
            {
                Trace.TraceError("Ignored QueueEntryEvent for unknown queue " + e.Queue);
                return;
            }
            if (channel == null)
            {
                Trace.TraceError("Ignored QueueEntryEvent for unknown channel " + e.Channel);
                return;
            }

            if (queue.getEntry(e.Channel) != null)
            {
                Trace.TraceError("Ignored duplicate queue entry during population in queue "
                        + e.Queue + " for channel " + e.Channel);
                return;
            }

            // Asterisk gives us an initial Position but doesn't tell us when he shifts the others
            // We won't use this data for ordering until there is a appropriate e in AMI.
            // (and refreshing the whole queue is too intensive and suffers incoherencies
            // due to asynchronous shift that leaves holes if requested too fast)
            int reportedPosition = e.Position;

            queue.createNewEntry(channel, reportedPosition, e.DateReceived);
        }

        /**
         * Called From DefaultAsteriskServer whenever a new entry appears in a queue.
         *
         * @param e the JoinEvent received
         */
        internal void handleJoinEvent(JoinEvent e)
        {
            AsteriskQueue queue = getQueueByName(e.Queue);
            AsteriskChannel channel = channelManager.getChannelByName(e.Channel);

            if (queue == null)
            {
                Trace.TraceError("Ignored JoinEvent for unknown queue " + e.Queue);
                return;
            }
            if (channel == null)
            {
                Trace.TraceError("Ignored JoinEvent for unknown channel " + e.Channel);
                return;
            }

            if (queue.getEntry(e.Channel) != null)
            {
                Trace.TraceError("Ignored duplicate queue entry in queue "
                        + e.Queue + " for channel " + e.Channel);
                return;
            }

            // Asterisk gives us an initial Position but doesn't tell us when he shifts the others
            // We won't use this data for ordering until there is a appropriate e in AMI.
            // (and refreshing the whole queue is too intensive and suffers incoherencies
            // due to asynchronous shift that leaves holes if requested too fast)
            int reportedPosition = e.Position;

            queue.createNewEntry(channel, reportedPosition, e.DateReceived);
        }

        /**
         * Called From DefaultAsteriskServer whenever an enty leaves a queue.
         *
         * @param e - the LeaveEvent received
         */
        internal void handleLeaveEvent(LeaveEvent e)
        {
            AsteriskQueue queue = getQueueByName(e.Queue);
            AsteriskChannel channel = channelManager.getChannelByName(e.Channel);

            if (queue == null)
            {
                Trace.TraceError("Ignored LeaveEvent for unknown queue " + e.Queue);
                return;
            }
            if (channel == null)
            {
                Trace.TraceError("Ignored LeaveEvent for unknown channel " + e.Channel);
                return;
            }

            AsteriskQueueEntry existingQueueEntry = queue.getEntry(e.Channel);
            if (existingQueueEntry == null)
            {
                Trace.TraceError("Ignored leave e for non existing queue entry in queue "
                        + e.Queue + " for channel " + e.Channel);
                return;
            }

            queue.removeEntry(existingQueueEntry, e.DateReceived);
        }

        /**
         * Challange a QueueMemberStatusEvent.
         * Called From DefaultAsteriskServer whenever a member State Changes.
         *
         * @param e that was triggered by Asterisk server.
         */
        internal void handleQueueMemberStatusEvent(QueueMemberStatusEvent e)
        {
            AsteriskQueue queue = getQueueByName(e.Queue);

            if (queue == null)
            {
                Trace.TraceError("Ignored QueueMemberStatusEvent for unknown queue " + e.Queue);
                return;
            }

            AsteriskQueueMember member = queue.getMemberByLocation(e.Location);
            if (member == null)
            {
                Trace.TraceError("Ignored QueueMemberStatusEvent for unknown member " + e.Location);
                return;
            }

            member.CallsTaken = e.CallsTaken;
            if (e.LastCall > 0)
            {
                member.LastCall = DateTime2UnixTime.ConvertIntDateTime(e.LastCall);

            }
            member.MemberName = e.MemberName;
            member.Name = e.Name;

            member.stateChanged((QueueMemberState)Enum.ToObject(typeof(QueueMemberState), e.Status));
            member.penaltyChanged(e.Penalty);
            queue.fireMemberStateChanged(member);
        }

        internal void handleQueueMemberPausedEvent(QueueMemberPausedEvent e)
        {
            AsteriskQueue queue = getQueueByName(e.Queue);

            if (queue == null)
            {
                Trace.TraceError("Ignored QueueMemberPausedEvent for unknown queue " + e.Queue);
                return;
            }

            AsteriskQueueMember member = queue.getMemberByLocation(e.Location);
            if (member == null)
            {
                Trace.TraceError("Ignored QueueMemberPausedEvent for unknown member " + e.Location);
                return;
            }

            member.pausedChanged(e.Paused);
        }

        internal void handleQueueMemberPenaltyEvent(QueueMemberPenaltyEvent e)
        {
            AsteriskQueue queue = getQueueByName(e.Queue);

            if (queue == null)
            {
                Trace.TraceError("Ignored QueueMemberStatusEvent for unknown queue " + e.Queue);
                return;
            }

            AsteriskQueueMember member = queue.getMemberByLocation(e.Location);
            if (member == null)
            {
                Trace.TraceError("Ignored QueueMemberStatusEvent for unknown member " + e.Location);
                return;
            }

            member.penaltyChanged(e.Penalty);
        }

        /**
         * Retrieves a queue by its Name.
         *
         * @param queueName Name of the queue.
         * @return the requested queue or <code>null</code> if there is no queue with the given Name.
         */
        private AsteriskQueue getQueueByName(string queueName)
        {
            AsteriskQueue queue;

            lock (queues)
            {
                queue = queues[queueName];
            }
            if (queue == null)
            {
                Trace.TraceError("Requested queue '" + queueName + "' not found!");
            }
            return queue;
        }

        /**
         * Challange a QueueMemberAddedEvent.
         *
         * @param e - the generated QueueMemberAddedEvent.
         */
        internal void handleQueueMemberAddedEvent(QueueMemberAddedEvent e)
        {
            AsteriskQueue queue = queues[e.Queue];
            if (queue == null)
            {
                Trace.TraceError("Ignored QueueMemberAddedEvent for unknown queue " + e.Queue);
                return;
            }

            AsteriskQueueMember member = queue.getMemberByLocation(e.Location);
            if (member == null)
            {
                member = new AsteriskQueueMember(server, queue, e.Location,
                        (QueueMemberState)Enum.ToObject(typeof(QueueMemberState), e.Status), e.Paused,
                        e.Penalty, e.Membership);
            }

            queue.addMember(member);
        }

        /**
         * Challange a QueueMemberRemovedEvent.
         *
         * @param e - the generated QueueMemberRemovedEvent.
         */
        internal void handleQueueMemberRemovedEvent(QueueMemberRemovedEvent e)
        {
            AsteriskQueue queue = queues[e.Queue];
            if (queue == null)
            {
                Trace.TraceError("Ignored QueueMemberRemovedEvent for unknown queue " + e.Queue);
                return;
            }

            AsteriskQueueMember member = queue.getMemberByLocation(e.Location);
            if (member == null)
            {
                Trace.TraceError("Ignored QueueMemberRemovedEvent for unknown agent name: "
                        + e.MemberName + " location: " + e.Location
                        + " queue: " + e.Queue);
                return;
            }

            queue.removeMember(member);
        }
    }
}
