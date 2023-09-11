using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Security.Claims;
using System.Xml.Linq;

namespace Webenglishfinal.Models
{
    public class DetailGradeAccount
    {
        [Key]
        [Display(Name = "IsListGraAccount")]
        public int Id { get; set; }
        [ForeignKey("Account")]
        public string Username { get; set; }
        public Account account { get; set; }

        [ForeignKey("Grade")]
        public int idGrade { get; set; }
        public Grade grade { get; set; }
        [DefaultValue(0)]
        public int isActive { get; set; }
    }
}
