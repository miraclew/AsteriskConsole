using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Dialplan.Variables
{
    class AsteriskVariables
    {
        // Global variables 
        // Shared variables 
        // Channel variables 

        /// <summary>
        /// Predefined Variables 
        /// </summary>
        enum PredefinedChannelVariables
        {
            ANSWEREDTIME, // This is the amount of time(in seconds) for actual call. 
            BLINDTRANSFER, // The Active SIP Channel that dialed the Number. This will return the SIP Channel that dialed the Number when doing blind transfers - see BLINDTRANSFER 
            // TODO CALLERID(all),
            CALLINGPRES, // PRI Call ID Presentation Variable for incoming calls (See callingpres ) 
            CHANNEL, // Current Channel Name
            CONTEXT, // The Name of the current Context 
            DATETIME, //  Current date time in the format: DDMMYYYY-HH:MM:SS This is deprecated in Asterisk 1.2, instead use :${STRFTIME(${EPOCH},,%d%mNaVH:NaVS)}) 
            DIALEDPEERNAME, // Name of the called party. Broken for now, see DIALEDPEERNAME 
            DIALEDPEERNUMBER, // Number of the called party. Broken for now, see DIALEDPEERNUMBER 
            DIALEDTIME,// Time since the Number was dialed (only works when dialed party answers the line?!) 
            DIALSTATUS, // Status of the call. See DIALSTATUS (note: In the current SVN release, DIALSTATUS seems to have been removed. Now you should use the DEVSTATE function. Try in astersisk console "core show function DEVSTATE" for More informations) 
            DNID, // Dialed Number Identifier. Limitations apply, see DNID 
            EPOCH, // The current UNIX-style epoch (Number of seconds since 1 Jan 1970) 
            EXTEN, // The current Extension1 
            HANGUPCAUSE, // The Last hangup return code on a Zap Channel connected to a PRI interface 
            INVALID_EXTEN, // The Extension1 asked for when redirected to the i (invalid) Extension1 
            LANGUAGE, // The current language setting. See Asterisk multi-language
            MEETMESECS, // Number of seconds a User participated in a MeetMe conference 
            PRIORITY, // The current Priority 
            RDNIS, // The current redirecting DNIS, Caller ID that redirected the call. Limitations apply, see RDNIS 
            SIPDOMAIN, // SIP destination domain of an inbound call (if appropriate) 
            SIP_CODEC, // Used to set the SIP Codec for a call (apparently broken in Ver 1.0.1, ok in Ver. 1.0.3 & 1.0.4, not sure about 1.0.2) 
            SIPCALLID, // The SIP dialog Call-ID: header 
            SIPUSERAGENT, // The SIP User agent header 
            TIMESTAMP, // Current date time in the format: YYYYMMDD-HHMMSS This is deprecated as of Asterisk 1.4, instead use :${STRFTIME(${EPOCH},,%Y%m%d-%H%M%S)}) 
            TRANSFERCAPABILITY, // Type of Channel 
            TXTCIDNAME, // Result of Application TXTCIDName (see below) 
            UNIQUEID, // Current call unique identifier 
            TOUCH_MONITOR, // used for "one touch record" (see Features.conf, and wW dial Flags). If is set on either side of the call then that var contains the app_args for app_monitor otherwise the default of WAV||m is used 
        }

        enum ApplicationSpecificVariables
        {
            CALLERID,// AgentCallbackLogin returns ${AGENTBYCALLERID_${CALLERID}}: The ID of the agent successfully logged on. 
            AVAILCHAN, // ChanIsAvail returns ${AVAILCHAN}: The First available Channel 
            VXML_URL, // Dial takes input From ${VXML_URL}: Send XML Url to Cisco 7960 or to i6net VoiceXML browser 
            ALERT_INFO, // Dial takes input From ${ALERT_INFO}: Set ring cadence or Allow intercom on for various SIP phones 
            CAUSECODE, // Dial returns ${CAUSECODE}: If the dial failed, this is the errormessage 
            DIALSTATUS, // Dial returns ${DIALSTATUS}: Text code returning status of Last dial attempt. 
            TRANSFER_CONTEXT, // Dial takes input From ${TRANSFER_CONTEXT}: If this Variable exists, when a #transfer is executed it goes to the selected Extension1 on this Context. 
            ENUM, // EnumLookup returns ${ENUM}: The result of the lookup 
            PRI_CAUSE, // Hangup reads the ${PRI_CAUSE} Variable for setting PRI return codes 
            MEETME_AGI_BACKGROUND, // MeetMe takes input From {MEETME_AGI_BACKGROUND}: An AGI script to run 
            MEETMESECS, // MeetMe returns ${MEETMESECS}: The Number of seconds the User was in a conference 
            PLAYBACKSTATUS, // Playback returns ${PLAYBACKSTATUS}: The status of the command (FAILED|SUCCESS) 
            QUEUESTATUS, // Queue returns ${QUEUESTATUS}: The reason for popping the call out of the queue 
            TXTCIDNAME, // TXTCIDName returns ${TXTCIDNAME}: The result of the DNS lookup 
            VMSTATUS // VoiceMail returns ${VMSTATUS}: indicates the status of the execution of the VoiceMail Application. Possible values are: SUCCESS | USEREXIT | FAILED . 
        }
        // Macro-specific variables 
        enum MacroSpecificVariables
        {
            ARG1, // The First argument passed to the macro 
            ARG2, //The second argument passed to the macro (and so on) 
            MACRO_CONTEXT, // The Context of the Extension1 that triggered this macro 
            MACRO_EXTEN, // The Extension1 that triggered this macro 
            MACRO_OFFSET, // Set by a macro to influence the Priority where execution will continue after exiting the macro 
            MACRO_PRIORITY // The Priority in the Extension1 where this macro was triggered 

        }

        // Environment variables 

    }
}
