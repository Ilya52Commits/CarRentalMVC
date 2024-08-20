using CarRentalMVC.Models;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarRentalMVC.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRegistrationService _message; 

    public HomeController(ILogger<HomeController> logger, IRegistrationService message)
    {
        _logger = logger;

        _message = message; 
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PrivateOffice()
    {
        return View();
    }

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