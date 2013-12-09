using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Core.Management
{
    public class LinuxSystem
    {
        public string OSVersion;
        public string Uptime;
        public string AsteriskBuild;
        public string ServerDateTimeZone;
        public string HostName;
        public string IfConfig;
        public string DiskUsage;
        public string MemoryUsage;

        public void Parse(List<string> output)
        {
            OSVersion = output[0];
            Uptime = output[1];
            AsteriskBuild = output[2];
            ServerDateTimeZone = output[3];
            HostName = output[4];
            int lastIndex = 4;
            IfConfig = "";
            for (int i = lastIndex+1; i < output.Count; i++)
            {
                lastIndex = i;
                IfConfig = IfConfig + output[i] +"\r\n";
                if (output[i].EndsWith("</div>"))
                {
                    break;
                }
            }
            DiskUsage = "";
            for (int i = lastIndex + 1; i < output.Count; i++)
            {
                lastIndex = i;
                DiskUsage = DiskUsage + output[i] + "\r\n";
                if (output[i].EndsWith("</div>"))
                {
                    break;
                }
            }

            MemoryUsage = "";
            for (int i = lastIndex + 1; i < output.Count; i++)
            {
                lastIndex = i;
                MemoryUsage = MemoryUsage + output[i] + "\r\n";
                if (output[i].EndsWith("</div>"))
                {
                    break;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(OSVersion);
            sb.AppendLine(Uptime);
            sb.AppendLine(AsteriskBuild);
            sb.AppendLine(ServerDateTimeZone);
            sb.AppendLine(HostName);
            sb.AppendLine(IfConfig);
            sb.AppendLine(DiskUsage);
            sb.AppendLine(MemoryUsage);
            return sb.ToString();
        }
    }
}
