﻿using System.Net;

namespace Contact.API.Dots
{
    public class ServiceDiscoveryOptions
    {
        public string UserServiceName { get; set; }
        public string ContactServiceName { get; set; }
        public ConsulOptions Consul { get; set; }
    }

    public class ConsulOptions
    {
        public string HttpEndpoint { get; set; }

        public DnsEndpoint DnsEndpoint { get; set; }
    }

    public class DnsEndpoint
    {
        public string Address { get; set; }

        public int Port { get; set; }

        public IPEndPoint ToIPEndPoint()
        {
            return new IPEndPoint(IPAddress.Parse(Address), Port);
        }
    }
}