using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk;
using System.Threading;
using VisualAsterisk.Core.Management;

namespace VisualAsterisk.Test.Asterisk
{
    class DefaultAsteriskServerDebug
    {
        DefaultAsteriskServer server = new DefaultAsteriskServer("192.168.203.129", "visualasterisk", "VisualAsterisk2009");

        public void RandomCallTest()
        {
            server.Initialize();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("RandomCallTest {0}", i.ToString());
                Random random = new Random();
                int functionID = random.Next(10);
                call(functionID);
                Thread.Sleep(100);
            }
            Console.ReadLine();
            server.Shutdown();
        }

        private void call(int functionID)
        {
            if (functionID == 1)
            {
                foreach (string item in server.GetAllBackupFiles())
                {
                    Console.WriteLine(item);
                }
            }
            else if (functionID == 2)
            {
                foreach (string item in server.GetAllCodecs())
                {
                    Console.WriteLine(item);   
                }
            }
            else if (functionID == 3)
            {
                foreach (string item in server.GetAllMusicFiles())
                {
                    Console.WriteLine(item);
                }
            }
            else if (functionID == 4)
            {
                foreach (string item in server.GetAllRecordedVoicePrompt())
                {
                    Console.WriteLine(item);
                }
            }
            else if (functionID == 5)
            {
                server.GetPeerEntries();
            }
            else if (functionID == 6)
            {
                server.GetPeerEntriesEx();
            }
            else if (functionID == 7)
            {
                Console.WriteLine(server.GetSystemInformation(true).ToString());
            }
            else if (functionID == 8)
            {
                server.GetVoicemailboxes();
            }
            else if (functionID == 9)
            {
            }
        }        
    }
}
