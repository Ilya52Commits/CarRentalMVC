namespace CarRentalMVC.Models;

public class UserModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Patronymic { get; set; }    
    public string? Passwort { get; set; }
    public string? Pasport { get; set; }
    public string? Phone { get; set; }
    public string? DateOfBirth { get; set; }
}
