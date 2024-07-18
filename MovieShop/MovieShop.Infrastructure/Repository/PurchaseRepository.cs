using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository;

public class PurchaseRepository : BaseRepository<Purchases> , IPurchasesRepository
{
    public PurchaseRepository(MovieShopDbContext movieShopDbContext) : base(movieShopDbContext)
    {
        
    }
}