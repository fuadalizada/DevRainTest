namespace DevRainTest.DAL.Repositories.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class, new()
    {
        Task<IQueryable<TEntity>> GetAllAsync();
    }
}
