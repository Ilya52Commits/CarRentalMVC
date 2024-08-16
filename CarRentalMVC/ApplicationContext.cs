using Microsoft.EntityFrameworkCore;
using CarRentalMVC.Models;

namespace CarRentalMVC;

public class ApplicationContext : DbContext
{      
    /* Строка подключения к базе данных PostgresSQL */
    public ApplicationContext() 
        : base() => Database.EnsureCreated();
    
    public DbSet<User> Users { get; set; }  // Объект таблицы пользователей
}

