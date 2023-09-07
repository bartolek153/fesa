using PublicApi._models;
using Application.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace PublicApi.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        Console.WriteLine(
            _authenticationService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
            )
        );

        return Ok();
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        _authenticationService.Login(request.Email, request.Password);

        return Ok("this is an teste");
    }
}
