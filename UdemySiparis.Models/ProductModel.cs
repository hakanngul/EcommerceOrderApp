using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemySiparis.Models
{
    public class ProductModel
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string Barcode { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("CategoryId")] public CategoryModel Category { get; set; }
    }
}