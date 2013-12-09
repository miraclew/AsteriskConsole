using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Internal;


namespace AstConfigFileParser
{
    [TestFixture]
    public class ConfigFileParserTest
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
        public void TestLoadManager()
        {
            Manager m = config.LoadManager();
            Assert.IsTrue(m.Displaysystemname);
            Assert.IsTrue(m.Webenabled);
            Assert.AreEqual(5038, m.Port);
            Assert.AreEqual("0.0.0.0", m.Bindaddr);
        }

        [Test]
        public void TestLoadAsterisk()
        {
            AsteriskConf a = config.LoadAsterisk();
            Assert.AreEqual("/etc/asterisk", a.Astetcdir);
            Assert.AreEqual(3, a.Debug);
            Assert.AreEqual("0660", a.Astctlpermissions);
        }

        [Test, Ignore]
        public void TestLoadQueues()
        {
            Queues q = config.LoadQueues();
            Assert.IsTrue(q.Persistentmembers);
            Assert.IsTrue(q.Autofill);
            Assert.AreEqual("MixMonitor", q.Monitortype);

            Assert.AreEqual(1, q.QueueList.Count);
            Assert.AreEqual("markq", q.QueueList[0].Name);
            Assert.AreEqual("default", q.QueueList[0].Musicclass);
            Assert.AreEqual(3, q.QueueList[0].Members.Count);
        }
        [Test]
        public void TestLoadExtensions()
        {
            Extension e = config.LoadExtensions2();
            Assert.AreEqual(e.Static, true);
            Assert.AreEqual(e.AutoFallthrough, true);
            Assert.AreEqual(e.ClearGlobalvars, true);
            Assert.AreEqual(e.WriteProtect, false);
            Assert.AreEqual(e.PriorityJumping, false);
            // Global
            Assert.AreEqual(e.Globals.Count, 4);
            Assert.AreEqual(e.Globals[0].Name, "CONSOLE");
            Assert.AreEqual(e.Globals[0].Value, "Console/dsp");
            Assert.AreEqual(e.Globals[3].Name, "TRUNKMSD");
            Assert.AreEqual(e.Globals[3].Value, "1");

            // Macros
            Assert.AreEqual(7, e.Macros.Count);
            Assert.AreEqual("stdexten-followme", e.Macros[0].Name);
            Assert.AreEqual(8, e.Macros[0].Extens.Count);

            // Contexts
            Assert.AreEqual(e.Contexts.Count, 26);
            Assert.AreEqual("asterisk_guitools", e.Contexts[0].Name);
            Assert.AreEqual(e.Contexts[0].Ignorepats.Count, 0);
            Assert.AreEqual(e.Contexts[0].Includes.Count, 0);
            Assert.AreEqual(11, e.Contexts[0].Extens.Count);

        }

        [Test]
        public void TestLoadUsers2()
        {
            Users user = config.LoadUsers2();
            Assert.AreEqual(user.UserList.Count, 2);

            Assert.AreEqual(user.UserList[0].Category, "6000");
            Assert.AreEqual(user.UserList[0].Context, "international");
            Assert.AreEqual(user.UserList[0].FullName, "Joe User");
            Assert.AreEqual(user.UserList[0].Vmsecret, "1234");
            Assert.AreEqual(user.UserList[0].HasSip, true);
            Assert.AreEqual(user.UserList[0].Hasiax, false);
            Assert.AreEqual(user.UserList[0].CallWaiting, false);
            Assert.AreEqual(user.UserList[0].Email, "joe@foo.bar");

            Assert.AreEqual(user.UserList[1].Category, "6001");
            Assert.AreEqual(user.UserList[1].Context, "demo");
            Assert.AreEqual(user.UserList[1].FullName, "Bob Wan");
            Assert.AreEqual(user.UserList[1].Secret, "6001");
            Assert.AreEqual(user.UserList[1].HasSip, true);
            Assert.AreEqual(user.UserList[1].Hasiax, true);
            Assert.AreEqual(user.UserList[1].CallWaiting, true);
            Assert.AreEqual(user.UserList[1].Email, "bw@a.com");
            Assert.AreEqual(user.UserList[1].Type, UserType.Friend);
        }

        [Test]
        public void TestLoadConfig()
        {
            AstConfig cfg = config.LoadFile(@"users.conf");
            List<AstCategory> cats = cfg.Categories;
            Assert.AreEqual(cats.Count, 3);

            Assert.AreEqual(cats[0].Name, "general");
            Assert.AreEqual(cats[0].Variables.Count, 16);
            Assert.AreEqual(cats[0].Variables[0].Name, "fullname");
            Assert.AreEqual(cats[0].Variables[0].Value, "New User");
            Assert.AreEqual(cats[0].Variables[1].Name, "userbase");
            Assert.AreEqual(cats[0].Variables[1].Value, "6000");
            Assert.AreEqual(cats[0].Variables[2].Name, "hasvoicemail");
            Assert.AreEqual(cats[0].Variables[2].Value, "yes");
            Assert.AreEqual(cats[0].Variables[3].Name, "vmsecret");
            Assert.AreEqual(cats[0].Variables[3].Value, "1234");


            Assert.AreEqual("6000", cats[1].Name);
            Assert.AreEqual(12, cats[1].Variables.Count);
            Assert.AreEqual("fullname", cats[1].Variables[0].Name);
            Assert.AreEqual("Joe User", cats[1].Variables[0].Value);
            Assert.AreEqual("hasvoicemail", cats[1].Variables[4].Name);
            Assert.AreEqual("yes", cats[1].Variables[4].Value);

            Assert.AreEqual("6001", cats[2].Name);
            Assert.AreEqual(cats[2].Variables.Count, 7);
            Assert.AreEqual(cats[2].Variables[0].Name, "fullname");
            Assert.AreEqual(cats[2].Variables[0].Value, "Bob Wan");
            Assert.AreEqual(cats[2].Variables[1].Name, "email");
            Assert.AreEqual(cats[2].Variables[1].Value, "bw@a.com");
            Assert.AreEqual(cats[2].Variables[2].Name, "host");
            Assert.AreEqual(cats[2].Variables[2].Value, "dynamic");
            Assert.AreEqual(cats[2].Variables[3].Name, "secret");
            Assert.AreEqual(cats[2].Variables[3].Value, "6001");
        }

        ConfigManager config;
    }
}
