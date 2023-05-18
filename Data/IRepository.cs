namespace Hobbies.Data
{
    public interface IRepository<T>
    {
        // Person
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T Remove(int id);
        T Update(int id, T entity);
        bool SaveChanges();

    }
}