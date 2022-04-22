namespace WatercoolerApi.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public User ReceivingUser { get; set; }
        public List<Message> Messages { get; set; }
    }
}