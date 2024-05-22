using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeurometaOncoAPI.Domain.Services.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Paciente;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Psicologo;
using Newtonsoft.Json;
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
               Description = "Se estiver criando um PACIENTE, deixe o campo do Json psicologo{} VAZIO, o mesmo vale para psicologo, deixe o campo paciente{} VAZIO."
           )]

    public async Task<IActionResult> Register([FromBody] RegisterUserCombinedDto registerUserCombinedDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var pacienteOrPsicologoJson = registerUserCombinedDto.Paciente != null
            ? JsonConvert.SerializeObject(registerUserCombinedDto.Paciente)
            : registerUserCombinedDto.Psicologo != null
                ? JsonConvert.SerializeObject(registerUserCombinedDto.Psicologo)
                : null;

        var result = await _userService.RegisterUser(registerUserCombinedDto.RegisterUser, pacienteOrPsicologoJson);
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
        try
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
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpGet("GetById/{id}")]
    [Authorize]
    [SwaggerOperation(
        Summary = "Retorna um usuário pelo ID",
        Description = "Retorna usuario. Use somente o ID do usuario")]
    public async Task<IActionResult> GetById(string id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.GetById(id);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetAll")]
    [Authorize]
    [SwaggerOperation(
               Summary = "Retorna uma lista de usuários",
               Description = "Retorna")]
    public async Task<IActionResult> GetAll()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.GetAll();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("UpdateUser/{id}")]
    [Authorize]
    [SwaggerOperation(
                      Summary = "Atualiza um usuário",
                      Description = "Atualiza um usuário no sistema. Use somente o ID do usuario"
                  )]
    public async Task<IActionResult> UpdateUser([FromBody] GetUserDto getUserDto, string id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.Update(id, getUserDto);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("DeleteUser/{id}")]
    [Authorize]
    [SwaggerOperation(
                             Summary = "Deleta um usuário",
                             Description = "Deleta um usuário no sistema"
                         )]
    public async Task<IActionResult> DeleteUser(string id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.Delete(id);
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