using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("TRINHDO_CHUYENMONs")]
    public class TRINHDO_CHUYENMON
    {
        public string STT { get; set; }
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }
        
        public string MaTrinhDo { get; set; }
        public string MaCM { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
        public virtual ICollection<CHUYENMON> CHUYENMONs { get; set; }
        public virtual ICollection<TRINHDO> TRINHDOs { get; set; }
    }
}