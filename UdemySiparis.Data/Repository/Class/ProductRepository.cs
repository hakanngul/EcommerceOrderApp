using UdemySiparis.Data.Repository.Interfaces;
using UdemySiparis.Models;

namespace UdemySiparis.Data.Repository.Class
{
    public class ProductRepository : Repository<ProductModel>, IProductRepository
    {
        private ApplicationDbContext Context { get; }

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            Context = context;
        }
    }
}
