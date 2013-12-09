using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Util
{
    /// <summary>
    /// Some static utility methods to imitate Asterisk specific logic.
    /// </summary>
    public class AstUtil
    {
        private static readonly IList<string> TRUE_LITERALS;
        private static readonly IList<string> NULL_LITERALS;

        static AstUtil()
        {
            TRUE_LITERALS = new List<string>(20);
            TRUE_LITERALS.Add("yes");
            TRUE_LITERALS.Add("true");
            TRUE_LITERALS.Add("y");
            TRUE_LITERALS.Add("t");
            TRUE_LITERALS.Add("1");
            TRUE_LITERALS.Add("on");
            TRUE_LITERALS.Add("enabled");

            NULL_LITERALS = new List<string>(20);
            NULL_LITERALS.Add("<unknown>");
            NULL_LITERALS.Add("unknown");
            NULL_LITERALS.Add("none"); // VarSet event in pbx.c
            NULL_LITERALS.Add("<none>");
            NULL_LITERALS.Add("-none-");
            NULL_LITERALS.Add("(none)");
            NULL_LITERALS.Add("<not set>");
            NULL_LITERALS.Add("(not set)");
            NULL_LITERALS.Add("<no name>");
            NULL_LITERALS.Add("n/a"); // channel in AgentsEvent
            NULL_LITERALS.Add("<null>");
            NULL_LITERALS.Add("(null)"); // appData in ListDialplanEvent
        }

        private AstUtil()
        {
            //hide constructor
        }

        /**
         * Checks if a string represents <code>true</code> or <code>false</code>
         * according to Asterisk's logic.
         * <p>
         * The original implementation is <code>util.c</code> is as follows:
         * 
         * <pre>
         *     int ast_true(const char *s)
         *     {
         *         if (!s || ast_strlen_zero(s))
         *             return 0;
         *      
         *         if (!strcasecmp(s, &quot;yes&quot;) ||
         *             !strcasecmp(s, &quot;true&quot;) ||
         *             !strcasecmp(s, &quot;y&quot;) ||
         *             !strcasecmp(s, &quot;t&quot;) ||
         *             !strcasecmp(s, &quot;1&quot;) ||
         *             !strcasecmp(s, &quot;on&quot;))
         *             return -1;
         *     
         *         return 0;
         *     }
         * </pre>
         * 
         * To support the dnd property of
         * {@link org.asteriskjava.manager.event.ZapShowChannelsEvent} this method
         * also consideres the string "Enabled" as true.
         * 
         * @param o the Object (usually a string) to check for <code>true</code>.
         * @return <code>true</code> if s represents <code>true</code>,
         *         <code>false</code> otherwise.
         */
        public static bool isTrue(object o)
        {
            if (o == null)
            {
                return false;
            }

            if (o is bool)
            {
                return (bool)o;
            }

            string s;
            if (o is string)
            {
                s = (string)o;
            }
            else
            {
                s = o.ToString();
            }
            // TODO: culture ignored
            return TRUE_LITERALS.Contains(s.ToLower());
        }

        /**
         * Parses a string for caller id information.
         * <p>
         * The caller id string should be in the form <code>"Some Name" &lt;1234&gt;</code>.
         * <p>
         * This resembles <code>ast_callerid_parse</code> in
         * <code>callerid.c</code> but strips any whitespace.
         * 
         * @param s the string to parse
         * @return a String[] with name (index 0) and number (index 1)
         */
        public static string[] parseCallerId(string s)
        {
            string[] result = new string[2];
            int lbPosition;
            int rbPosition;
            string name;
            string number;

            if (s == null)
            {
                return result;
            }

            lbPosition = s.LastIndexOf('<');
            rbPosition = s.LastIndexOf('>');

            // no opening and closing brace? use value as CallerId name
            if (lbPosition < 0 || rbPosition < 0)
            {
                name = s.Trim();
                if (name.Length == 0)
                {
                    name = null;
                }
                result[0] = name;
                return result;
            }
            else
            {
                number = s.Substring(lbPosition + 1, rbPosition).Trim();
                if (number.Length == 0)
                {
                    number = null;
                }
            }

            name = s.Substring(0, lbPosition).Trim();
            if (name.StartsWith("\"") && name.EndsWith("\"") && name.Length > 1)
            {
                name = name.Substring(1, name.Length - 1).Trim();
            }
            if (name.Length == 0)
            {
                name = null;
            }

            result[0] = name;
            result[1] = number;
            return result;
        }

        /**
         * Checks if the value of s was <code>null</code> in Asterisk.
         * <p>
         * This method is useful as Asterisk likes to replace <code>null</code>
         * values with different string values like "unknown", "&lt;unknown&gt;"
         * or "&lt;null&gt;".
         * <p>
         * To find such replacements search for <code>S_OR</code> in Asterisk's
         * source code. You will find things like
         * <pre>
         * S_OR(chan-&gt;cid.cid_num, "&lt;unknown&gt;")
         * fdprintf(fd, "agi_callerid: %s\n", S_OR(chan-&gt;cid.cid_num, "unknown"));
         * </pre>
         * and more...
         * 
         * @param s the string to test, may be <code>null</code>.
         * @return <code>true</code> if the s was <code>null</code> in Asterisk;
         *         <code>false</code> otherwise. 
         */
        public static bool isNull(string s)
        {
            if (s == null)
            {
                return true;
            }

            // TODO: culture ignored
            return NULL_LITERALS.Contains(s.ToLower());
        }

    }
}
