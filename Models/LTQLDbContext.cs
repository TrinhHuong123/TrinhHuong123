using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<TRINHDO> TRINHDOs { get; set; }
        public virtual DbSet<CONGTAC> CONGTACs { get; set; }
        public virtual DbSet<CHUYENMON> CHUYENMONs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<TRINHDO_NGOAINGU> TRINHDO_NGOAINGUs { get; set; }
        public virtual DbSet<TRINHDO_CHUYENMON> TRINHDO_CHUYENMONs { get; set; }
        public virtual DbSet<DUAN> DUANs { get; set; }
        public virtual DbSet<CHITIETDUAN> CHITIETDUANs { get; set; }
        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<BANGCHAMCONG> BANGCHAMCONGs { get; set; }
        public virtual DbSet<CHITIETKHENTHUONG_KYLUAT> CHITIETKHENTHUONG_KYLUATs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.HoTen)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.GioiTinh)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.Ngaysinh);
            modelBuilder.Entity<NHANVIEN>()
              .Property(e => e.QueQuan)
              .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.Tuoi);
               
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.NoiOHienNay)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.MaCV)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.TenCV)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.MaPhongBan)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.Ngaykyhopdong);

            modelBuilder.Entity<CHUCVU>()
               .Property(e => e.MaCV)
               .IsUnicode(false);
            modelBuilder.Entity<CHUCVU>()
               .Property(e => e.TenCV)
               .IsUnicode(false);

            modelBuilder.Entity<TRINHDO>()
               .Property(e => e.MaTrinhDo)
               .IsUnicode(false);
            modelBuilder.Entity<TRINHDO>()
               .Property(e => e.TenTrinhDo)
               .IsUnicode(false);

            modelBuilder.Entity<CONGTAC>()
               .Property(e => e.MaCT)
               .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
               .Property(e => e.MaNV)
               .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
               .Property(e => e.CongViec)
               .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
               .Property(e => e.ChucVu)
               .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
               .Property(e => e.PhongBan)
               .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
               .Property(e => e.NoiLamViec)
               .IsUnicode(false);

            modelBuilder.Entity<CHUYENMON>()
               .Property(e => e.MaCM)
               .IsUnicode(false);
            modelBuilder.Entity<CHUYENMON>()
               .Property(e => e.TenCM)
               .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
               .Property(e => e.MaPB)
               .IsUnicode(false);
            modelBuilder.Entity<PHONGBAN>()
               .Property(e => e.TenPB)
               .IsUnicode(false);

            modelBuilder.Entity<TRINHDO_NGOAINGU>()
               .Property(e => e.MaTrinhDoNN)
               .IsUnicode(false);
            modelBuilder.Entity<TRINHDO_NGOAINGU>()
               .Property(e => e.MaTrinhDo)
               .IsUnicode(false);
            modelBuilder.Entity<TRINHDO_NGOAINGU>()
               .Property(e => e.TenTrinhDo)
               .IsUnicode(false);

            modelBuilder.Entity<TRINHDO_CHUYENMON>()
              .Property(e => e.STT)
              .IsUnicode(false);
            modelBuilder.Entity<TRINHDO_CHUYENMON>()
               .Property(e => e.MaNV)
               .IsUnicode(false);
            modelBuilder.Entity<TRINHDO_CHUYENMON>()
               .Property(e => e.MaTrinhDo)
                .IsUnicode(false);
            modelBuilder.Entity<TRINHDO_CHUYENMON>()
               .Property(e => e.MaCM)
               .IsUnicode(false);

            modelBuilder.Entity<DUAN>()
              .Property(e => e.MaDuAn)
              .IsUnicode(false);
            modelBuilder.Entity<DUAN>()
              .Property(e => e.TenDuAn)
              .IsUnicode(false);
            modelBuilder.Entity<DUAN>()
              .Property(e => e.MaNV)
              .IsUnicode(false);


            modelBuilder.Entity<CHITIETDUAN>()
             .Property(e => e.TenDuAn)
             .IsUnicode(false);
            modelBuilder.Entity<CHITIETDUAN>()
             .Property(e => e.MaDuAn)
             .IsUnicode(false);
            modelBuilder.Entity<CHITIETDUAN>()
              .Property(e => e.MaNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<CHITIETDUAN>()
             .Property(e => e.Ngaybatdau);
            modelBuilder.Entity<CHITIETDUAN>()
             .Property(e => e.Ngaygiahan);
            modelBuilder.Entity<CHITIETDUAN>()
             .Property(e => e.Ngayketthuc);
            modelBuilder.Entity<CHITIETDUAN>()
              .Property(e => e.SoLuong)
              .IsUnicode(false);
            modelBuilder.Entity<CHITIETDUAN>()
              .Property(e => e.DonGia)
              .IsUnicode(false);
            modelBuilder.Entity<CHITIETDUAN>()
              .Property(e => e.ChietKhau)
              .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
             .Property(e => e.MaLuong)
             .IsUnicode(false);
            modelBuilder.Entity<BANGLUONG>()
              .Property(e => e.MaNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<BANGLUONG>()
              .Property(e => e.TenNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<BANGLUONG>()
              .Property(e => e.HeSoLuong);
            modelBuilder.Entity<BANGLUONG>()
              .Property(e => e.BacLuong);
            modelBuilder.Entity<BANGLUONG>()
              .Property(e => e.NgayThanhToan);

            modelBuilder.Entity<BANGCHAMCONG>()
              .Property(e => e.MaCC)
              .IsUnicode(false);
            modelBuilder.Entity<BANGCHAMCONG>()
              .Property(e => e.MaNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<BANGCHAMCONG>()
              .Property(e => e.TenNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<BANGCHAMCONG>()
              .Property(e => e.Songaycong);
            modelBuilder.Entity<BANGCHAMCONG>()
              .Property(e => e.Songaydilam);
            modelBuilder.Entity<BANGCHAMCONG>()
              .Property(e => e.Songayvangmat);

            modelBuilder.Entity<CHITIETKHENTHUONG_KYLUAT>()
              .Property(e => e.SoQĐ);
            modelBuilder.Entity<CHITIETKHENTHUONG_KYLUAT>()
              .Property(e => e.MaNV)
              .IsUnicode(false);
            modelBuilder.Entity<CHITIETKHENTHUONG_KYLUAT>()
              .Property(e => e.HinhThuc)
              .IsUnicode(false);
            modelBuilder.Entity<CHITIETKHENTHUONG_KYLUAT>()
              .Property(e => e.SoTien);   
            modelBuilder.Entity<CHITIETKHENTHUONG_KYLUAT>()
              .Property(e => e.NgayHieuLuc);
            modelBuilder.Entity<CHITIETKHENTHUONG_KYLUAT>()
              .Property(e => e.LyDo)
              .IsUnicode(false);

        }
    }
}
