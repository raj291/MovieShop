using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;

namespace MovieShop.Controllers;

public class GenresController : Controller
{
    private readonly IGenreService _genreService;

    public GenresController(IGenreService genreService)
    {
        _genreService = genreService;
    }

    [HttpGet]
    public async Task<IActionResult> GenreDropdown()
    {
        var genres = await _genreService.GetAllGenres();
        return PartialView("_GenreDropdown", genres);
    }
}
