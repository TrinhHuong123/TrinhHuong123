namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NHANVIEN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NHANVIENs",
                c => new
                    {
                        HoTen = c.String(nullable: false, maxLength: 30, unicode: false),
                        MaNV = c.String(unicode: false),
                        GioiTinh = c.String(unicode: false),
                        Ngaysinh = c.DateTime(nullable: false),
                        QueQuan = c.String(unicode: false),
                        DanToc = c.String(unicode: false),
                        NoiOHienNay = c.String(unicode: false),
                        MaCV = c.String(unicode: false),
                        TenCV = c.String(unicode: false),
                        MaPhongBan = c.String(unicode: false),
                        Ngaykyhopdong = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HoTen);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NHANVIENs");
        }
    }
}
