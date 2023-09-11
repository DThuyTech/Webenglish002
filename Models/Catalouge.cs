using System.ComponentModel.DataAnnotations;

namespace Webenglishfinal.Models
{
    public class Catalouge
    {
        [Key]
        public int Id { get; set; }
        public string symbols { get; set; }
        public string Desciption { get; set; }

    }
}
