using Microsoft.AspNetCore.Mvc;

namespace MovieShop.Controllers;

public class MoviesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}