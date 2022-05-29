using UdemySiparis.Data.Repository.Interfaces;
using UdemySiparis.Models;

namespace UdemySiparis.Data.Repository.Class
{
    public class CartRepository : Repository<CartModel>, ICartRepository
    {
        private ApplicationDbContext Context { get; }

        public CartRepository(ApplicationDbContext context) : base(context)
        {
            Context = context;
        }
    }
}
