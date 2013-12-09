using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VisualAsterisk.Asterisk;
using System.Threading;
using Asterisk.NET.Manager;
using VisualAsterisk.Asterisk.Config;
using System.IO;

namespace VisualAsterisk.Test.Asterisk
{
    /// <summary>
    /// Use mock manager connection to test
    /// </summary>
    [TestFixture]
    public class DefaultAsteriskServerTest2
    {
        DefaultAsteriskServerTester server = new DefaultAsteriskServerTester();
        private AsteriskConfigManager configManager = new AsteriskConfigManager(Path.Combine(Environment.CurrentDirectory,
            @"..\..\..\TestData\configfiles\centos1"));

        public DefaultAsteriskServerTest2()
        {
            server.ConfigManager = configManager;
        }

        [Test]
        public void TestOriginate()
        {
            server.Initialize();
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("command", "sh /var/lib/asterisk/scripts/listfiles /var/lib/asterisk/sounds/record/");
            server.OriginateToExtension("Local/executecommand@asterisk_guitools", "asterisk_guitools", "", 1, 60000, null, variables);
            Assert.AreEqual(1, server.Channels.Count);
            AsteriskChannel channel = server.Channels[0];
            Assert.AreEqual(channel.Name, "Local/executecommand@asterisk_guitools");
        }

        class DefaultAsteriskServerTester : DefaultAsteriskServer
        {
            public DefaultAsteriskServerTester()
                : base("192.168.88.129", "admin", "abc123")
            {

            }
            protected override IManagerConnection createManagerConnection()
            {
                return new ManagerConnectionMock();
            }
        }
    }
}
