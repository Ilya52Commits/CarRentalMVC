using CarRentalMVC.Models;
using CarRentalMVC.Repository;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarRentalMVC.Controllers;
public class HomeController : Controller
{
    IRepository<User> db; 
    private readonly ILogger<HomeController> _logger;
    private readonly IMessageSender _message; 

    public HomeController(ILogger<HomeController> logger, IMessageSender message)
    {
        _logger = logger;

        _message = message; 

        db = new SQLUserRepository();
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
    public JsonResult PrivateOffice(User user)
    {
        return Json(_message.Send());
        //_dbContext.Users.Add(user);
        //await _dbContext.SaveChangesAsync();
        //return RedirectToAction("Index");
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