using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;

namespace Webenglishfinal.Models
{
    public class Exercise
    {
        [Key]
        public int IdExe { get; set; }
        public string Path { get; set; }
        public int mark { get; set; }
        public int passpercent { get; set; }

        [ForeignKey("Test")]
        public int idTest { get; set; }
        public Test test { get; set; }

        [ForeignKey("TypeofExex")]
        public int idTypeofExe { get; set; }
        public TypeofExe typeofExe { get; set; }
    }
}
