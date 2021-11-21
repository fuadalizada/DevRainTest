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

        public async Task<IQueryable<UserLoginAttemptStatisticEntityViewModel>> Statistic(FilterViewModelEntity filterViewModelEntity)
        {
            List<UserLoginAttemptStatisticEntityViewModel> query = new();
            if (filterViewModelEntity.Metric.ToLower().Trim() == "hour")
            {
                query = await Context.Set<UserLoginAttempt>().Where(x => (x.Attempt >= filterViewModelEntity.StartDate && x.Attempt <= filterViewModelEntity.EndDate) && x.IsSuccess == filterViewModelEntity.IsSuccess)
                   .GroupBy(row => new
                   {
                       Date = row.Attempt,
                       row.Attempt.Hour
                   })
                       .Select(grp => new UserLoginAttemptStatisticEntityViewModel
                       {
                           Period = grp.Key.Date.ToString("yyyy-MM-dd HH:mm"),
                           Value = grp.Count()
                       }).ToListAsync();
            }
            else if (filterViewModelEntity.Metric.ToLower().Trim() == "month")
            {
                query = await Context.Set<UserLoginAttempt>().Where(x => (x.Attempt >= filterViewModelEntity.StartDate && x.Attempt <= filterViewModelEntity.EndDate) && x.IsSuccess == filterViewModelEntity.IsSuccess)
                    .GroupBy(row => new
                    {
                        Date = row.Attempt,
                        row.Attempt.Month
                    })
                        .Select(grp => new UserLoginAttemptStatisticEntityViewModel
                        {
                            Period = grp.Key.Date.ToString("Y"),
                            Value = grp.Count()
                        }).ToListAsync();
            }
            else if (filterViewModelEntity.Metric.ToLower().Trim() == "year")
            {
                query = await Context.Set<UserLoginAttempt>().Where(x => (x.Attempt >= filterViewModelEntity.StartDate && x.Attempt <= filterViewModelEntity.EndDate) && x.IsSuccess == filterViewModelEntity.IsSuccess)
                    .GroupBy(row => new
                    {
                        Date = row.Attempt,
                        row.Attempt.Year
                    })
                        .Select(grp => new UserLoginAttemptStatisticEntityViewModel
                        {
                            Period = grp.Key.Date.ToString("yyyy"),
                            Value = grp.Count()
                        }).ToListAsync();
            }
            return query.AsQueryable();
        }
    }
}
