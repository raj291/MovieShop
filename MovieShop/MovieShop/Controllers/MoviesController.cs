using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;
using MovieShop.Core.Models.Response;

namespace MovieShop.Controllers;

public class MoviesController : Controller
{
    private readonly IMovieServices services;

    public MoviesController(IMovieServices services)
    {
        this.services = services;
    }
    // GET
    public async Task<IActionResult> Index(int id)
    {
        var movie = await services.GetMovie(id);

        if (movie == null)
        {
            return NotFound();
        }

        return View(movie);
    }
}