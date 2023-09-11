using System.ComponentModel.DataAnnotations;

namespace Webenglishfinal.Models
{
    public class Account
    {
        [Key]
        public String username { get; set; } = null!;
        public String password { get; set; } = null!;
        public String name { get; set; } = null!;
        public String? email { get; set; } = null;
        public String? phone { get; set; }
        public String? isActive { get; set; }
    }
}
