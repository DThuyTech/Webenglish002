using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webenglishfinal.Models
{
    public class IncorrectSen
    {
        [Key]
        public int idSentences { get; set; }
        public string content { get; set; }
        [ForeignKey("Report")]
        public int idReport { get; set; }
        public Report report { get; set; }
    }
}
