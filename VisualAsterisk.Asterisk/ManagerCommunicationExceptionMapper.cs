using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Exception;
using Asterisk.NET.Manager;

namespace VisualAsterisk.Asterisk
{
    class ManagerCommunicationExceptionMapper
    {
        // hide constructor
        private ManagerCommunicationExceptionMapper()
        {

        }

        /**
         * Maps exceptions received From
         * {@link org.asteriskjava.manager.ManagerConnection} when sending a
         * {@link org.asteriskjava.manager.Action.ManagerAction} to the corresponding
         * {@link org.asteriskjava.live.ManagerCommunicationException}.
         * 
         * @param actionName Name of the Action that has been tried to send
         * @param exception exception received
         * @return the corresponding ManagerCommunicationException
         */
        public static ManagerCommunicationException mapSendActionException(string actionName, System.Exception exception)
        {
            /*
        if (exception is IllegalStateException)
        {
            return new ManagerCommunicationException("Not connected to Asterisk Server", exception);
        }
        else 
            */
            if (exception is EventTimeoutException)
            {
                return new ManagerCommunicationException("Timeout waiting for events from " + actionName + "Action", exception);
            }
            else
            {
                return new ManagerCommunicationException("Unable to send " + actionName + "Action", exception);
            }
        }
    }
}
