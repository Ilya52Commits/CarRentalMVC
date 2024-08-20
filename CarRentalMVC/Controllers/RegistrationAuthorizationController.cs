using CarRentalMVC.Models;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalMVC.Controllers;

public class RegistrationAuthorizationController : BaseController
{
    private readonly IRegistrationAuthorizationService _dbContext;

    public RegistrationAuthorizationController(IRegistrationAuthorizationService registrationService)
    {
        _dbContext = registrationService;
    }

    public ActionResult<UserModel> Authorization(UserModel user)
    {
        return _dbContext.Authorization(user);
    }

    [HttpPost]
    public void Registration(UserModel user) 
    {
        _dbContext.Registration(user);
    }
}

