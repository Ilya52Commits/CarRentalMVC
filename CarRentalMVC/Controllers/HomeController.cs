using CarRentalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CarRentalMVC.Controllers;
public class HomeController : Controller
{
    ApplicationContext db;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ApplicationContext context)
    {
        _logger = logger;

        db = context;
    }

    public  IActionResult Index()
    {
        return View();
    }

    public IActionResult PrivateOffice()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> PrivateOffice(User user)
    {
        db.Users.Add(user);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
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