using UdemySiparis.Data.Repository.Interfaces;
using UdemySiparis.Models;

namespace UdemySiparis.Data.Repository.Class
{
    public class OrderDetailsRepository : Repository<OrderDetailsModel>, IOrderDetailsRepository
    {
        private ApplicationDbContext Context { get; }

        public OrderDetailsRepository(ApplicationDbContext context) : base(context)
        {
            Context = context;
        }
    }
}
