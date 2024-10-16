using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Testing.DAL.Entityes;

public class Person
{
    [DisplayName("Табельный №")]
    [Key]
    public string? TabelId { get; private set; }
    [Required]
    [DisplayName("Фамилия")]
    public string? LastName { get; private set; }

    [DisplayName("Имя")]
    public string? FirstName { get; private set; }

    [DisplayName("Отчество")]
    public string? MiddleName { get; private set; }

    [DisplayName("Статус")]
    [Required]
    public string? Status { get; private set; }
    [Required]
    [DisplayName("Пароль")]
    public string? Password { get; private set; }
}