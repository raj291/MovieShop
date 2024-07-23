using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Core.Interfaces.Services;

namespace MovieShop.Infrastructure.Service;

public class GenreService : IGenreService
{
    private readonly IGenreRepository _genreRepository;

    public GenreService(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public async Task<IEnumerable<Genres>> GetAllGenres()
    {
        return  _genreRepository.GetAllGenres();
    }
}