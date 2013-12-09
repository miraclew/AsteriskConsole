using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;

namespace AstConfigFileParser
{
    [TestFixture]
    public class ConfigFileSaveTest
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
        public void TestSave()
        {
            AsteriskConf a = config.LoadAsterisk();
            Assert.AreEqual(3, a.Debug);
            a.Debug = 4;
            config.SaveConfig(ConfigFileEnum.Asterisk);

            config.LoadAsterisk();
            Assert.AreEqual(4, a.Debug);
            a.Debug = 3;
            config.SaveConfig(ConfigFileEnum.Asterisk);
        }

        [Test]
        public void TestAllToString()
        {
            //config.LoadAll();

            //foreach (AstConfigFileParser.ConfigFileEnum var in config.ConfigTable.Keys)
            //{
            //    string File = @"c:\test\" + var.ToString().ToLower() + ".conf";
            //    try
            //    {
            //        using (StreamWriter sw = new StreamWriter(File))
            //        {
            //            sw.Write(config.ConfigTable[var].ToString());
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Trace.TraceError("The File could not be Read:");
            //        Trace.TraceError(e.Message);
            //        throw;
            //    }

            //}
        }

        #region test ToString
        [Test]
        public void TestExtensionsToString()
        {
            Extension ext = config.LoadExtensions2();
            string str = ext.ToString();
            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\test\extensions.conf"))
                {
                    sw.Write(str);
                }
            }
            catch (Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }
        }
        [Test]
        public void TestUsersToString()
        {
            Users u = config.LoadUsers2();
            string str = u.ToString();
            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\test\users.conf"))
                {
                    sw.Write(str);
                }
            }
            catch (Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }
        }


        [Test]
        public void TestSipToString()
        {
            Sip s = config.LoadSip();
            string str = s.ToString();
            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\test\sip.conf"))
                {
                    sw.Write(str);
                }
            }
            catch (Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }
        }


        [Test]
        public void TestQueueToString()
        {
            Queues q = config.LoadQueues();
            string str = q.ToString();
            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\test\queues.conf"))
                {
                    sw.Write(str);
                }
            }
            catch (Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }
        }

        [Test]
        public void TestCdrToString()
        {
            Cdr cdr = config.LoadCdr();
            string str = cdr.ToString();
            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\cdr.conf"))
                {
                    sw.Write(str);
                }
            }
            catch (Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }
        }

        [Test]
        public void TestAgentToString()
        {
            Agents agents = config.LoadAgents();
            string str = agents.ToString();
            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\agents.conf"))
                {
                    sw.Write(str);
                }
            }
            catch (Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }
        }

        [Test]
        public void TestAsteriskToString()
        {
            AsteriskConf a = config.LoadAsterisk();
            string str = a.ToString();

            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\asterisk.conf"))
                {
                    sw.Write(str);
                }
            }
            catch (Exception e)
            {
                Trace.TraceError("The file could not be read:");
                Trace.TraceError(e.Message);
                throw;
            }
        }
        #endregion

        ConfigManager config;
    }
}
