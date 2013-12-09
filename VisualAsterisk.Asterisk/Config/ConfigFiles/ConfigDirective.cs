using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public abstract class ConfigDirective : ConfigElement
    {
        protected ConfigDirective()
        {
        }

        protected ConfigDirective(string filename, int lineno)
            : base(filename, lineno)
        {
        }
    }
}
