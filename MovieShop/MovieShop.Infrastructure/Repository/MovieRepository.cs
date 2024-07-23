using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;
using MovieShop.Infrastructure.Migrations;

namespace MovieShop.Infrastructure.Repository;

public class MovieRepository : BaseRepository<Movies>, IMovieRepository
{
    private readonly MovieShopDbContext _movieShopDbContext;

    public MovieRepository(MovieShopDbContext movieShopDbContext) : base(movieShopDbContext)
    {
        _movieShopDbContext = movieShopDbContext;
    }

    public IEnumerable<Movies> GetHighestGrossingMovies()
    {
        throw new Exception();
    }
    
    public async Task<Movies> GetMovieByIdAsync(int id)
    {
        return await _movieShopDbContext.Movies
            .Include(m => m.TrailersList)
            .Include( m => m.MovieCastsList)
                .ThenInclude(mc => mc.Casts)
            .FirstOrDefaultAsync(m => m.Id == id);
    }

}