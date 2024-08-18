namespace CarRentalMVC.Repository;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    private ApplicationContext _dbContext; 

    public void Create(T item) // Add 
    {
        _dbContext.Set<T>().Add(item);
    }

    public void Delete(T item)
    {
        _dbContext.Set<T>().Remove(item);
    }

    public void Dispose()
    {
        _dbContext.Dispose();
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
}

