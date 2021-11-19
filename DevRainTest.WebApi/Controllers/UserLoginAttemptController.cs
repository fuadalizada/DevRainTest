using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevRainTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginAttemptController : ControllerBase
    {

        public UserLoginAttemptController()
        {

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Statistic()
        {
            return Ok();
        }
    }
}
