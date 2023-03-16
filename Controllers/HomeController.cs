using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using coffeeProje.Models;

namespace mvcProje.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("/about")]
    public IActionResult About()
    {
        return View();
    }

    [Route("/blog")]
    public IActionResult Blog()
    {
        return View();
    }

    [Route("/cart")]
    public IActionResult Cart()
    {
        return View();
    }

    [Route("/checkout")]
    public IActionResult Checkout()
    {
        return View();
    }

    [Route("/contact")]
    public IActionResult Contact()
    {
        return View();
    }

    [Route("/menu")]
    public IActionResult Menu()
    {
        return View();
    }

    [Route("/productdetail")]
    public IActionResult ProductDetail()
    {
        return View();
    }

    [Route("/services")]
    public IActionResult Services()
    {
        return View();
    }

    [Route("/shop")]
    public IActionResult Shop()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
