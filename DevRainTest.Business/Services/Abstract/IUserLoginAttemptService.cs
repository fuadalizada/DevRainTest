using DevRainTest.Business.DTOs;

namespace DevRainTest.Business.Services.Abstract
{
    public interface IUserLoginAttemptService : IBaseService<UserLoginAttemptDto>
    {
        Task<UserLoginAttemptDto> Statistic(FilterViewModelDto filterViewModelDto);
        Task InitUserLoginAttempt(List<UserLoginAttemptDto> userLoginAttempts);
        Task RemoveOldUserLoginAttempts();
    }
}
