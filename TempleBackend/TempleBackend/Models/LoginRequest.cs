namespace TempleBackend.Models;

public class LoginRequest
{
    public required string Account { get; set; }
    public required string Password { get; set; }
}