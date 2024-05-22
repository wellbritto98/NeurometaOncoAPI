using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json;
using NeurometaOncoAPI.Domain.DomainModels.Models.ApiResponse;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Paciente;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using Newtonsoft.Json.Linq;

namespace NeurometaOncoAPI.Domain.Services.Auth;

public class UserService
{
    private IEmailSender _emailSender;
    private IMapper _mapper;
    private UserManager<User> _userManager;
    private SignInManager<User> _signInManager;
    private IHttpContextAccessor _httpContextAccessor;
    private HttpClient _httpClient;
    private JwtService _jwtService;
    private IPacienteRepository _pacienteRepository;
    private IPsicologoRepository _psicologoRepository;

    public UserService(IMapper mapper, UserManager<User> userManager,
        SignInManager<User> signInManager, IHttpContextAccessor httpContextAccessor, IEmailSender emailSender,
        HttpClient httpClient, JwtService jwtService, IPacienteRepository pacienteRepository, IPsicologoRepository psicologoRepository)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _httpContextAccessor = httpContextAccessor;
        _emailSender = emailSender;
        _httpClient = httpClient;
        _jwtService = jwtService;
        _pacienteRepository = pacienteRepository;
        _psicologoRepository= psicologoRepository;
    }

    public async Task<ApiResponse> RegisterUser(RegisterUserDto dto, string pacienteOrPsicologoDtoJson)
    {
        try
        {
            Paciente paciente = null;
            Psicologo psicologo = null;
            var pacienteOrPsicologoDto = JsonConvert.DeserializeObject<JObject>(pacienteOrPsicologoDtoJson);

            // Verificar se o json é um paciente ou psicologo
            if (pacienteOrPsicologoDto == null)
            {
                return new ApiResponse { Success = false, Message = "Json inválido" };
            }

            // Verificar se contém a propriedade "crmMedico" ou "crp"
            if (pacienteOrPsicologoDto["CrmMedico"] != null)
            {
                paciente = pacienteOrPsicologoDto.ToObject<Paciente>();
                // mapeia o paciente
            }
            else if (pacienteOrPsicologoDto["Crp"] != null)
            {
                psicologo = pacienteOrPsicologoDto.ToObject<Psicologo>();
                // mapeia o psicologo
            }
            else
            {
                return new ApiResponse { Success = false, Message = "Json inválido" };
            }

            User user = _mapper.Map<User>(dto);
            user.UserName = user.Email;
            user.Email = user.Email.ToLower();
            user.RegisteredAt = DateTime.UtcNow;
            if (dto.Role.ToUpper() != "PACIENTE" && dto.Role.ToUpper() != "PSICOLOGO")
            {
                return new ApiResponse { Success = false, Message = "Role não encontrada!" };
            }
            user.role = dto.Role.ToUpper() == "PACIENTE" ? "Paciente" : "Psicologo";

            var today = DateTime.Today;
            var age = today.Year - user.DataNascimento.Year;

            // Ajusta a idade se o aniversário ainda não ocorreu este ano
            if (user.DataNascimento.Date > today.AddYears(-age))
            {
                age--;
            }

            if (age < 18)
            {
                return new ApiResponse { Success = false, Message = "Usuário menor de idade!" };
            }

            if (!dto.AgreeTerms)
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Infelizmente só podemos cadastrar usuários que aceitam os termos de uso."
                };
            }

            IdentityResult resultado = await _userManager.CreateAsync(user, dto.Password);
            await _userManager.AddToRoleAsync(user, dto.Role.ToUpper() == "PACIENTE" ? "Paciente" : "Psicologo");

            if (!resultado.Succeeded)
            {
                var errors = resultado.Errors.Select(e => e.Description);
                return new ApiResponse
                { Success = false, Message = $"Falha ao cadastrar usuário: {string.Join(", ", errors)}" };
            }

            var userId = _userManager.FindByEmailAsync(user.Email).Result.Id;

            // cria um paciente ou Psicologo vinculado ao Id desse usuario
            if (dto.Role.ToUpper() == "PACIENTE")
            {
                if (paciente != null)
                {
                    paciente.PacienteId = userId;
                    await _pacienteRepository.AddAsync(paciente);
                }
                else
                {
                    return new ApiResponse { Success = false, Message = "Erro ao mapear paciente" };
                }
            }
            else
            {
                if (psicologo != null)
                {
                    psicologo.PsicologoId = userId;
                    await _psicologoRepository.AddAsync(psicologo);
                }
                else
                {
                    return new ApiResponse { Success = false, Message = "Erro ao mapear psicologo" };
                }
            }

            var endpoint = "https://neurometaoncoapi.azurewebsites.net/resendConfirmationEmail";
            var payload = new { email = user.Email };
            var json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Usuário cadastrado com sucesso! Verifique sua conta no link que enviamos por email"
                };
            }
            else
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Falha ao enviar email de confirmação"
                };
            }
        }
        catch (Exception ex)
        {
            // Log do erro
            Console.WriteLine($"Erro ao cadastrar usuário: {ex.Message}");
            Console.WriteLine(ex.ToString());
            return new ApiResponse
            {
                Success = false,
                Message = "Ocorreu um erro ao processar a solicitação. Por favor, tente novamente mais tarde."
            };
        }
    }

    //logar usuario

    public async Task<ApiResponse> LoginUser(LoginUserDto dto)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                return new ApiResponse { Success = false, Message = "Usuário não encontrado" };
            }
            else if (user.EmailConfirmed != true)
            {
                return new ApiResponse { Success = false, Message = "Email não confirmado" };
            }

            var resultado = await _signInManager.PasswordSignInAsync(user, dto.Password, false, true);

            if (resultado.Succeeded)
            {
                var token = _jwtService.GenerateToken(new JwtDto { Email = user.Email, Id = user.Id, Role= user.role });
                _httpContextAccessor.HttpContext.Response.Cookies.Append("jwt", token, new CookieOptions
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.None,
                    Secure = true,
                    Expires = DateTime.Now.AddDays(7)
                });

                var refreshToken = GenerateRefreshToken();
                SetRefreshTokenInCookie(refreshToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Usuário logado com sucesso",
                    Data = new { Token = token, RefreshToken = refreshToken }
                };
            }
            else
            {
                return new ApiResponse { Success = false, Message = "Falha ao logar usuário" };
            }   
        }

        catch (Exception ex)
        {
            return new ApiResponse { Success = false, Message = "Falha ao logar usuário" };
        }
    }

    private RefreshToken GenerateRefreshToken()
    {
        var refreshToken = new RefreshToken
        {
            Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
            Expired = DateTime.Now.AddDays(7)
        };
        return refreshToken;
    }

    private void SetRefreshTokenInCookie(RefreshToken refreshToken)
    {
        var user = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            SameSite = SameSiteMode.None,
            Secure = true,
            Expires = refreshToken.Expired
        };
        _httpContextAccessor.HttpContext.Response.Cookies.Append("refreshToken", refreshToken.Token, cookieOptions);
        if (user != null)
        {
            user.RefreshToken = refreshToken.Token;
            user.TokenCreatedAt = refreshToken.CreatedAt;
            user.TokenExpiredAt = refreshToken.Expired;
            _userManager.UpdateAsync(user);
        }
    }

    //GetById
    public async Task<ApiResponse> GetById(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return new ApiResponse { Success = false, Message = "Usuário não encontrado" };
        }

        var userDto = _mapper.Map<GetUserDto>(user);
        return new ApiResponse { Success = true, Data = userDto };
    }

    //GetAll
    public async Task<ApiResponse> GetAll()
    {
        var users = _userManager.Users.ToList();
        var usersDto = _mapper.Map<List<GetUserDto>>(users);
        return new ApiResponse { Success = true, Data = usersDto };
    }

    //Delete
    public async Task<ApiResponse> Delete(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return new ApiResponse { Success = false, Message = "Usuário não encontrado" };
        }

        var result = await _userManager.DeleteAsync(user);
        if (result.Succeeded)
        {
            return new ApiResponse { Success = true, Message = "Usuário deletado com sucesso" };
        }
        else
        {
            return new ApiResponse { Success = false, Message = "Falha ao deletar usuário" };
        }
    }

    //Update
    public async Task<ApiResponse> Update(string id, GetUserDto dto)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return new ApiResponse { Success = false, Message = "Usuário não encontrado" };
        }

        var userDto = _mapper.Map(dto, user);
        var result = await _userManager.UpdateAsync(userDto);
        if (result.Succeeded)
        {
            return new ApiResponse { Success = true, Message = "Usuário atualizado com sucesso" };
        }
        else
        {
            return new ApiResponse { Success = false, Message = "Falha ao atualizar usuário" };
        }
    }

    public async Task<ApiResponse> RefreshToken()
    {
        var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == "id");
        var userEmailClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email);

        if (userIdClaim == null || userEmailClaim == null)
        {
            return new ApiResponse { Success = false, Message = "Usuário não encontrado" };
        }

        var user = await _userManager.FindByIdAsync(userIdClaim.Value);
        if (user == null)
        {
            return new ApiResponse { Success = false, Message = "Usuário não encontrado" };
        }

        var refreshToken = GenerateRefreshToken();
        SetRefreshTokenInCookie(refreshToken);

        var newToken = _jwtService.GenerateToken(new JwtDto { Email = userEmailClaim.Value, Id = userIdClaim.Value });
        _httpContextAccessor.HttpContext.Response.Cookies.Append("jwt", newToken, new CookieOptions
        {
            HttpOnly = true,
            SameSite = SameSiteMode.None,
            Secure = true
        });

        return new ApiResponse
        {
            Success = true,
            Message = "Token atualizado com sucesso",
            Data = new { Token = newToken, RefreshToken = refreshToken }
        };
    }
}