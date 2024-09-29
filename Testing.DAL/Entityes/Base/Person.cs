using System.ComponentModel;

namespace Testing.DAL.Entityes.Base;

public abstract class Person : NamedEntity
{
    [DisplayName("Табельный №")]
    public string? IdTabel { get; set; }

    [DisplayName("Фамилия")]
    public string? LastName { get; set; }

    [DisplayName("Имя")]
    public string? FirstName { get; set; }

    [DisplayName("Отчество")]
    public string? MiddleName { get; set; }

    [DisplayName("Статус")]
    public string? Status { get; set; }

    [DisplayName("Пароль")]
    public string? Password { get; set; }
}