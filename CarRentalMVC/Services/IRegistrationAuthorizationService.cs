using CarRentalMVC.Models;

namespace CarRentalMVC.Services;

public interface IRegistrationAuthorizationService
{
    public UserModel Authorization(UserModel user);

    public void Registration(UserModel user);
}