using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Domain.DomainModels.Models;

public class Endereco : BaseEntity.BaseEntity
{
    [Key]
    public int Id {  get; set; }
    public string CEP { get; set; }
    public string Pais { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }
    public virtual ICollection<User> Users { get; set; }
}
