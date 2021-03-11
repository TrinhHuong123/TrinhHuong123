using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("CHITIETKHENTHUONG_KYLUATs")]
    public class CHITIETKHENTHUONG_KYLUAT
    {
        public int SoQĐ { get; set; }
        [Key]
        [StringLength(30)]
        public string MaNV { get; set; }
        public string HinhThuc { get; set; }
        public DateTime NgayHieuLuc { get; set; }
        public string LyDo { get; set; }
        public float SoTien { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }


    }
}