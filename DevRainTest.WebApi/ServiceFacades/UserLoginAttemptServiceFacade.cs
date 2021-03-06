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
                userLoginAttempts.Add(new UserLoginAttemptDto 
                { 
                    Id = Guid.NewGuid(),
                    Attempt = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy HH:mm")),
                    IsSuccess = true,
                    UserId = item.Id 
                });
            }
            return userLoginAttempts;
        }
    }
}
