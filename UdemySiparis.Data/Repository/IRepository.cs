using System.Linq.Expressions;

namespace UdemySiparis.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        bool Add<TA>(TA model) where TA : class;
        Task AddAsync(T entity);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}