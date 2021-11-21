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
        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IQueryable<UserDto>> GetByEmail(string email)
        {
            if (IsValidEmail(email))
            {
                var user = await _userRepository.GetByEmail(email);
                if (!user.Any())
                    return null;
                var result = _mapper.ProjectTo<UserDto>(user);
                return result;
            }
            return null;
        }

        public async Task InitUser(List<UserDto> users)
        {
            var userList = _mapper.Map<List<User>>(users);
            await _userRepository.InitUser(userList);
        }

        public async Task RemoveOldUsers()
        {
            await _userRepository.RemoveOldUsers();
        }

        bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false;
            }
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
