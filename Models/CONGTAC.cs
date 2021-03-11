using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("CONGTACs")]
    public class CONGTAC
    {
        public string MaCT { get; set; }
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }
        
        public string CongViec { get; set; }
        public string ChucVu { get; set; }
        public string PhongBan { get; set; }
        public string NoiLamViec { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}