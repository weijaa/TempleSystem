using TempleBackend.Models;

namespace TempleBackend.Repositories;

public interface IUserRepository
{
    bool Login(AccountDto accountDto);
}