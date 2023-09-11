using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Webenglishfinal.Models
{
    public class Grade
    {
        [Key]
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        [DefaultValue(1)]

        public int isActive { get; set; }
    }
}
