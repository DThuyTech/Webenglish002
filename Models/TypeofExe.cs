using System.ComponentModel.DataAnnotations;

namespace Webenglishfinal.Models
{
    public class TypeofExe
    {
        [Key]
        public int IdType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
