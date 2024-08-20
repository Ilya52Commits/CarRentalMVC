namespace CarRentalMVC.Repository;

public interface IRepository<T> : IDisposable
        where T : class
{
    Task<IEnumerable<T>> GetAllObjects();   // получение всех объектов
    Task<T> GetById(int id);              // получение одного объекта по id
    Task Create(T item);            // создание объекта
    Task Update(T item);            // обновление объекта
    Task Delete(T item);            // удаление объекта по id
    Task Save();                    // сохранение изменений
}