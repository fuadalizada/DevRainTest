using AutoMapper;
using DevRainTest.Business.DTOs;
using DevRainTest.Business.Services.Abstract;
using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.Domain.Entities;

namespace DevRainTest.Business.Services.Concrete
{
    public class UserLoginAttemptService : BaseService<UserLoginAttemptDto, UserLoginAttempt, IUserLoginAttemptRepository>, IUserLoginAttemptService
    {
        private readonly IUserLoginAttemptRepository _userLoginAttemptRepository;
        private readonly IMapper _mapper;

        public UserLoginAttemptService(IUserLoginAttemptRepository userLoginAttemptRepository,IMapper mapper) : base(userLoginAttemptRepository,mapper)
        {
            _userLoginAttemptRepository = userLoginAttemptRepository;
            _mapper = mapper;
        }

        public async Task InitUserLoginAttempt(List<UserLoginAttemptDto> userLoginAttempts)
        {
            var userLoginAttemptList = _mapper.Map<List<UserLoginAttempt>>(userLoginAttempts);
            await _userLoginAttemptRepository.InitUserLoginAttempt(userLoginAttemptList);
        }

        public async Task RemoveOldUserLoginAttempts()
        {
            await _userLoginAttemptRepository.RemoveOldUserLoginAttempts();
        }

        public async Task<UserLoginAttemptDto> Statistic(DateTime? startDate, DateTime? endDate, DateTime metric, bool? isSuccess)
        {
            throw new NotImplementedException();
        }
    }
}
