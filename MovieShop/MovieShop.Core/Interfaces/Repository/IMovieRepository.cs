using MovieShop.Core.Entities;

namespace MovieShop.Core.Interfaces.Repository;

public interface IMovieRepository : IRepository<Movies>
{
    public IEnumerable<Movies> GetHighestGrossingMovies();
    Task<Movies> GetMovieByIdAsync(int id);
}