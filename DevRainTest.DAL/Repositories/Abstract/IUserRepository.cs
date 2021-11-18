using DevRainTest.Domain.Entities;

namespace DevRainTest.DAL.Repositories.Abstract
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IQueryable<User>> GetByEmail(string email);
    }
}
