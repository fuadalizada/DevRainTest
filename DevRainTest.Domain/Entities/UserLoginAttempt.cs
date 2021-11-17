namespace DevRainTest.Domain.Entities
{
    public class UserLoginAttempt : BaseEntity
    {
        public TimeSpan Attempt { get; set; }
        public bool IsSuccess { get; set; }
    }
}
