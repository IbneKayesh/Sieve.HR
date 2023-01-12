using System.Linq.Expressions;

namespace Sieve.HR.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> Select(Expression<Func<T, bool>> expression);
        T SelectById(int id);
        IEnumerable<T> SelectAll();        
        
        void Insert(T entity);
        void InsertAll(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateAll(IEnumerable<T> entities);

        void Delete(T entity);
        void DeleteAll(IEnumerable<T> entities);
    }
}
