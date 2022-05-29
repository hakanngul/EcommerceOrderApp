using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UdemySiparis.Models;

namespace UdemySiparis.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AppUserModel> AppUser { get; set; }
        public DbSet<CartModel> Carts { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<OrderDetailsModel> OrderDetails { get; set; }
        public DbSet<OrderProductModel> OrderProducts { get; set; }
        public DbSet<ProductModel> Products { get; set; }
    }
}