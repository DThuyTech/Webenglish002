using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webenglishfinal.Models
{
    public class Report
    {
        [Key]
        public int idReport { get; set; }
        public string content { get; set; }
        public DateTime datesend { get; set; }
        [ForeignKey("Status")]
        public int idStatus { get; set; }
        public Status status { get; set; }
    }
}
