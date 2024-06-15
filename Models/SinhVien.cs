using System.ComponentModel.DataAnnotations;

namespace Khanhlyluyentap1.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }

        [Required]
        public string TenSinhVien { get; set; }

        [Required]
        public string GioiTinh { get; set; }
    }
}