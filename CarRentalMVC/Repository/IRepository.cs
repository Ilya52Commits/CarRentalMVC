namespace CarRentalMVC.Repository;

public interface IRepository<T> : IDisposable
        where T : class
{
    public IEnumerable<T> GetAllObjects(); // получение всех объектов
    public T GetById(int id);              // получение одного объекта по id
    public Task Create(T item);            // создание объекта
    public void Update(T item);            // обновление объекта
    public void Delete(T item);            // удаление объекта по id
    public Task Save();                    // сохранение изменений
}