using CarRentalMVC.Repository;
using CarRentalMVC.Models;

namespace CarRentalMVC.Services;

public class RegistrationAuthorizationService : IRegistrationAuthorizationService
{
    private UserRepository _dbContext;

    public RegistrationAuthorizationService(UserRepository dbContext)
    {
        _dbContext = dbContext;
    }

    public UserModel Authorization(UserModel user)
    {
        return _dbContext.GetById(user.Id);
    }

    public void Registration(UserModel user)
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

