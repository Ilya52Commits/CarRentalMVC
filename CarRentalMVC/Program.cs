using CarRentalMVC;
using CarRentalMVC.Repository;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//var connectionString = builder.Configuration.GetConnectionString("MSSQL");

builder.Services.AddTransient<IRegistrationAuthorizationService, RegistrationAuthorizationService>();

// ��������� �������� ApplicationContext � �������� ������� � ����������
//builder.Services.AddDbContext<ApplicationContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(connectionString));

// ����������� �����������
//builder.Services.AddScoped<IRepository<User>, SQLUserRepository>();
// ��� PostgreSQL ���������������� ��������� ������ � ��������������� ����������:
builder.Services.AddScoped<UserRepository>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = new PathString("/Account/Login");
});
builder.Services.AddControllersWithViews();

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
