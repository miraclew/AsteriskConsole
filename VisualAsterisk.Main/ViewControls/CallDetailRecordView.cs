using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Data.DataProviders;
using System.Collections.Specialized;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.ViewControls
{
    public partial class CallDetailRecordView : DataViewControl
    {
        public CallDetailRecordView()
        {
            InitializeComponent();
        }

        protected override void OnLoadData()
        {
            if (AsteriskManager.Default.CurrentAsteriskController == null)
            {
                return;
            }
            base.OnLoadData();
            if (AsteriskManager.Default.CurrentAsteriskController.Server.State == ServerState.Initilized)
            {
                AsteriskManager.Default.CurrentAsteriskController.Server.LoadCDR(AsteriskManager.Default.CurrentAsteriskController.CDRCsvDirectory, false);

                VisualAsteriskCsvDataProvider dp = new VisualAsteriskCsvDataProvider();
                NameValueCollection nvs = new NameValueCollection();
                nvs.Add("RootDataDirectory", AsteriskManager.Default.CurrentAsteriskController.CDRCsvDirectory);
                dp.Connect(nvs);
                cdrDataSet.CallDetailRecord.Merge(dp.Data.CallDetailRecord);
            }
        }
    }
}
