using UdemySiparis.Data.Repository.Interfaces;
using UdemySiparis.Models;

namespace UdemySiparis.Data.Repository.Class
{
    public class AppUserRepository : Repository<AppUserModel>, IAppUserRepository
    {
        private ApplicationDbContext Context { get; }

        public AppUserRepository(ApplicationDbContext context) : base(context)
        {
            Context = context;
        }
    }
}