namespace Service.Domain.Models
{
    public class ServiceBusMessage
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}
