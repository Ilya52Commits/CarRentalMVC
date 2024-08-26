
namespace CarRentalMVC.Repository;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    private ApplicationContext _dbContext;

    public BaseRepository(ApplicationContext context)
    {
        _dbContext = context;
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

    //public async Task<IEnumerable<T>> GetAllObjects()
    //{
    //    return await _dbContext.Set<T>().FindAsync();
    //}

    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Create(T item)
    {
        await _dbContext.Set<T>().AddAsync(item);
    }

    public async Task Update(T item)
    {
        _dbContext.Set<T>().Update(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(T item)
    {
        _dbContext.Set<T>().Remove(item);
        await _dbContext.SaveChangesAsync();
    }

    Task IRepository<T>.Save()
    {
        throw new NotImplementedException();
    }
}