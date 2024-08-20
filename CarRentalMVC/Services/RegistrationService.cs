using CarRentalMVC.Repository;
using CarRentalMVC.Models;

namespace CarRentalMVC.Services;
 
public class RegistrationService : IRegistrationService
{
    private UserRepository _dbContext;

    public RegistrationService(UserRepository dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddNewUser(UserModel user)
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

