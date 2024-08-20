namespace CarRentalMVC.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    private ApplicationContext _dbContext;

    public BaseRepository()
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CarRentalDb;Username=postgres;Password=52");

        _dbContext = new ApplicationContext(optionsBuilder.Options);
    }

    public void Create(T item) // Add 
    {
        _dbContext.Set<T>().Add(item);
    }

    public void Delete(T item)
    {
        _dbContext.Set<T>().Remove(item);
    }

    public T GetUser(T item)
    {
        return _dbContext.Set<T>().Find(item);
    }

    public IEnumerable<T> GetUserList()
    {
        return _dbContext.Set<T>();
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }

    public void Update(T item)
    {
        _dbContext.Set<T>().Update(item);
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