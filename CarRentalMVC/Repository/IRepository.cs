using CarRentalMVC.Models;

namespace CarRentalMVC.Repository;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T> GetById<TId>(TId id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<int> SaveChanges();
}

