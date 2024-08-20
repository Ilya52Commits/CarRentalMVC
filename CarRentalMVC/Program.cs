using CarRentalMVC;
using CarRentalMVC.Repository;
using CarRentalMVC.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//var connectionString = builder.Configuration.GetConnectionString("MSSQL");

builder.Services.AddTransient<IRegistrationAuthorizationService, RegistrationAuthorizationService>();

// добавляем контекст ApplicationContext в качестве сервиса в приложение
//builder.Services.AddDbContext<ApplicationContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(connectionString));

// Регистрация репозитория
//builder.Services.AddScoped<IRepository<User>, SQLUserRepository>();
// Для PostgreSQL раскомментируйте следующую строку и закомментируйте предыдущую:
builder.Services.AddScoped<UserRepository>();

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

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}",
        defaults: new { controller = "Home", action = "Index" }
    );
    _ = endpoints.MapControllerRoute(
        name: "Sing-up",
        pattern: "{controller=RegistrationAuthorization}/{action=RegistrationMethod}/{id?}",
        defaults: new { controller = "RegistrationAuthorization", action = "RegistrationMethod" }
    );
    _ = endpoints.MapControllerRoute(
        name: "Sing-in",
        pattern: "{controller=RegistrationAuthorization}/{action=AuthorizationMethod}/{id?}",
        defaults: new { controller = "RegistrationAuthorization", action = "AuthorizationMethod" }
    );
});

app.Run();
