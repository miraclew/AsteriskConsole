using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Exception;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// OriginateCallback EventHandler
    /// </summary>
    /// <param Name="sender">source of the event</param>
    /// <param Name="Channel">the Channel created.</param>
    public delegate void OriginateCallbackEventHandler(object sender, AsteriskChannel channel);

    public delegate void OriginateCallbackFailureEventHandler(object sender, AsteriskException cause);

    /// <summary>
    /// Callback interface for asynchronous originates.
    /// </summary>
    public interface IOriginateCallback
    {
        /// <summary>
        /// Called when the Channel has been created and before it starts ringing.
        /// </summary>
        event OriginateCallbackEventHandler Dialing;
        /// <summary>
        /// Called if the originate was successful and the called party answered the call.
        /// </summary>
        event OriginateCallbackEventHandler Success;
        /// <summary>
        /// Called if the originate was unsuccessful because the called party did not answer the call.
        /// </summary>
        event OriginateCallbackEventHandler NoAnswer;
        /// <summary>
        /// Called if the originate was unsuccessful because the called party was busy.
        /// </summary>
        event OriginateCallbackEventHandler Busy;
        /// <summary>
        /// Called if the originate failed for example due to an invalid Channel Name
        /// or an originate to an unregistered SIP or IAX Peer.
        /// </summary>
        event OriginateCallbackEventHandler Failure;

        void fireDialing(object sender, AsteriskChannel channel);
        void fireSuccess(object sender, AsteriskChannel channel);
        void fireNoAnswer(object sender, AsteriskChannel channel);
        void fireBusy(object sender, AsteriskChannel channel);
        void fireFailure(object sender, AsteriskException cause);
    }
}
