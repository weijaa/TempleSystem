using TempleBackend.Models;
using TempleBackend.Services;

namespace TempleBackend.Repositories;

internal class UserRepository : IUserRepository
{
    public bool Login(AccountDto accountDto)
    {
        return accountDto.Account == "admin" && accountDto.Password == "admin";
    }
}