using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main
{
    public class AppSettings
    {
        #region Load/Save Asterisk Host to XML File
        public static List<ManagerConnectionInfo> LoadAsteriskHosts()
        {
            List<ManagerConnectionInfo> hosts = null;
            try
            {
                FileStream fs = new FileStream("asterisk_hosts.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(List<ManagerConnectionInfo>));
                hosts = xs.Deserialize(fs) as List<ManagerConnectionInfo>;
                fs.Close();
            }
            catch (FileNotFoundException e)
            {
                Trace.TraceWarning("File not found: {0}", e.Message);
            }
            catch (IOException)
            {

                throw;
            }
            return hosts;
        }

        public static void saveAsteriskHosts(List<ManagerConnectionInfo> hosts)
        {
            try
            {
                FileStream fs = new FileStream("asterisk_hosts.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(typeof(List<ManagerConnectionInfo>));
                xs.Serialize(fs, hosts);
                fs.Close();
            }
            catch (IOException)
            {
                throw;
            }
        }
        #endregion

    }
}
