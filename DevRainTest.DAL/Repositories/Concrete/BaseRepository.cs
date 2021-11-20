using DevRainTest.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.DAL.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        protected readonly Microsoft.EntityFrameworkCore.DbContext Context;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository(Microsoft.EntityFrameworkCore.DbContext context)
        {
            Context = context;
            _dbSet = Context.Set<TEntity>();
        }

        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            var result = await _dbSet.ToListAsync();
            return result.AsQueryable();
        }
    }
}
