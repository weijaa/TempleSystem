using Microsoft.AspNetCore.Mvc;
using TempleBackend.Models;
using TempleBackend.Services;

namespace TempleBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TempleController(ITempleService templeService) : ControllerBase
    {

        [HttpGet]
        public ApiResponse<Temple> GetTempleInfo()
        {
            var temple = templeService.GetTemple();

            return ApiResponse<Temple>.Success(temple);
        }
    }
} 