using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Reflection;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Internal;

namespace AstConfigFileParser
{
    [TestFixture]
    public class ConfigFileBaseTest
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            config = new ConfigManager();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\cache");
            path = Path.Combine(path, "Test");
            config.ConfigFileDir = path;
        }

        [Test]
        public void TestParser()
        {
            AstConfig cfg = config.LoadFile("asterisk.conf");
            ConfigFileBase cfb_1 = ConfigFileBase.Parse(cfg);
            Assert.IsInstanceOfType(typeof(AsteriskConf), cfb_1);
            
            // assert the second Praser function return a new copy of ConfigFileBase
            ConfigFileBase cfb_2 = ConfigFileBase.Parse(cfg);
            Assert.AreNotSame(cfb_1, cfb_2);
        }

        ConfigManager config;
    }
}
