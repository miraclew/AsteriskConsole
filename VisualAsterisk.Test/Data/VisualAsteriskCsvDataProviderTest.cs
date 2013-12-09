using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VisualAsterisk.Data.DataProviders;
using System.Collections.Specialized;

namespace VisualAsterisk.Test.Data
{
    [TestFixture]
    public class VisualAsteriskCsvDataProviderTest
    {
        public void TestConnect()
        {
            VisualAsteriskCsvDataProvider dp = new VisualAsteriskCsvDataProvider();
            NameValueCollection nvs = new NameValueCollection();
            nvs.Add("RootDataDirectory", TestData.Instace().CsvDataDirectory);
            dp.Connect(nvs);
        }

    }
}
