using TempleBackend.Controllers;
using TempleBackend.Models;

namespace TempleBackend.Services;

public class TempleService : ITempleService
{
    public Temple GetTemple()
    {
        var temple = new Temple
        {
            Name = "示例宮廟",
            Address = "台灣台北市",
            Phone = "02-12345678",
            Description = "這是一個示例宮廟的描述"
        };

        return temple;
    }
}