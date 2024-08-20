using CarRentalMVC.Repository;
using CarRentalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalMVC.Services;
 
public class RegistrationAuthorizationService : IRegistrationAuthorizationService
{
    private UserRepository _dbContext;

    public RegistrationAuthorizationService(UserRepository dbContext)
    {
        _dbContext = dbContext;
    }

    public ActionResult<UserModel> AuthorizationMethod(UserModel user)
    {
        return _dbContext.GetUser(user);
    }

    public void RegistrationMethod(UserModel user)
    {
        _dbContext.Create(user);
        _dbContext.Save();
    }

    protected void Dispose(bool disposing)
    {
        _dbContext.Dispose();
        Dispose(disposing);
    }
}

