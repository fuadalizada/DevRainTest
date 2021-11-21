using DevRainTest.DAL.ViewModels;
using DevRainTest.Domain.Entities;

namespace DevRainTest.DAL.Repositories.Abstract
{
    public interface IUserLoginAttemptRepository : IBaseRepository<UserLoginAttempt>
    {
        Task<IQueryable<UserLoginAttemptStatisticEntityViewModel>> Statistic(FilterViewModelEntity filterViewModelEntity);
        Task InitUserLoginAttempt (List<UserLoginAttempt> userLoginAttempts);
        Task RemoveOldUserLoginAttempts();
    }
}
