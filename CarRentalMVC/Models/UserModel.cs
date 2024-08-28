using System.ComponentModel.DataAnnotations;

namespace CarRentalMVC.Models;

public class UserModel
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Patronymic { get; set; }
    [Required]
    public string? Passwort { get; set; }
    [Required]
    public string? Pasport { get; set; }
    [Required]
    public string? Phone { get; set; }
    [Required]
    public string? DateOfBirth { get; set; }
}
