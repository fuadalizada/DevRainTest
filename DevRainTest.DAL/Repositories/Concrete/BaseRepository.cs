using DevRainTest.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.DAL.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly Microsoft.EntityFrameworkCore.DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository(Microsoft.EntityFrameworkCore.DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
    }
}
