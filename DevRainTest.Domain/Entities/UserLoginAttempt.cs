namespace DevRainTest.Domain.Entities
{
    public class UserLoginAttempt : BaseEntity
    {
        public Guid UserId { get; set; }
        public DateTime Attempt { get; set; }
        public bool IsSuccess { get; set; }
        public User User { get; set; }
    }
}
