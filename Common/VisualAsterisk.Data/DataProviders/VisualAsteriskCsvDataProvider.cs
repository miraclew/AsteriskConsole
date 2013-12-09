using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.IO;

namespace VisualAsterisk.Data.DataProviders
{
    public class VisualAsteriskCsvDataProvider
    {
        private string rootDataDirectory = "";
        private string rootGreetingSoundDirectory = "";
        private VisualAsteriskDataSet data;

        public VisualAsteriskDataSet Data
        {
            get { return data; }
            set { data = value; }
        }

        public bool Connect(NameValueCollection settings)
        {
            rootDataDirectory = settings["RootDataDirectory"];

            data = new VisualAsteriskDataSet();

            // Load all of our Data
            LoadDataset();
            return true;
        }

        private void LoadDataset()
        {
            FillFromDataFile("Master.csv");
            StreamReader sr = new StreamReader(rootDataDirectory + "\\Master.csv");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] tmp = line.Split(',');
                List<string> row = new List<string>();
                for (int i = 0; i < tmp.Length; i++)
                {
                    row.Add(tmp[i].Trim('"'));
                }
                int duration, billableSecs;
                DateTime start,answer,end;
                if (row.Count <= 18 && int.TryParse(row[12], out duration) && int.TryParse(row[13], out billableSecs)
                    && DateTime.TryParse(row[9], out start) && DateTime.TryParse(row[10], out answer) && 
                    DateTime.TryParse(row[11], out end))
                {
                    data.CallDetailRecord.AddCallDetailRecordRow(row[0], row[1], row[2], row[3], row[4],
                        row[5], row[6], row[7], row[8], start, answer, end, duration, billableSecs,
                        row[14], row[15], row[16]);
                }
            }
            data.AcceptChanges();
        }

        private void FillFromDataFile(string p)
        {

        }

    }
}
