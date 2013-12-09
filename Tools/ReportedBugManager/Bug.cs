using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.ExceptionManagement;

namespace ReportedBugManager
{
    public enum BugState
    {
        NewFound, Fixed
    }

    [Serializable]
    public class Bug
    {
        private BugState state;
        private ErrorPacket errorPacket;
        private string errorPacketFileName;

        public string ErrorPacketFileName
        {
            get { return errorPacketFileName; }
            set { errorPacketFileName = value; }
        }

        public DateTime ReportTime
        {
            get { return errorPacket.Timestamp; }
        }

        public DateTime OcurrTime
        {
            get { return errorPacket.Timestamp; }
        }

        public string Version
        {
            get { return errorPacket.Version; }
        }

        public BugState State
        {
            get { return state; }
            set { state = value; }
        }

        public ErrorPacket ErrorPacket
        {
            get { return errorPacket; }
            set { errorPacket = value; }
        }
    }
}
