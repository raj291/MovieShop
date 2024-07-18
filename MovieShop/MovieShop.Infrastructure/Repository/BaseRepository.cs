using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository;

public class BaseRepository<T> : IRepository<T> where T : class
{
    private readonly MovieShopDbContext movieShopDbContext;

    public BaseRepository(MovieShopDbContext movieShopDbContext)
    {
        this.movieShopDbContext = movieShopDbContext;
    }
    public int Insert(T entity)
    {
        movieShopDbContext.Set<T>().Add(entity);
        return movieShopDbContext.SaveChanges();
    }

    public int Update(T entity)
    {
        movieShopDbContext.Set<T>().Entry(entity).State = EntityState.Modified;
        return movieShopDbContext.SaveChanges();
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            movieShopDbContext.Set<T>().Remove(entity);
            return 1;
        }

        return 0;
    }

    public T GetById(int id)
    {
        return movieShopDbContext.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return movieShopDbContext.Set<T>().ToList();
    }
}