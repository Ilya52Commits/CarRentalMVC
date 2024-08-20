using CarRentalMVC.Repository;
using CarRentalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalMVC.Services;

public class RegistrationService
{
    private UserRepository _dbContext;

    public RegistrationService(UserRepository dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public void PrivateOffice(UserModel user)
    {
        _dbContext.Create(user);
        _dbContext.Save();
    }
}

