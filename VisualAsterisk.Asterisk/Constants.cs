using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Defines constants used internally in the live package in multiple classes.
    /// </summary>
    class Constants
    {
        // hide constructor
        private Constants()
        {

        }
        #region contexts
        public const string DIALPLAN_CONTEXT_PREFIX = "numberplan-custom-"; // old
        public const string CallingPlanPrefix = "DLPN_"; // new
        public const string TrunkDIDPrefix = "DID_trunk_";
        public const string TrunkDefaultSuffix = "_default";
        public const string RINGGOUP_CONTEXT_PREFIX = "ringroups-custom-";
        public const string VoiceMenuPrefix = "voicemenu-custom-";
        public const string TimeBasedRulePrefix = "timebasedrule-custom-";
        public const string TimeIntervalPrefix = "timeinterval_";
        public const string CallingRulePrefix = "CallingRule_";
        #endregion
        public const string VARIABLE_TRACE_ID = "VA_TRACE_ID";
    }
}
