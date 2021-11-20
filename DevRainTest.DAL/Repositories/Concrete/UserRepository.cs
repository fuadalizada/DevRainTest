using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.DAL.Repositories.Concrete
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext.DevRainDbContext context) : base(context)
        {

        }

        public async Task<IQueryable<User>> GetByEmail(string email)
        {
            var result = await Context.Set<User>().Include(x => x.UserLoginAttempts).Where(x => x.Email == email).ToListAsync();
            return result.AsQueryable();
        }

        public async Task InitUser(List<User> users)
        {           
           await Context.AddRangeAsync(users);
           await Context.SaveChangesAsync();
        }
      
        public async Task RemoveOldUsers()
        {
            await Context.Database.ExecuteSqlRawAsync("Delete from TBL_USER");           
        }
    }
}
