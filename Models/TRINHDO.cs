using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("TRINHDOs")]
    public class TRINHDO
    {
        public string MaTrinhDo { get; set; }
        [Key]
        [StringLength(50)]
        public string TenTrinhDo { get; set; }
        public virtual TRINHDO_CHUYENMON TRINHDO_CHUYENMONs { get; set; }
    }
}