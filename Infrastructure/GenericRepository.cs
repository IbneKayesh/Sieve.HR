using System.Linq.Expressions;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly HRDbContext context;
        public GenericRepository(HRDbContext context)
        {
            this.context = context;
        }
        
        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void InsertAll(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Select(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }
        public T SelectById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public IEnumerable<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }
        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void UpdateAll(IEnumerable<T> entities)
        {
            context.Set<T>().UpdateRange(entities);
        }
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }
    }
}
