using System.ComponentModel;

namespace Testing.DAL.Entityes.Base;

public abstract class Person : NamedEntity
{
    [DisplayName("Табельный №")]
    public string? IdTabel { get; private set; }

    [DisplayName("Фамилия")]
    public string? LastName { get; private set; }

    [DisplayName("Имя")]
    public string? FirstName { get; private set; }

    [DisplayName("Отчество")]
    public string? MiddleName { get; private set; }

    [DisplayName("Статус")]
    public string? Status { get; private set; }

    [DisplayName("Пароль")]
    public string? Password { get; private set; }
}