using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.DAL.ViewModels;
using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.DAL.Repositories.Concrete
{
    public class UserLoginAttemptRepository : BaseRepository<UserLoginAttempt>, IUserLoginAttemptRepository
    {
        public UserLoginAttemptRepository(DbContext.DevRainDbContext context) : base(context)
        {

        }

        public async Task InitUserLoginAttempt(List<UserLoginAttempt> userLoginAttempts)
        {
            await Context.AddRangeAsync(userLoginAttempts);
            await Context.SaveChangesAsync();
        }

        public async Task RemoveOldUserLoginAttempts()
        {
            await Context.Database.ExecuteSqlRawAsync("Delete from TBL_USER_LOGIN_ATTEMPT");
        }

        public async Task<UserLoginAttempt> Statistic(FilterViewModelEntity filterViewModelEntity)
        {
            if (filterViewModelEntity.Metric == "Hour")
            {
                var result = await Context.Set<UserLoginAttempt>().Where(x => (x.Attempt > filterViewModelEntity.StartDate && x.Attempt < filterViewModelEntity.EndDate) && x.IsSuccess == filterViewModelEntity.IsSuccess).GroupBy(x =>x.Attempt.Hour ).ToListAsync();
                
            }
            return null;
        }
    }
}
