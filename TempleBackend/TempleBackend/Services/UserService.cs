using TempleBackend.Controllers;
using TempleBackend.Models;
using TempleBackend.Repositories;

namespace TempleBackend.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public bool Login(AccountDto accountDto)
    {
        return userRepository.Login(accountDto);
    }
}