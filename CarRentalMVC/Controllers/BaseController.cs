using System.ComponentModel;

namespace CarRentalMVC.Controllers;

public class BaseController : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;  // Создание объекта собития класса PropertyChanged

    // Метод для сообщения о событии изменения
    protected virtual void OnPropertyChanged(string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

