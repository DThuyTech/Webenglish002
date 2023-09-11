using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webenglishfinal.Models
{
    public class Test
    {
        [Key]
        public int IdTest { get; set; }
        public string name { get; set; }
        public int markpass { get; set; }
        [ForeignKey("Lesson")]     
        public int idLesson { get; set; }
        public Lesson lesson { get; set; }
        
    }
}
