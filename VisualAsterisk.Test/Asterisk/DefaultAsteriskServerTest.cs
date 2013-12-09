using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VisualAsterisk.Asterisk;
using System.Threading;
using Asterisk.NET.Manager;

namespace VisualAsterisk.Test.Asterisk
{
    /// <summary>
    /// Please confirm the Server1 ip and it's configuration is define as expected before run this test
    /// </summary>
    [TestFixture]
    public class DefaultAsteriskServerTest
    {
        DefaultAsteriskServer server = new DefaultAsteriskServer("192.168.203.129", "visualasterisk", "VisualAsterisk2009");
        [TestFixtureSetUp]
        public void Setup()
        {
            server.Initialize();
        }

        [TestFixtureTearDown]
        public void Teardown()
        {
            server.Shutdown();
        }

        [Test]
        public void TestMeetMe()
        {
            Assert.AreEqual(1, server.MeetmeRooms.Count);
            Assert.AreEqual("8000", server.MeetmeRooms[0].RoomNumber);
            Assert.AreEqual("8000", server.GetMeetmeRoom("8000").RoomNumber);
        }

    }
}
