using AutoMapper;
using DevRainTest.Business.DTOs;
using DevRainTest.Business.Services.Abstract;
using DevRainTest.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevRainTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginAttemptController : ControllerBase
    {
        private readonly IUserLoginAttemptService _userLoginAttemptService;
        private readonly IMapper _mapper;

        public UserLoginAttemptController(IUserLoginAttemptService userLoginAttemptService,IMapper mapper)
        {
            _userLoginAttemptService = userLoginAttemptService;
            _mapper = mapper;
        }

        [HttpPost("Statistic")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Statistic([FromBody]FilterViewModel filterViewModel)
        {
            var dto = _mapper.Map<FilterViewModelDto>(filterViewModel);
            var result = await _userLoginAttemptService.Statistic(dto);
            if (result is null)
            {
                return NotFound();
            }
            return new JsonResult(result);
        }
    }
}
