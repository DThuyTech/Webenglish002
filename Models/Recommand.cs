using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webenglishfinal.Models
{
    public class Recommand
    {
        [Key]
        public int IdRecommand { get; set; }
        public string path { get; set; }
        [ForeignKey("Test")]
        public int idTest { get; set; }
    }
}
