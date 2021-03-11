using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("BANGCHAMCONGs")]
    public class BANGCHAMCONG
    {
        public string MaCC { get; set; }
        [Key]
        [StringLength(50)]
        public string MaNhanVien { get; set; }    
        public string TenNhanVien { get; set; }
        public float Songaycong { get; set; }
        public float Songaydilam { get; set; }
        public float Songayvangmat { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}