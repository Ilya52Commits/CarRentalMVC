using Microsoft.EntityFrameworkCore;

namespace CarRentalMVC.Repository;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbContext _context;

    public Repository(DbContext context)
    {
        _context = context;
    }

    public async virtual Task<List<TEntity>> GetAll()
    {
        return await _context.Set<TEntity>().ToListAsync<TEntity>();
    }

    public async virtual Task<TEntity> GetById<TId>(TId id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public virtual void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }

    public virtual void Update(TEntity entity)
    {
        _context.Update(entity);
    }

    public virtual void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public async virtual Task<int> SaveChanges()
    {
        return await _context.SaveChangesAsync();
    }
}

