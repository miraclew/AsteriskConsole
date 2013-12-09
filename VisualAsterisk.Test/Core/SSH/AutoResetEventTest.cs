using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace VisualAsterisk.Test.Core.SSH
{
    [TestFixture]
    public class AutoResetEventTest
    {
        private AutoResetEvent m_ResetEvent = new AutoResetEvent(false);

        [Test]
        public void TestWaitOne()
        {
            Thread thread1 = new Thread(new ThreadStart(delegate(){
                while (true)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Thread1: I send the signal");
                    m_ResetEvent.Set();

                }
            }));

            Thread thread2 = new Thread(new ThreadStart(delegate() {
                while (true)
                {
                    m_ResetEvent.WaitOne();
                    Console.WriteLine("Thread2: I got the signal");
                }
            }));

            thread1.Start();
            thread2.Start();
            Thread.Sleep(1000000);
        }
    }
}
