using Microsoft.AspNetCore.Mvc;
using myfinance.Application.Services.Interfaces;
using myfinance.Domain.DTOS;

namespace myfinance.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetUsersAsync());
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginDTO userData)
        {
            var teste = userData;
            return Ok(userData);
        }
    }
}
