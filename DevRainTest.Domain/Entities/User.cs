namespace DevRainTest.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            UserLoginAttempts = new HashSet<UserLoginAttempt>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public ICollection<UserLoginAttempt> UserLoginAttempts { get; set; }
    }
}
