using CarRentalMVC;
using CarRentalMVC.Models;
using CarRentalMVC.Repository;
using CarRentalMVC.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//var connectionString = builder.Configuration.GetConnectionString("MSSQL");

builder.Services.AddTransient<IRegistrationService, RegistrationService>();

// добавляем контекст ApplicationContext в качестве сервиса в приложение
//builder.Services.AddDbContext<ApplicationContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(connectionString));

// Регистрация репозитория
//builder.Services.AddScoped<IRepository<User>, SQLUserRepository>();
// Для PostgreSQL раскомментируйте следующую строку и закомментируйте предыдущую:
 builder.Services.AddScoped<IRepository<User>, PostgreSqlUserRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
