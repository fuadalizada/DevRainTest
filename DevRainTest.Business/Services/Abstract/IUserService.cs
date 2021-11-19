using DevRainTest.Business.DTOs;

namespace DevRainTest.Business.Services.Abstract
{
    public interface IUserService : IBaseService<UserDto>
    {
        Task<IQueryable<UserDto>> GetByEmail(string email);
        Task RemoveOldUsers();
        Task InitUser(List<UserDto> users);
    }
}
