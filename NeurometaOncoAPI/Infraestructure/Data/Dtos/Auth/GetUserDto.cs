using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;

public class GetUserDto
{   
    public string Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? FotoPerfil { get; set; }
    public string EnderecoCompleto { get; set; }
    public string role { get; set; }
}