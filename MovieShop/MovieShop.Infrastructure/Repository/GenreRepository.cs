using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository;

public class GenreRepository : BaseRepository<Genres>, IGenreRepository
{
    private readonly MovieShopDbContext _movieShopDbContext;

    public GenreRepository(MovieShopDbContext movieShopDbContext) : base(movieShopDbContext)
    {
        _movieShopDbContext = movieShopDbContext;
    }

    public IEnumerable<Genres> GetAllGenres()
    {
        return _movieShopDbContext.Genres.ToList();
    }
}