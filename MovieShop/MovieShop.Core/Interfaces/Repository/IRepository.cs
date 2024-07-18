namespace MovieShop.Core.Interfaces.Repository;

public interface IRepository<T> where T:class
{
    public int Insert(T entity);
    public int Update(T entity);
    public int Delete(int id);
    public T GetById(int id);
    public IEnumerable<T> GetAll();
}