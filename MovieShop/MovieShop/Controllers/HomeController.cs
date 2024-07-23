using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;

namespace MovieShop.Controllers;

    public class HomeController : Controller
    {
        private readonly IMovieServices movieService;
        private readonly IGenreService _genreService;


        public HomeController(IMovieServices movieService, IGenreService genreService)
        {
            this.movieService = movieService;
            _genreService = genreService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await movieService.GetAllMovies();
            // ViewBag.Genres = _genreService.GetAllGenres();
            return View(movies);
        }
    }
