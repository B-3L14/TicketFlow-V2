using Microsoft.AspNetCore.Mvc;
using TicketFlow.Contexts.Auth.DTOs;
using TicketFlow.Contexts.Auth.UseCases;

namespace TicketFlow.Contexts.Auth.Controllers;

[ApiController]
[Route("auth")]
public class AuthController(RegisterUseCase registerUseCase, LoginUseCase loginUseCase) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var response = await registerUseCase.ExecuteAsync(request);
        if (response is null)
            return Conflict(new { message = "E-mail já está em uso." });

        return Created(string.Empty, response);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var response = await loginUseCase.ExecuteAsync(request);
        if (response is null)
            return Unauthorized(new { message = "E-mail ou senha inválidos." });

        return Ok(response);
    }
}