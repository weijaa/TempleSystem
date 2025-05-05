using TempleBackend.Controllers;
using TempleBackend.Models;
using TempleBackend.Repositories;

namespace TempleBackend.Services;

public class TempleService(ITempleRepository templeRepository) : ITempleService
{
    public Temple GetTemple()
    {
        var temple = templeRepository.GetTemple();

        return temple;
    }
}