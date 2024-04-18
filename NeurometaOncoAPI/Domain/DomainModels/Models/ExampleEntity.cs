using System.ComponentModel.DataAnnotations;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Domain.DomainModels.Models;

public class ExampleEntity : BaseEntity.BaseEntity
{
    [Key]
    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }
    public bool IsConfirmed { get; set; }
}
