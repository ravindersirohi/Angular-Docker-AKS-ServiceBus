using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.ServiceBus
{
    internal static class HelperService
    {
        internal const string MSG_TYPE = "User Message";
        internal const string SenderConnectionString = "Endpoint=sb://hvguserservice.servicebus.windows.net/;SharedAccessKeyName=SenderPolicy;SharedAccessKey=dFh8UkXOLdJuuD3fsOHtETZNG1XaOKRgFa1leCHFG1w=";
        internal const string TopicName = "usermessagetopic";
    }
}
