using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeurometaOncoAPI.Domain.Services.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;
using Swashbuckle.AspNetCore.Annotations;

namespace NeurometaOncoAPI.Presentation.Controllers.Identity;

public class UserController : ControllerBase
{
    private UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost("RegisterUser")]
    [SwaggerOperation(
               Summary = "Cria um novo usuário",
               Description = "Cria um novo usuário no sistema"
           )]

    public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.RegisterUser(registerUserDto);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("LoginUser")]
    [SwaggerOperation(
                      Summary = "Faz login de um usuário",
                      Description = "Faz login de um usuário no sistema"
                  )]
    public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.LoginUser(loginUserDto);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("RefreshToken")]
    [Authorize]
    [SwaggerOperation(
                             Summary = "Atualiza o token de um usuário",
                             Description = "Atualiza o token de um usuário no sistema recebendo o refreshToken do usuario"
                         )]
    public async Task<IActionResult> RefreshToken()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.RefreshToken();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}