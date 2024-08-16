using CarRentalMVC.Models;

namespace CarRentalMVC.Repository;
    
public class UserRepository : Repository<User>
{
    public UserRepository(Microsoft.EntityFrameworkCore.DbContext context) : base(context)
    {
    }
}

