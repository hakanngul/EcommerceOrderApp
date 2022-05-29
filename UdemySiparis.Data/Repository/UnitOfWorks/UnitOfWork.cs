using UdemySiparis.Data.Repository.Class;
using UdemySiparis.Data.Repository.Interfaces;

namespace UdemySiparis.Data.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext DbContext { get; }
        public IAppUserRepository AppUser => new AppUserRepository(DbContext);
        public ICartRepository Cart => new CartRepository(DbContext);
        public ICategoryRepository Category => new CategoryRepository(DbContext);
        public IOrderDetailsRepository OrderDetails => new OrderDetailsRepository(DbContext);
        public IProductRepository Product => new ProductRepository(DbContext);
        public IOrderProductRepository OrderProduct => new OrderProductRepository(DbContext);

        public UnitOfWork(ApplicationDbContext context)
        {
            DbContext = context;
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}