
namespace CarRentalMVC.Repository;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    private ApplicationContext _dbContext;

    public BaseRepository(ApplicationContext context)
    {
        _dbContext = context;
    }

    public IEnumerable<T> GetAllObjects()
    {
        return _dbContext.Set<T>();
    }

    public T GetById(int id)
    {
        return _dbContext.Set<T>().Find(id);
    }

    public async Task Create(T item)
    {
        await _dbContext.Set<T>().AddAsync(item);
    }

    public void Update(T item)
    {
        _dbContext.Set<T>().Update(item);
    }

    public void Delete(T item)
    {
        _dbContext.Set<T>().Remove(item);
    }

    public async Task Save()
    {
        await _dbContext.SaveChangesAsync();
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