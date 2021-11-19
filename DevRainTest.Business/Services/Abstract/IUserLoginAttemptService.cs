using DevRainTest.Business.DTOs;

namespace DevRainTest.Business.Services.Abstract
{
    public interface IUserLoginAttemptService : IBaseService<UserLoginAttemptDto>
    {
        Task<UserLoginAttemptDto> Statistic(DateTime? startDate, DateTime? endDate, DateTime metric, bool? isSuccess);
        Task InitUserLoginAttempt(List<UserLoginAttemptDto> userLoginAttempts);
        Task RemoveOldUserLoginAttempts();
    }
}
