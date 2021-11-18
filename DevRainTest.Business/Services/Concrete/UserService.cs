using AutoMapper;
using DevRainTest.Business.DTOs;
using DevRainTest.Business.Services.Abstract;
using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.Domain.Entities;

namespace DevRainTest.Business.Services.Concrete
{
    public class UserService : BaseService<UserDto, User, IUserRepository>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository,IMapper mapper) : base(userRepository,mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IQueryable<UserDto>> GetByEmail(string email)
        {
            var user = await _userRepository.GetByEmail(email);
            if (user == null)
                return null;
            var result = _mapper.ProjectTo<UserDto>(user);
            return result;
        }
    }
}
