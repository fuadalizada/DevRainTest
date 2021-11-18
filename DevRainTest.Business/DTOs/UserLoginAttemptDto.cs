namespace DevRainTest.Business.DTOs
{
    public class UserLoginAttemptDto : BaseDto
    {
        public Guid UserId { get; set; }
        public DateTime Attempt { get; set; }
        public bool IsSuccess { get; set; }
    }
}
