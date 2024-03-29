namespace WatercoolerApi.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ActivityStatus UserActivity { get; set; }
        public string ProfilePictureUri { get; set; } = string.Empty;
        public int PermissionLevel { get; set; }
    }
}