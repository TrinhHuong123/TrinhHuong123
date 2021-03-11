using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("TRINHDO_NGOAINGUs")]
    public class TRINHDO_NGOAINGU
    {
        public string MaTrinhDoNN { get; set; }
        [Key]
        [StringLength(50)]
        public string MaTrinhDo { get; set; }
        
        public string TenTrinhDo { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}