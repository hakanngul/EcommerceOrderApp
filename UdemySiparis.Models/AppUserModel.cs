using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemySiparis.Models
{
    public class AppUserModel : IdentityUser
    {
        [Required] public string FullName { get; set; }
        public string Address { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string MobilePhone { get; set; } = string.Empty;
        [NotMapped] public string Role { get; set; } = string.Empty;

    }
}