using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Service.Domain.Models;

namespace Azure.ServiceBus.Integration
{
    public class SenderService
    {
        public async Task SendMessage(UserMessage dto)
        {
            try
            {
                string messageString = JsonSerializer.Serialize(dto);
                ITopicClient topicClient = new TopicClient(HelperService.SenderConnectionString, HelperService.TopicName);
                var serviceBusMessage = new ServiceBusMessage
                {
                    Id = Guid.NewGuid().ToString(),
                    Type = HelperService.MSG_TYPE,
                    Content = messageString
                };

                var message = new Message(Encoding.UTF8.GetBytes(messageString));
                message.UserProperties.Add("Type", serviceBusMessage.Type);
                message.MessageId = serviceBusMessage.Id;

                await topicClient.SendAsync(message);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
