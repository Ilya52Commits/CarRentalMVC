using CarRentalMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalMVC.Repository;

public class PostgreSqlUserRepository : IRepository<User>
{
    private readonly ApplicationContext _dbContext;

    public PostgreSqlUserRepository(ApplicationContext context)
    {
        _dbContext = context;
    }

    public IEnumerable<User> GetUserList()
    {
        return _dbContext.Users;
    }

    public User GetUser(int id)
    {
        return _dbContext.Users.Find(id);
    }

    public void Create(User User)
    {
        _dbContext.Users.Add(User);
    }

    public void Update(User User)
    {
        _dbContext.Entry(User).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        User User = _dbContext.Users.Find(id);
        if (User != null)
            _dbContext.Users.Remove(User);
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }

    private bool disposed = false;

    public virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}

