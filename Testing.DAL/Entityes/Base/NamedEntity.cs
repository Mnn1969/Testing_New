using System.ComponentModel.DataAnnotations;

namespace Testing.DAL.Entityes.Base;

public abstract class NamedEntity : Entity
{
    [Required]
    public string? Name { get; set; }
}