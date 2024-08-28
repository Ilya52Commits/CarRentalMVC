using CarRentalMVC.Models;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalMVC.Controllers;

public class RegistrationAuthorizationController : Controller
{
    private readonly IRegistrationAuthorizationService _dbContext;

    public RegistrationAuthorizationController(IRegistrationAuthorizationService registrationService)
    {
        _dbContext = registrationService;
    }

    [HttpPost]
    public ActionResult<UserModel> Authorization(UserModel user)
    {
        if (ModelState.IsValid)
        {
            return _dbContext.Authorization(user);
        }

        return View(user);
    }

    [HttpPost]
    public void Registration(UserModel user)
    {
        if (ModelState.IsValid)
        {
            _dbContext.Registration(user);
        }
    }
}

