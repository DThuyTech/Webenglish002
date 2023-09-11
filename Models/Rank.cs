using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webenglishfinal.Models
{
    public class Rank
    {
        [Key]
        public int idRank { get; set; }
        public long ranknumber { get; set; }
        public float mark { get; set; }
        [ForeignKey("Account")]
        public string username { get; set; }
        public Account account { get; set; }
    }
}
