using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository;

public class MovieRepository : BaseRepository<Movies>, IMovieRepository
{
    public MovieRepository(MovieShopDbContext movieShopDbContext) : base(movieShopDbContext)
    {
        
    }
}