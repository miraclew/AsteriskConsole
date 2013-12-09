using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui
{
    public partial class AsteriskUIBase : Form
    {
        protected List<AsteriskController> asteriskControllers;

        public virtual List<AsteriskController> AsteriskControllers
        {
            get { return asteriskControllers; }
            set
            {
                asteriskControllers = value;
                initAsteriskControllers();
            }
        }

        protected virtual void initAsteriskControllers()
        {
        }

        public AsteriskUIBase()
        {
            InitializeComponent();
        }
    }
}
