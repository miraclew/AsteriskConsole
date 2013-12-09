using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config;
using System.IO;
using NUnit.Framework;
using VisualAsterisk.Asterisk.Config.Configuration;

namespace VisualAsterisk.Test.Asterisk.Config
{
    [TestFixture]
    public class AsteriskConfigManagerTest
    {
        private AsteriskConfigManager configManager = new AsteriskConfigManager(Path.Combine(Environment.CurrentDirectory,
            @"..\..\..\TestData\configfiles\centos1"));

        [Test]
        public void TestInitialize()
        {
            configManager.Initialize();

            // users
            Assert.AreEqual(5, configManager.Users.Count);
            string[] users = new string[] { "6001", "6002", "6003", "6004", "6005" };
            foreach (string item in users)
            {
                Assert.IsTrue(configManager.Users.Contains(configManager.FindUser(item)));
            }
            Assert.IsNull(configManager.FindUser("trunk_1"));
            Assert.AreEqual("New User", configManager.GeneralUser.FullName);
            Assert.AreEqual("6000", configManager.GeneralUser.Userbase);
            Assert.IsTrue(configManager.GeneralUser.HasVoicemail);
            Assert.IsFalse(configManager.GeneralUser.AllowAliasExtns);
            Assert.AreEqual("6001", configManager.GeneralUser.OperatorExtension);

            Assert.AreEqual("numberplan-custom-1", configManager.FindUser("6005").Context);
            Assert.IsFalse(configManager.FindUser("6005").Hasagent);

            // trunk
            Assert.AreEqual(1, configManager.Trunks.Count);
            Assert.AreEqual("trunk_1", configManager.FindTrunkByUserCategory("trunk_1").TrunkUserCategory);
            Assert.AreEqual("DID_trunk_1", configManager.FindTrunkByUserCategory("trunk_1").Context);
            Assert.AreEqual("192.168.88.128", configManager.FindTrunkByName("Custom - iax-trunk-1").Host);

            // 
        }

        [Test]
        public void TestGetAllZapDevices()
        {
            IList<ZapDevice> devices = configManager.GetAllZapDevices(false);
            Assert.AreEqual(1, devices.Count);
            Assert.IsTrue(devices[0].Active);
            Assert.AreEqual("OK", devices[0].Alarms);
            Assert.AreEqual(1, devices[0].Basechan);
            Assert.AreEqual(4, devices[0].Totchans);
            Assert.AreEqual(18, devices[0].Irq);
            Assert.AreEqual("analog", devices[0].Type);
            Assert.AreEqual(4, devices[0].Ports.Count);
            Assert.AreEqual("FXO", devices[0].PortNumberToType[1]);
            Assert.AreEqual("FXS", devices[0].PortNumberToType[2]);
            Assert.AreEqual("FXS", devices[0].PortNumberToType[3]);
            Assert.AreEqual("FXS", devices[0].PortNumberToType[4]);
        }
    }
}
