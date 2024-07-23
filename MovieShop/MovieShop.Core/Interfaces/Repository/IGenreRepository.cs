using MovieShop.Core.Entities;

namespace MovieShop.Core.Interfaces.Repository;

public interface IGenreRepository : IRepository<Genres>
{
    IEnumerable<Genres> GetAllGenres();
}