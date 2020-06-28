namespace Service.Domain.Models
{
    public class UserMessage : BaseModel
    {
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
