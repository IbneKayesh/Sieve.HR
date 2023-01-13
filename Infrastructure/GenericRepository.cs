using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly HRDbContext context;
        private DbSet<T> dbSet;
        public GenericRepository(HRDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        
        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public void InsertAll(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }
        public void Update(T entity)
        {
            dbSet.Update(entity);
        }

        public void UpdateAll(IEnumerable<T> entities)
        {
            dbSet.UpdateRange(entities);
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }


        //Selections
        public T SelectById(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> SelectAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }
        public IEnumerable<T> SelectAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbSet;

            foreach (Expression<Func<T, object>> include in includes)
                query = query.Include(include);

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }
    }
}
