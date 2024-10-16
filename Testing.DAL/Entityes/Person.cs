using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Testing.DAL.Entityes.Base;

namespace Testing.DAL.Entityes;

public class Person : NamedEntity
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