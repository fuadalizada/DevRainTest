using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.Domain.Entities;

namespace DevRainTest.DAL.Repositories.Concrete
{
    public class UserLoginAttemptRepository : BaseRepository<UserLoginAttempt>, IUserLoginAttemptRepository
    {
        private readonly Microsoft.EntityFrameworkCore.DbContext _context;
        public UserLoginAttemptRepository(DbContext.DevRainDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<UserLoginAttempt> Statistic(DateTime? startDate, DateTime? endDate, DateTime metric, bool? isSuccess)
        {
            throw new NotImplementedException();
        }
    }
}
