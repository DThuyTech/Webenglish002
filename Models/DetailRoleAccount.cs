using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Webenglishfinal.Models
{
    public class DetailRoleAccount
    {
        [Key]
        [Display(Name = "IDDetailRole")]
        public string Id { get; set; }

        [ForeignKey("Account")]
        public string username { get; set; }
        public Account account { get; set; }

        [ForeignKey("Role")]
        public int roleId { get; set; }
        public Role role { get; set; }
    }
}
