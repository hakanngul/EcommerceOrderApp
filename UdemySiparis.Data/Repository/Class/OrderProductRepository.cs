using UdemySiparis.Data.Repository.Interfaces;
using UdemySiparis.Models;

namespace UdemySiparis.Data.Repository.Class
{
    public class OrderProductRepository : Repository<OrderProductModel>, IOrderProductRepository
    {
        private ApplicationDbContext Context { get; }

        public OrderProductRepository(ApplicationDbContext context) : base(context)
        {
            Context = context;
        }
    }
}
