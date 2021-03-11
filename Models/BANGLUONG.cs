using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("BANGLUONGs")]
    public class BANGLUONG
    {
        public string MaLuong { get; set; }
        [Key]
        [StringLength(50)]
        public string MaNhanVien  { get; set; }
        
        public string TenNhanVien { get; set; }
        public float HeSoLuong { get; set; }
        public float BacLuong { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}