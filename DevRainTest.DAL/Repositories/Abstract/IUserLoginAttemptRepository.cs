using DevRainTest.Domain.Entities;

namespace DevRainTest.DAL.Repositories.Abstract
{
    public interface IUserLoginAttemptRepository : IBaseRepository<UserLoginAttempt>
    {
        Task<UserLoginAttempt> Statistic(FilterViewModelEntity filterViewModelEntity);
        Task InitUserLoginAttempt (List<UserLoginAttempt> userLoginAttempts);
        Task RemoveOldUserLoginAttempts();
    }
}
