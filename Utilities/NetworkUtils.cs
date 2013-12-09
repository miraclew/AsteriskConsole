using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Utilities
{
    public class NetworkUtils
    {
        public static string GetCurrentIpAddress()
        {
            string hostname = Dns.GetHostName();

            IPAddress[] ips = Dns.GetHostAddresses(hostname);

            string ip = String.Empty;

            if (ips.Length > 0)
            {
                ip = ips[0].ToString();
            }

            return ip;
        }

        public static IPAddress GetHostIPAddress(string hostName, System.Net.Sockets.AddressFamily addressFamily)
        {
            try
            {
                // If there's a port, remove it
                if (hostName.Contains(":"))
                    hostName = hostName.Split(':')[0];

                IPAddress parsedAddress;

                if (IPAddress.TryParse(hostName, out parsedAddress))
                    return parsedAddress;

                IPHostEntry ipEntry = Dns.GetHostEntry(hostName);

                if (ipEntry.AddressList.Length > 0)
                {
                    foreach (IPAddress address in ipEntry.AddressList)
                    {
                        if (address.AddressFamily == addressFamily && address.GetAddressBytes()[0] > 0)
                            return address;
                    }
                }
            }
            catch
            {
            }

            return new IPAddress(0);
        }

        public static void ParseHostString(string hostString, ref string hostName, ref int port)
        {
            hostName = hostString;

            if (hostString.Contains(":"))
            {
                string[] hostParts = hostString.Split(':');

                if (hostParts.Length == 2)
                {
                    hostName = hostParts[0];

                    int.TryParse(hostParts[1], out port);
                }
            }
        }
    }
}
