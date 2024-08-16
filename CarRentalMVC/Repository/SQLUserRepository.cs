using CarRentalMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalMVC.Repository;

public class SQLUserRepository : IRepository<User>
{
    private ApplicationContext db;

    public SQLUserRepository()
    {
        this.db = new ApplicationContext();
    }

    public IEnumerable<User> GetUserList() 
    {
        return db.Users;
    }

    public User GetUser(int id)
    {
        return db.Users.Find(id);
    }
    
    public void Create(User user)
    {
        db.Users.Add(user);
    }

    public void Update(User user)
    {
        db.Entry(user).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        User user = db.Users.Find(id);
        if (user != null)
        {
           db.Users.Remove(user);
        }
    }

    public void Save()
    {
        db.SaveChanges();
    }

    private bool disposed = false; 

    public virtual void Dispose(bool disposing) 
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                db.Dispose();
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

