using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.DAL.DbContext
{
    public class DevRainDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DevRainDbContext(DbContextOptions<DevRainDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserLoginAttempt> UserLoginAttempts { get; set; }
    }
}
