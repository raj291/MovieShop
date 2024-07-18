using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository;

public class UserRepository : BaseRepository<Users> , IUserRepository
{
    public UserRepository(MovieShopDbContext movieShopDbContext) : base(movieShopDbContext)
    {
        
    }
}