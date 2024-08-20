
namespace CarRentalMVC.Repository;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    private ApplicationContext _dbContext;

    public BaseRepository(ApplicationContext context)
    {
        _dbContext = context;
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

    public Task<IEnumerable<T>> GetAllObjects()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Create(T item)
    {
       await _dbContext.Set<T>().AddAsync(item);
    }

    Task IRepository<T>.Update(T item)
    {
        throw new NotImplementedException();
    }

    //public async Task Delete(T item)
    //{
    //   // await _dbContext.Set<T>().Async(item);
    //}

    Task IRepository<T>.Save()
    {
        throw new NotImplementedException();
    }
}
// Удалить : 
// Npgsql; 
// Npgsql.EntityFrameworkCore...; 
// Microsoft.EFCore.SqlServer; 
// Переустановить пакеты: 
// Microsoft.EFCore / Tools