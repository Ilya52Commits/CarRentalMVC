using CarRentalMVC.Models;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalMVC.Controllers;

[ApiController]
[Route("/{controller=api}/{action=RegistrationAuthorization}")]
public class RegistrationAuthorizationController : BaseController
{
    private readonly IRegistrationAuthorizationService _dbContext;

    public RegistrationAuthorizationController(IRegistrationAuthorizationService registrationService)
    {
        _dbContext = registrationService;
    }

    [HttpGet("{id}")]
    public ActionResult<UserModel> AuthorizationMethod(UserModel user)
    {
        return _dbContext.AuthorizationMethod(user);
    }

    [HttpPost]
    public void RegistrationMethod(UserModel user) 
    {
        _dbContext.RegistrationMethod(user);
    }
}

