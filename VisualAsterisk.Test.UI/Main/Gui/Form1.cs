using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using VisualAsterisk.Main.Gui.Configuration;
using VisualAsterisk.Main.Gui;

namespace VisualAsterisk.Test.Main.Gui
{
    public partial class Form1 : Form
    {
        private InventoryControl inventoryWindow = new InventoryControl();
        public Form1()
        {
            InitializeComponent();
            this.dockPanel1.SuspendLayout(true);
            inventoryWindow.Show(dockPanel1, DockState.DockLeft);
            //UsersConfigPage user = new UsersConfigPage();
            Content1 doc1 = new Content1();
            doc1.Show(dockPanel1, DockState.Document);
            Content1 doc2 = new Content1();
            doc2.Show(dockPanel1, DockState.Document);
            dockPanel1.ResumeLayout(true, true);
        }
    }
}
