using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    [StepAttribute]
    public class Macro : VoiceMenuAction
    {
        public Macro(string macroToRun)
        {
            this.macroToRun = macroToRun;
            this.applicationString = new string[] { "Macro", macroToRun };
        }

        private string macroToRun;

        public override string DisplayText
        {
            get
            {
                return "Run Macro " + macroToRun;
            }
        }

        public override string HelpText
        {
            get
            {
                return "macroname|arg1|arg2 .... Executes a macro using the context 'macro-<macroname>'";
            }
        }
    }
}
