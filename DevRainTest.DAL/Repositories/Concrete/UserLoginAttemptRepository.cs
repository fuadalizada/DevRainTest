using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.DAL.Repositories.Concrete
{
    public class UserLoginAttemptRepository : BaseRepository<UserLoginAttempt>, IUserLoginAttemptRepository
    {
        private readonly Microsoft.EntityFrameworkCore.DbContext _context;
        public UserLoginAttemptRepository(DbContext.DevRainDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task InitUserLoginAttempt(List<UserLoginAttempt> userLoginAttempts)
        {
            await _context.AddRangeAsync(userLoginAttempts);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveOldUserLoginAttempts()
        {
            await _context.Database.ExecuteSqlRawAsync("Delete from TBL_USER_LOGIN_ATTEMPT");
        }

        public async Task<UserLoginAttempt> Statistic(DateTime? startDate, DateTime? endDate, DateTime metric, bool? isSuccess)
        {
            throw new NotImplementedException();
        }
    }
}
