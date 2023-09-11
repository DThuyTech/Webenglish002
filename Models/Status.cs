using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;

namespace Webenglishfinal.Models
{
    public class Status
    {
        [Key]
        public int Idstatus { get; set; }
        public int mark { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
        [ForeignKey("Account")]
        public string Username { get; set; }
        public Account account { get; set; }
        [ForeignKey("Test")]
        public int idTest { get; set; }
        public Test test { get; set; }
    }
}
