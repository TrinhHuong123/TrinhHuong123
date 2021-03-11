using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("PHONGBANs")]
    public class PHONGBAN
    {
        public String MaPB { get; set; }
        [Key]
        [StringLength(50)]
        public String TenPB { get; set; }
        public virtual NHANVIEN NHANVIENs { get; set; }
    }
}