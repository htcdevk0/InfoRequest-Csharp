using System;
using System.Net;
using System.Net.Sockets;

namespace InfoRequest.Requests
{
    public class NetworkInfo
    {
        public static string RequestLocalIP
        {
            get
            {
                try
                {
                    var host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (var ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            return ip.ToString();
                        }
                    }
                    return "No IPv4 address found";
                }
                catch
                {
                    return "Error retrieving local IP";
                }
            }
        }
        
        public static string RequestPublicIP
        {
            get
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        return client.DownloadString("https://api.ipify.org");
                    }
                }
                catch
                {
                    return "Error retrieving public IP";
                }
            }
        }

        // Nome do host
        public static string RequestHostName = Dns.GetHostName();
    }
}