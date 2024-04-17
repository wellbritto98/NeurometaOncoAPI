using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Domain.DomainModels.Models.Auth;

public class User : IdentityUser
{

    public string Nickname { get; set; }

    public DateTime RegisteredAt { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime? LastLoginAt { get; set; }
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime TokenExpiredAt { get; set; }
    public DateTime TokenCreatedAt { get; set; }
    public string EnderecoCompleto { get; set; }
    public string role { get; set; } = "Paciente";
    
    public virtual ICollection <Paciente> Pacientes { get; set; }
}