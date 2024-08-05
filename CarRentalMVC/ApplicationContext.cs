using Microsoft.EntityFrameworkCore;
using CarRentalMVC.Models;

namespace CarRentalMVC;

public class ApplicationContext : DbContext
{    
    public DbSet<User> Users { get; set; }  // Объект таблицы пользователей

    /* Строка подключения к базе данных PostgresSQL */
    public ApplicationContext(DbContextOptions<ApplicationContext> options) 
        : base(options) => Database.EnsureCreated();
}

