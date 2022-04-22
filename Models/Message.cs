namespace WatercoolerApi.Models
{
    public class Message
    {
        public int Id { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }
        public string Content { get; set; }
    }
}