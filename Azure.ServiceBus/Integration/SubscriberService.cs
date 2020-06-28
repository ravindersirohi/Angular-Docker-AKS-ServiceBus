using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.ServiceBus.Integration
{
    public class SubscriberService
    {
        const string ServiceBusConnectionString = "Endpoint=sb://hvguserservice.servicebus.windows.net/;SharedAccessKeyName=ListenPolicy;SharedAccessKey=/xljJVxlXJaVAW1hNQaJAbPHpIwdtJd5MTep75R3O8I=";
        const string TopicName = "usermessagetopic";
        const string SubscriptionName = "UserMessageTopic-Subscription";
    }
}
