using UdemySiparis.Data.Repository.Interfaces;
using UdemySiparis.Models;

namespace UdemySiparis.Data.Repository.Class
{
    public class CategoryRepository : Repository<CategoryModel>, ICategoryRepository
    {
        private ApplicationDbContext Context { get; }

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            Context = context;
        }
    }
}
