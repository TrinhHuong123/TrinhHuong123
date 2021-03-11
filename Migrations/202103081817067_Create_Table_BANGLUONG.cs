namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_BANGLUONG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BANGLUONGs",
                c => new
                    {
                        TenNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNhanVien = c.String(unicode: false),
                        HeSoLuong = c.Single(nullable: false),
                        BacLuong = c.Single(nullable: false),
                        NgayThanhToan = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TenNhanVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BANGLUONGs");
        }
    }
}
