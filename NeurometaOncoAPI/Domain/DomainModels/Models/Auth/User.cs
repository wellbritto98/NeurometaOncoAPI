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
    [ForeignKey("Endereco")]
    public int EnderecoId { get; set; }
    public virtual Endereco Endereco { get; set; }
    
}