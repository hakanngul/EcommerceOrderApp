using UdemySiparis.Data.Repository.Interfaces;

namespace UdemySiparis.Data.Repository.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IAppUserRepository AppUser { get; }
        ICartRepository Cart { get; }
        ICategoryRepository Category { get; }
        IOrderDetailsRepository OrderDetails { get; }
        IProductRepository Product { get; }
        IOrderProductRepository OrderProduct { get; }
        void Save();
    }
}