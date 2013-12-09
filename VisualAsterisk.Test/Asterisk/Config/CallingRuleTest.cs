using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config.Configuration;
using NUnit.Framework;

namespace VisualAsterisk.Test.Asterisk.Config
{
    [TestFixture]
    public class CallingRuleTest
    {
        [Test]
        public void TestSetExtenConfigString()
        {
            //[CallingRule_callingrule1]
            //exten = 9XXXXXXX,1,Macro(trunkdial-failover-0.3,${trunk_1}/${EXTEN:1},,trunk_1,trunk_1)
            //exten = _9XXXX!,1,Macro(trunkdial,${trunk_1}/+2${EXTEN:1},${trunk_1_cid})

            string exten = "9XXXXXXX,1,Macro(trunkdial-failover-0.3,${trunk_1}/${EXTEN:1},,trunk_1,trunk_1)";
            CallingRule rule = new CallingRule(1);
            rule.ExtenConfigString = exten;
        }
    }
}
