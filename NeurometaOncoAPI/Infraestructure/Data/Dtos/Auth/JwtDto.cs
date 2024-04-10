using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;

public class JwtDto
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Id { get; set; }

}