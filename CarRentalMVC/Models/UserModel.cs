using System.ComponentModel.DataAnnotations;

namespace CarRentalMVC.Models;

public class UserModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Некорректное имя")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Некорректная фамилия")]
    public string? LastName { get; set; }
    [Required(ErrorMessage = "Некорректное отчество")]
    public string? Patronymic { get; set; }
    [Required(ErrorMessage = "Некорректнпароль должен иметь не меньше 8 символов")]
    public string? Passwort { get; set; }
    [Required(ErrorMessage = "Некорректный паспорт")]
    public string? Pasport { get; set; }
    [Required(ErrorMessage = "Некорректный телефон")]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Некорректная дата рождения")]
    public string? DateOfBirth { get; set; }
}
