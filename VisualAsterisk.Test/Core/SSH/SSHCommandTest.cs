using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VisualAsterisk.Core.SSH;
using System.Threading;
using Granados;

namespace VisualAsterisk.Test.Core.SSH
{
    [TestFixture]
    public class SSHCommandTest
    {
        [Test]
        public void TestCopyFileNotExsit()
        {
            SSHCommand cmd = new SSHCommand();
            cmd.Connect("192.168.88.129", "root", "Ideal12");
            cmd.Copy("abc", "what", SCPCopyDirection.RemoteToLocal);
        }

        [Test]
        public void TestExecute()
        {
            SSHCommand cmd = new SSHCommand();
            cmd.Connect("192.168.88.129", "root", "Ideal12");
            IList<string> result = cmd.Execute("ls > /root/abc.txt");
            Assert.AreEqual(0, result.Count);
            result = cmd.Execute("pwd");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("/root", result[0]);
            result = cmd.Execute("ls");
            result = cmd.ExecuteRedirect("ls");
            //result = cmd.Execute(string.Format("touch /root/sshcommand_{0}", DateTime.Now.Ticks.ToString()));
            for (int i = 0; i < 20; i++)
            {
                result = cmd.ExecuteRedirect("ls");
                Assert.AreEqual(10, result.Count);
            }
            Thread.Sleep(10000);
        }
    }
}
