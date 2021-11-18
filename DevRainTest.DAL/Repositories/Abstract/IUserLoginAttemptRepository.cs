using DevRainTest.Domain.Entities;

namespace DevRainTest.DAL.Repositories.Abstract
{
    public interface IUserLoginAttemptRepository : IBaseRepository<UserLoginAttempt>
    {
        Task<UserLoginAttempt> Statistic(DateTime? startDate, DateTime? endDate,DateTime metric,bool? isSuccess);
    }
}
