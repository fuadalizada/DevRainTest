using DevRainTest.Business.DTOs;
using DevRainTest.Business.Services.Abstract;
using DevRainTest.WebApi.ServiceFacades;
using Microsoft.AspNetCore.Mvc;

namespace DevRainTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserLoginAttemptService _userLoginAttemptService;
        private readonly UserServiceFacade _userServiceFacade;
        private readonly UserLoginAttemptServiceFacade _userLoginAttemptServiceFacade;
        public UserController(IUserService userService, IUserLoginAttemptService userLoginAttemptService, UserServiceFacade userServiceFacade, UserLoginAttemptServiceFacade userLoginAttemptServiceFacade)
        {
            _userService = userService;
            _userLoginAttemptService = userLoginAttemptService;
            _userServiceFacade = userServiceFacade;
            _userLoginAttemptServiceFacade = userLoginAttemptServiceFacade;
        }

        [HttpGet("GetByEmail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                var result = await _userService.GetByEmail(email);
                if (result == null)
                    return NotFound();
                return new JsonResult(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("InitUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> InitUser()
        {
            await _userService.RemoveOldUsers();
            await _userLoginAttemptService.RemoveOldUserLoginAttempts();

            var users = _userServiceFacade.InsertUserDatas();
            var userLoginAttempts = _userLoginAttemptServiceFacade.InsertUserLoginAttemptDatas(users);
            await _userService.InitUser(users);
            await _userLoginAttemptService.InitUserLoginAttempt(userLoginAttempts);
            return Ok();
        }
    }
}
