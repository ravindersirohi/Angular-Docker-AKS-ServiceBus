using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Azure.ServiceBus
{
    public class ServiceBusConfiguration
    {
        public string PublisherConnectionString { get; set; }
        public string SubscriberConnectionString { get; set; }
    }
}
