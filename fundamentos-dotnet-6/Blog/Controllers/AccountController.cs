using Blog.Data;
using Blog.Extensions;
using Blog.Models;
using Blog.Services;
using Blog.ViewModels.Account;
using Blog.ViewModels.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecureIdentity.Password;

namespace Blog.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("v1/accounts/")]
        public async Task<IActionResult> Post([FromBody] RegisterViewModel model, [FromServices] BlogDataContext context)
        {
            if(!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

            var password = PasswordGenerator.Generate(25);
            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Slug = model.Email.Replace("@", "-").Replace(".", "-"),
                PasswordHash = PasswordHasher.Hash(password)
            };

            try
            {
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();

                return Ok(new ResultViewModel<dynamic>(new
                {
                    user = user.Email,
                    password,
                    passwordHash = user.PasswordHash
                }));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Category>("Falha interna no servidor!"));
            }

            return Ok();
        }

        [HttpPost("v1/accounts/login")]
        public IActionResult Login([FromServices] TokenService tokenService)
        {
            return Ok(tokenService.GenerateToken(null));
        }
    }
}
