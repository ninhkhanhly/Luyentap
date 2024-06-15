using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Khanhlyluyentap1.Models
{
    public class Lop
    {
        [Key]
        public string MaLop { get; set; }
        [Required]
        public string TenLop { get; set; }

        [ForeignKey("MaSinhVien")]
        public string MaSinhVien { get; set; }
    }
}