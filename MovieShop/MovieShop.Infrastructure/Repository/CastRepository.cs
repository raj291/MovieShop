using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository;

public class CastRepository : BaseRepository<Casts> , ICastRepository
{
    public CastRepository(MovieShopDbContext movieShopDbContext) : base(movieShopDbContext)
    {
    }
}