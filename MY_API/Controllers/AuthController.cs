using Microsoft.AspNetCore.Mvc;
using MY_API.Entities;

namespace MY_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    public static User user = new User();

    [HttpPost("register")]
    public ActionResult<User> Register(UserDto request)
    {
        string passwordHash
            = BCrypt.Net.BCrypt.HashPassword(request.Password);
    }

}
