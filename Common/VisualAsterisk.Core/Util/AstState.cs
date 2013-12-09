using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace VisualAsterisk.Core.Util
{
    /// <summary>
    /// Utility methods related to channel State handling in Asterisk's <code>channel.c</code>.
    /// </summary>
    public class AstState
    {
        /* from include/asterisk/channel.h */

        /**
         * Channel is down and available.
         */
        public const int AST_STATE_DOWN = 0;

        /**
         * Channel is down, but reserved.
         */
        public const int AST_STATE_RSRVD = 1;

        /**
         * Channel is off hook.
         */
        public const int AST_STATE_OFFHOOK = 2;

        /**
         * Digits (or equivalent) have been dialed.
         */
        public const int AST_STATE_DIALING = 3;

        /**
         * Line is ringing.
         */
        public const int AST_STATE_RING = 4;

        /**
         * Remote end is ringing.
         */
        public const int AST_STATE_RINGING = 5;

        /**
         * Line is up.
         */
        public const int AST_STATE_UP = 6;

        /**
         * Line is busy.
         */
        public const int AST_STATE_BUSY = 7;

        /**
         * Digits (or equivalent) have been dialed while offhook.
         */
        public const int AST_STATE_DIALING_OFFHOOK = 8;

        /**
         * Channel has detected an incoming call and is waiting for ring.
         */
        public const int AST_STATE_PRERING = 9;

        private static readonly Dictionary<string, int> inverseStateMap;

        static AstState()
        {
            Dictionary<string, int> tmpInverseStateMap = new Dictionary<string, int>();

            tmpInverseStateMap.Add("Down", AST_STATE_DOWN);
            tmpInverseStateMap.Add("Rsrvd", AST_STATE_RSRVD);
            tmpInverseStateMap.Add("OffHook", AST_STATE_OFFHOOK);
            tmpInverseStateMap.Add("Dialing", AST_STATE_DIALING);
            tmpInverseStateMap.Add("Ring", AST_STATE_RING);
            tmpInverseStateMap.Add("Ringing", AST_STATE_RINGING);
            tmpInverseStateMap.Add("Up", AST_STATE_UP);
            tmpInverseStateMap.Add("Busy", AST_STATE_BUSY);
            tmpInverseStateMap.Add("Dialing Offhook", AST_STATE_DIALING_OFFHOOK);
            tmpInverseStateMap.Add("Pre-ring", AST_STATE_PRERING);

            inverseStateMap = tmpInverseStateMap;
        }

        private readonly Regex UNKNOWN_STATE_PATTERN = new Regex("^Unknown \\((\\d+)\\)$");

        private AstState()
        {

        }

        /**
         * This is the inverse to <code>ast_state2str</code> in <code>channel.c</code>.
         *
         * @param str State as a descriptive text.
         * @return numeric State.
         */
        public static int Str2state(string str)
        {
            int state;

            if (str == null)
            {
                throw new ArgumentNullException(string.Format("state string is null"), "str");
            }

            //State = inverseStateMap.get(str);

            //if (State == null)
            //{
            //    Matcher matcher = UNKNOWN_STATE_PATTERN.matcher(str);
            //    if (matcher.matches())
            //    {
            //        try
            //        {
            //            State = int.valueOf(matcher.group(1));
            //        }
            //        catch (NumberFormatException e)
            //        {
            //            // should not happen as the pattern requires \d+ for the State.
            //            throw new IllegalArgumentException("Unable to convert State '" + str + "' to integer representation", e);
            //        }
            //    }
            //}
            if (inverseStateMap.ContainsKey(str))
            {
                state = inverseStateMap[str];
            }
            else
                throw new ArgumentException(string.Format("state string {0} is illegal", str), "str");

            return state;
        }
    }
}
