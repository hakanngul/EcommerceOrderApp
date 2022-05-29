using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemySiparis.Models
{
    public class CartModel
    {
        [Key] public int Id { get; set; }
        public string AppUserId { get; set; }
        public int ProductId { get; set; }
        [DefaultValue(1)] public int Count { get; set; }
        public double Price { get; set; }
        [ForeignKey("AppUserId")] public AppUserModel AppUser { get; set; }
        [ForeignKey("ProductId")] public ProductModel Product { get; set; }
    }
}