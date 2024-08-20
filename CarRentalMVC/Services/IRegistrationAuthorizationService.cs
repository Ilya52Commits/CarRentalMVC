using CarRentalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalMVC.Services;

public interface IRegistrationAuthorizationService
{
    ActionResult<UserModel> AuthorizationMethod(UserModel user);

    void RegistrationMethod(UserModel user);
}

    
