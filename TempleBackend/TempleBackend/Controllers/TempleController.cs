using Microsoft.AspNetCore.Mvc;

namespace TempleBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TempleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTempleInfo()
        {
            // 暫時返回示例數據
            var templeInfo = new
            {
                Name = "示例宮廟",
                Address = "台灣台北市",
                Phone = "02-12345678",
                Description = "這是一個示例宮廟的描述"
            };

            return Ok(templeInfo);
        }
    }
} 