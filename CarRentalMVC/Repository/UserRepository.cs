using CarRentalMVC.Models;

namespace CarRentalMVC.Repository;

public class UserRepository : BaseRepository<UserModel>
{
    public UserRepository(ApplicationContext context) : base(context)
    {
    }
}
