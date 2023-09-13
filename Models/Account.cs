using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Webenglishfinal.Models
{
    public class Account : IdentityUser
    {
        [Key]
        public String username { get; set; } = null!;
        public String password { get; set; } = null!;
        public String name { get; set; } = null!;
        public String? email { get; set; } = null;
        public String? phone { get; set; }
        public String? isActive { get; set; }
        public IdentityUser? IdentityUser { get; set; }
        public IdentityUser? IdentityUsers { get; set; }


    }
}
