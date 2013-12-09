using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    /// <summary>
    /// Represent a device probe by ztscan
    /// </summary>
    public class ZapDevice
    {
        private bool active;
        private string alarms;
        private string description;
        private string name;
        private string manufacturer;
        private string devicetype;
        private string location;
        private int basechan;
        private int totchans;
        private int irq;
        private string _type;
        private IList<string> ports;

        private Dictionary<int, string> portsMap;

        [ConfigurationProperty(ConfigurationPropertyType.Var, "active")]
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "alarms")]
        public string Alarms
        {
            get { return alarms; }
            set { alarms = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "manufacturer")]
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "devicetype")]
        public string Devicetype
        {
            get { return devicetype; }
            set { devicetype = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "location")]
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "basechan")]
        public int Basechan
        {
            get { return basechan; }
            set { basechan = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "totchans")]
        public int Totchans
        {
            get { return totchans; }
            set { totchans = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "irq")]
        public int Irq
        {
            get { return irq; }
            set { irq = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Var, "type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        [ConfigurationProperty(ConfigurationPropertyType.Object, "port")]
        public IList<string> Ports
        {
            get { return ports; }
            set
            {
                ports = value;
                portsMap = new Dictionary<int, string>();

                foreach (string item in ports)
                {
                    int portNumber = int.Parse(item.Split(',')[0]);
                    string portType = item.Split(',')[1];
                    portsMap.Add(portNumber, portType);
                }
            }
        }

        public Dictionary<int, string> PortNumberToType
        {
            get
            {
                return portsMap;
            }
        }
    }

    public enum PortType
    {
        FXO, FXS
    }
}
