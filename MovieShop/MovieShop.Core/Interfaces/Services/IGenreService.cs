using MovieShop.Core.Entities;

namespace MovieShop.Core.Interfaces.Services;

public interface IGenreService
{
    Task<IEnumerable<Genres>> GetAllGenres();
}