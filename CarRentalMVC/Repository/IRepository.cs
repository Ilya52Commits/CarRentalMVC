namespace CarRentalMVC.Repository;

public interface IRepository<T> : IDisposable
        where T : class
{
    IEnumerable<T> GetUserList();   // получение всех объектов
    T GetUser(T item);              // получение одного объекта по id
    void Create(T item);            // создание объекта
    void Update(T item);            // обновление объекта
    void Delete(T item);            // удаление объекта по id
    void Save();                    // сохранение изменений
}