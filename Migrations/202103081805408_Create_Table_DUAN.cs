namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DUAN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DUANs",
                c => new
                    {
                        TenDuAn = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaDuAn = c.String(unicode: false),
                        Ngaybatdau = c.DateTime(nullable: false),
                        Ngaygiahan = c.DateTime(nullable: false),
                        Ngayketthuc = c.DateTime(nullable: false),
                        SoLuong = c.String(unicode: false),
                        DonGia = c.String(unicode: false),
                        ChietKhau = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenDuAn);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DUANs");
        }
    }
}
