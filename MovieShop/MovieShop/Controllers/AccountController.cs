using Microsoft.AspNetCore.Mvc;

namespace MovieShop.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}