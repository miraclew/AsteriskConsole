using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace VisualAsterisk.ExceptionManagement.Dialogs
{
    public partial class ShowErrorDialog : Form
    {
        public ShowErrorDialog()
        {
            InitializeComponent();
        }

        public ShowErrorDialog(ErrorPacket ePack)
        {
            InitializeComponent();
            LoadErrorContent(ePack);
        }

        private void LoadErrorContent(ErrorPacket ePack)
        {
            FieldInfo[] fis = typeof(ErrorPacket).GetFields();

            foreach (FieldInfo fi in fis)
            {
                object[] atts = fi.GetCustomAttributes(typeof(ShowOnErrorAttribute), false);

                if (atts.Length > 0)
                {
                    ShowOnErrorAttribute s = (ShowOnErrorAttribute)atts[0];

                    txtErrorInfo.Text += s.FriendlyName + ": " + fi.GetValue(ePack) + "\r\n\r\n";
                    //DataRow row = tbl.NewRow();
                    //row[0] = s.FriendlyName;
                    //row[1] = fi.GetValue(ePack);
                    //tbl.Rows.Add(row);
                }
            }
        }
    }
}
