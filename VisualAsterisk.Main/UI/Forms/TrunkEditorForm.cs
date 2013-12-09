using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk.Config.Configuration;
using VisualAsterisk.Asterisk.Config;

namespace VisualAsterisk.Main.UI.Forms
{
    public partial class TrunkEditorForm : EditorWizardFormBase
    {
        private IAsteriskConfigManager configManager;

        public TrunkEditorForm(Trunk trunk, IAsteriskConfigManager configManager)
        {
            InitializeComponent();
            this.configManager = configManager;
            this.trunkBindingSource.DataSource = trunk;
        }
    }
}
