using System;
using System.Net;

class get_IP
{
    static void Main()
    {
        string hostName = Dns.GetHostName();
        IPAddress[] addresses = Dns.GetHostAddresses(hostName);

        Console.WriteLine("IP Addresses for " + hostName + ":");
        foreach (IPAddress address in addresses)
        {
            Console.WriteLine(address);
        }
    }
}
