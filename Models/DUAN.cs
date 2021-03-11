using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("DUANs")]
    public class DUAN
    {
        public string MaDuAn { get; set; }
        [Key]
        [StringLength(50)]
        public string TenDuAn { get; set; }
        public string MaNV { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
        public virtual CHITIETDUAN CHITIETDUANs { get; set; }



    }
}