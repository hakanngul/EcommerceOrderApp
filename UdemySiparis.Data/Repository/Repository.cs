using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace UdemySiparis.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext Context { get; }
        internal DbSet<T> DbSet { get; }

        public Repository(ApplicationDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }


        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public bool Add<TA>(TA model) where TA : class
        {
            Context.Set<TA>().Add(model);
            return true;
        }

        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = DbSet;
            if (filter != null)
                query = query.Where(filter!);

            // "Product, Order"
            if (includeProperties != null)
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }

            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = DbSet;
            if (filter != null)
                query = query.Where(filter!);

            // "Product, Order"
            if (includeProperties != null)
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }

            return query.FirstOrDefault();
        }


        public void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }
    }
}