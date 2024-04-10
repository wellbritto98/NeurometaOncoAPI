using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

public abstract class BaseEntity
{
    [Key]
    [Required]
    public int Id { get; set; }
}
