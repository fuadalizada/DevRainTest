using DevRainTest.Domain.Entities;

namespace DevRainTest.Business.DTOs
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public ICollection<UserLoginAttempt> UserLoginAttempts { get; set; }
    }
}
