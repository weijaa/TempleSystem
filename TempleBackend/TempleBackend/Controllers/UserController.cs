using Microsoft.AspNetCore.Mvc;
using TempleBackend.Models;
using TempleBackend.Services;

namespace TempleBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {

        [HttpPost("login")]
        public ApiResponse<bool> Login(LoginRequest loginRequest)
        {
            var login = userService.Login(new AccountDto
            {
                Account = loginRequest.Account,
                Password = loginRequest.Password
            });

            return ApiResponse<bool>.Success(login);
        }
    }
} 