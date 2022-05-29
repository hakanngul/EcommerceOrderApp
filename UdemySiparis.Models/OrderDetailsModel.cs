using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemySiparis.Models
{
    public class OrderDetailsModel
    {
        [Key] public int Id { get; set; }
        public int OrderProductId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        [ForeignKey("OrderProductId")] public OrderProductModel OrderProduct { get; set; }
        [ForeignKey("ProductId")] public ProductModel Product { get; set; }
    }
}