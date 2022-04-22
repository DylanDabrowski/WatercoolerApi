namespace WatercoolerApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ActivityStatus UserActivity { get; set; }
        public string ProfilePictureUri { get; set; } = string.Empty;
        public int PermissionLevel { get; set; }
        // public List<Conversation> Conversations { get; set; }
    }
}