using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemySiparis.Models
{
    public class OrderProductModel
    {
        [Key] public int Id { get; set; }
        public string AppUserId { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderPrice { get; set; }
        public string OrderStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string ReceiverName { get; set; }
        [ForeignKey("AppUserId")] public AppUserModel AppUser { get; set; }
    }
}
