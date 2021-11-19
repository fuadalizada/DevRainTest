using DevRainTest.Business.DTOs;
using DevRainTest.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DevRainTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserLoginAttemptService _userLoginAttemptService;
        public UserController(IUserService userService, IUserLoginAttemptService userLoginAttemptService)
        {
            _userService = userService;
            _userLoginAttemptService = userLoginAttemptService;
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

            var users = new List<UserDto>()
            {
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test2@gmail.com",Name="Test2",Surname="Testov2"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test5@gmail.com",Name="Test5",Surname="Testov5"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"}
            };

            var userLoginAttempts = new List<UserLoginAttemptDto>();
            foreach (var item in users)
            {
                userLoginAttempts.Add(new UserLoginAttemptDto { Id = Guid.NewGuid(), Attempt = DateTime.Now, IsSuccess = true, UserId = item.Id });
            }

            await _userService.InitUser(users);
            await _userLoginAttemptService.InitUserLoginAttempt(userLoginAttempts);
            return Ok();
        }
    }
}
