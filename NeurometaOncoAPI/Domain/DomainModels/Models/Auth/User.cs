using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Domain.DomainModels.Models.Auth;

public class User : IdentityUser
{

    public string Nome { get; set; }

    public DateTime RegisteredAt { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime? LastLoginAt { get; set; }
    public string? FotoPerfil { get; set; }
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime TokenExpiredAt { get; set; }
    public DateTime TokenCreatedAt { get; set; }
    public string EnderecoCompleto { get; set; }
    public string Telefone { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string role { get; set; }
    
}