using TempleBackend.Controllers;
using TempleBackend.Models;

namespace TempleBackend.Services;

public interface IUserService
{
    bool Login(AccountDto accountDto);
}