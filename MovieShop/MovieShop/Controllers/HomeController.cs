using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;
using System.Threading.Tasks;

namespace MovieShop.Web.Controllers;

    public class HomeController : Controller
    {
        private readonly IMovieServices movieService;

        public HomeController(IMovieServices movieService)
        {
            this.movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await movieService.GetAllMovies();
            return View(movies);
        }
    }
