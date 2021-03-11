using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("CHUCVUs")]
    public class CHUCVU
    {
        public string MaCV { get; set; }
        [Key]
        [StringLength(50)]
        public string TenCV { get; set; }
        public virtual NHANVIEN NHANVIENs { get; set; }

    }
}