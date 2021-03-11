using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    [Table("NHANVIENs")]
    public class NHANVIEN
    {
        [Key]
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        [Required, MaxLength (50)]
        public string GioiTinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string QueQuan { get; set; }
        
        public int  Tuoi { get; set; }
        public string NoiOHienNay { get; set; }
        
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public string MaPhongBan { get; set; }
        public DateTime Ngaykyhopdong { get; set; }
        public virtual DUAN DUANs { get; set; }
        public virtual CONGTAC CONGTACs { get; set; }
        public virtual TRINHDO_CHUYENMON TRINHDO_CHUYENMONs { get; set; }
        public virtual TRINHDO_NGOAINGU TRINHDO_NGOAINGUs { get; set; }

        public virtual BANGCHAMCONG BANGCHAMCONGs { get; set; }
        public virtual BANGLUONG BANGLUONGs { get; set; }
        public virtual CHITIETKHENTHUONG_KYLUAT CHITIETKHENTHUONG_KYLUATs { get; set; }
        public virtual ICollection<CHUCVU> CHUCVUs { get; set; }
        public virtual ICollection<PHONGBAN> PHONGBANs { get; set; }


    }
}