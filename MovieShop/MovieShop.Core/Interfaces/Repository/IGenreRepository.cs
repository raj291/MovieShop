using MovieShop.Core.Entities;

namespace MovieShop.Core.Interfaces.Repository;

public interface IGenreRepository : IRepository<Genres>
{
    Task<List<Genres>> GetAllGenres();
}