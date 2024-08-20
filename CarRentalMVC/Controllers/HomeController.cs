using CarRentalMVC.Models;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarRentalMVC.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRegistrationService _registrationService;

    public HomeController(ILogger<HomeController> logger, IRegistrationService registrationService)
    {
        _logger = logger;

        _registrationService = registrationService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PrivateOffice()
    {
        return View();
    }

    [HttpPost]
    public IActionResult PrivateOffice(UserModel user)
    {
        _registrationService.AddNewUser(user);
        return PrivateOffice();
    }

    /*
1.  Реализовать авторизацию
2. Реализовать передачу строки подключения в RegistrationService; 
3. Реализовать передачу данных после регистрации и авторизации
 */


    public IActionResult Reservation()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}