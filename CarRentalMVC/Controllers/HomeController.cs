using CarRentalMVC.Models;
using CarRentalMVC.Repository;
using CarRentalMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarRentalMVC.Controllers;
public class HomeController : Controller
{
    IRepository<User> _dbContext; 
    private readonly ILogger<HomeController> _logger;
    private readonly IMessageSender _message; 

    public HomeController(ILogger<HomeController> logger, IMessageSender message, IRepository<User> userRepository)
    {
        _logger = logger;

        _message = message; 

        _dbContext = userRepository;
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
    public IActionResult PrivateOffice(User user)
    {
        //return Json(_message.Send());
        _dbContext.Create(user);
        _dbContext.Save();
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