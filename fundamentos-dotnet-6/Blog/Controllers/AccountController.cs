using Blog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {

        [HttpPost("v1/login")]
        public IActionResult Login([FromServices] TokenService tokenService)
        {
            return Ok(tokenService.GenerateToken(null));
        }
    }
}
