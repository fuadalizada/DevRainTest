using DevRainTest.Business.DTOs;

namespace DevRainTest.WebApi.ServiceFacades
{
    public class UserLoginAttemptServiceFacade
    {
        public List<UserLoginAttemptDto> InsertUserLoginAttemptDatas(List<UserDto> users)
        {
            var userLoginAttempts = new List<UserLoginAttemptDto>();
            foreach (var item in users)
            {
                userLoginAttempts.Add(new UserLoginAttemptDto { Id = Guid.NewGuid(), Attempt = DateTime.Now, IsSuccess = true, UserId = item.Id });
            }
            return userLoginAttempts;
        }
    }
}
