using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webenglishfinal.Models
{
    public class Lesson
    {
        [Key]
        public int IdLesson { get; set; }
        public string nameLesson { get; set; }
        [DefaultValue(0)]

        public int level { get; set; }

        [DefaultValue(1)]
        public int isActive { get; set; }
        [ForeignKey("Grade")]
        public int idGrade { get; set; }
        public Grade grade { get; set; }

        public DateTime DatetimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public DateTime dateUpdate { get; set; }
    }
}
