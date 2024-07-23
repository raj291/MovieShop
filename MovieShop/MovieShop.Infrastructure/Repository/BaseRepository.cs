using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository;

public class BaseRepository<T> : IRepository<T> where T : class
{
    private readonly MovieShopDbContext _movieShopDbContext;

    public BaseRepository(MovieShopDbContext movieShopDbContext)
    {
        _movieShopDbContext = movieShopDbContext;
    }
    public int Insert(T entity)
    {
        _movieShopDbContext.Set<T>().Add(entity);
        return _movieShopDbContext.SaveChanges();
    }

    public int Update(T entity)
    {
        _movieShopDbContext.Set<T>().Entry(entity).State = EntityState.Modified;
        return _movieShopDbContext.SaveChanges();
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            _movieShopDbContext.Set<T>().Remove(entity);
            return 1;
        }

        return 0;
    }

    public T GetById(int id)
    {
        return _movieShopDbContext.Set<T>().Find(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return _movieShopDbContext.Set<T>().ToList();
    }
}